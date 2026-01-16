// .NET Standard-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Namespaces.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// ===== LOKALER GRAPHICS NAMESPACE =====
// Graphics Namespace - lokal im Projekt (nicht externe DLL).
// 
// CLR-NAMESPACE-DEMO: Zeigt Verwendung OHNE assembly-Parameter.
// 
// KONZEPT: LOKALE ASSEMBLY-REFERENZ
// 
// 1. ASSEMBLY-STRUKTUR:
//    - WpfApp.exe (Haupt-Assembly)
//      ├── MainApp (Namespace)
//      │   └── Window1, App (Klassen)
//      └── BigStar.Lib.Graphics (Namespace)
//          └── WaterBackground, Octopod (Klassen im GraphicsLocal-Ordner)
// 
// 2. NAMESPACE-DEKLARATION IN XAML:
//    xmlns:local="clr-namespace:BigStar.Lib.Graphics"
//    
//    Syntax-Breakdown:
//    - "local" → Prefix (frei wählbar, Konvention für lokale Namespaces)
//    - "clr-namespace:" → CLR-Namespace-Mapping-Präfix
//    - "BigStar.Lib.Graphics" → Vollständiger .NET-Namespace
//    - KEIN ";assembly=..." → Suche in LOKALER Assembly (WpfApp.exe)
// 
// 3. ASSEMBLY-PARAMETER WEGLASSEN:
//    - assembly-Parameter ist OPTIONAL für lokale Namespaces
//    - Wenn weggelassen: XAML-Parser sucht in aktueller Assembly
//    - Wenn vorhanden: XAML-Parser sucht in angegebener Assembly
//    - REGEL: assembly-Parameter NUR bei Cross-Assembly-Referenzen
// 
// 4. VERWENDUNG IN XAML:
//    <Window xmlns:local="clr-namespace:BigStar.Lib.Graphics">
//      <local:WaterBackground />  <!-- Findet Klasse in WpfApp.exe -->
//    </Window>
// 
// 5. VERGLEICH MIT EXTERNER REFERENZ:
//    LOKAL (diese Datei):
//      xmlns:local="clr-namespace:BigStar.Lib.Graphics"
//      → Sucht in WpfApp.exe
//      → GraphicsLocal-Ordner
//    
//    EXTERN (GraphicsLib.dll):
//      xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib"
//      → Sucht in GraphicsLib.dll
//      → Externe Bibliothek
//    
//    GLEICHER NAMESPACE, UNTERSCHIEDLICHE ASSEMBLY!
namespace BigStar.Lib.Graphics
	 {
	/// <summary>
	/// Interaction logic for WaterBackground.xaml
	/// </summary>
	
	// 'WaterBackground': Lokale Kopie des WaterBackground-Controls.
	// 
	// ASSEMBLY-ZUORDNUNG:
	// - Kompiliert in WpfApp.exe (nicht GraphicsLib.dll)
	// - Im GraphicsLocal-Ordner (Projekt-Unterordner)
	// - Teil der MainApp-Assembly
	// 
	// XAML-VERWENDUNG (lokal):
	//   xmlns:local="clr-namespace:BigStar.Lib.Graphics"
	//   <local:WaterBackground />
	//   
	//   WICHTIG: Kein assembly-Parameter!
	//   GRUND: Control ist in gleicher Assembly wie Window
	// 
	// XAML-VERWENDUNG (extern) - Zum Vergleich:
	//   xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib"
	//   <gfx:WaterBackground />
	//   
	//   UNTERSCHIED: assembly-Parameter zeigt auf GraphicsLib.dll
	//   VORAUSSETZUNG: Projekt-Referenz auf GraphicsLib.dll
	// 
	// VORTEIL LOKALER CONTROLS:
	// - Keine externe DLL-Referenz nötig
	// - Schnellere Kompilierung (eine Assembly)
	// - Einfachere Deployment (weniger Dateien)
	// - Eng gekoppelt an Anwendung
	// 
	// NACHTEIL:
	// - Nicht wiederverwendbar in anderen Projekten
	// - Größere Haupt-Assembly
	// - Keine separate Versionierung möglich
	public partial class WaterBackground : UserControl {
		
		// Konstruktor: Initialisiert lokales grafisches Control.
		public WaterBackground() {
			// Lädt XAML-Definition aus WaterBackground.xaml.
			// HINWEIS: XAML-Datei ist lokal im GraphicsLocal-Ordner.
			// KOMPILIERUNG: XAML wird in WpfApp.exe eingebettet, nicht in separate DLL.
			InitializeComponent();
		}
	}
}
