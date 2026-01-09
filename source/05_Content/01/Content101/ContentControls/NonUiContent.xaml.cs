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
	/// Interaction logic for NonUiContent.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert, dass Content nicht nur UI-Elemente sein müssen.
	// KONZEPT: ContentControl.Content kann beliebige Objekte sein:
	// - Strings: Werden automatisch in TextBlocks umgewandelt
	// - Business-Objekte: Werden via DataTemplates dargestellt
	// - Collections: Werden via ItemsControl dargestellt
	// HINTERGRUND: Dies ist ein Kernkonzept von WPF - Trennung von Daten und Darstellung.
	// Die Darstellung wird über DataTemplates gesteuert, nicht durch den Datentyp selbst.
	public partial class NonUiContent : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public NonUiContent() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei werden verschiedene Non-UI-Content-Beispiele demonstriert:
			// - String als Content
			// - Business-Objekt als Content (mit DataTemplate)
			// - Numeric-Werte als Content
			InitializeComponent();
		}
	}
}
