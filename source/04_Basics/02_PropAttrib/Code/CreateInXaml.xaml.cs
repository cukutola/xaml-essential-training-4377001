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
// Importiert WPF-Shapes
using System.Windows.Shapes;

// Namespace für dieses Projekt
namespace PropertyAttributes {
	/// <summary>
	/// Interaction logic for CreateInXaml.xaml
	/// </summary>
	// 'public': Diese Fensterklasse ist öffentlich zugänglich
	// 'partial': Aufgeteilte Klassendefinition zwischen Code-Behind und XAML-generiertem Code
	// ': Window': Erbt von Window - macht diese Klasse zu einem Top-Level-Fenster
	public partial class CreateInXaml : Window {
		// Konstruktor: Initialisiert das Fenster
		// Dieses Beispiel demonstriert die XAML-basierte UI-Erstellung im Gegensatz
		// zur programmatischen Erstellung in CreateInCode.xaml.cs
		public CreateInXaml() {
			// 'InitializeComponent': Lädt und parsed die CreateInXaml.xaml-Datei
			// In der XAML-Datei werden die gleichen UI-Elemente deklarativ definiert,
			// die in CreateInCode.xaml.cs programmatisch erstellt werden.
			// VORTEIL von XAML: TypeConverter konvertieren automatisch Strings zu komplexen Typen
			// (z.B. "Green" → SolidColorBrush, "20,10,20,10" → Thickness)
			InitializeComponent();
		}
	}
}
