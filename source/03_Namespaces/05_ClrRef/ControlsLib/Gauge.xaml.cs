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

// Control Library Namespace.
// XAML-MAPPING: xmlns:ctrl="clr-namespace:BigStar.Lib.Controls;assembly=ControlsLib"
namespace BigStar.Lib.Controls {
	/// <summary>
	/// Interaction logic for Gauge.xaml
	/// </summary>
	
	// Gauge-UserControl: Drehbares Messzeiger-Control.
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
		
		// 'static readonly DependencyProperty': WPF Dependency Property.
		// VORTEIL: Data Binding, Animationen, Styling.
		public static readonly DependencyProperty DegreeProperty =
				// 'Register': Registriert Property im WPF Property System.
				DependencyProperty.Register(
						"Degree",              // Property-Name
						typeof(double),        // Datentyp
						typeof(Gauge),         // Owner-Type
						new PropertyMetadata(0d, OnDegreeChanged)); // Default-Wert und Callback

		/// <summary>
		/// Gets or sets the Degree property. This dependency property 
		/// indicates ....
		/// </summary>
		
		// CLR-Wrapper für DependencyProperty.
		// WICHTIG: Nur GetValue/SetValue aufrufen (keine zusätzliche Logik).
		public double Degree {
			// 'GetValue': Liest aus WPF Property System.
			get { return (double)GetValue(DegreeProperty); }
			
			// 'SetValue': Schreibt ins WPF Property System.
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
		
		// 'static' Callback: Bei Wert-Änderung aufgerufen.
		private static void OnDegreeChanged(
				DependencyObject d, DependencyPropertyChangedEventArgs e) {
			// Cast zum konkreten Typ.
			var target = (Gauge)d;
			
			// Alte und neue Werte.
			double oldDegree = (double)e.OldValue;
			double newDegree = target.Degree;
			
			// Delegiert an Instanz-Methode.
			target.OnDegreeChanged(oldDegree, newDegree);
		}

		/// <summary>
		/// Provides derived classes an opportunity to handle changes
		/// to the Degree property.
		/// </summary>
		/// <param name="oldDegree">The old Degree value</param>
		/// <param name="newDegree">The new Degree value</param>
		
		// Instanz-Methode: Reagiert auf Degree-Änderungen.
		private void OnDegreeChanged(
				double oldDegree, double newDegree) {
			// Aktualisiert Transform-Winkel für Rotation.
			GridTransform.Angle = newDegree;
			
			// Aktualisiert String-Darstellung.
			DegreeString = newDegree.ToString() + " º";

		}
		#endregion

		#region DegreeString
		/// <summary>
		/// DegreeString Dependency Property
		/// </summary>
		
		// DependencyProperty für String-Darstellung.
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
		public string DegreeString {
			get { return (string)GetValue(DegreeStringProperty); }
			set { SetValue(DegreeStringProperty, value); }
		}
		#endregion
	}
}
