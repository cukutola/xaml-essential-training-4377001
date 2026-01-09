// Importiert grundlegende .NET-Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Importiert WPF-Basistypen
using System.Windows;
// Importiert WPF-Controls
using System.Windows.Controls;
// Importiert WPF-Data-Binding-Klassen
using System.Windows.Data;
// Importiert WPF-Dokument-Klassen
using System.Windows.Documents;
// Importiert WPF-Input-Klassen
using System.Windows.Input;
// Importiert WPF-Media-Klassen
using System.Windows.Media;
// Importiert WPF-Imaging-Klassen
using System.Windows.Media.Imaging;
// Importiert WPF-Shapes
using System.Windows.Shapes;

// Namespace für dieses Projekt
namespace ObjectElements {
	/// <summary>
	/// Interaction logic for InstantiateObjects.xaml
	/// </summary>
	// 'public': Die Fensterklasse ist öffentlich zugänglich
	// 'partial': Klassendefinition aufgeteilt zwischen diesem Code-Behind und dem XAML-generierten Code
	// ': Window': Erbt von Window - macht diese Klasse zu einem eigenständigen Fenster
	public partial class InstantiateObjectsWindow : Window {
		// Konstruktor: Initialisiert eine neue Instanz des Fensters
		public InstantiateObjectsWindow() {
			// 'InitializeComponent': Lädt und initialisiert die XAML-UI.
			// Diese Methode wird vom XAML-Compiler generiert und ist in der anderen partial-Klasse definiert.
			// Sie parsed die XAML-Datei, erstellt die Object-Tree und verknüpft Event-Handler.
			InitializeComponent();
			
			// Nach InitializeComponent können hier weitere Initialisierungen durchgeführt werden,
			// z.B. Daten laden, Event-Handler registrieren oder UI-Elemente programmatisch konfigurieren.
			// Dieser Code wird nach dem Laden der XAML-UI, aber vor dem Anzeigen des Fensters ausgeführt.
		}
	}
}
