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

// 'namespace': Organisiert die Klassen in logische Gruppen.
namespace WhyTypeConverters.Controls {
	/// <summary>
	/// Interaction logic for Rating.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': UserControl': Basisklasse für wiederverwendbare UI-Komponenten.
	public partial class Rating : UserControl {
		
		// KONSTRUKTOR: Wird beim Erstellen des Controls aufgerufen.
		public Rating() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			InitializeComponent();
	
		}


		// HINWEIS: Ein echtes UI-Element sollte Dependency Properties verwenden.
		// GRUND: Dependency Properties unterstützen Binding, Animation, Styling, etc.
		// Dieses Beispiel verwendet zur Vereinfachung normale .NET-Properties.

		// 'string': Speichert den Überschriftstext für das Rating-Control.
		// VERWENDUNG: In einer echten Implementierung wäre dies eine Dependency Property.
		public string HeaderText { get; set; }
		
		// 'int': Anzahl der anzuzeigenden Sterne.
		public int StarCount { get; set; }
		
		// 'double': Die Benutzerbewertung (z.B. 3.5 von 5 Sternen).
		public double UserRating { get; set; }
		
		// 'Brush': Hintergrundfarbe der Sterne.
		// HINWEIS: Brush ist ein abstrakter Typ - kann SolidColorBrush, LinearGradientBrush, etc. sein.
		public Brush StarBackground { get; set; }
		
		// 'Brush': Umrissfarbe (Stroke) der Sterne.
		public Brush StarStroke { get; set; }
		
		// 'BorderLine': Ein benutzerdefinierter Typ für Rahmenbreiten.
		// ZWECK: Demonstriert, dass auch ohne TypeConverter Properties funktionieren,
		// aber nur mit Objekt-Syntax, nicht mit Attribut-Syntax in XAML.
		public BorderLine StarBorder { get; set; }


	}
	
	// BENUTZERDEFINIERTE KLASSE: Erstellt für Demonstrationszwecke.
	// HINWEIS: In produktivem Code sollte der eingebaute 'Thickness'-Typ verwendet werden.
	// ZWECK: Zeigt den Unterschied zwischen Typen mit und ohne TypeConverter.
	// OHNE TYPECONVERTER: Diese Klasse muss in XAML mit Element-Syntax verwendet werden:
	// <Rating>
	//   <Rating.StarBorder>
	//     <BorderLine Left="5" Top="10" Right="5" Bottom="10"/>
	//   </Rating.StarBorder>
	// </Rating>
	public class BorderLine {
		// 'double': Rahmenbreite für die obere Kante.
		public double Top { get; set; }
		
		// Rahmenbreite für die untere Kante.
		public double Bottom { get; set; }
		
		// Rahmenbreite für die linke Kante.
		public double Left { get; set; }
		
		// Rahmenbreite für die rechte Kante.
		public double Right { get; set; }
	}
}
