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

namespace CommonResources {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// <remarks>
	/// HAUPTFENSTER - CommonResources Demo-Launcher
	/// 
	/// Dieses Hauptfenster dient als Launcher für verschiedene Demonstrationsfenster,
	/// die unterschiedliche Resource-Konzepte zeigen.
	/// 
	/// DEMO-FENSTER ÜBERSICHT:
	/// - DataWindow: Zeigt Daten ohne Custom DataTemplate (Standard-Rendering)
	/// - StyleWindow: Demonstriert Style-Definition und Anwendung
	/// - ColorWindow: Zeigt einfache Color/Brush Resources
	/// - DataTemplateWindow: Zeigt Custom DataTemplates für Datenobjekte
	/// 
	/// NAVIGATION PATTERN:
	/// Jeder Button öffnet ein neues Window mit Show() statt ShowDialog():
	/// - Ermöglicht mehrere geöffnete Fenster gleichzeitig
	/// - Benutzer kann zwischen Fenstern wechseln
	/// - Ideal für Vergleichs-Demonstrationen
	/// </remarks>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}
		
		/// <summary>
		/// Öffnet das DataWindow - Zeigt Datenobjekte ohne Custom DataTemplate
		/// </summary>
		/// <remarks>
		/// Demonstriert Standard-Rendering von Objekten (typischerweise ToString()).
		/// Zeigt den Unterschied zu DataTemplateWindow, wo Custom Templates verwendet werden.
		/// </remarks>
		private void DataButton_Click(object sender, RoutedEventArgs e) {
			// new DataWindow() erstellt eine neue Instanz des DataWindow
			// Show() öffnet das Fenster nicht-modal (Benutzer kann zum Hauptfenster zurückkehren)
			(new DataWindow()).Show();
		}

		/// <summary>
		/// Öffnet das StyleWindow - Demonstriert Styles mit TargetType und Setters
		/// </summary>
		/// <remarks>
		/// Zeigt wie Styles definiert und auf Controls angewendet werden.
		/// Demonstriert TargetType, Setters, und Style-Wiederverwendung.
		/// </remarks>
		private void StyleButton_Click(object sender, RoutedEventArgs e) {
			// StyleWindow demonstriert:
			// - Explizite Styles (mit x:Key)
			// - Implizite Styles (ohne x:Key, automatische Anwendung)
			// - BasedOn für Style-Vererbung
			// - Setter für verschiedene Properties
			(new StyleWindow()).Show();
		}

		/// <summary>
		/// Öffnet das ColorWindow - Zeigt einfache Brush/Color Resources
		/// </summary>
		/// <remarks>
		/// Demonstriert die grundlegendste Form von Resources:
		/// - SolidColorBrush Resources
		/// - Color Resources
		/// - Verwendung in verschiedenen Controls
		/// </remarks>
		private void ColorButton_Click(object sender, RoutedEventArgs e) {
			// ColorWindow zeigt:
			// - Definition von Brush Resources
			// - {StaticResource} Verwendung
			// - Wiederverwendung derselben Brush in mehreren Controls
			(new ColorWindow()).Show();
		}

		/// <summary>
		/// Öffnet das DataTemplateWindow - Zeigt Custom DataTemplates
		/// </summary>
		/// <remarks>
		/// Demonstriert wie DataTemplates das visuelle Erscheinungsbild von
		/// Datenobjekten steuern. Vergleiche mit DataWindow, um den Unterschied zu sehen.
		/// </remarks>
		private void DataTemplateButton_Click(object sender, RoutedEventArgs e) {
			// DataTemplateWindow demonstriert:
			// - DataTemplate-Definition
			// - Data Binding innerhalb von DataTemplates
			// - ItemTemplate für ItemsControls
			// - ContentTemplate für ContentControls
			(new DataTemplateWindow()).Show();
		}
    }
}
