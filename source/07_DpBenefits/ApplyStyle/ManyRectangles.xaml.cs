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
using System.Windows.Shapes;

namespace ApplyStyle {
	/// <summary>
	/// Interaction logic for ManyRectangles.xaml
	/// 
	/// STYLE-ANWENDUNG mit Dependency Properties:
	/// - Demonstriert wie Styles auf viele Elemente gleichzeitig angewendet werden
	/// - Auskommentierter Code zeigt programmatische Erstellung (ineffizient)
	/// 
	/// DEPENDENCY PROPERTY VORTEILE für Styles:
	/// - STYLE VALUE hat mittlere Priorität im Value Precedence System
	/// - Priorität: Local > Style > Default > Inherited
	/// - Styles nutzen Setter um Dependency Property Werte zu setzen
	/// 
	/// PERFORMANCE-VORTEILE:
	/// - Styles sind effizienter als einzelne Property-Zuweisungen
	/// - Sparse Storage: Nur abweichende Werte werden gespeichert
	/// - Style-Werte werden in Metadata geteilt zwischen allen Elementen
	/// - Memory Efficiency: Tausende Elemente können denselben Style nutzen
	/// 
	/// VERGLEICH: Code vs. Style:
	/// - Programmatische Zuweisung (auskommentiert) = LOCAL VALUE (höchste Priorität)
	/// - Style-basierte Zuweisung = STYLE VALUE (mittlere Priorität)
	/// - Style kann mit ClearValue() zurückgesetzt werden
	/// </summary>
	public partial class ManyRectangles : Window {
		public ManyRectangles() {
			InitializeComponent();
			
			// INEFFIZIENTER ANSATZ - Programmatische Erstellung:
			// Jede Zuweisung (z.B. rect.Fill) erstellt einen LOCAL VALUE
			// Dies überschreibt alle Styles und verbraucht mehr Speicher
			//var ran  = new Random();

			//for (int counter = 0; counter < 80; counter++)
			//{
				
			//	var rect = new Rectangle() { Width= 24, Height= 36};
			//	rect.Fill = Brushes.LightBlue;
			//	if (ran.Next() % 2 == 0)
			//	{
			//		rect.Fill = Brushes.Violet;
			//	}

			//	if (ran.Next() % 3 == 0)
			//	{
			//		rect.Fill = Brushes.PaleGoldenrod;
			//	}
			//	var circ = new Ellipse() { Width = 40, Height = 40 };
			//	this.MainGrid.Children.Add(rect);
			//	this.MainGrid.Children.Add(circ);
			//}
		}
	}
}
