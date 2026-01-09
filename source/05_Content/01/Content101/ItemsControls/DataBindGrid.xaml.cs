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
	/// Interaction logic for DataBindGrid.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert Data Binding mit DataGrid - einem tabellarischen Control.
	// KONZEPT: DataGrid ist ein spezialisiertes ItemsControl für Tabellendaten.
	// Es generiert automatisch Spalten basierend auf den Properties der Datenquelle.
	// WICHTIGE DATAGRID-EIGENSCHAFTEN:
	// - ItemsSource: Die Datenquelle (Collection von Objekten)
	// - AutoGenerateColumns: Automatische Spalten-Generierung (true/false)
	// - Columns: Manuelle Definition der Spalten (DataGridTextColumn, DataGridCheckBoxColumn, etc.)
	// - SelectionMode: Single oder Extended (mehrere Zeilen)
	// - CanUserAddRows/DeleteRows/SortColumns: Benutzer-Interaktionen
	// SPALTENTYPEN:
	// - DataGridTextColumn: Für Text (Binding an string/numeric Properties)
	// - DataGridCheckBoxColumn: Für Boolean-Werte
	// - DataGridComboBoxColumn: Für Auswahllisten
	// - DataGridTemplateColumn: Für benutzerdefinierte Templates
	public partial class DataBindGrid : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public DataBindGrid() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei wird DataGrid demonstriert:
			// - AutoGenerateColumns für automatische Spalten
			// - Manuelle Spalten-Definition mit DataGridTextColumn
			// - Binding an Properties der Datenquelle
			// - Sortierung und Filterung
			InitializeComponent();
		}

	
    }
}
