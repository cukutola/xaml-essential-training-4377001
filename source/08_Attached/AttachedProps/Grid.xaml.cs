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

namespace AttachedProps
{
    /// <summary>
    /// Grid-Beispiel: Zeigt die klassische Verwendung von Grid.Row und Grid.Column Attached Properties.
    /// Grid.Row und Grid.Column sind prototypische Beispiele für Attached Properties in WPF:
    /// Sie erlauben es Child-Elementen, ihre Position im Grid anzugeben, obwohl die Child-Elemente
    /// selbst keine Row/Column-Properties definieren.
    /// </summary>
    public partial class GridExample : Window
    {
        public GridExample()
        {
            InitializeComponent();
        }

		// Event-Handler: Demonstriert die programmatische Verwendung von Attached Properties.
		// Anstatt im XAML Grid.Row="2" zu setzen, kann man dies auch im Code-Behind tun.
		private void MoveButton_Click(object sender, RoutedEventArgs e) {
			// Grid.SetColumn(): Setter-Methode für die Grid.Column Attached Property.
			// Verschiebt 'Circle1' zur Spalte 0 (erste Spalte).
			// WICHTIG: Dies ist der programmatische Weg - entspricht Grid.Column="0" in XAML.
			Grid.SetColumn(Circle1, 0);
			
			// Grid.SetRow(): Setter-Methode für die Grid.Row Attached Property.
			// Verschiebt 'Circle1' zur Zeile 2 (dritte Zeile, da nullbasiert).
			// Das Layout des Grids wird automatisch aktualisiert, wenn diese Werte geändert werden.
			Grid.SetRow(Circle1, 2);
		}
	}
}
