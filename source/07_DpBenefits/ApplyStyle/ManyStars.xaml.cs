// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente.
using System.Windows.Controls;
// System.Windows.Data: Data Binding-Funktionalität.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;

// Namespace für die Style-Demo.
// KONTEXT: Demonstriert die Anwendung von Styles auf mehrere Star-Controls.
namespace ApplyStyle {
    /// <summary>
    /// Interaction logic for ManyStars.xaml
    /// </summary>
    // 'ManyStars': Fenster mit mehreren Star-Instanzen.
    // ZWECK: Zeigt, wie Styles DependencyProperty-Werte zentral definieren können.
    // DEPENDENCY PROPERTY VORTEIL: Styles können DP-Werte über Setter setzen.
    // BEISPIEL: <Style TargetType="Star"><Setter Property="Points" Value="5"/></Style>
    // EFFEKT: Alle Stars erhalten automatisch 5 Zacken, ohne individuelles Setzen.
    // VALUE PRECEDENCE: Style-Werte haben niedrigere Priorität als lokale Werte.
    // HIERARCHIE: Local > Style > Default (aus PropertyMetadata).
    public partial class ManyStars : Window
    {
        // Konstruktor: Initialisiert das Fenster.
        public ManyStars()
        {
            // 'InitializeComponent()': Lädt XAML mit mehreren Star-Instanzen.
            // XAML-INHALT: Definiert Styles für Star-Controls im Resources-Bereich.
            // STYLE-APPLICATION: <Star Style="{StaticResource StarStyle}"/> oder implizit.
            // IMPLICIT STYLES: Wenn Style keinen x:Key hat, wird er automatisch auf alle
            // Controls vom TargetType angewendet.
            InitializeComponent();
        }
    }
}
