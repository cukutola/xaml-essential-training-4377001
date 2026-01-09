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
	/// Interaction logic for PanelsExample.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert verschiedene Layout-Panels - die Container für UI-Elemente.
	// KONZEPT: Panels sind Controls, die mehrere Child-Elemente enthalten und deren
	// Position und Größe steuern. Sie sind essentiell für das WPF-Layout-System.
	// PANEL-TYPEN:
	// - StackPanel: Stapelt Children vertikal oder horizontal
	// - WrapPanel: Ordnet Children in Zeilen/Spalten mit automatischem Umbruch
	// - Grid: Tabellenbasiertes Layout mit Zeilen und Spalten
	// - Canvas: Absolute Positionierung (Left, Top, Right, Bottom)
	// - UniformGrid: Grid mit gleichgroßen Zellen
	// VERERBUNG: Alle Panels erben von System.Windows.Controls.Panel.
	// CONTENTPROPERTY: Panel.Children ist die ContentProperty, daher kann man direkt
	// Child-Elemente in <Panel> schreiben ohne <Panel.Children>.
	public partial class PanelsExample : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public PanelsExample() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei werden verschiedene Panels demonstriert:
			// - StackPanel mit Orientation="Vertical" und "Horizontal"
			// - WrapPanel mit verschiedenen ItemWidth/ItemHeight
			// - Grid mit RowDefinitions und ColumnDefinitions
			// - Canvas mit absoluter Positionierung
			InitializeComponent();
		}
	}
}
