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
namespace AddProperties {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	public partial class MainWindow : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public MainWindow() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// WICHTIG: In der XAML-Datei werden die benutzerdefinierten MarkupExtensions verwendet.
			InitializeComponent();
		}
	}
}
