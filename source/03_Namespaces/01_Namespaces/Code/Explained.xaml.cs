// ===== C# USING-DIREKTIVEN =====
// 'using': Importiert Namespaces, um Typen ohne vollqualifizierten Namen nutzen zu können.
// 
// ZWECK:
// - Reduziert Code-Verbosität und erhöht die Lesbarkeit
// - Vermeidet wiederholte vollqualifizierte Namen
// - Beispiel: 'Window' statt 'System.Windows.Window'
// 
// ALTERNATIVE OHNE using:
//   System.Windows.Window myWindow = new System.Windows.Window();
//   System.Windows.Controls.Button myButton = new System.Windows.Controls.Button();
// 
// MIT using (vereinfacht):
//   Window myWindow = new Window();
//   Button myButton = new Button();
// 
// WICHTIG: C# 'using' ≠ XAML 'xmlns'
// - C# using: Importiert Namespaces für C#-Code
// - XAML xmlns: Mappt XML-Namespaces auf CLR-Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ===== WPF-KERN-NAMESPACES =====
// Jeder Namespace entspricht bestimmten WPF-Funktionsbereichen:

// 'System.Windows': Der Haupt-Namespace für WPF-Anwendungen.
// ENTHÄLT: Window, Application, UIElement, FrameworkElement, DependencyObject, etc.
// WICHTIG: Kern-Namespace für alle WPF-Fenster und -Anwendungen.
// XAML-ÄQUIVALENT: Teil von xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
using System.Windows;

// 'System.Windows.Controls': Enthält UI-Steuerelemente.
// ENTHÄLT: Button, TextBox, ListBox, ComboBox, Grid, StackPanel, etc.
// VERWENDUNG: Alle Standard-WPF-Controls
// XAML-ÄQUIVALENT: Teil von xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
using System.Windows.Controls;

// 'System.Windows.Data': Bietet Klassen für Data Binding.
// ENTHÄLT: Binding, BindingExpression, IValueConverter, etc.
// VERWENDUNG: Datenverbindung zwischen UI und Datenquellen
// BEISPIEL: Binding myBinding = new Binding("PropertyName");
using System.Windows.Data;

// 'System.Windows.Documents': Für Dokumenten-Darstellung.
// ENTHÄLT: FlowDocument, Paragraph, Run, Bold, Italic, etc.
// VERWENDUNG: Rich-Text-Formatierung und Dokumenten-UI
using System.Windows.Documents;

// 'System.Windows.Input': Behandlung von Eingabegeräten.
// ENTHÄLT: Mouse, Keyboard, TouchDevice, ICommand, etc.
// VERWENDUNG: Event-Handling für Tastatur, Maus, Touch
using System.Windows.Input;

// 'System.Windows.Media': Grafik-Funktionalität.
// ENTHÄLT: Brushes (SolidColorBrush, LinearGradientBrush), Colors, Transforms, etc.
// VERWENDUNG: Farben, Pinsel, Transformationen, Animationen
using System.Windows.Media;

// 'System.Windows.Media.Imaging': Bildverarbeitung und Bild-Formate.
// ENTHÄLT: BitmapImage, BitmapSource, WriteableBitmap, etc.
// VERWENDUNG: Laden, Anzeigen und Manipulieren von Bildern
using System.Windows.Media.Imaging;

// 'System.Windows.Shapes': Geometrische Formen.
// ENTHÄLT: Rectangle, Ellipse, Line, Polygon, Path, etc.
// VERWENDUNG: Vektor-Grafiken und geometrische UI-Elemente
using System.Windows.Shapes;

// ===== NAMESPACE-DEKLARATION =====
// 'namespace': Definiert einen logischen Container für Typen.
// 
// ZWECK:
// - Organisiert Klassen in logische Gruppen
// - Verhindert Namenskonflikte
// - Ermöglicht gleiche Klassennamen in verschiedenen Namespaces
// 
// BEISPIEL FÜR NAMENSKONFLIKT-VERMEIDUNG:
//   namespace CompanyA.Controls { public class Button { } }
//   namespace CompanyB.Controls { public class Button { } }
//   // Beide 'Button'-Klassen können koexistieren!
// 
// XAML-BEZIEHUNG:
// - In XAML wird dieser Namespace über 'clr-namespace' referenziert
// - xmlns:local="clr-namespace:UnderstandNamespaces"
// - 'local' ist ein Prefix (frei wählbar)
// - 'clr-namespace:UnderstandNamespaces' mappt auf diesen C#-Namespace
// 
// VERWENDUNG IN XAML:
//   <Window xmlns:local="clr-namespace:UnderstandNamespaces">
//     <local:Explained />  <!-- Verwendet diese Klasse -->
//   </Window>
namespace UnderstandNamespaces {
	
	// ===== XML-DOKUMENTATIONSKOMMENTAR =====
	// '/// <summary>': XML-Dokumentationskommentar.
	// ZWECK:
	// - Wird von IntelliSense angezeigt
	// - Dokumentiert API für andere Entwickler
	// - Kann zu XML-Dokumentation kompiliert werden
	// 
	// VERWENDUNG:
	//   /// <summary>Beschreibung der Klasse</summary>
	//   /// <param name="paramName">Beschreibung des Parameters</param>
	//   /// <returns>Beschreibung des Rückgabewerts</returns>
	/// <summary>
	/// Interaction logic for Explained.xaml
	/// </summary>
	
	// ===== PARTIAL CLASS MIT XAML =====
	// 'public': Macht die Klasse von außen sichtbar.
	// WICHTIG FÜR XAML:
	// - Klasse muss 'public' sein, um in XAML verwendet zu werden
	// - 'internal' Klassen können NICHT in XAML aus anderen Assemblies verwendet werden
	// - 'private' und 'protected' sind für Top-Level-Klassen nicht erlaubt
	// 
	// 'partial': Teilt die Klasse in mehrere Dateien.
	// HINTERGRUND:
	// - Ermöglicht Trennung von generiertem Code und manuellem Code
	// - Teil 1: Diese Code-Behind-Datei (Explained.xaml.cs) - manueller Code
	// - Teil 2: Generierte Datei (Explained.g.cs) - XAML-Compiler-Output
	// - Beide Teile werden zur Kompilierzeit zusammengeführt
	// 
	// GENERIERTER CODE (Explained.g.cs) ENTHÄLT:
	// - InitializeComponent() Methode
	// - Felder für alle benannten Controls (x:Name)
	// - Event-Handler-Verbindungen
	// - XAML-Resource-Loading-Logik
	// 
	// ': Window': Basisklasse für Fenster.
	// ERBT FUNKTIONEN:
	// - Minimize, Maximize, Close
	// - Title, Width, Height, WindowState
	// - ShowDialog(), Show(), Hide()
	// - Events: Loaded, Closing, Closed, etc.
	// - Fensterrahmen, Titelleiste, Buttons
	// 
	// XAML-VERBINDUNG:
	// - x:Class="UnderstandNamespaces.Explained" in XAML
	// - Verbindet XAML-Datei mit dieser Code-Behind-Klasse
	// - XAML definiert UI-Struktur, Code-Behind definiert Logik
	public partial class Explained : Window {
		
		// ===== KONSTRUKTOR =====
		// Konstruktor: Wird beim Erstellen des Fensters aufgerufen.
		// 
		// ZEITPUNKT:
		// - Vor dem Anzeigen des Fensters (Show/ShowDialog)
		// - Nach dem Erstellen der Instanz (new Explained())
		// - Vor dem Laden von Ressourcen und Initialisierung der UI
		// 
		// TYPISCHE VERWENDUNG:
		// - Initialisierung von Datenmodellen
		// - Event-Handler-Registrierung
		// - Setzen von InitialValues
		public Explained() {
			// ===== INITIALIZECOMPONENT() =====
			// 'InitializeComponent': KRITISCH! Generierte Methode aus Explained.g.cs.
			// 
			// FUNKTIONEN:
			// 1. XAML laden und parsen
			//    - Liest Explained.xaml aus eingebetteten Ressourcen
			//    - Parst XML-Struktur
			//    - Validiert Namespace-Deklarationen
			// 
			// 2. UI-Elemente instanziieren
			//    - Erstellt alle Controls (Button, TextBox, Grid, etc.)
			//    - Setzt Properties (Width, Height, Background, etc.)
			//    - Baut visuelle Baum-Struktur auf
			// 
			// 3. Event-Handler verbinden
			//    - Mappt XAML-Event-Attribute auf Code-Behind-Methoden
			//    - Beispiel: Click="Button_Click" → this.Button_Click
			// 
			// 4. Named Elements (x:Name) als Felder mappen
			//    - <Button x:Name="myButton" /> → private Button myButton;
			//    - Ermöglicht Zugriff auf Controls: myButton.Content = "Click";
			// 
			// 5. Resources laden
			//    - Lädt Styles, Templates, Brushes aus Resources
			//    - Merged Dictionaries einbinden
			// 
			// 6. Bindings initialisieren
			//    - Aktiviert Data Binding-Expressions
			//    - Verbindet DataContext mit UI-Elementen
			// 
			// WICHTIG: Muss IMMER als erstes im Konstruktor stehen!
			// GRUND:
			// - Vor InitializeComponent() existieren keine UI-Elemente
			// - Zugriff auf x:Name-Controls vor InitializeComponent() → NullReferenceException
			// - XAML-definierte Event-Handler müssen verbunden werden
			// 
			// REIHENFOLGE:
			// ✓ RICHTIG:
			//   public Explained() {
			//     InitializeComponent();
			//     myButton.Content = "Ready";  // OK, myButton existiert
			//   }
			// 
			// ✗ FALSCH:
			//   public Explained() {
			//     myButton.Content = "Ready";  // FEHLER! myButton ist null
			//     InitializeComponent();
			//   }
			InitializeComponent();
		}
	}
}
