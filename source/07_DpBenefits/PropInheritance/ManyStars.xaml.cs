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
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;

// Namespace für die Property Inheritance Demo.
// KONTEXT: Demonstriert Property Value Inheritance im Visual Tree.
namespace PropInheritance
{
    /// <summary>
    /// Interaction logic for ManyStars.xaml
    /// </summary>
    // 'ManyStars': Fenster für Property Inheritance-Demonstration.
    // ZWECK: Zeigt, wie DependencyProperty-Werte den Visual Tree hinab vererbt werden.
    // PROPERTY INHERITANCE: Einige DPs (z.B. FontFamily, FontSize, Foreground) werden
    // automatisch von Parent zu Child vererbt, wenn nicht lokal überschrieben.
    // BEISPIEL: Window.FontSize = 20 → alle Children haben FontSize 20 (außer lokal gesetzt).
    // VORTEIL: Konsistentes Styling mit minimalem Code, zentrales Theme-Management.
    // EINGESCHRÄNKTE VERERBUNG: Nur bestimmte DPs unterstützen Inheritance (FrameworkPropertyMetadata.Inherits = true).
    // HÄUFIG VERERBTE PROPERTIES: FontFamily, FontSize, FontWeight, Foreground, Background, DataContext.
    public partial class ManyStars : Window
    {
        // Konstruktor: Initialisiert das Fenster.
        public ManyStars()
        {
            // 'InitializeComponent()': Lädt XAML mit Star-Controls.
            // XAML-DEMO: Zeigt vermutlich mehrere Stars ohne explizite Property-Setze,
            // die ihre Werte vom Parent-Window oder Panel erben.
            // VERERBUNGS-EFFEKT: Änderung von Window.FontSize ändert alle Child-Stars.
            // PRECEDENCE: Inherited < Style < Local, d.h. lokale Werte überschreiben Vererbung.
            InitializeComponent();
        }
    }
}
