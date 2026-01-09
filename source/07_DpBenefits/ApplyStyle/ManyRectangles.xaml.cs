// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente.
using System.Windows.Controls;
// System.Windows.Data: Data Binding.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente (Rectangle, Ellipse).
using System.Windows.Shapes;

// Namespace für die Style-Demo.
namespace ApplyStyle {
	/// <summary>
	/// Interaction logic for ManyRectangles.xaml
	/// </summary>
	// 'ManyRectangles': Fenster mit mehreren Rectangle-Shapes.
	// ZWECK: Demonstriert Style-Anwendung auf Standard-WPF-Shapes.
	// VERGLEICH: Analog zu ManyStars, aber mit Rectangles statt Custom Controls.
	// STYLE-VORTEILE: Zentrales Styling, DRY-Prinzip (Don't Repeat Yourself).
	public partial class ManyRectangles : Window {
		// Konstruktor: Initialisiert das Fenster.
		public ManyRectangles() {
			// Lädt XAML mit Rectangle-Definitionen und Styles.
			InitializeComponent();
			
			// Auskommentierter Code: Zeigt dynamische Rectangle-Erzeugung in C#.
			// ZWECK: Demonstrationszweck - wie Shapes programmgesteuert erstellt werden.
			// ALTERNATIVE: In echten Apps meist XAML-basiert oder mit ItemsControl + DataTemplate.
			//var ran  = new Random();

			// for-Schleife: Würde 80 Rectangles und Ellipses dynamisch erstellen.
			//for (int counter = 0; counter < 80; counter++)
			//{
				
			//	// 'new Rectangle()': Erstellt neues Rectangle-Shape.
			//	// Object Initializer: Width und Height direkt setzen.
			//	var rect = new Rectangle() { Width= 24, Height= 36};
			//	
			//	// Default-Farbe: LightBlue.
			//	rect.Fill = Brushes.LightBlue;
			//	
			//	// Random-Check: 50% Chance für Violet.
			//	// 'ran.Next() % 2 == 0': Gerade/Ungerade-Prüfung.
			//	if (ran.Next() % 2 == 0)
			//	{
			//		rect.Fill = Brushes.Violet;
			//	}

			//	// Random-Check: 33% Chance für PaleGoldenrod.
			//	// 'ran.Next() % 3 == 0': Teilbarkeit durch 3.
			//	if (ran.Next() % 3 == 0)
			//	{
			//		rect.Fill = Brushes.PaleGoldenrod;
			//	}
			//	
			//	// Erstellt Ellipse (Kreis/Oval).
			//	var circ = new Ellipse() { Width = 40, Height = 40 };
			//	
			//	// Fügt zur MainGrid Children-Collection hinzu.
			//	// HINWEIS: Panel.Children ist Observable, UI updates automatisch.
			//	this.MainGrid.Children.Add(rect);
			//	this.MainGrid.Children.Add(circ);
			//}
			
			// WARUM AUSKOMMENTIERT:
			// - Demo zeigt wahrscheinlich XAML-basierten Ansatz statt Code-Behind.
			// - Styles in XAML sind deklarativer und wartbarer.
			// - Code-Behind für dynamische Elemente wäre mit ItemsControl + DataBinding besser.
		}
	}
}
