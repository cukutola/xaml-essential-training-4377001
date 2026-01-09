// 'using': Importiert Namespaces für WPF-Controls und .NET-Basisfunktionalität.
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

// 'namespace': Organisiert die Klassen der Anwendung.
namespace Content101 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Dient als Hauptfenster der Anwendung mit Navigation zu verschiedenen Beispielen.
	public partial class MainWindow : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Hauptfensters aufgerufen.
		public MainWindow() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			InitializeComponent();
		}

		// EVENT HANDLER: Öffnet das TextBlock-Inlines-Beispiel.
		// 'private': Nur innerhalb dieser Klasse sichtbar (für Event-Handler ausreichend).
		// PARAMETER:
		// - 'sender': Das Control, das das Event ausgelöst hat (der Button).
		// - 'e': Event-Argumente (RoutedEventArgs enthält Source, OriginalSource, Handled).
		private void Inlines_Click(object sender, RoutedEventArgs e) {
			// 'new Windows.TextBlockInlines()': Erstellt eine neue Instanz des Beispiel-Fensters.
			// '.Show()': Öffnet das Fenster als nicht-modales Fenster (erlaubt Interaktion mit anderen Fenstern).
			// HINWEIS: Für modale Fenster würde man '.ShowDialog()' verwenden.
			(new Windows.TextBlockInlines()).Show();
		}

		// EVENT HANDLER: Öffnet das Panels-Beispiel.
		// ZWECK: Demonstriert verschiedene Layout-Panels (StackPanel, Grid, WrapPanel, etc.).
		private void PanelsButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.PanelsExample()).Show();
		}

		// EVENT HANDLER: Öffnet das DockPanel-Beispiel.
		// ZWECK: Demonstriert das DockPanel für Andock-Layout (Top, Bottom, Left, Right, Fill).
		private void DockPanelButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.DockPanelExample()).Show();
		}

		// EVENT HANDLER: Öffnet das ItemsControl-Beispiel.
		// ZWECK: Demonstriert ItemsControl - die Basisklasse für alle Listen-Controls.
		// HINTERGRUND: ItemsControl zeigt eine Collection von Items ohne Selection/Scrolling.
		private void ItemsControlButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.ItemsControlExample()).Show();
		}

		// EVENT HANDLER: Öffnet das DataBinding-Listen-Beispiel.
		// ZWECK: Demonstriert Data Binding mit ListBox, ComboBox, etc.
		// KONZEPT: Zeigt, wie Collections an ItemsControl-basierte Controls gebunden werden.
		private void BindListsButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.DataBindLists()).Show();
		}

		// EVENT HANDLER: Öffnet das DataBinding-Grid-Beispiel.
		// ZWECK: Demonstriert Data Binding mit DataGrid.
		// KONZEPT: DataGrid ist ein spezialisiertes ItemsControl für tabellarische Daten.
		private void BindGridButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.DataBindGrid()).Show();
		}

		// EVENT HANDLER: Öffnet das ListItem-Beispiel.
		// ZWECK: Demonstriert die Verwendung von ListBoxItem, ComboBoxItem, etc.
		// KONZEPT: Zeigt den Unterschied zwischen Item-Container und Item-Inhalt.
		private void ListItemButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.ListItemExample()).Show();
		}

		// EVENT HANDLER: Öffnet das ContentControl-Beispiel.
		// ZWECK: Demonstriert ContentControl - die Basisklasse für Controls mit einem einzelnen Content.
		// BEISPIELE: Button, Label, ScrollViewer - alle erben von ContentControl.
		// KONZEPT: ContentControl hat eine Content-Property, die beliebige Objekte aufnehmen kann.
		private void ContentControlButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.ContentControlsExample()).Show();
		}

		// EVENT HANDLER: Öffnet das Decorator-Beispiel.
		// ZWECK: Demonstriert Decorator-Controls (Border, Viewbox, BulletDecorator).
		// KONZEPT: Decorators sind spezielle ContentControls, die ihrem Child visuelle Effekte hinzufügen.
		private void DecoratorButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.DecoratorExample()).Show();
		}

		// EVENT HANDLER: Öffnet das NonUI-Content-Beispiel.
		// ZWECK: Demonstriert, dass Content nicht nur UI-Elemente sein können.
		// KONZEPT: ContentControl.Content kann auch Business-Objekte, Strings, etc. sein.
		// Die Content-Darstellung wird dann über DataTemplates gesteuert.
		private void NonUiButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.NonUiContent()).Show();
		}

		// EVENT HANDLER: Öffnet das ContentServices-Beispiel.
		// ZWECK: Demonstriert Services wie ContentPresenter und ContentTemplate.
		// KONZEPT: Zeigt, wie WPF Content via Templates und Presenter in UI umwandelt.
		private void ContentServiceButton_Click(object sender, RoutedEventArgs e) {
			(new Windows.ContentServices()).Show();
		}
	}
}
