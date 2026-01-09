// 'using': Importiert Namespaces für WPF-Controls, Reflection und .NET-Basisfunktionalität.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection; // Ermöglicht Runtime-Typ-Analyse
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// 'namespace': Organisiert die Klassen der Anwendung.
namespace ShowTypeConverters {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für Fenster in WPF.
	public partial class MainWindow : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public MainWindow() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			InitializeComponent();
			
			// ZWECK: Dieser Code demonstriert, wie man TypeConverter in verschiedenen
			// .NET-Assemblies via Reflection findet und auflistet.
			
			// 'typeof(...)': Liefert das Type-Objekt für die angegebene Klasse.
			// 't1': ByteConverter aus System.ComponentModel (Basis-Framework).
			Type t1 = typeof(System.ComponentModel.ByteConverter);
			// '.Assembly': Liefert die Assembly, in der der Typ definiert ist.
			// VERWENDUNG: Ermöglicht das Durchsuchen aller Typen in dieser Assembly.
			var assembly1 = t1.Assembly;
			
			// 't2': Brush-Klasse aus WindowsBase.dll (WPF-Basis-Assembly).
			Type t2 = typeof(System.Windows.Media.Brush);
			var assembly2 = t2.Assembly;

			// 't3': FontSizeConverter aus PresentationFramework.dll (WPF-UI-Assembly).
			Type t3 = typeof(System.Windows.FontSizeConverter);
			var assembly3 = t3.Assembly;


			// LINQ-ABFRAGE: Findet alle TypeConverter in der System.ComponentModel Assembly.
			// 'from type in assembly1.GetTypes()': Iteriert über alle Typen in der Assembly.
			// 'where type.IsSubclassOf(...)': Filtert nur Klassen, die von TypeConverter erben.
			// 'orderby type.Name': Sortiert alphabetisch nach Typname.
			// 'let ShortName = ...': Erstellt eine Variable mit dem Kurznamen (ohne "Converter"-Suffix).
			// '.Remove(...LastIndexOf("Converter"))': Entfernt das "Converter"-Suffix vom Namen.
			// ERGEBNIS: Liste von Converter-Namen wie "Byte", "Int32", "String" statt "ByteConverter", etc.
			var q1 = from type in assembly1.GetTypes()
							where type.IsSubclassOf(typeof(System.ComponentModel.TypeConverter))
							orderby type.Name
							let ShortName = type.Name.Remove(type.Name.LastIndexOf("Converter"))
							select ShortName;


			// LINQ-ABFRAGE: Findet alle TypeConverter in der WindowsBase Assembly (WPF-Typen).
			// BEISPIELE: BrushConverter, ColorConverter, PointConverter, etc.
			var q2 = from type in assembly2.GetTypes()
							 where type.IsSubclassOf(typeof(System.ComponentModel.TypeConverter))
							 orderby type.Name
							 let ShortName = type.Name.Remove(type.Name.LastIndexOf("Converter"))
							 select ShortName; ;

			// LINQ-ABFRAGE: Findet alle TypeConverter in der PresentationFramework Assembly.
			// BEISPIELE: FontSizeConverter, ThicknessConverter, GridLengthConverter, etc.
			var q3 = from type in assembly3.GetTypes()
							 where type.IsSubclassOf(typeof(System.ComponentModel.TypeConverter))
							 orderby type.Name
							 let ShortName = type.Name.Remove(type.Name.LastIndexOf("Converter"))
							 select ShortName; ;
			
			// '.ToList()': Materialisiert die LINQ-Query in eine konkrete List<string>.
			// WICHTIG: LINQ-Queries sind "lazy" - ohne ToList() würden sie erst bei
			// Iteration ausgeführt werden.
			var result = q2.ToList();
			// '.AddRange()': Fügt alle Elemente aus einer anderen Collection hinzu.
			result.AddRange(q3.ToList());
	
			// DATA BINDING: Setzt die DataContext-Property der ListBoxen.
			// 'this.TypeConvertersListBox': Ein benanntes Element aus der XAML-Datei.
			// '.DataContext': Die Datenquelle für Bindings in diesem Element und seinen Children.
			// '.OrderBy(t => t)': Sortiert die Liste alphabetisch.
			// AUSWIRKUNG: Die ListBox zeigt automatisch alle TypeConverter-Namen an,
			// wenn sie ein ItemsSource-Binding hat, das auf DataContext verweist.
			this.TypeConvertersListBox.DataContext = q2.ToList().OrderBy(t => t);
			this.BasicConvertersListBox.DataContext = q1.ToList().OrderBy(t => t);
			this.BrushConvertersListBox.DataContext = q3.ToList().OrderBy(t => t);
		}

		// EVENT HANDLER: Wird aufgerufen, wenn die Auswahl in einer ListBox geändert wird.
		// 'private': Nur innerhalb dieser Klasse sichtbar (Event-Handler müssen nicht public sein).
		// PARAMETER:
		// - 'sender': Das Control, das das Event ausgelöst hat (eine der ListBoxen).
		// - 'e': Event-Argumente mit Informationen über hinzugefügte/entfernte Elemente.
		private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			// 'as ListBox': Sichere Type-Konvertierung (gibt 'null' zurück bei Fehler, statt Exception).
			// ZWECK: Castet 'sender' von 'object' zu 'ListBox', um auf ListBox-spezifische Members zuzugreifen.
			var currentListBox = sender as ListBox;
			// '.SelectedItem': Die aktuell ausgewählte Item in der ListBox.
			// 'ShowListBox.Items.Add()': Fügt das ausgewählte Element zu einer anderen ListBox hinzu.
			// VERWENDUNG: Zeigt die ausgewählten Converter in einer separaten Sammlung an.
			ShowListBox.Items.Add(currentListBox.SelectedItem);
		}
	}
}

