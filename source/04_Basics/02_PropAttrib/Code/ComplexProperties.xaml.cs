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
	/// Interaction logic for ComplexProperties.xaml
	/// </summary>
	// 'public': Diese Fensterklasse ist öffentlich zugänglich
	// 'partial': Die Klasse ist aufgeteilt. Der XAML-Compiler generiert automatisch
	// den anderen Teil mit UI-Element-Feldern und der InitializeComponent-Methode.
	// ': Window': Erbt von Window - macht diese Klasse zu einem Top-Level-Fenster
	// mit Titelleiste, Rahmen und Standard-Fensterfunktionalität.
	public partial class ComplexProperties : Window {
		// Konstruktor: Wird beim Erstellen einer neuen Fensterinstanz aufgerufen
		public ComplexProperties() {
			// 'InitializeComponent': Vom XAML-Compiler generierte Methode, die:
			// 1. Die XAML-Datei lädt und parsed
			// 2. Den visuellen Baum aufbaut (alle UI-Elemente erstellt)
			// 3. Property-Werte aus XAML setzt (durch TypeConverter)
			// 4. Benannte Elemente (x:Name) mit C#-Feldern verknüpft
			// 5. Event-Handler aus XAML registriert
			// Diese Methode demonstriert, wie komplexe Properties (wie Brush, Thickness, etc.)
			// in XAML als Attribute gesetzt werden können, dank TypeConverter.
			InitializeComponent();
		}
	}
}
