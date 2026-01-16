using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApplyBinding {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		/// <summary>
		/// Event-Handler für die Änderung des Slider-Werts
		/// 
		/// DEPENDENCY PROPERTY KONZEPTE:
		/// - Demonstriert die direkte Zuweisung (SetValue) einer Dependency Property
		/// - Dies setzt einen LOCAL VALUE, der höchste Priorität im Value Precedence System hat
		/// - Reihenfolge der Wertpriorität: Local > Style > Default > Inherited
		/// 
		/// PERFORMANCE-VORTEIL:
		/// - Binding ist effizienter als manuelle Event-Handler
		/// - WPF nutzt Sparse Storage: nur gesetzte Werte werden im Memory gespeichert
		/// - Default-Werte werden in der Dependency Property Metadata geteilt
		/// 
		/// ALTERNATIVE ANSÄTZE:
		/// - SetCurrentValue() würde den Wert setzen ohne Binding zu überschreiben
		/// - ClearValue() könnte verwendet werden um zurück zum Style/Default zu gehen
		/// </summary>
		private void CodeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
			// Direkte Property-Zuweisung = SetValue() im Hintergrund
			// Dies erstellt einen LOCAL VALUE mit höchster Priorität
			CodeStar.Points = (int)CodeSlider.Value;
		}
	}
}
