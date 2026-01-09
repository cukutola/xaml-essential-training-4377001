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
	/// Interaction logic for DockPanelExample.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert DockPanel - ein spezielles Panel für Andock-Layout.
	// KONZEPT: DockPanel dockt Child-Elemente an den Rändern an (Top, Bottom, Left, Right).
	// Das letzte Element füllt den verbleibenden Raum (außer LastChildFill=false).
	// ATTACHED PROPERTY: DockPanel.Dock ist eine Attached Property, die an jedem Child
	// gesetzt werden kann, um zu steuern, an welchem Rand es andockt.
	// VERWENDUNG: Typisch für Anwendungslayouts mit:
	// - Toolbar oben (Dock="Top")
	// - Status-Leiste unten (Dock="Bottom")
	// - Navigation links (Dock="Left")
	// - Hauptinhalt füllt den Rest (LastChildFill="True")
	// BEISPIEL: Visual Studio, Word - Toolbars und Panels docken an Rändern an.
	public partial class DockPanelExample : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public DockPanelExample() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei wird DockPanel mit verschiedenen Dock-Werten demonstriert:
			// - Element mit DockPanel.Dock="Top"
			// - Element mit DockPanel.Dock="Bottom"
			// - Element mit DockPanel.Dock="Left"
			// - Element mit DockPanel.Dock="Right"
			// - Letztes Element füllt den verbleibenden Raum
			InitializeComponent();
		}
	}
}
