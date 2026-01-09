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
	/// Interaction logic for DataBindLists.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert Data Binding mit Listen-Controls (ListBox, ComboBox).
	// KONZEPT: Data Binding verbindet UI-Elemente mit Datenquellen (Collections, Properties).
	// WICHTIGE BINDING-EIGENSCHAFTEN:
	// - ItemsSource: Die Datenquelle (IEnumerable, ObservableCollection, etc.)
	// - DisplayMemberPath: Welche Property als Text angezeigt wird
	// - SelectedValuePath: Welche Property als SelectedValue verwendet wird
	// - SelectedItem: Das aktuell ausgewählte Objekt
	// - SelectedValue: Der Wert der SelectedValuePath-Property
	// HINTERGRUND: WPF verwendet MVVM (Model-View-ViewModel) Pattern.
	// Die View (XAML) bindet an das ViewModel via Data Binding.
	// OBSERVABLECOLLECTION: Für automatische UI-Updates bei Collection-Änderungen.
	public partial class DataBindLists : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public DataBindLists() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei werden Bindings demonstriert:
			// - ListBox mit ItemsSource="{Binding ...}"
			// - DisplayMemberPath für Property-Anzeige
			// - DataTemplate für komplexe Item-Darstellung
			// - SelectedItem Binding für Synchronisation
			InitializeComponent();
		}
	}
}
