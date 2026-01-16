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

namespace PropInheritance
{
    /// <summary>
    /// Interaction logic for ManyStars.xaml
    /// 
    /// PROPERTY INHERITANCE Demo:
    /// - Zeigt wie Dependency Properties im Visual Tree vererbt werden
    /// - Demonstriert Inherited Values in der Value Precedence Hierarchie
    /// 
    /// PROPERTY INHERITANCE Konzept:
    /// - Bestimmte DPs werden automatisch von Parent zu Child vererbt
    /// - Beispiele: FontFamily, FontSize, Foreground, DataContext
    /// - Muss bei DP-Registrierung aktiviert werden: FrameworkPropertyMetadataOptions.Inherits
    /// 
    /// VALUE PRECEDENCE mit Inheritance:
    /// 1. Local (auf diesem Element)
    /// 2. Style (auf diesem Element)
    /// 3. Default (auf diesem Element)
    /// 4. Inherited (vom Parent-Element) ← Niedrigste Priorität
    /// 
    /// VISUAL TREE TRAVERSAL:
    /// - WPF durchsucht den Visual Tree nach oben bis ein Wert gefunden wird
    /// - Stoppt bei erstem gesetzten Wert
    /// - Sehr effizient durch Sparse Storage
    /// 
    /// PERFORMANCE-VORTEILE:
    /// - Kein Memory-Overhead für geerbte Werte (Sparse Storage)
    /// - Automatische Change Notification im gesamten Subtree
    /// - Zentrale Konfiguration auf Parent-Level möglich
    /// 
    /// BEISPIEL:
    /// - Window.FontSize = 20 → alle Child-Controls erben diesen Wert
    /// - Einzelne Controls können mit Local Value überschreiben
    /// - ClearValue() stellt Vererbung wieder her
    /// </summary>
    public partial class ManyStars : Window
    {
        public ManyStars()
        {
            InitializeComponent();
            
            // Alle Star-Controls im Visual Tree erben Properties vom Window
            // z.B. FontSize, Foreground, DataContext (falls als Inheritable registriert)
        }
    }
}
