// ===== WPF-BASIS-NAMESPACES =====
// 'using System.Windows': Grundlegende WPF-Typen.
// 'using System.Windows.Controls': UI-Steuerelemente.
using System.Windows;
using System.Windows.Controls;

// ===== CLR-NAMESPACE-REFERENZ DEMO =====
// 'namespace MainApp': Hauptanwendungs-Namespace für CLR-Namespace-Referenz-Demo.
// 
// KONTEXT: Diese Demo zeigt den Unterschied zwischen:
//          - LOKALEN Controls (im gleichen Projekt)
//          - EXTERNEN Controls (in separater Assembly)
// 
// ===== LOKALE vs. EXTERNE NAMESPACE-REFERENZIERUNG =====
// 
// 1. LOKALE CONTROLS (GraphicsLocal-Ordner):
//    - Controls sind im GLEICHEN Projekt/Assembly
//    - XAML-DEKLARATION: xmlns:local="clr-namespace:BigStar.Lib.Graphics"
//    - KEIN assembly-Parameter erforderlich!
//    - GRUND: XAML-Parser findet Typen in der gleichen Assembly automatisch
//    - VERWENDUNG: <local:Octopod />, <local:WaterBackground />
//    - BEISPIEL:
//      <Window xmlns:local="clr-namespace:BigStar.Lib.Graphics">
//        <local:Octopod />
//      </Window>
//
// 2. EXTERNE CONTROLS (aus GraphicsLib.dll):
//    - Controls sind in SEPARATER Assembly/DLL
//    - XAML-DEKLARATION: xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib"
//    - assembly-Parameter ist ERFORDERLICH!
//    - GRUND: XAML-Parser muss wissen, in welcher DLL der Typ zu finden ist
//    - Projekt muss Referenz auf GraphicsLib.dll haben
//    - VERWENDUNG: <gfx:Octopod />, <gfx:WaterBackground />
//    - BEISPIEL:
//      <Window xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib">
//        <gfx:Octopod />
//      </Window>
//
// 3. NAMESPACE-SYNTAX-BREAKDOWN:
//    clr-namespace:NamespaceName              → Lokal (gleiche Assembly)
//    clr-namespace:NamespaceName;assembly=DLL → Extern (andere Assembly)
//    
//    Komponenten:
//    - "clr-namespace:" → Prefix für CLR-Namespace-Mapping
//    - "NamespaceName" → Vollständiger .NET-Namespace (z.B. BigStar.Lib.Graphics)
//    - ";assembly=" → Separator für Assembly-Name
//    - "DLL" → Assembly-Name OHNE .dll-Endung (z.B. GraphicsLib)
//
// 4. BEST PRACTICES:
//    - Verwende aussagekräftige Prefixe: 'local', 'ctrl', 'gfx', 'vm', etc.
//    - Konsistenz: Gleiches Prefix für verwandte Controls
//    - Dokumentation: Kommentiere Custom Namespace-Deklarationen
//
// BESONDERHEIT DIESER DEMO:
// - GraphicsLocal-Ordner enthält LOKALE Kopien von Octopod und WaterBackground
// - Gleicher Namespace (BigStar.Lib.Graphics) wie externe GraphicsLib.dll
// - Demonstriert, dass Namespace-Name und Assembly-Zugehörigkeit unabhängig sind
namespace MainApp
{
  // Demo-Kommentar beibehalten.

    // 'Window1': Hauptfenster der CLR-Namespace-Referenz-Demo.
    // 
    // ZWECK: Zeigt Unterschied zwischen lokalen und externen Assembly-Referenzen.
    // 
    // LOKALE CONTROLS (GraphicsLocal-Ordner):
    // - Octopod.xaml.cs und WaterBackground.xaml.cs
    // - Namespace: BigStar.Lib.Graphics (gleich wie externe Lib!)
    // - XAML-Verwendung: xmlns:local="clr-namespace:BigStar.Lib.Graphics"
    // - KEIN assembly-Parameter nötig (gleiche Assembly)
    // 
    // CLR-NAMESPACE-KONZEPT:
    // - CLR-Namespace (BigStar.Lib.Graphics) ist nur logische Gruppierung
    // - Assembly (WpfApp.exe vs. GraphicsLib.dll) bestimmt physische Zugehörigkeit
    // - Gleicher Namespace kann in mehreren Assemblies existieren
    // - XAML muss wissen, in welcher Assembly nach dem Typ gesucht werden soll
    // 
    // VERGLEICH:
    // - Lokal:  xmlns:local="clr-namespace:BigStar.Lib.Graphics"
    // - Extern: xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib"
    // - Gleicher Namespace, unterschiedliche Assembly-Zuordnung!
    public partial class Window1 : Window
    {
        // Konstruktor: Initialisiert Fenster.
        public Window1()
        {
            // InitializeComponent(): Lädt XAML mit lokalen Control-Referenzen.
            // 
            // XAML-PARSING-ABLAUF:
            // 1. Parser liest xmlns:local="clr-namespace:BigStar.Lib.Graphics"
            // 2. KEIN assembly-Parameter → Suche in aktueller Assembly
            // 3. Findet Octopod und WaterBackground in GraphicsLocal-Ordner
            // 4. Instanziiert lokale Versionen der Controls
            // 
            // WICHTIG: Wenn assembly-Parameter fehlt, wird NUR in lokaler Assembly gesucht!
            InitializeComponent();
        }
    }
}
