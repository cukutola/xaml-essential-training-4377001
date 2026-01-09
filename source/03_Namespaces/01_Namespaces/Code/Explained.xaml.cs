// 'using': Importiert Namespaces, um Typen ohne vollqualifizierten Namen nutzen zu können.
// EINSATZZWECK: Reduziert Code-Verbosität und erhöht die Lesbarkeit.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 'System.Windows': Der Haupt-Namespace für WPF-Anwendungen (Window, Application, UIElement, etc.).
// WICHTIG: Kern-Namespace für alle WPF-Fenster und -Anwendungen.
using System.Windows;

// 'System.Windows.Controls': Enthält UI-Steuerelemente wie Button, TextBox, ListBox, etc.
using System.Windows.Controls;

// 'System.Windows.Data': Bietet Klassen für Data Binding zwischen UI und Daten.
using System.Windows.Data;

// 'System.Windows.Documents': Für Dokumenten-Darstellung (FlowDocument, Paragraph, etc.).
using System.Windows.Documents;

// 'System.Windows.Input': Behandlung von Eingabegeräten (Tastatur, Maus, Touch).
using System.Windows.Input;

// 'System.Windows.Media': Grafik-Funktionalität (Brushes, Colors, Transforms, etc.).
using System.Windows.Media;

// 'System.Windows.Media.Imaging': Bildverarbeitung und Bild-Formate (BitmapImage, etc.).
using System.Windows.Media.Imaging;

// 'System.Windows.Shapes': Geometrische Formen (Rectangle, Ellipse, Line, etc.).
using System.Windows.Shapes;

// 'namespace': Definiert einen logischen Container für Typen. Verhindert Namenskonflikte.
// HINTERGRUND: In XAML wird dieser Namespace über 'clr-namespace' referenziert.
// XAML-MAPPING: xmlns:local="clr-namespace:UnderstandNamespaces"
namespace UnderstandNamespaces {
	
	// '/// <summary>': XML-Dokumentationskommentar. Wird von IntelliSense angezeigt.
	// EINSATZZWECK: Beschreibt den Zweck der Klasse für andere Entwickler.
	/// <summary>
	/// Interaction logic for Explained.xaml
	/// </summary>
	
	// 'public': Macht die Klasse von außen sichtbar. WICHTIG für XAML-Zugriff!
	// 'partial': Teilt die Klasse in mehrere Dateien. Der XAML-Compiler generiert
	// den anderen Teil mit den UI-Element-Referenzen (z.B. Buttons, TextBoxes).
	// HINTERGRUND: Ermöglicht Trennung von generiertem Code und manuellem Code.
	// ': Window': Basisklasse für Fenster. Erbt Funktionen wie Minimize, Maximize, Close.
	public partial class Explained : Window {
		
		// Konstruktor: Wird beim Erstellen des Fensters aufgerufen.
		// ZEITPUNKT: Vor dem Anzeigen des Fensters (Show/ShowDialog).
		public Explained() {
			// 'InitializeComponent': KRITISCH! Generierte Methode, die:
			// 1. XAML lädt und parst
			// 2. UI-Elemente instanziiert
			// 3. Event-Handler verbindet
			// 4. Named-Elements (x:Name) als Felder mappt
			// WICHTIG: Muss IMMER als erstes im Konstruktor stehen!
			InitializeComponent();
		}
	}
}
