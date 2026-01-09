// WPF-Basis-Namespaces.
using System.Windows;
using System.Windows.Controls;

// 'namespace MainApp': Hauptanwendungs-Namespace.
// KONTEXT: Demonstriert Verwendung von Custom Controls aus externen Assemblies.
// XAML-NAMESPACE-DEKLARATION: Nutzt xmlns mit clr-namespace und assembly-Parameter.
namespace MainApp
{
  // Demo-Kommentar im Original-Code beibehalten.

    // 'Window1': Hauptfenster der Predefined-Namespace-Demo.
    // ZWECK: Zeigt Verwendung von vordefinierten Custom Controls (IpAddress, Gauge).
    // ASSEMBLY-REFERENZ: Nutzt Controls aus ControlsLib.dll.
    public partial class Window1 : Window
    {
        // Konstruktor: Initialisiert Fenster.
        public Window1()
        {
            // Lädt XAML mit Custom Control Definitionen.
            // WICHTIG: XAML muss xmlns:ctrl="clr-namespace:BigStar.Lib.Controls;assembly=ControlsLib" deklarieren.
            InitializeComponent();
        }
    }
}
