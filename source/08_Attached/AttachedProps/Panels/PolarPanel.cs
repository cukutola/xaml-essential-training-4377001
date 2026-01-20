using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace AttachedProps
{
	// PolarPanel: Ein benutzerdefiniertes Panel, das Child-Elemente in Polarkoordinaten anordnet.
	// Dieses Panel demonstriert die Erstellung eigener Attached Properties (Angle und Radius)
	// sowie die Implementierung eines Custom Layouts durch Überschreiben von MeasureOverride und ArrangeOverride.
	// VERWENDUNG: Child-Elemente verwenden PolarPanel.Angle und PolarPanel.Radius zur Positionierung.
	public class PolarPanel : Panel
	{


		/// <summary>
		/// AngleFromTop: Steuert, ob der Winkel 0° oben (Y-Achse) oder rechts (X-Achse) ist.
		/// Standard in Polarkoordinaten ist rechts (X-Achse), aber für UI-Zwecke ist oft oben intuitiver.
		/// 
		/// WICHTIG: Dies ist KEINE DependencyProperty, daher nicht bindable.
		/// Der Setter ruft InvalidateArrange() auf, um ein Layout-Update zu erzwingen,
		/// wenn sich der Wert ändert.
		/// 
		/// original idea from Silverlight community
		/// <para>
		/// Note that this property is not 
		/// bindable, as it is not
		/// a Dependency Property.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// The Polar Axis is a semi-infinite 
		/// ray from the Origin. This is generally
		/// set to be the X-Axis...but is preferred
		/// by some to be be the Y-Axis.
		/// </para>
		/// </remarks>
		/// <value>
		/// <c>true</c> if angle 0 is at the top; 
		/// otherwise, <c>false</c>.
		/// </value>
		public bool AngleFromTop
		{
			get { return _AngleFromTop; }
			set
			{
				if (value != _AngleFromTop)
				{
					_AngleFromTop = value;
					// InvalidateArrange(): Markiert das Layout als ungültig und erzwingt ein erneutes Arrangement.
					// Dies ist notwendig, da sich die Positionierung aller Child-Elemente ändert,
					// wenn der Referenzwinkel von X-Achse zu Y-Achse (oder umgekehrt) wechselt.
					this.InvalidateArrange();
				}
			}
		}
		private bool _AngleFromTop = true;


		#region Attached Property - Angle
		
		// ATTACHED PROPERTY 'Angle': Definiert den Winkel in Grad für ein Child-Element.
		// 'RegisterAttached': Registriert eine Attached Property im WPF Property-System.
		// Im Gegensatz zu normalen DependencyProperties (die 'Register' verwenden) gibt es hier
		// KEINE CLR-Property mit get/set, sondern statische GetAngle/SetAngle Methoden.
		// PropertyMetadata(0.0, Property_Changed): Setzt den Standardwert auf 0° und definiert
		// einen Callback, der aufgerufen wird, wenn sich der Wert ändert.
		public static readonly DependencyProperty AngleProperty =
				DependencyProperty.RegisterAttached("Angle",
				typeof(double),
				typeof(PolarPanel),
				new PropertyMetadata(0.0, Property_Changed));

		/// <summary>
		/// SetAngle: Setter für die Angle Attached Property.
		/// Wird vom XAML-Parser aufgerufen, wenn im XAML z.B. PolarPanel.Angle="45" gesetzt wird.
		/// WICHTIG: Der Methodenname MUSS exakt "SetAngle" sein (Set + Propertyname).
		/// </summary>
		/// <param name="element">Das UI-Element, an das der Winkel angehängt wird.</param>
		/// <param name="radius">Der Winkelwert in Grad (0-360).</param>
		public static void SetAngle(UIElement element, double radius)
		{
			// SetValue(): Die eigentliche Setter-Methode für DependencyProperties.
			// Speichert den Wert in der internen Property-Storage des Elements.
			element.SetValue(AngleProperty, radius);
		}

		/// <summary>
		/// GetAngle: Getter für die Angle Attached Property.
		/// Wird vom XAML-Parser und von Code verwendet, um den aktuellen Winkel abzurufen.
		/// VERWENDUNG IM CODE: double angle = PolarPanel.GetAngle(myElement);
		/// </summary>
		/// <param name="element">Das Element, von dem der Winkel abgerufen wird.</param>
		/// <returns>Der Winkel in Grad.</returns>
		public static double GetAngle(UIElement element)
		{
			// GetValue(): Ruft den Wert aus der Property-Storage ab und castet ihn zum korrekten Typ.
			return (double)element.GetValue(AngleProperty);
		}
		#endregion

		#region Attached Property - Radius

		// ATTACHED PROPERTY 'Radius': Definiert den Abstand vom Mittelpunkt in Pixeln.
		// Zusammen mit 'Angle' bildet dies ein vollständiges Polarkoordinatensystem.
		// BEISPIEL IN XAML: <Button local:PolarPanel.Radius="100" local:PolarPanel.Angle="45" />
		// Dies positioniert den Button 100 Pixel vom Zentrum entfernt, in einem 45°-Winkel.
		public static readonly DependencyProperty RadiusProperty =
				DependencyProperty.RegisterAttached(
				"Radius",
				typeof(double),
				typeof(PolarPanel),
				new PropertyMetadata(0.0, Property_Changed));

		/// <summary>
		/// SetRadius: Setter für die Radius Attached Property.
		/// Setzt den Abstand zwischen dem Mittelpunkt des Child-Elements und dem Mittelpunkt des Panels.
		/// WICHTIG: Wie bei allen Attached Properties muss die Methode statisch sein und
		/// ein DependencyObject als ersten Parameter nehmen.
		/// </summary>
		/// <param name="element">Das Element, an das der Radius angehängt wird.</param>
		/// <param name="radius">Der Radius in Pixeln.</param>
		public static void SetRadius(UIElement element, double radius)
		{
			element.SetValue(RadiusProperty, radius);
		}

		/// <summary>
		/// GetRadius: Getter für die Radius Attached Property.
		/// Ruft den aktuellen Radius-Wert vom Element ab.
		/// VERWENDUNG: double r = PolarPanel.GetRadius(element);
		/// </summary>
		/// <param name="element">Das Element, von dem der Radius abgerufen wird.</param>
		/// <returns>Der Radius in Pixeln.</returns>
		public static double GetRadius(UIElement element)
		{
			return (double)element.GetValue(RadiusProperty);
		}
		#endregion

		/// <summary>
		/// Property_Changed: Callback, der aufgerufen wird, wenn sich eine Attached Property ändert.
		/// Dies ist der in PropertyMetadata registrierte Callback für Angle und Radius.
		/// 
		/// ZWECK: Wenn sich Angle oder Radius eines Child-Elements ändern, muss das Panel
		/// sein Layout neu berechnen. Daher rufen wir InvalidateArrange() auf dem Panel auf.
		/// 
		/// WICHTIG: 'sender' ist das Child-Element (z.B. Button), NICHT das Panel selbst.
		/// Wir müssen über element.Parent zum PolarPanel navigieren.
		/// </summary>
		/// <param name="sender">Das Element, dessen Attached Property sich geändert hat.</param>
		/// <param name="e">
		/// Event-Args mit OldValue und NewValue.
		/// The 
		/// <see cref="System.Windows.DependencyPropertyChangedEventArgs"/>
		/// instance containing the event data.
		/// </param>
		public static void Property_Changed(DependencyObject sender,
			DependencyPropertyChangedEventArgs e)
		{
			FrameworkElement? element = sender as FrameworkElement;

			if (element == null)
			{
				return;
			}

			// Wir benötigen nicht das Element, das die Änderung ausgelöst hat (z.B. Image),
			// sondern das übergeordnete Container-Panel (in diesem Fall das PolarPanel).
			// Nur das Panel kann InvalidateArrange() aufrufen, um das Layout neu zu berechnen.
			//We want not the element who was triggered
			//the change (eg: Image) but the parent container
			//panel...in this case the Polar Panel:
			PolarPanel? panel =
				element.Parent as PolarPanel;

			if (panel == null)
			{
				return;
			}

			// InvalidateArrange(): Erzwingt eine Neuberechnung des Layouts für das Panel.
			// Dies führt dazu, dass ArrangeOverride erneut aufgerufen wird,
			// wodurch alle Child-Elemente mit den neuen Angle/Radius-Werten neu positioniert werden.
			//Invalidate the layout of the panel
			//due to changes in Angle/Radius of
			//an element:
			panel.InvalidateArrange();
		}


		#region Constructors
		/// <summary>
		/// Konstruktor: Initialisiert eine neue Instanz des PolarPanel.
		/// Initializes a new instance 
		/// of the <see cref="PolarPanel"/> class.
		/// </summary>
		public PolarPanel() { }
		#endregion

		#region MethodOverrides
		/// <summary>
		/// MeasureOverride: Die "Measure"-Phase des WPF-Layout-Systems.
		/// Hier bestimmt das Panel, wie viel Platz es für sich und seine Children benötigt.
		/// 
		/// ZWECK: Jedes Child-Element wird gemessen, um seine DesiredSize zu ermitteln.
		/// Für PolarPanel geben wir einfach die verfügbare Größe zurück, da die Positionierung
		/// in Polarkoordinaten erfolgt und nicht größenabhängig ist.
		/// 
		/// REIHENFOLGE: MeasureOverride wird VOR ArrangeOverride aufgerufen.
		/// Provides the behavior for the "measure" pass 
		/// of Silverlight layout.
		/// Classes can override this method to define 
		/// their own measure pass behavior.
		/// </summary>
		/// <param name="availableSize">
		/// Die verfügbare Größe, die dieses Panel seinen Children geben kann.
		/// Infinity bedeutet unbegrenzte Größe.
		/// The available size that this object can give to child objects. 
		/// Infinity can be specified as a value to indicate that the 
		/// object will size to whatever content is available.
		/// </param>
		/// <returns>
		/// Die Größe, die das Panel basierend auf seinen Berechnungen benötigt.
		/// The size that this object determines it needs 
		/// during layout, based on its calculations 
		/// of child object allotted sizes.
		/// </returns>
		protected override Size MeasureOverride(Size availableSize)
		{
			// Schleife durch alle Child-Elemente und rufe Measure() auf.
			// Measure() teilt jedem Child mit, wie viel Platz verfügbar ist,
			// und das Child berechnet seine DesiredSize.
			//Loop through each child element, 
			//forcing measure to take place:
			foreach (UIElement element in this.Children)
			{
				element.Measure(element.DesiredSize);
			}
			// Wir geben die verfügbare Größe als unsere benötigte Größe zurück.
			// Dies ist vereinfacht - ein robusteres Panel könnte hier basierend auf
			// den Radius-Werten der Children eine minimale Größe berechnen.
			//At this point, they all should be the same 
			//as their stated size -- of the size 
			//this control:
			return availableSize;
		}


		/// <summary>
		/// ArrangeOverride: Die "Arrange"-Phase des WPF-Layout-Systems.
		/// Hier positioniert das Panel seine Child-Elemente basierend auf ihren Attached Properties.
		/// 
		/// KERNLOGIK: Für jedes Child-Element:
		/// 1. Hole Angle und Radius aus den Attached Properties
		/// 2. Konvertiere Polarkoordinaten (Angle, Radius) zu kartesischen Koordinaten (X, Y)
		/// 3. Rufe element.Arrange() auf, um das Element an der berechneten Position zu platzieren
		/// 
		/// WICHTIG: Dies ist der Ort, wo die Attached Properties tatsächlich verwendet werden!
		/// When implemented in a derived class, 
		/// provides the behavior for 
		/// the "Arrange" pass of Silverlight layout.
		/// </summary>
		/// <param name="finalSize">
		/// Die finale Größe, die dem Panel zur Verfügung steht.
		/// The final area within the parent that this 
		/// element should use to arrange itself and its children.
		/// </param>
		/// <returns>Die tatsächlich verwendete Größe (The actual size used).</returns>
		protected override Size ArrangeOverride(Size finalSize)
		{

			// Nicht vollständig implementiert: Könnte zur Rotation des gesamten Panels verwendet werden.
			//Not implemented yet:
			double baseRotationAngle = (double)this.GetValue(AngleProperty);


			// Hauptschleife: Positioniere jedes Child-Element basierend auf Angle und Radius.
			foreach (UIElement element in this.Children)
			{
				// GetValue(): Hole den Angle-Wert von der Attached Property des Elements.
				// Dies ist der Wert, der in XAML mit PolarPanel.Angle="..." gesetzt wurde.
				//Get the Element's Angle and Radius 
				//from the Panel center:
				double elementAngle = (double)element.GetValue(AngleProperty);
				
				// Konvertierung: Wenn AngleFromTop=true, verschieben wir 0° von rechts nach oben.
				// Standardmäßig ist 0° in Polarkoordinaten rechts (X-Achse),
				// aber für UI ist oben (Y-Achse) oft intuitiver.
				if (_AngleFromTop)
				{
					elementAngle -= 90;//From Right to Top.
				}
				elementAngle += baseRotationAngle;

				// GetValue(): Hole den Radius-Wert von der Attached Property des Elements.
				double radius = (double)element.GetValue(RadiusProperty);

				// DegreesToXY(): Hilfsmethode zur Umwandlung von Polarkoordinaten (Angle, Radius)
				// zu kartesischen Koordinaten (X, Y) für die Bildschirmpositionierung.
				//Use helper to Cartesian coordinates
				//from polar coordinates:
				Point point = DegreesToXY(elementAngle, radius);


				// Arrange(): Teilt dem Element seine finale Position und Größe mit.
				// Das Rect definiert die Bounding Box des Elements.
				// point.X, point.Y: Die berechnete Position
				// finalSize.Width/Height: Die verfügbare Größe für das Element
				//And give it a rectangle in which to draw themselves:
				element.Arrange(
					new Rect(
						point.X, point.Y,
						finalSize.Width, finalSize.Height
						)
						);
			}

			return base.ArrangeOverride(finalSize);
		}
		#endregion

		#region Static Methods
		// DegreesToXY: Konvertiert Polarkoordinaten (Winkel in Grad, Radius) zu kartesischen Koordinaten (X, Y).
		// MATHEMATIK:
		// - X = cos(Winkel in Radiant) * Radius
		// - Y = sin(Winkel in Radiant) * Radius
		// WICHTIG: Diese Methode arbeitet mit mathematischen Standardkoordinaten,
		// wo 0° rechts ist und Winkel gegen den Uhrzeigersinn zunehmen.
		protected Point DegreesToXY(double degrees, double radius)
		{
			// Grad zu Radiant: Multipliziere mit π/180
			double radians = degrees * Math.PI / 180.0;
			Point result = new Point();
			// Trigonometrische Umrechnung von Polar zu Kartesisch
			result.X = Math.Cos(radians) * radius;
			result.Y = Math.Sin(radians) * radius;
			return result;
		}
		#endregion

		/// <summary>
		/// CartesianToPolar: Konvertiert kartesische Koordinaten (X, Y) zu Polarkoordinaten (Winkel, Radius).
		/// Diese Methode ist die Umkehrung von DegreesToXY und wird aktuell nicht verwendet,
		/// könnte aber nützlich sein für Hit-Testing oder Drag-and-Drop-Funktionalität.
		/// 
		/// MATHEMATIK:
		/// - Radius = √(X² + Y²) - Satz des Pythagoras
		/// - Winkel = arctan(X / Y) - mit Sonderfällen für die Y-Achse
		/// Converts Cartesian coordinates 
		/// to Polar coordinates.
		/// </summary>
		/// <param name="p">Der kartesische Punkt (The p).</param>
		/// <param name="angle">Output: Der berechnete Winkel (The angle).</param>
		/// <param name="radius">Output: Der berechnete Radius (The radius).</param>
		static void CartesianToPolar(Point p,
			out double angle, out double radius)
		{

			// Satz des Pythagoras zur Berechnung der Distanz vom Ursprung
			radius = Math.Sqrt((p.X * p.X) + (p.Y + p.Y));
			double div = Math.PI / 2.0;
			
			// Sonderfälle für Punkte auf der Y-Achse (X = 0)
			if (p.X == 0.0)
			{
				// Auf der Y-Achse:
				//On X-Axis:
				if (p.Y > 0)
				{
					// Nach rechts (oben in Bildschirmkoordinaten):
					//To the right:
					angle = div;
					return;
				}
				else if (p.Y < 0)
				{
					// Nach links (unten in Bildschirmkoordinaten):
					//to the left:
					angle = 3 * div;
					return;
				}
			}
			// Standardfall: Verwende arctan für die Winkelberechnung
			angle = Math.Atan(p.X / p.Y);
		}
	}
}
