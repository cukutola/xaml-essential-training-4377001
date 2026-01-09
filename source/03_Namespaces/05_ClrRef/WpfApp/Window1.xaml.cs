// WPF-Basis-Namespaces.
using System.Windows;
using System.Windows.Controls;

// 'namespace MainApp': Hauptanwendungs-Namespace für ClrRef-Demo.
// KONTEXT: Demonstriert CLR-Namespace-Referenzen mit lokalen Controls.
// BESONDERHEIT: GraphicsLocal-Controls sind im selben Projekt (keine externe Assembly).
// XAML-MAPPING: xmlns:local="clr-namespace:BigStar.Lib.Graphics" (OHNE assembly-Parameter!).
namespace MainApp
{
  // Demo-Kommentar beibehalten.

    // 'Window1': Hauptfenster der CLR-Namespace-Referenz-Demo.
    // ZWECK: Zeigt Unterschied zwischen lokalen und externen Assembly-Referenzen.
    // LOKALE CONTROLS: GraphicsLocal-Ordner enthält lokale Kopien von Octopod/WaterBackground.
    // CLR-NAMESPACE: Kann direkt ohne assembly-Parameter referenziert werden.
    public partial class Window1 : Window
    {
        // Konstruktor.
        public Window1()
        {
            // Lädt XAML mit lokalen Control-Referenzen.
            // WICHTIG: xmlns:local="clr-namespace:BigStar.Lib.Graphics" (kein assembly nötig).
            InitializeComponent();
        }
    }
}
