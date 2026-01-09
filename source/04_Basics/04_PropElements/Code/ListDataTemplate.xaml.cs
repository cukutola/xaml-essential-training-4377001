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
	/// Interaction logic for ListDataTemplate.xaml
	/// </summary>
	// 'public': Diese Fensterklasse ist öffentlich zugänglich
	// 'partial': Klassendefinition aufgeteilt zwischen Code-Behind und XAML-generiertem Code
	// ': Window': Erbt von Window - macht diese Klasse zu einem Top-Level-Fenster
	public partial class ListDataTemplate : Window {
		// Konstruktor: Initialisiert das Fenster
		// Dieses Fenster demonstriert die Verwendung von DataTemplates für Listen
		// und die Property-Element-Syntax für komplexe Property-Werte
		public ListDataTemplate() {
			// 'InitializeComponent': Lädt und parsed die XAML-Datei
			// In der XAML-Datei wird wahrscheinlich ein ItemTemplate oder ContentTemplate
			// mittels Property-Element-Syntax definiert:
			// <ListBox.ItemTemplate>
			//   <DataTemplate>
			//     <!-- Template-Inhalt -->
			//   </DataTemplate>
			// </ListBox.ItemTemplate>
			// Diese Syntax wird verwendet, wenn der Property-Wert zu komplex für
			// ein Attribut ist (z.B. DataTemplate, ControlTemplate, Style)
			InitializeComponent();
		}
	}
}
