
// 'using AttachedProps.Windows': Importiert Namespace für UsePolar-Fenster.
// NAMESPACE-STRUKTUR: AttachedProps.Windows für bessere Organisation der Window-Klassen.
using AttachedProps.Windows;
// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente.
using System.Windows.Controls;
// System.Windows.Data: Data Binding.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Navigation: Navigation.
using System.Windows.Navigation;
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;

// Namespace für Attached Properties Demos.
namespace AttachedProps {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// 'MainWindow': Launcher-Fenster für verschiedene Attached Property Demos.
	// ZWECK: Zentrale Navigation zu Grid, KeyNav, Tooltip und PolarPanel Demos.
	// MENU-PATTERN: Hauptfenster mit Buttons zum Öffnen spezifischer Demo-Fenster.
	// ATTACHED PROPERTIES DEMOS:
	// 1. Grid - Grid.Row, Grid.Column Attached Properties
	// 2. KeyNav - KeyboardNavigation Attached Properties (TabIndex, etc.)
	// 3. Tooltip - ToolTipService Attached Properties
	// 4. PolarPanel - Custom Attached Properties (Angle, Radius)
	public partial class MainWindow : Window {
		// Konstruktor: Initialisiert das Launcher-Fenster.
		public MainWindow() {
			// Lädt XAML mit Navigations-Buttons.
			// XAML-STRUKTUR: Vermutlich StackPanel mit vier Buttons.
			InitializeComponent();
		}

		// Event-Handler für PolarPanel-Demo-Button.
		// ZWECK: Öffnet UsePolar-Fenster, das Custom PolarPanel Attached Properties demonstriert.
		// POLARPANEL ATTACHED PROPS: Angle und Radius für polare Koordinaten-Layouts.
		private void PolarPanelButton_Click(object sender, RoutedEventArgs e) {
			// 'new UsePolar()': Erstellt Instanz des PolarPanel-Demo-Fensters.
			// '.Show()': Öffnet als nicht-modales Fenster (parallel zu MainWindow).
			// PATTERN: Direct instantiation + Show in einem Statement für Demo-Zwecke.
			(new UsePolar()).Show();
		}

		// Event-Handler für KeyNav-Demo-Button.
		// ZWECK: Öffnet KeyNav-Fenster für Keyboard Navigation Attached Properties Demo.
		// KEYNAV ATTACHED PROPS: KeyboardNavigation.TabIndex, TabNavigation, etc.
		// BARRIEREFREIHEIT: Wichtig für Tastatur-Navigation und Accessibility.
		private void KeyNavButton_Click(object sender, RoutedEventArgs e) {
			// Öffnet KeyNav-Demo-Fenster.
			// DEMO-FOKUS: Tab-Reihenfolge, DirectionalNavigation, IsTabStop.
			(new KeyNav()).Show();
		}

		// Event-Handler für Tooltip-Demo-Button.
		// ZWECK: Öffnet TooltipExample-Fenster für ToolTipService Attached Properties Demo.
		// TOOLTIP ATTACHED PROPS: ToolTip, InitialShowDelay, Placement, etc.
		// UI-UX: Tooltips bieten kontextuelle Hilfe bei Hover.
		private void TooltipButton_Click(object sender, RoutedEventArgs e) {
			// Öffnet Tooltip-Demo-Fenster.
			// DEMO-FOKUS: Verschiedene Tooltip-Konfigurationen und Placement-Optionen.
			(new TooltipExample()).Show();
		}

		// Event-Handler für Grid-Demo-Button.
		// ZWECK: Öffnet GridExample-Fenster für Grid Attached Properties Demo.
		// GRID ATTACHED PROPS: Grid.Row, Grid.Column, Grid.RowSpan, Grid.ColumnSpan.
		// LAYOUT: Grid ist das flexibelste und am häufigsten verwendete WPF-Layout-Panel.
		private void GridButton_Click(object sender, RoutedEventArgs e) {
			// Öffnet Grid-Demo-Fenster.
			// DEMO-FOKUS: Programmgesteuerte Änderung von Grid.Row/Column via SetRow/SetColumn.
			(new GridExample()).Show();
		}
    }
}
