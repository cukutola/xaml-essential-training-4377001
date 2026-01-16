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
    /// Tooltip-Beispiel: Demonstriert die Verwendung von Attached Properties.
    /// ToolTip ist ein klassisches Beispiel für eine Attached Property - jedes UI-Element
    /// kann ein ToolTip erhalten, obwohl nicht jedes Element selbst eine ToolTip-Property definiert.
    /// VERWENDUNG IN XAML: <Button ToolTip="Mein Tooltip Text" />
    /// </summary>
    public partial class TooltipExample : Window
    {
        public TooltipExample()
        {
            // InitializeComponent(): Lädt und initialisiert die XAML-UI für dieses Fenster.
            // Hier werden alle in der XAML definierten Attached Properties (z.B. ToolTip) gesetzt.
            InitializeComponent();
        }
    }
}
