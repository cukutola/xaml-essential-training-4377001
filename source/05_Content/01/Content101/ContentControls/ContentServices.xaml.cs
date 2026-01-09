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
	/// Interaction logic for ContentServices.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert Content-Services - die Infrastruktur, die Content in UI umwandelt.
	// KONZEPTE:
	// - ContentPresenter: Das Element, das Content tatsächlich rendert
	// - ContentTemplate: DataTemplate, das definiert, wie Content dargestellt wird
	// - ContentTemplateSelector: Logik zur Auswahl des passenden Templates
	// HINTERGRUND: WPF trennt Daten (Content) von Darstellung (Template).
	public partial class ContentServices : Window {

		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public ContentServices() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei werden ContentPresenter und ContentTemplate demonstriert.
			InitializeComponent();
		}
	}
}
