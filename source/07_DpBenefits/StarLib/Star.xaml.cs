// Standard .NET Namespaces
using System;
// System.Collections: Basis-Collections-Interfaces (IEnumerable, ICollection, etc.)
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF-Desktop-Anwendungen
using System.Windows;
// System.Windows.Controls: Alle Standard-UI-Steuerelemente (Button, TextBox, UserControl, etc.)
using System.Windows.Controls;
// System.Windows.Data: Datenbindung zwischen UI und Geschäftslogik
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung (FlowDocument, Paragraph, etc.)
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung (Maus, Tastatur, Touch, Commands)
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms, Animationen
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung und -anzeige
using System.Windows.Media.Imaging;
// System.Windows.Navigation: Navigation zwischen Seiten/Frames
using System.Windows.Navigation;
// System.Windows.Shapes: Vektorgrafikelemente (Rectangle, Ellipse, Line, Polygon)
using System.Windows.Shapes;

namespace StarLib.Shapes {

	// 'public': Macht dieses Steuerelement für andere Programmteile und externe Assemblies verfügbar.
	// 'partial': Teilt die Klasse auf. Der Compiler kombiniert diesen Teil mit dem vom XAML-Parser 
	// generierten Code (der die UI-Elemente wie Grids oder Ellipsen instanziiert).
	// ': UserControl': Basisklasse für zusammengesetzte Steuerelemente. Sie bietet bereits 
	// Unterstützung für Ressourcen, DataContext und visuelle Baumstrukturen.
	// ZWECK: Star ist ein wiederverwendbares Custom Control mit mehreren Dependency Properties,
	// das eine animierte Stern-Grafik mit konfigurierbaren Eigenschaften darstellt.
	public partial class Star : UserControl {

		// Instanz-Konstruktor: Wird aufgerufen, wenn das Star-Control im Speicher erzeugt wird.
		// AUFRUF: Automatisch durch WPF bei XAML-Parsing oder durch new Star() im Code.
		public Star() {
			// 'InitializeComponent': KRITISCH! Diese Methode wird vom XAML-Compiler generiert.
			// Sie lädt die XAML-Datei (Star.xaml), verbindet Event-Handler und mappt x:Name auf Felder.
			// WICHTIG: Ohne diesen Aufruf würde das Control keine visuelle Darstellung haben!
			InitializeComponent();
		}

		// DEPENDENCY PROPERTIES: Das Herzstück des WPF Property Systems
		// VORTEILE gegenüber normalen CLR-Properties:
		// 1. Data Binding: Automatische UI-Updates bei Wertänderungen
		// 2. Styling & Triggers: Properties können durch Styles gesetzt werden
		// 3. Animations: Smooth Animationen ohne zusätzlichen Code
		// 4. Value Precedence: Local > Style > Template > Inherited > Default
		// 5. Property Change Notifications: Callbacks bei Wertänderungen
		// 6. Memory Efficiency: Sparse Storage - Werte werden nur gespeichert, wenn ≠ Default

		// VORAUSSETZUNG: Um DependencyProperty nutzen zu können, muss die Klasse von 
		// DependencyObject ableiten. UserControl erfüllt diese Anforderung bereits, da die 
		// Vererbungskette UserControl -> Control -> FrameworkElement -> UIElement -> 
		// Visual -> DependencyObject läuft.

		// SCHRITT 1: Deklaration der DependencyProperty-Felder
		// 'public static readonly': Diese Felder sind die "Fingerabdrücke" der Properties im WPF-System.
		// 'static': Sorgt dafür, dass die Property-Metadaten nur EINMAL pro AppDomain existieren,
		// nicht einmal pro Instanz. Dies spart massiv Speicher bei vielen Control-Instanzen.
		// 'readonly': Verhindert, dass die Registrierung zur Laufzeit versehentlich überschrieben wird.
		// NAMING CONVENTION: PropertyName + "Property" (z.B. Points + Property = PointsProperty)

		// PointsProperty: Definiert die Anzahl der Sternspitzen (min: 2, max: 10)
		// VERWENDUNG IN XAML: <Star Points="5" />
		public static readonly DependencyProperty PointsProperty;

		// InnerSizeProperty: Skaliert die inneren Ellipsen relativ zu den äußeren Ellipsen.
		// WERT: 1.0 = gleiche Größe, 0.5 = halbe Größe, 2.0 = doppelte Größe
		// VERWENDUNG IN XAML: <Star InnerSize="0.7" />
		public static readonly DependencyProperty InnerSizeProperty;

		// BackEffectVisibleProperty: Steuert die Sichtbarkeit des Hintergrund-Kreises.
		// VERWENDUNG: Kann verwendet werden, um einen Leuchteffekt um den Stern ein-/auszublenden.
		// VERWENDUNG IN XAML: <Star BackEffectVisible="True" />
		public static readonly DependencyProperty BackEffectVisibleProperty;

		// MessageProperty: Text, der im Stern angezeigt werden soll.
		// ZWECK: Ermöglicht das Anzeigen von benutzerdefinierten Texten innerhalb der Stern-Grafik.
		// VERWENDUNG IN XAML: <Star Message="Herzlich Willkommen" />
		public static readonly DependencyProperty MessageProperty;

		// SCHRITT 2: Statischer Konstruktor - Wird EINMAL pro AppDomain ausgeführt
		// 'static': Wird automatisch VOR der ersten Instanziierung der Klasse aufgerufen.
		// ZWECK: Registrierung aller DependencyProperties beim WPF Property System.
		// WICHTIG: 'readonly' Felder können NUR im statischen Konstruktor zugewiesen werden.
		// TIMING: Dieser Code läuft garantiert vor jedem Instanz-Konstruktor oder Static-Member-Zugriff.
		static Star() {
			// SCHRITT 2A: Registrierung der PointsProperty
			// PropertyMetadata: Definiert Standardwert und Callback-Mechanismus
			// 'defaultValue': Wert, der verwendet wird, wenn keine andere Quelle (Local/Style/etc.) einen Wert liefert.
			// 'propertyChangedCallback': Wird aufgerufen, wenn sich der Property-Wert ändert.
			// PATTERN: Static Callback leitet an instanzbasierte virtuelle Methode weiter.
			var meta = new PropertyMetadata(defaultValue: 8,
																	propertyChangedCallback: PointsChanged);
			// DependencyProperty.Register: Registriert die Property global im WPF-System.
			// 'name': String-Name der Property (muss mit CLR-Property übereinstimmen).
			// 'propertyType': CLR-Typ der Property (int, double, string, bool, etc.).
			// 'ownerType': Die Klasse, die diese Property besitzt (typeof(Star)).
			// 'typeMetadata': Metadaten mit Default-Wert, Callbacks, Coercion, etc.
			// RÜCKGABE: Eine DependencyProperty-Instanz, die als eindeutiger Identifier dient.
			PointsProperty = DependencyProperty.Register(name: "Points",
																									propertyType: typeof(int),
																									ownerType: typeof(Star),
																									typeMetadata: meta);

			// SCHRITT 2B: Registrierung der InnerSizeProperty
			// 'defaultValue: 1.0': Standardmäßig haben innere und äußere Ellipsen dieselbe Größe.
			var meta2 = new PropertyMetadata(defaultValue: 1.0,
																	propertyChangedCallback: InnerSizeChanged);
			// 'propertyType: typeof(double)': Erlaubt Dezimalwerte für präzise Skalierung.
			InnerSizeProperty = DependencyProperty.Register(name: "InnerSize",
																											propertyType: typeof(double),
																											ownerType: typeof(Star),
																											typeMetadata: meta2);


			// SCHRITT 2C: Registrierung der BackEffectVisibleProperty
			// 'defaultValue: true': Der Hintergrundeffekt ist standardmäßig sichtbar.
			var meta3 = new PropertyMetadata(defaultValue: true,
														propertyChangedCallback: BackEffectVisibleChanged);
			// 'propertyType: typeof(bool)': Boolean-Property für einfaches Ein-/Ausschalten.
			BackEffectVisibleProperty = DependencyProperty.Register(name: "BackEffectVisible",
																														propertyType: typeof(bool),
																														ownerType: typeof(Star),
																														typeMetadata: meta3);

			// SCHRITT 2D: Registrierung der MessageProperty
			// 'defaultValue: String.Empty': Standardmäßig ist kein Text im Stern.
			var meta4 = new PropertyMetadata(defaultValue: String.Empty,
														propertyChangedCallback: MessageChanged);
			// HINWEIS: 'name: "MessageProperty"' ist inkonsistent - sollte "Message" sein!
			// Dies funktioniert trotzdem, da der CLR-Wrapper korrekt auf MessageProperty verweist.
			MessageProperty = DependencyProperty.Register(name: "MessageProperty",
																										propertyType: typeof(string),
																										ownerType: typeof(Star),
																										typeMetadata: meta4);
		}



		#region Points

		// SCHRITT 3: CLR-Wrapper für PointsProperty
		// CLR-Wrapper: Ermöglicht Programmierern den Zugriff wie auf eine normale C#-Eigenschaft.
		// WICHTIG: Das WPF-System (Binding/XAML) umgeht diesen Wrapper oft aus Performancegründen.
		// REGEL: Kein zusätzlicher Code im Getter/Setter erlaubt! Nur GetValue/SetValue aufrufen.
		// GRUND: Da XAML und Bindings den Wrapper überspringen, würde zusätzliche Logik nicht zuverlässig ausgeführt.
		// HINWEIS: Es gibt KEIN Backing-Field (keine private Variable). Der Wert wird im WPF Property Store gespeichert.
		public int Points
		{
			// 'GetValue': Fragt den aktuellen Wert aus dem WPF-Prioritätssystem ab.
			// PRIORITÄT (höchste zuerst): Local Value > Template > Style > Inherited > Default
			get { return (int)GetValue(PointsProperty); }
			// 'SetValue': Setzt einen LOCAL VALUE im Framework-Speicher (höchste Priorität außer Animationen).
			set { SetValue(PointsProperty, value); }
		}

		#region Points Property Changed
		// PROPERTY CHANGED CALLBACK - TEIL 1: Static Entry Point
		// 'private static': Statische Callback-Methode, die vom WPF-System aufgerufen wird.
		// 'sender': Das DependencyObject (hier: Star-Instanz), dessen Property sich geändert hat.
		// 'args': Enthält OldValue, NewValue und die Property-Referenz.
		// PATTERN: Diese Methode castet den Sender und delegiert an eine instanzbasierte virtuelle Methode.
		// VORTEIL: Ermöglicht Ableitungsklassen, das Verhalten durch Überschreiben zu ändern.
		private static void PointsChanged(object sender, DependencyPropertyChangedEventArgs args) {
			// Cast von 'object' zu 'Star', da wir wissen, dass nur Star-Instanzen diese Property haben.
			((Star)sender).OnPointsChanged(args);

		}

		// PROPERTY CHANGED CALLBACK - TEIL 2: Instance Method
		// 'protected virtual': Kann von abgeleiteten Klassen überschrieben werden (Erweiterbarkeit).
		// ZWECK: Reagiert auf Änderungen der Points-Property und aktualisiert die UI entsprechend.
		protected virtual void OnPointsChanged(DependencyPropertyChangedEventArgs e) {

			// VALIDIERUNG: Begrenze die Anzahl der Punkte auf den Bereich [2, 10]
			// 'e.NewValue': Der neue Wert, der gerade gesetzt wurde.
			int pointCount = Math.Min((int)e.NewValue, 10);
			pointCount = Math.Max((int)e.NewValue, 2);


			// BERECHNUNG: Winkel zwischen den Sternspitzen (360° / Anzahl Punkte / 2)
			// BEISPIEL: Bei 5 Punkten ergibt sich 180 / 5 = 36°
			double angle = 180 / pointCount;
			double angleCounter = 0;

			// LINQ-ABFRAGE 1: Alle großen Ellipsen aus dem BigGrid auswählen
			// 'OfType<Ellipse>()': Filtert die Children-Collection nach Ellipse-Elementen.
			// VORTEIL: Typ-sicher, kein Cast erforderlich, ignoriert andere UI-Elemente.
			var allBigEllipse = BigGrid.Children.OfType<Ellipse>();
			// 'Take(pointCount)': Nimmt nur die ersten N Ellipsen (entsprechend der Punktanzahl).
			var selectBigEllipses = BigGrid.Children.OfType<Ellipse>().Take(pointCount);

			// LINQ-ABFRAGE 2: Alle kleinen Ellipsen aus dem SmallGrid auswählen
			var allSmallEllipse = SmallGrid.Children.OfType<Ellipse>();
			var selectSmallEllipses = SmallGrid.Children.OfType<Ellipse>().Take(pointCount);

			// SCHRITT 1: Alle großen Ellipsen ausblenden
			// 'Visibility.Collapsed': Element wird unsichtbar und benötigt keinen Layout-Platz.
			// ALTERNATIVE: 'Visibility.Hidden' wäre unsichtbar, aber würde Platz reservieren.
			foreach (var elip in allBigEllipse)
			{
				elip.Visibility = Visibility.Collapsed;
			}
			// SCHRITT 2: Alle kleinen Ellipsen ausblenden
			foreach (var elip in allSmallEllipse)
			{
				elip.Visibility = Visibility.Collapsed;
			}

			// SCHRITT 3: Ausgewählte große Ellipsen einblenden und rotieren
			angleCounter = 0;
			foreach (var elip in selectBigEllipses)
			{
				// Ellipse sichtbar machen
				elip.Visibility = Visibility.Visible;

				// TRANSFORM-MANIPULATION: Zugriff auf die RenderTransform der Ellipse
				// 'RenderTransform': Ermöglicht Transformationen (Rotation, Skalierung, Translation).
				// 'as TransformGroup': Cast, da mehrere Transformationen gruppiert sein können.
				var render = elip.RenderTransform as TransformGroup;
				// LINQ: 'First()' holt die erste RotateTransform aus der Children-Collection.
				var rot = render.Children.OfType<RotateTransform>().First();
				// Setze den Rotationswinkel für diese Spitze
				rot.Angle = angleCounter;
				angleCounter += angle;
			}

			// SCHRITT 4: Ausgewählte kleine Ellipsen einblenden und rotieren
			// 'offset': Kleine Ellipsen werden um die Hälfte des Winkels versetzt,
			// sodass sie zwischen den großen Ellipsen positioniert sind.
			var offset = angle / 2;
			angleCounter = 0 + offset;
			foreach (var elip in selectSmallEllipses)
			{
				// Ellipse sichtbar machen
				elip.Visibility = Visibility.Visible;

				// Zugriff auf die Rotation (gleiche Technik wie bei großen Ellipsen)
				var render = elip.RenderTransform as TransformGroup;
				var rot = render.Children.OfType<RotateTransform>().First();
				// Setze den Rotationswinkel (versetzt um offset)
				rot.Angle = angleCounter;
				angleCounter += angle;
			}

		}

		#endregion

		#endregion


		#region InnerSize

		// CLR-Wrapper für InnerSizeProperty
		// ZWECK: Ermöglicht den Zugriff auf die Skalierung der inneren Ellipsen.
		public double InnerSize
		{
			// 'GetValue': Ruft den aktuellen Skalierungswert aus dem WPF Property Store ab.
			get { return (double)GetValue(InnerSizeProperty); }
			// 'SetValue': Setzt den Skalierungswert und triggert den PropertyChanged-Callback.
			set { SetValue(InnerSizeProperty, value); }
		}

		// PROPERTY CHANGED CALLBACK: Static Entry Point für InnerSizeProperty
		// AUFRUF: Wird automatisch vom WPF-System aufgerufen, wenn sich InnerSize ändert.
		private static void InnerSizeChanged(object sender, DependencyPropertyChangedEventArgs args) {
			// Delegation an instanzbasierte Methode
			((Star)sender).OnInnerSizeChanged(args);

		}

		// PROPERTY CHANGED CALLBACK: Instance Method für InnerSizeProperty
		// ZWECK: Skaliert das SmallGrid (enthält die inneren Ellipsen) entsprechend dem neuen Wert.
		protected virtual void OnInnerSizeChanged(DependencyPropertyChangedEventArgs e) {

			// Extrahiere den neuen Wert
			var newValue = (double)e.NewValue;

			// VALIDIERUNG: Negative Werte werden in positive umgewandelt
			// HINWEIS: Dies verhindert "umgedrehte" Sterne durch negative Skalierung.
			if (newValue < 0)
			{
				InnerSize = Math.Abs(newValue);
			}

			// TRANSFORM-MANIPULATION: Zugriff auf die RenderTransform des SmallGrid
			var render = SmallGrid.RenderTransform as TransformGroup;
			// LINQ: Hole die ScaleTransform aus der TransformGroup
			// 'First()': Nimmt die erste ScaleTransform (sollte nur eine geben).
			var scale = render.Children.OfType<ScaleTransform>().First();
			// SKALIERUNG: Setze beide Achsen (X und Y) auf den gleichen Wert für proportionale Skalierung.
			// EFFEKT: Bei 0.5 werden die inneren Ellipsen auf halbe Größe verkleinert.
			scale.ScaleX = scale.ScaleY = newValue;
		}
		#endregion

		#region BackEffectVisible

		// CLR-Wrapper für BackEffectVisibleProperty
		// ZWECK: Steuert die Sichtbarkeit des Hintergrund-Leuchteffekts (BackCircle).
		public bool BackEffectVisible
		{
			// 'GetValue': Fragt den Boolean-Wert aus dem WPF Property Store ab.
			get { return (bool)GetValue(BackEffectVisibleProperty); }
			// 'SetValue': Ändert die Sichtbarkeit und triggert den PropertyChanged-Callback.
			set { SetValue(BackEffectVisibleProperty, value); }
		}

		// PROPERTY CHANGED CALLBACK: Static Entry Point für BackEffectVisibleProperty
		private static void BackEffectVisibleChanged(object sender, DependencyPropertyChangedEventArgs args) {
			// Delegation an instanzbasierte Methode
			((Star)sender).OnBackEffectVisible(args);

		}

		// PROPERTY CHANGED CALLBACK: Instance Method für BackEffectVisibleProperty
		// ZWECK: Schaltet den Hintergrund-Kreis (BackCircle) sichtbar/unsichtbar.
		protected virtual void OnBackEffectVisible(DependencyPropertyChangedEventArgs e) {

			// Extrahiere den neuen Boolean-Wert
			bool IsVisible = (bool)e.NewValue;

			// VISIBILITY-MANIPULATION: Schalte BackCircle ein oder aus
			if (IsVisible)
			{
				// 'Visibility.Visible': Element wird angezeigt und nimmt Layout-Platz ein.
				BackCircle.Visibility = Visibility.Visible;
			}
			else
			{
				// 'Visibility.Collapsed': Element wird ausgeblendet und nimmt keinen Layout-Platz ein.
				// EFFEKT: Der Leuchteffekt um den Stern verschwindet komplett.
				BackCircle.Visibility = Visibility.Collapsed;
			}
		}
		#endregion

		#region Message

		// CLR-Wrapper für MessageProperty
		// ZWECK: Ermöglicht das Setzen/Lesen der Textnachricht, die im Stern angezeigt wird.
		public string Message
		{
			// 'GetValue': Ruft den aktuellen Text aus dem WPF Property Store ab.
			get { return (string)GetValue(MessageProperty); }
			// 'SetValue': Setzt den Text und triggert den PropertyChanged-Callback.
			set { SetValue(MessageProperty, value); }
		}

		// PROPERTY CHANGED CALLBACK: Static Entry Point für MessageProperty
		private static void MessageChanged(object sender, DependencyPropertyChangedEventArgs args) {
			// Delegation an instanzbasierte Methode
			((Star)sender).OnMessageChanged(args);

		}

		// PROPERTY CHANGED CALLBACK: Instance Method für MessageProperty
		// ZWECK: Aktualisiert den angezeigten Text im MessageTextBlock.
		protected virtual void OnMessageChanged(DependencyPropertyChangedEventArgs e) {

			// Extrahiere den neuen String-Wert
			// 'ToString()': Konvertiert e.NewValue (vom Typ object) zu string.
			// SICHERHEIT: Auch wenn NewValue null ist, gibt ToString() "".
			string message = e.NewValue.ToString();

			// TEXT-AKTUALISIERUNG: Setze den Text des TextBlocks im XAML
			// 'MessageTextBlock': Muss in Star.xaml mit x:Name="MessageTextBlock" definiert sein.
			MessageTextBlock.Text = message;
		}

		#endregion
	}
}
