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
// Importiert WPF-Navigation-Klassen (für Frame, NavigationService)
using System.Windows.Navigation;
// Importiert WPF-Shapes
using System.Windows.Shapes;

// Namespace für dieses Projekt
namespace ObjectElements {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// 'public': MainWindow ist öffentlich und kann von anderen Assemblies verwendet werden
	// 'partial': Die Klassendefinition ist aufgeteilt. Der XAML-Compiler generiert automatisch
	// den anderen Teil, der UI-Element-Felder (für x:Name-Attribute) und InitializeComponent enthält.
	// ': Window': Erbt von der Window-Basisklasse. Window ist das Hauptfenster der Anwendung
	// und bietet Funktionen wie Rahmen, Titelleiste, Minimieren/Maximieren/Schließen-Buttons.
	public partial class MainWindow : Window {
		// Konstruktor: Wird beim Erstellen des Hauptfensters aufgerufen (z.B. beim App-Start)
		// 'public': Muss öffentlich sein, damit WPF das Fenster instanziieren kann
		public MainWindow() {
			// 'InitializeComponent': Diese zentrale Methode wird vom XAML-Compiler generiert.
			// Sie führt folgende Schritte aus:
			// 1. Lädt die MainWindow.xaml-Datei aus den Ressourcen
			// 2. Parsed das XAML und erstellt den visuellen Baum (Visual Tree)
			// 3. Initialisiert alle UI-Elemente (Buttons, TextBoxes, Grids, etc.)
			// 4. Verknüpft benannte Elemente (x:Name) mit C#-Feldern in dieser Klasse
			// 5. Registriert alle Event-Handler, die in XAML definiert wurden
			// WICHTIG: Muss VOR jedem Zugriff auf UI-Elemente aufgerufen werden!
			InitializeComponent();
		}
	}
}
