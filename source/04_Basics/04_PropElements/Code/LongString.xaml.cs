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
	/// Interaction logic for LongString.xaml
	/// </summary>
	// 'public': Diese Fensterklasse ist öffentlich zugänglich
	// 'partial': Klassendefinition aufgeteilt zwischen Code-Behind und XAML-generiertem Code
	// ': Window': Erbt von Window - macht diese Klasse zu einem Top-Level-Fenster
	public partial class LongString : Window {
		// Konstruktor: Initialisiert das Fenster
		// Dieses Fenster demonstriert die Property-Element-Syntax für lange Strings
		public LongString() {
			// 'InitializeComponent': Lädt und parsed die XAML-Datei
			// In der XAML-Datei wird wahrscheinlich ein langer Text-String
			// mittels Property-Element-Syntax gesetzt statt als Attribut:
			// Statt: <TextBlock Text="Sehr langer Text..." />
			// Besser lesbar als Element:
			// <TextBlock>
			//   <TextBlock.Text>
			//     Sehr langer Text, der über
			//     mehrere Zeilen geht...
			//   </TextBlock.Text>
			// </TextBlock>
			// VORTEIL: Bessere Lesbarkeit und keine Probleme mit Anführungszeichen
			InitializeComponent();
		}
	}
}
