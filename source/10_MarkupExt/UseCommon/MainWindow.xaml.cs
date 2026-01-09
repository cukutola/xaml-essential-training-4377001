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
namespace UseCommon {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	public partial class MainWindow : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public MainWindow() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// WICHTIG: In der XAML-Datei werden eingebaute MarkupExtensions demonstriert:
			// - {Binding}: Bindet Properties an Datenquellen
			// - {StaticResource}: Referenziert Ressourcen aus ResourceDictionaries
			// - {DynamicResource}: Dynamische Ressourcen-Referenz (Updates bei Änderungen)
			// - {x:Static}: Zugriff auf statische Members
			// - {x:Type}: Liefert ein Type-Objekt
			// Diese sind alle Beispiele für eingebaute MarkupExtensions in WPF.
			InitializeComponent();
		}
	}
}
