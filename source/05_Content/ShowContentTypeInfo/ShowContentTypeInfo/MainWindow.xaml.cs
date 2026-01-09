// 'using': Importiert Namespaces für WPF, Reflection und XAML-Funktionalität.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection; // Für Type-Analyse zur Laufzeit
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup; // Für ContentPropertyAttribute
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// 'namespace': Organisiert die Klassen der Anwendung.
namespace ShowContentTypeInfo {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert Reflection-basierte Analyse von ContentProperty-Attributen.
	// Zeigt alle WPF-Controls mit ihren ContentProperty-Namen.
	public partial class MainWindow : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public MainWindow() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			InitializeComponent();
			
			// 'typeof(TextBlock)': Holt den Type für TextBlock.
			Type t = typeof(System.Windows.Controls.TextBlock);
			// '.Assembly': Die Assembly, die TextBlock enthält (PresentationFramework.dll).
			Assembly assembly = t.Assembly;
			
			// LINQ-ABFRAGE: Findet alle UIElements mit ContentProperty-Attribut.
			var custAttr = from type in assembly.GetTypes()
										 // Nur Klassen, die von UIElement erben.
										 where type.IsSubclassOf(typeof(System.Windows.UIElement))
										 orderby type.Name

										 // 'GetCustomAttributes': Reflection - holt ContentPropertyAttribute.
										 // 'let': LINQ-Variable für wiederverwendbare Berechnungen.
										 let ContentAttributes = ((ContentPropertyAttribute[])type.GetCustomAttributes(typeof(ContentPropertyAttribute), true)).ToList()

										 // Nur Typen MIT ContentProperty-Attribut.
										 where ContentAttributes.Count() > 0
										 // Keine abstrakten Klassen.
										 where type.IsAbstract == false

										 // Das erste (und normalerweise einzige) ContentProperty-Attribut.
										 let attributeItems = ContentAttributes[0]
										 // Nur wenn Name nicht null ist.
										 where attributeItems.Name != null
										 // 'GetProperty': Reflection - holt die PropertyInfo für die ContentProperty.
										 let x = type.GetProperty(attributeItems.Name)
										 // Erstellt ein XAML-Beispiel-String.
										 // '$': String-Interpolation für lesbare Formatierung.
										 // 'Environment.NewLine': Plattform-unabhängiger Zeilenumbruch.
										 let message = $"<{type.Name}>{Environment.NewLine}    {x.PropertyType.Name} ◄ {Environment.NewLine}</{type.Name}>"
										 // ANONYMOUS TYPE: Erstellt ein Objekt mit den relevanten Informationen.
										 select new { UIElementName = type.Name, ContentPropName = attributeItems.Name, PropertyType = x.PropertyType.Name, XamlExample = message };

			// 'DataContext': Setzt die Datenquelle für Data Binding.
			// '.ToList()': Materialisiert die LINQ-Query.
			// Das UI bindet an diese Liste, um alle ContentProperty-Informationen anzuzeigen.
			this.DataContext = custAttr.ToList();
		}
	}
}
