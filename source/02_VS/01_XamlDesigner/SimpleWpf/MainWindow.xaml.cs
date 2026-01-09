// Standard .NET Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF-Desktop-Anwendungen
using System.Windows;
// System.Windows.Controls: Alle Standard-UI-Steuerelemente (Button, TextBox, ListBox, Grid, etc.)
using System.Windows.Controls;
// System.Windows.Data: Datenbindung zwischen UI und Geschäftslogik (Binding, INotifyPropertyChanged)
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung (FlowDocument, Paragraph, etc.)
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung (Maus, Tastatur, Touch, Commands)
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms, Animationen
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung und -anzeige (BitmapImage, RenderTargetBitmap)
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente (Rectangle, Ellipse, Line, Polygon)
using System.Windows.Shapes;

namespace SimpleWpf {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// 'partial': Teilt die Klassendefinition auf. Der XAML-Compiler generiert automatisch den 
	// anderen Teil dieser Klasse aus MainWindow.xaml, der alle UI-Elemente als Felder enthält 
	// und deren Initialisierung durchführt.
	// ': Window': Basisklasse für Top-Level-Fenster in WPF. Sie bietet Funktionalität für 
	// Fenster-Management (Minimize, Maximize, Close), Dialog-Unterstützung und ist Container 
	// für alle UI-Elemente des Fensters.
	public partial class MainWindow : Window {
		// Konstruktor: Wird aufgerufen, wenn das Fenster erstellt wird.
		// In WPF wird das MainWindow automatisch beim App-Start erstellt, sofern nicht anders 
		// konfiguriert in App.xaml (StartupUri="MainWindow.xaml").
		public MainWindow() {
			// 'InitializeComponent()': KRITISCH! Diese vom XAML-Compiler generierte Methode:
			// 1. Lädt und parst die MainWindow.xaml-Datei
			// 2. Erstellt alle in XAML definierten UI-Elemente (Buttons, Grids, TextBoxes, etc.)
			// 3. Setzt Properties basierend auf XAML-Attributen (Width, Height, Background, etc.)
			// 4. Verbindet Event-Handler (Click, Loaded, etc.) mit den hier definierten Methoden
			// 5. Verknüpft benannte Elemente (x:Name) mit Feldern dieser Klasse für Code-Zugriff
			// 6. Initialisiert Ressourcen (Styles, Templates) und Datenbindungen
			// Ohne diesen Aufruf wäre das Fenster leer und alle x:Name-Referenzen wären null!
			InitializeComponent();
		}
	}
}
