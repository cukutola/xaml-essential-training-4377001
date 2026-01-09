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
// Importiert WPF-Navigation-Klassen
using System.Windows.Navigation;
// Importiert WPF-Shapes
using System.Windows.Shapes;

// Namespace für dieses Projekt - demonstriert Property-Attribute in XAML
namespace PropertyAttributes {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// 'public': Diese Hauptfenster-Klasse ist öffentlich zugänglich
	// 'partial': Die Klasse ist aufgeteilt. Der XAML-Compiler generiert den anderen Teil
	// mit Feldern für benannte UI-Elemente (x:Name) und der InitializeComponent-Methode.
	// ': Window': Erbt von der Window-Basisklasse
	public partial class MainWindow : Window {
		// Konstruktor: Wird beim Start der Anwendung aufgerufen (wenn MainWindow das StartupUri ist)
		public MainWindow() {
			// 'InitializeComponent': Diese vom XAML-Compiler generierte Methode:
			// 1. Lädt die MainWindow.xaml-Datei
			// 2. Parsed das XAML und erstellt den UI-Baum
			// 3. Setzt Property-Werte durch Aufrufen von TypeConverters
			//    (z.B. String "Red" → SolidColorBrush durch BrushConverter)
			// 4. Verknüpft benannte Elemente mit C#-Feldern
			// 5. Registriert Event-Handler
			// XAML Property-Attribut-Syntax: <Element PropertyName="PropertyValue" />
			// TypeConverter ermöglichen die String-basierte Zuweisung komplexer Typen in XAML
			InitializeComponent();
		}

		// Event-Handler: Wird aufgerufen, wenn der "In Code"-Button geklickt wird
		// 'private': Nur innerhalb dieser Klasse sichtbar (typisch für Event-Handler)
		// 'void': Gibt keinen Wert zurück
		// 'object sender': Das UI-Element, das das Event ausgelöst hat (hier: der Button)
		// 'RoutedEventArgs e': Event-Argumente mit zusätzlichen Informationen über das Event
		private void InCodeButton_Click(object sender, RoutedEventArgs e) {
			// Erstellt eine neue Instanz des CreateInCode-Fensters und zeigt es an
			// 'new CreateInCode()': Ruft den Konstruktor auf
			// '.Show()': Zeigt das Fenster nicht-modal an (Hauptfenster bleibt bedienbar)
			// Alternative wäre .ShowDialog() für modale Anzeige
			(new CreateInCode()).Show();
		}

		// Event-Handler für den "In XAML"-Button
		private void InXamlButton_Click(object sender, RoutedEventArgs e) {
			// Erstellt und zeigt das CreateInXaml-Fenster
			// Dieses Fenster demonstriert die gleiche UI wie CreateInCode,
			// aber deklarativ in XAML erstellt statt programmatisch in C#
			(new CreateInXaml()).Show();
		}
	}
}
