// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF-Anwendungen.
using System.Windows;
// System.Windows.Controls: Alle Standard-UI-Steuerelemente.
using System.Windows.Controls;
// System.Windows.Data: Data Binding zwischen UI und Geschäftslogik.
// WICHTIG: Dieses Projekt demonstriert Data Binding mit DependencyProperties!
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Navigation: Seitennavigation.
using System.Windows.Navigation;
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;

// Namespace für die Data Binding Demo.
// KONTEXT: Demonstriert die Vorteile von DependencyProperties für Data Binding.
// VERGLEICH: Code-basiertes Binding vs. XAML-Binding.
namespace ApplyBinding {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// 'MainWindow': Hauptfenster der ApplyBinding-Demo.
	// ZWECK: Vergleicht verschiedene Binding-Ansätze mit DependencyProperties.
	// KONTEXT: Teil der "07_DpBenefits"-Serie über Dependency Property Vorteile.
	public partial class MainWindow : Window {
		// Konstruktor: Initialisiert das Fenster.
		public MainWindow() {
			// 'InitializeComponent()': Lädt XAML mit Binding-Definitionen.
			// XAML-INHALT: Enthält sowohl Code-Binding (CodeStar) als auch XAML-Binding (XamlStar).
			// UNTERSCHIED: CodeStar wird hier im Code-Behind gebunden, XamlStar in XAML.
			InitializeComponent();
		}

		// Event-Handler für Slider ValueChanged-Event.
		// ZWECK: Manuelle Code-basierte Synchronisation zwischen Slider und Star.Points.
		// NACHTEIL: Erfordert Event-Handler-Code. XAML-Binding wäre deklarativer und wartbarer.
		// VORTEIL: Ermöglicht Validierung/Transformation vor der Zuweisung.
		// 'RoutedPropertyChangedEventArgs<double>': Enthält OldValue und NewValue.
		private void CodeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
			// 'CodeStar.Points': Setzt die Points-DependencyProperty des Star-UserControls.
			// '(int)CodeSlider.Value': Liest den aktuellen Slider-Wert und castet zu int.
			// ALTERNATIVE: e.NewValue könnte statt CodeSlider.Value verwendet werden.
			// DATA BINDING VORTEIL: In XAML wäre dies: Points="{Binding Value, ElementName=CodeSlider}"
			// - Kein Code-Behind nötig
			// - Automatische Synchronisation
			// - Bidirektional möglich (Mode=TwoWay)
			CodeStar.Points = (int)CodeSlider.Value;
		}
	}
}
