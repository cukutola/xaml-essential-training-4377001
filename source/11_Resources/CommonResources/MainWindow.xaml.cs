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
// System.Windows.Data: Data Binding-Infrastruktur.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes (SolidColorBrush, etc.).
// WICHTIG: Dieses Fenster demonstriert Brush-Ressourcen!
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Navigation: Navigation.
using System.Windows.Navigation;
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;

// Namespace für CommonResources-Demos.
// KONTEXT: Demonstriert verschiedene Ressourcen-Typen in WPF.
namespace CommonResources {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// 'MainWindow': Hauptfenster der CommonResources-Demo-Anwendung.
	// ZWECK: Launcher-Fenster mit Buttons zum Öffnen verschiedener Ressourcen-Demos.
	// RESSOURCEN-TYPEN: Data, Styles, Colors/Brushes, DataTemplates.
	// MENU-PATTERN: Zentrales Fenster als Navigation zu verschiedenen Demo-Fenstern.
	public partial class MainWindow : Window {
		// Konstruktor: Initialisiert das Launcher-Fenster.
		public MainWindow() {
			// Lädt XAML mit Buttons für verschiedene Demos.
			// XAML-STRUKTUR: Vermutlich StackPanel mit mehreren Buttons.
			InitializeComponent();
		}
		
		// Event-Handler für Data-Button Click.
		// ZWECK: Öffnet Fenster, das Daten-Ressourcen demonstriert.
		// DATA-RESSOURCEN: x:Key="myData" mit Objektinstanzen in Resources.
		private void DataButton_Click(object sender, RoutedEventArgs e) {
			// 'new DataWindow()': Erstellt neue Instanz des DataWindow.
			// '.Show()': Öffnet Fenster als nicht-modales Fenster (Benutzer kann zu MainWindow zurück).
			// ALTERNATIV: ShowDialog() würde modales Fenster öffnen (blockiert MainWindow).
			// PATTERN: Direkte Instanziierung und Show in einem Statement.
			(new DataWindow()).Show();
		}

		// Event-Handler für Style-Button Click.
		// ZWECK: Öffnet Fenster, das Style-Ressourcen demonstriert.
		// STYLE-RESSOURCEN: <Style TargetType="Button"> mit Setters für Properties.
		// DEMONSTRATION: Zentrale Style-Definitionen, Wiederverwendung, Wartbarkeit.
		private void StyleButton_Click(object sender, RoutedEventArgs e) {
			// Öffnet StyleWindow als nicht-modales Fenster.
			// STYLE-DEMO: Zeigt vermutlich Buttons mit verschiedenen Styles.
			(new StyleWindow()).Show();
		}

		// Event-Handler für Color-Button Click.
		// ZWECK: Öffnet Fenster, das Color/Brush-Ressourcen demonstriert.
		// COLOR-RESSOURCEN: <SolidColorBrush x:Key="MyBrush" Color="#FF0000"/>
		// VORTEIL: Zentrale Farb-Definitionen, konsistentes Theming.
		private void ColorButton_Click(object sender, RoutedEventArgs e) {
			// Öffnet ColorWindow.
			// COLOR-DEMO: Zeigt vermutlich Shapes/Buttons mit ressourcenbasierten Brushes.
			(new ColorWindow()).Show();
		}

		// Event-Handler für DataTemplate-Button Click.
		// ZWECK: Öffnet Fenster, das DataTemplate-Ressourcen demonstriert.
		// DATATEMPLATE: Definiert, WIE Datenobjekte visuell dargestellt werden.
		// EINSATZ: Für ListBox.ItemTemplate, ComboBox.ItemTemplate, ContentControl.ContentTemplate.
		// BEISPIEL: <DataTemplate x:Key="TreeTemplate"><TextBlock Text="{Binding TreeName}"/></DataTemplate>
		private void DataTemplateButton_Click(object sender, RoutedEventArgs e) {
			// Öffnet DataTemplateWindow.
			// DATATEMPLATE-DEMO: Zeigt vermutlich Trees-Collection mit custom DataTemplate.
			(new DataTemplateWindow()).Show();
		}
    }
}
