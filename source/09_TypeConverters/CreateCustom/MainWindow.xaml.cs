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
namespace CreateCustom {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// HINTERGRUND: Der XAML-Compiler generiert automatisch eine zweite partial-Klasse
	// aus MainWindow.xaml, die InitializeComponent() und alle benannten Elemente enthält.
	// ': Window': Basisklasse für Fenster in WPF.
	// ZWECK: Window bietet Titelleiste, Rahmen, Minimieren/Maximieren/Schließen Buttons,
	// und Fenster-Verwaltung (Größe, Position, Modality).
	public partial class MainWindow : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public MainWindow() {
			// 'InitializeComponent()': Wird vom XAML-Compiler generiert.
			// AUFGABE: Lädt MainWindow.xaml, erstellt den Visual Tree, verbindet Event-Handler
			// und mappt alle benannten Elemente (x:Name) auf Felder dieser Klasse.
			// WICHTIG: Muss als erstes im Konstruktor aufgerufen werden, damit die
			// XAML-Elemente verfügbar sind.
			InitializeComponent();
		}
	}
}
