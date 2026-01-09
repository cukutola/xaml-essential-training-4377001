// Standard .NET Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF
using System.Windows;
// System.Windows.Controls: Alle Standard-UI-Steuerelemente
using System.Windows.Controls;
// System.Windows.Data: Datenbindung zwischen UI und Datenmodellen
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung (Maus, Tastatur, Commands)
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung
using System.Windows.Media.Imaging;
// System.Windows.Navigation: Navigation zwischen Seiten/Frames in WPF
using System.Windows.Navigation;
// System.Windows.Shapes: Vektorgrafikelemente
using System.Windows.Shapes;

namespace WorkWithXamlTools {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// 'partial': Teilt die Klassendefinition auf. Der XAML-Compiler generiert den anderen Teil 
	// aus MainWindow.xaml mit allen UI-Elementen als Felder.
	// ': Window': Basisklasse für WPF-Fenster. Sie bietet Fenster-Management-Funktionalität,
	// Dialog-Unterstützung und ist der Top-Level-Container für alle UI-Elemente.
	public partial class MainWindow : Window {
		// Konstruktor: Wird beim Erstellen des Fensters aufgerufen.
		// Das MainWindow wird automatisch beim App-Start erstellt (definiert in App.xaml als StartupUri).
		public MainWindow() {
			// 'InitializeComponent()': KRITISCH! Diese vom XAML-Compiler generierte Methode:
			// 1. Lädt und parst die MainWindow.xaml-Datei
			// 2. Erstellt alle in XAML definierten UI-Elemente (Controls, Layouts, etc.)
			// 3. Setzt alle Properties basierend auf XAML-Attributen
			// 4. Verbindet Event-Handler mit Code-Behind-Methoden
			// 5. Verknüpft benannte Elemente (x:Name) mit Feldern für Code-Zugriff
			// 6. Initialisiert Ressourcen und Datenbindungen
			// Ohne diesen Aufruf wäre das Fenster leer!
			InitializeComponent();
		}
	}
}
