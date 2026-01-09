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
	/// Interaction logic for ItemsControlExample.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert ItemsControl - die Basisklasse für alle Listen-Controls.
	// KONZEPT: ItemsControl zeigt eine Collection von Items an, ohne Selection oder Scrolling.
	// Es ist die einfachste Form eines Listen-Controls in WPF.
	// VERERBUNGSHIERARCHIE: 
	// - ItemsControl (Basis)
	//   - Selector (fügt Selection hinzu: ListBox, ComboBox, TabControl)
	//     - ListBox (fügt Scrolling und virtualisierte Items hinzu)
	//     - ComboBox (Dropdown-Liste)
	// CONTENTPROPERTY: ItemsControl.Items ist die ContentProperty.
	// WICHTIGE PROPERTIES:
	// - Items: Die Collection von Items (nur für Code)
	// - ItemsSource: Die Datenquelle für Binding (Collection/IEnumerable)
	// - ItemTemplate: DataTemplate für die Darstellung jedes Items
	// - ItemsPanel: Das Panel, das die Items Layout (default: StackPanel)
	public partial class ItemsControlExample : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public ItemsControlExample() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei wird ItemsControl demonstriert:
			// - Einfache Items direkt in XAML definiert
			// - ItemTemplate für benutzerdefinierte Darstellung
			// - ItemsPanel für alternatives Layout (z.B. WrapPanel statt StackPanel)
			InitializeComponent();
		}
	}
}
