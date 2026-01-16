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
    /// KeyNav-Beispiel: Demonstriert KeyboardNavigation Attached Properties.
    /// KeyboardNavigation bietet mehrere Attached Properties zur Steuerung der Tastaturnavigation:
    /// - KeyboardNavigation.TabIndex: Bestimmt die Reihenfolge beim Tabben durch Elemente.
    /// - KeyboardNavigation.TabNavigation: Steuert das Verhalten beim Tab-Drücken (z.B. Cycle, Continue, Once).
    /// - KeyboardNavigation.DirectionalNavigation: Steuert die Pfeiltasten-Navigation.
    /// VERWENDUNG: <Button KeyboardNavigation.TabIndex="3" /> setzt die Tab-Reihenfolge.
    /// </summary>
    public partial class KeyNav : Window
    {
        public KeyNav()
        {
            // InitializeComponent(): Lädt das XAML, wo KeyboardNavigation Attached Properties
            // auf verschiedenen UI-Elementen gesetzt werden, um die Tab-Reihenfolge zu definieren.
            InitializeComponent();
        }
    }
}
