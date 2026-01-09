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
using System.Windows.Shapes;

// 'namespace': Organisiert Beispiel-Fenster in einem separaten Namespace.
namespace Content101.Windows {
	/// <summary>
	/// Interaction logic for ContentControlsExample.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert ContentControl - die Basisklasse für Controls mit einem einzelnen Content.
	// KONZEPT: ContentControl hat eine Content-Property, die ein beliebiges Objekt aufnehmen kann.
	// VERERBUNGSHIERARCHIE: ContentControl → Control → FrameworkElement → UIElement → Visual
	// BEISPIELE: Button, Label, ScrollViewer, GroupBox, ToolTip erben alle von ContentControl.
	public partial class ContentControlsExample : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public ContentControlsExample() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei werden verschiedene ContentControls demonstriert:
			// - Button mit Text-Content
			// - Button mit komplexem Content (z.B. StackPanel mit Icon und Text)
			// - Label, ScrollViewer, etc.
			InitializeComponent();
		}
	}
}
