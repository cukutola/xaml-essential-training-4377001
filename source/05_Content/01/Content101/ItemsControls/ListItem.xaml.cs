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
using System.Windows.Shapes;

// 'namespace': Organisiert Beispiel-Fenster in einem separaten Namespace.
namespace Content101.Windows {
	/// <summary>
	/// Interaction logic for ListItemExample.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert ListItem-Container (ListBoxItem, ComboBoxItem, etc.).
	// KONZEPT: WPF trennt zwischen Items (Datenobjekte) und Item-Containern (UI-Wrapper).
	// ITEM vs. ITEM-CONTAINER:
	// - Item: Das Datenobjekt (z.B. string "Apple", Customer-Objekt)
	// - Item-Container: Das UI-Element, das das Item umhüllt (ListBoxItem, ComboBoxItem)
	// AUTOMATISCHE CONTAINER-GENERIERUNG:
	// Wenn man direkt UI-Elemente in ListBox einfügt, werden sie automatisch in ListBoxItems gewrappt.
	// Wenn man Datenobjekte via ItemsSource bindet, generiert WPF die Container automatisch.
	// ITEM-CONTAINER-EIGENSCHAFTEN:
	// - IsSelected: Ob das Item ausgewählt ist
	// - IsEnabled: Ob das Item aktiviert ist
	// - Background, Foreground: Visuelle Eigenschaften
	// STYLES: Item-Container können via ItemContainerStyle gestylt werden.
	public partial class ListItemExample : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public ListItemExample() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei werden ListBoxItems demonstriert:
			// - Direkte Definition von ListBoxItem-Elementen
			// - ItemContainerStyle für einheitliches Styling
			// - Unterschied zwischen Item.Content und Item selbst
			InitializeComponent();
		}
	}
}
