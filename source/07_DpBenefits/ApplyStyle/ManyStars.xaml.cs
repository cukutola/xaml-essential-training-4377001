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

namespace ApplyStyle {
    /// <summary>
    /// Interaction logic for ManyStars.xaml
    /// 
    /// STYLE-ANWENDUNG mit Custom Controls:
    /// - Zeigt wie Styles auf Custom Controls (Star) angewendet werden
    /// - Custom Controls können Dependency Properties definieren
    /// 
    /// DEPENDENCY PROPERTY BENEFITS:
    /// - Styles können auf Custom Dependency Properties angewendet werden
    /// - VALUE PRECEDENCE bleibt erhalten: Local > Style > Default
    /// - Triggers können auf Dependency Properties reagieren
    /// 
    /// PERFORMANCE mit vielen Elementen:
    /// - Sparse Storage: Nur abweichende Werte von Style werden gespeichert
    /// - Shared Metadata: Default-Werte werden für alle Instanzen geteilt
    /// - Effiziente Change Notification nur bei tatsächlichen Änderungen
    /// </summary>
    public partial class ManyStars : Window
    {
        public ManyStars()
        {
            InitializeComponent();
        }
    }
}
