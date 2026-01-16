
using AttachedProps.Windows;
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

namespace AttachedProps {
	/// <summary>
	/// Hauptfenster der Attached Properties Demo-Anwendung.
	/// Dieses Fenster dient als Startpunkt und öffnet verschiedene Beispielfenster,
	/// die unterschiedliche Aspekte von Attached Properties demonstrieren:
	/// - Grid.Row/Column (klassisches Layout-Beispiel)
	/// - KeyboardNavigation.TabIndex (Navigation)
	/// - ToolTip (UI-Verbesserung)
	/// - PolarPanel mit eigenen Attached Properties (Custom Panel)
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		// Öffnet das PolarPanel-Beispiel: Ein Custom Panel mit eigenen Attached Properties.
		// PolarPanel.Angle und PolarPanel.Radius sind selbst definierte Attached Properties.
		private void PolarPanelButton_Click(object sender, RoutedEventArgs e) {
			(new UsePolar()).Show();
		}

		// Öffnet das KeyboardNavigation-Beispiel.
		// Zeigt wie KeyboardNavigation.TabIndex die Tab-Reihenfolge steuert.
		private void KeyNavButton_Click(object sender, RoutedEventArgs e) {
			(new KeyNav()).Show();
		}

		// Öffnet das Tooltip-Beispiel.
		// ToolTip ist eine built-in Attached Property, die an jedes FrameworkElement angehängt werden kann.
		private void TooltipButton_Click(object sender, RoutedEventArgs e) {
			(new TooltipExample()).Show();
		}

		// Öffnet das Grid-Beispiel.
		// Zeigt Grid.Row und Grid.Column - die klassischen Attached Properties für Layout.
		private void GridButton_Click(object sender, RoutedEventArgs e) {
			(new GridExample()).Show();
		}
    }
}
