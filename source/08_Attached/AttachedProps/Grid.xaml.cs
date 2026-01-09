// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente, insbesondere Grid-Panel.
// WICHTIG: Grid ist ein Layout-Panel, das Attached Properties (Row, Column) verwendet!
using System.Windows.Controls;
// System.Windows.Data: Data Binding.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente (Ellipse, Rectangle).
using System.Windows.Shapes;

// Namespace für Attached Properties Demos.
// KONTEXT: Demonstriert Verwendung von Attached Properties am Beispiel von Grid.
namespace AttachedProps
{
    /// <summary>
    /// Interaction logic for GridExample.xaml
    /// </summary>
    // 'GridExample': Fenster, das Grid Attached Properties demonstriert.
    // ZWECK: Zeigt, wie Grid.Row und Grid.Column Attached Properties funktionieren.
    // ATTACHED PROPERTY KONZEPT: Properties, die an beliebige Elemente "angehängt" werden können,
    // auch wenn diese Elemente die Property selbst nicht definieren.
    // BEISPIEL: Grid.Row kann an Button, TextBox, Ellipse angehängt werden, obwohl diese
    // Elemente keine Row-Property besitzen. Grid liest diese Werte beim Layout.
    public partial class GridExample : Window
    {
        // Konstruktor: Initialisiert das Fenster.
        public GridExample()
        {
            // Lädt XAML mit Grid-Layout und Ellipse (Circle1).
            // XAML-BEISPIEL: <Ellipse x:Name="Circle1" Grid.Row="0" Grid.Column="1" />
            // ATTACHED PROPERTIES: Grid.Row und Grid.Column sind Attached Properties.
            InitializeComponent();
        }

		// Event-Handler für Move-Button Click.
		// ZWECK: Demonstriert programmgesteuerte Änderung von Attached Properties.
		// LERNZIEL: Zeigt den Unterschied zwischen XAML-Syntax und Code-Syntax für Attached Props.
		private void MoveButton_Click(object sender, RoutedEventArgs e) {
      // 'Grid.SetColumn': Statische Setter-Methode für Grid.Column Attached Property.
      // SYNTAX: OwnerType.SetPropertyName(targetElement, value)
      // PARAMETER 1 'Circle1': Das Element, an das die Property angehängt wird (Ellipse).
      // PARAMETER 2 '0': Der neue Column-Wert (Spalte 0).
      // XAML-ÄQUIVALENT: <Ellipse Grid.Column="0" />
      // WICHTIG: Jedes Attached Property hat zwei statische Methoden: GetXXX und SetXXX.
      Grid.SetColumn(Circle1, 0);
      
      // 'Grid.SetRow': Statische Setter-Methode für Grid.Row Attached Property.
      // PARAMETER 2 '2': Setzt Zeile auf 2 (dritte Zeile, da 0-basiert).
      // EFFEKT: Circle1 wird zur Position Column=0, Row=2 im Grid verschoben.
      // LAYOUT-UPDATE: Grid führt automatisch Re-Layout durch (InvalidateArrange).
			Grid.SetRow(Circle1, 2);
			
			// ATTACHED PROPERTY PATTERN:
			// 1. Definition: public static readonly DependencyProperty RowProperty = 
			//                DependencyProperty.RegisterAttached("Row", typeof(int), typeof(Grid), ...)
			// 2. Getter: public static int GetRow(UIElement element)
			// 3. Setter: public static void SetRow(UIElement element, int value)
			// 4. XAML-Verwendung: Grid.Row="2" (Compiler ruft SetRow auf)
			// 5. Code-Verwendung: Grid.SetRow(element, 2) oder element.SetValue(Grid.RowProperty, 2)
		}
	}
}
