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
	/// Interaction logic for TextBlockInlines.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert TextBlock.Inlines - die Collection für Inline-Formatierung.
	// KONZEPT: TextBlock kann nicht nur einfachen Text, sondern auch formatierte Inlines enthalten.
	// INLINES-TYPEN:
	// - Run: Einfacher Textabschnitt mit eigener Formatierung
	// - Bold, Italic, Underline: Formatierungs-Wrapper
	// - Span: Generischer Container für andere Inlines
	// - LineBreak: Erzwingt einen Zeilenumbruch
	// - Hyperlink: Klickbarer Link
	// - InlineUIContainer: Container für UI-Elemente innerhalb von Text
	// HINTERGRUND: TextBlock.Inlines ist eine ContentProperty, daher kann man direkt
	// Inline-Elemente in <TextBlock> schreiben ohne <TextBlock.Inlines>.
	public partial class TextBlockInlines : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public TextBlockInlines() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei werden verschiedene Inline-Elemente demonstriert:
			// - Run mit verschiedenen Foreground/FontWeight-Werten
			// - Bold, Italic, Underline
			// - Hyperlink mit NavigateUri
			// - InlineUIContainer mit eingebetteten Controls
			InitializeComponent();
		}
	}
}
