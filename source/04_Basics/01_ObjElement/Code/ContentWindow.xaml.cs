// Importiert grundlegende .NET-Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Importiert WPF-Basistypen
using System.Windows;
// Importiert WPF-Controls (Button, TextBox, ListBox, etc.)
using System.Windows.Controls;
// Importiert WPF-Data-Binding-Klassen
using System.Windows.Data;
// Importiert WPF-Dokument-Klassen (Flow- und Fixed-Dokumente)
using System.Windows.Documents;
// Importiert WPF-Input-Klassen (Mouse, Keyboard, Touch)
using System.Windows.Input;
// Importiert WPF-Media-Klassen (Brushes, Pens, Geometrie)
using System.Windows.Media;
// Importiert WPF-Imaging-Klassen (BitmapImage, etc.)
using System.Windows.Media.Imaging;
// Importiert WPF-Shapes (Rectangle, Ellipse, Line, etc.)
using System.Windows.Shapes;

// Namespace für dieses Projekt
namespace ObjectElements {
	/// <summary>
	/// Interaction logic for Content.xaml
	/// </summary>
	// 'public': Die Klasse ist von außerhalb der Assembly zugänglich
	// 'partial': Die Klassendefinition ist aufgeteilt. Der XAML-Parser generiert den anderen Teil,
	// der die UI-Elemente (durch x:Name benannte Felder) und die InitializeComponent-Methode enthält.
	// ': Window': Erbt von der Window-Klasse, die ein Top-Level-Fenster repräsentiert.
	// Window bietet Funktionen wie Titelleiste, Rahmen, Minimieren/Maximieren und Modaldialog-Unterstützung.
	public partial class ContentWindow : Window {
		// Konstruktor: Wird beim Erstellen einer neuen Fensterinstanz aufgerufen
		// 'public': Muss öffentlich sein, damit das Fenster von außen instanziiert werden kann
		public ContentWindow() {
			// 'InitializeComponent': KRITISCH! Diese vom XAML-Parser generierte Methode:
			// 1. Lädt die zugehörige XAML-Datei (ContentWindow.xaml)
			// 2. Erstellt alle in XAML definierten UI-Elemente (Buttons, TextBoxes, etc.)
			// 3. Verknüpft benannte Elemente (x:Name) mit den Feldern dieser Klasse
			// 4. Registriert Event-Handler, die in XAML definiert wurden
			// MUSS als erstes im Konstruktor aufgerufen werden, bevor auf UI-Elemente zugegriffen wird!
			InitializeComponent();
		}
	}
}
