// .NET Standard-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Namespaces für UserControl und DependencyProperty.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// Custom Control Library Namespace.
// XAML-MAPPING: xmlns:ctrl="clr-namespace:BigStar.Lib.Controls;assembly=ControlsLib"
namespace BigStar.Lib.Controls {
	/// <summary>
	/// Interaction logic for Gauge.xaml
	/// </summary>
	
	// Gauge-UserControl: Zeigt einen drehbaren Messzeiger (Gauge).
	// EINSATZZWECK: Visuelle Darstellung von Werten (z.B. Geschwindigkeit, Temperatur).
	public partial class Gauge : UserControl {
		
		// Konstruktor.
		public Gauge() {
			// Initialisiert XAML-UI.
			InitializeComponent();
		}

		#region Degree
		/// <summary>
		/// Degree Dependency Property
		/// </summary>
		
		// 'static readonly DependencyProperty': Definiert eine WPF Dependency Property.
		// WICHTIG: Ermöglicht Data Binding, Animationen, Styling, und Property Value Inheritance.
		// UNTERSCHIED zu CLR-Property: Unterstützt WPF-Features wie Binding und Change Notifications.
		// NAMING: Konvention ist PropertyName + "Property" (hier: Degree + Property).
		public static readonly DependencyProperty DegreeProperty =
				// 'DependencyProperty.Register': Registriert die Property im WPF Property System.
				DependencyProperty.Register(
						"Degree",              // Property-Name (muss mit CLR-Wrapper übereinstimmen)
						typeof(double),        // Datentyp der Property
						typeof(Gauge),         // Owner-Type (diese Klasse)
						new PropertyMetadata(0d, OnDegreeChanged)); // Default-Wert und Change-Callback

		/// <summary>
		/// Gets or sets the Degree property. This dependency property 
		/// indicates ....
		/// </summary>
		
		// CLR-Wrapper für die DependencyProperty.
		// WICHTIG: XAML und Code nutzen diesen Wrapper, nicht die DependencyProperty direkt.
		// KONVENTION: Getter/Setter müssen nur GetValue/SetValue aufrufen (keine zusätzliche Logik!).
		public double Degree {
			// 'GetValue': Liest den Wert aus dem WPF Property System.
			// VORTEIL: Unterstützt Data Binding, Animationen, Styling.
			get { return (double)GetValue(DegreeProperty); }
			
			// 'SetValue': Schreibt den Wert ins WPF Property System.
			// TRIGGER: Feuert automatisch OnDegreeChanged-Callback.
			set { SetValue(DegreeProperty, value); }
		}

		/// <summary>
		/// Handles changes to the Degree property.
		/// </summary>
		/// <param name="d">
		/// The <see cref="DependencyObject"/> on which
		/// the property has changed value.
		/// </param>
		/// <param name="e">
		/// Event data that is issued by any event that
		/// tracks changes to the effective value of this property.
		/// </param>
		
		// 'static' Callback: Wird aufgerufen, wenn sich der Degree-Wert ändert.
		// WICHTIG: Muss static sein, weil er für alle Instanzen gilt.
		// PARAMETER 'd': Das DependencyObject (hier: Gauge-Instanz).
		// PARAMETER 'e': Enthält OldValue und NewValue.
		private static void OnDegreeChanged(
				DependencyObject d, DependencyPropertyChangedEventArgs e) {
			// Cast zum konkreten Typ (Gauge).
			var target = (Gauge)d;
			
			// Alte und neue Werte extrahieren.
			double oldDegree = (double)e.OldValue;
			double newDegree = target.Degree;
			
			// Ruft instanz-spezifische Methode auf.
			// PATTERN: Static Callback delegiert an Instanz-Methode für bessere Kapselung.
			target.OnDegreeChanged(oldDegree, newDegree);
		}

		/// <summary>
		/// Provides derived classes an opportunity to handle changes
		/// to the Degree property.
		/// </summary>
		/// <param name="oldDegree">The old Degree value</param>
		/// <param name="newDegree">The new Degree value</param>
		
		// Instanz-Methode: Reagiert auf Degree-Änderungen.
		// VORTEIL: Kann auf Instanz-Felder zugreifen (im Gegensatz zu static Callback).
		private void OnDegreeChanged(
				double oldDegree, double newDegree) {
			// Aktualisiert Transform-Winkel für visuelle Rotation.
			// ANNAHME: 'GridTransform' ist ein RotateTransform in der XAML.
			GridTransform.Angle = newDegree;
			
			// Aktualisiert String-Darstellung mit Grad-Symbol.
			// BINDING: DegreeString wird vermutlich in XAML angezeigt.
			DegreeString = newDegree.ToString() + " º";

		}
		#endregion

		#region DegreeString
		/// <summary>
		/// DegreeString Dependency Property
		/// </summary>
		
		// Zweite DependencyProperty für String-Darstellung des Degree-Werts.
		// ZWECK: Formatierter String für Anzeige in der UI.
		public static readonly DependencyProperty DegreeStringProperty =
				DependencyProperty.Register(
						"DegreeString",        // Property-Name
						typeof(string),        // String-Typ
						typeof(Gauge),         // Owner-Type
						new PropertyMetadata("0")); // Default: "0"

		/// <summary>
		/// Gets or sets the DegreeString property. This dependency property 
		/// indicates ....
		/// </summary>
		
		// CLR-Wrapper für DegreeString.
		// VERWENDUNG: Kann in XAML gebunden werden: {Binding DegreeString}
		public string DegreeString {
			get { return (string)GetValue(DegreeStringProperty); }
			set { SetValue(DegreeStringProperty, value); }
		}
		#endregion
	}
}
