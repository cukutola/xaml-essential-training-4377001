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

// ===== LOKALE CLR-NAMESPACE-REFERENZ =====
// 'BigStar.Lib.Graphics': Gleicher Namespace wie externe GraphicsLib.dll-Assembly.
// 
// WICHTIGE KONZEPTE:
// 
// 1. NAMESPACE vs. ASSEMBLY-ZUORDNUNG:
//    - Dieser Ordner: GraphicsLocal (Teil von WpfApp.exe)
//    - Externe DLL: GraphicsLib.dll
//    - GLEICHER Namespace: BigStar.Lib.Graphics
//    - UNTERSCHIEDLICHE Assembly-Zugehörigkeit
//    - FAZIT: Namespace-Name ist UNABHÄNGIG von Assembly-Struktur
// 
// 2. LOKALER KONTEXT:
//    - Diese Datei ist TEIL der MainApp (WpfApp.exe)
//    - Im GraphicsLocal-Ordner (Projekt-Unterordner)
//    - Wird in GLEICHE Assembly kompiliert wie MainApp
//    - KEIN separates DLL - direkt in WpfApp.exe eingebettet
// 
// 3. XAML-REFERENZIERUNG (LOKAL):
//    xmlns:local="clr-namespace:BigStar.Lib.Graphics"
//    - KEIN assembly-Parameter erforderlich!
//    - GRUND: Control ist in gleicher Assembly (WpfApp.exe)
//    - XAML-Parser findet Typ automatisch in lokaler Assembly
//    - VERWENDUNG: <local:Octopod />
// 
// 4. XAML-REFERENZIERUNG (EXTERN) - Zum Vergleich:
//    xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib"
//    - assembly-Parameter ERFORDERLICH
//    - GRUND: Control ist in anderer Assembly (GraphicsLib.dll)
//    - Projekt muss Referenz auf GraphicsLib.dll haben
//    - VERWENDUNG: <gfx:Octopod />
// 
// 5. NAMESPACE-WIEDERVERWENDUNG:
//    - Gleicher Namespace in mehreren Assemblies ist ERLAUBT
//    - Vermeidet Namespace-Proliferation
//    - Organisiert zusammengehörige Typen logisch
//    - XAML unterscheidet via assembly-Parameter
// 
// 6. WANN LOKAL vs. EXTERN?
//    - LOKAL: Kleine Controls, eng gekoppelt an App
//    - EXTERN: Wiederverwendbare Controls, Library-Verteilung
//    - LOKAL: Schnellere Kompilierung (eine Assembly)
//    - EXTERN: Bessere Modularität, versionierbar
namespace BigStar.Lib.Graphics {
	/// <summary>
	/// Interaction logic for Octopod.xaml
	/// </summary>
	
	// 'Octopod': Lokale Kopie des Octopod-Controls.
	// 
	// KONTEXT:
	// - Identisches Control wie in GraphicsLib.dll
	// - ABER: In WpfApp.exe eingebettet (nicht externe DLL)
	// - Gleicher Namespace (BigStar.Lib.Graphics)
	// - Unterschiedliche Assembly-Zugehörigkeit
	// 
	// ZWECK DIESER DEMO:
	// - Zeigt Unterschied zwischen lokaler und externer Referenzierung
	// - Demonstriert Namespace-Unabhängigkeit von Assembly-Struktur
	// - Erklärt, wann assembly-Parameter nötig ist
	// 
	// XAML-VERWENDUNG:
	//   <Window xmlns:local="clr-namespace:BigStar.Lib.Graphics">
	//     <local:Octopod />  <!-- Lädt DIESE lokale Klasse -->
	//   </Window>
	// 
	// vs. EXTERNE VERSION:
	//   <Window xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib">
	//     <gfx:Octopod />  <!-- Lädt Klasse aus GraphicsLib.dll -->
	//   </Window>
	// 
	// BEST PRACTICE:
	// - Verwende unterschiedliche Prefixe für lokale vs. externe Namespaces
	// - Dokumentiere, welche Version verwendet wird
	// - Vermeide Namespace-Konflikte durch klare Benennung
	public partial class Octopod : UserControl {
		
		// Konstruktor: Initialisiert lokales Control.
		public Octopod() {
			// Lädt XAML-Definition aus Octopod.xaml (lokal im Projekt).
			// HINWEIS: Diese XAML-Datei ist Teil von WpfApp, nicht GraphicsLib.
			InitializeComponent();
		}
	}
}
