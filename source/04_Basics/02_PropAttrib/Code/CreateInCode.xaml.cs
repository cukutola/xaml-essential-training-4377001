// Importiert WPF-Basistypen
using System.Windows;
// Importiert WPF-Controls (StackPanel, Rectangle, etc.)
using System.Windows.Controls;
// Importiert WPF-Media-Klassen (Brushes, Colors, etc.)
using System.Windows.Media;
// Importiert WPF-Shapes (Rectangle, Ellipse, etc.)
using System.Windows.Shapes;

// Namespace für dieses Projekt
namespace PropertyAttributes {
	// 'public': Diese Fensterklasse ist öffentlich zugänglich
	// 'partial': Aufgeteilte Klassendefinition zwischen Code-Behind und XAML-generiertem Code
	// ': Window': Erbt von Window-Basisklasse
	public partial class CreateInCode : Window {
		// Konstruktor: Demonstriert die programmatische Erstellung von UI-Elementen in C#
		// im Vergleich zur deklarativen XAML-Syntax
		public CreateInCode() {
			// Lädt die XAML-UI (falls vorhanden)
			InitializeComponent();

			// Erstellt UI-Elemente programmatisch durch Instanziierung
			// 'var': Implizite Typisierung - der Compiler leitet den Typ automatisch ab
			// 'new StackPanel()': Ruft den Konstruktor auf und erstellt eine neue Instanz
			// StackPanel ist ein Layout-Container, der Kinder vertikal oder horizontal stapelt
			var stack = new StackPanel();
			
			// Rectangle: WPF-Shape für rechteckige Formen
			var rect = new Rectangle();
			
			// Ellipse: WPF-Shape für Kreise und Ellipsen
			var elip = new Ellipse();

			// Aufbau der visuellen Hierarchie durch Zuweisen von Parent-Child-Beziehungen
			// 'this.Content': Window.Content ist die Content-Property des Fensters (kann nur ein Element aufnehmen)
			this.Content = stack;
			
			// 'Children.Add()': Fügt Kindelemente zur Children-Collection des StackPanels hinzu
			// Diese Aufrufe entsprechen der XAML-Element-Syntax: <StackPanel><Rectangle/><Ellipse/></StackPanel>
			stack.Children.Add(rect);
			stack.Children.Add(elip);

			// Setzen von Properties programmatisch
			// 'Width': Double-Property - in XAML würde TypeConverter den String "60" zu Double konvertieren
			rect.Width = 60;
			rect.Height = 90;
			
			// WICHTIG: In C# können komplexe Typen NICHT als String zugewiesen werden!
			// rect.Fill = "Green"; // ❌ KOMPILIERFEHLER - Fill ist vom Typ Brush, nicht String
			
			// Korrekt: Erstellen eines SolidColorBrush-Objekts
			// In XAML würde der BrushConverter den String "Green" automatisch konvertieren
			// In C# muss die Konvertierung manuell erfolgen
			rect.Fill = new SolidColorBrush(Colors.Green);
			
			// 'Stroke': Brush für die Umrandung
			rect.Stroke = new SolidColorBrush(Colors.LightGreen);
			
			// 'StrokeThickness': Dicke der Umrandung in geräteunabhängigen Einheiten (1/96 Zoll)
			rect.StrokeThickness = 3;
			
			// 'StrokeDashArray': Definiert das Strich-Muster für gestrichelte Linien
			// DoubleCollection mit Werten [6, 3] bedeutet: 6 Einheiten Strich, 3 Einheiten Lücke
			rect.StrokeDashArray = new DoubleCollection() { 6, 3 };

			// Setzen von Ellipse-Properties
			elip.Width = 200;
			elip.Height = 160;
			elip.Fill = new SolidColorBrush(Colors.Goldenrod);
			
			// 'Opacity': Transparenz von 0 (unsichtbar) bis 1 (vollständig sichtbar)
			elip.Opacity = .7;

			// WICHTIG: In C# kann Margin NICHT als String zugewiesen werden!
			// elip.Margin = "20,10,20,-10"; // ❌ KOMPILIERFEHLER - Margin ist vom Typ Thickness

			// Korrekt: Erstellen eines Thickness-Objekts
			// Thickness(left, top, right, bottom) - definiert Abstände in alle Richtungen
			// In XAML würde der ThicknessConverter den String "20,-40,20,20" automatisch konvertieren
			elip.Margin = new Thickness(20, -40, 20, 20);
		}
	}
}
