// Standard .NET Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF
using System.Windows;
// System.Windows.Controls: Alle Standard-UI-Steuerelemente (ListBox, Button, TextBox, etc.)
using System.Windows.Controls;
// System.Windows.Data: Datenbindung zwischen UI und Geschäftslogik
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung (Maus, Tastatur, Touch, Commands)
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms, Animationen
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung und -anzeige
using System.Windows.Media.Imaging;
// System.Windows.Navigation: Navigation zwischen Seiten/Frames
using System.Windows.Navigation;
// System.Windows.Shapes: Vektorgrafikelemente (Rectangle, Ellipse, etc.)
using System.Windows.Shapes;

namespace BigStarCollectiblesDesktop {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// 'partial': Teilt die Klassendefinition auf. Der XAML-Compiler generiert den anderen Teil 
	// aus MainWindow.xaml mit allen UI-Elementen (AlienListBox, MonsterListBox) als Felder.
	// ': Window': Basisklasse für WPF-Fenster mit Fenster-Management-Funktionalität.
	public partial class MainWindow : Window {
		// Konstruktor: Wird beim Erstellen des Fensters aufgerufen.
		// Das MainWindow wird automatisch beim App-Start erstellt (definiert in App.xaml).
		public MainWindow() {
			// 'InitializeComponent()': KRITISCH! Diese vom XAML-Compiler generierte Methode:
			// 1. Lädt und parst die MainWindow.xaml-Datei
			// 2. Erstellt alle in XAML definierten UI-Elemente (ListBoxes, Grids, etc.)
			// 3. Setzt Properties basierend auf XAML-Attributen
			// 4. Verbindet Event-Handler mit Code-Behind-Methoden
			// 5. Verknüpft benannte Elemente (x:Name="AlienListBox") mit Feldern in dieser Klasse
			// 6. Initialisiert Ressourcen, Styles und Datenbindungen
			// Ohne diesen Aufruf wäre das Fenster leer und alle x:Name-Referenzen wären null!
			InitializeComponent();

			// Erstellt eine neue Instanz der CardSource-Klasse, die die Sammelkarten-Daten bereitstellt.
			// 'var': Typ-Inferenz - der Compiler leitet den Typ 'CardSource' automatisch ab.
			var source = new BigStar.Models.CardSource();
			// Setzt den DataContext der AlienListBox auf die AlienCards-Collection.
			// 'DataContext': Definiert die Datenquelle für Datenbindungen. Alle Bindings in der 
			// ListBox und ihren Child-Elementen beziehen sich auf diesen Kontext.
			// WICHTIG: In WPF wird DataContext die Hierarchie herunter vererbt. Child-Elemente 
			// erben den DataContext ihres Parents, sofern sie keinen eigenen setzen.
			AlienListBox.DataContext = source.AlienCards;
			// Analog für MonsterCards: Setzt die Datenquelle für die MonsterListBox.
			// Dadurch werden zwei separate Datenkontexte für die beiden ListBoxes verwendet,
			// was eine unabhängige Datenbindung ermöglicht.
			MonsterListBox.DataContext = source.MonsterCards;
		}
	}
}
