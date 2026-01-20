// WPF Application-Namespace.
using System.Windows;

// ===== CLR-NAMESPACE-REFERENZ KONZEPTE =====
// 'namespace XamlNamespaces': XAML-Namespace-Demo für CLR-Namespace-Referenzen.
// 
// LERNZIELE DIESER DEMO:
// 1. Wann ist der assembly-Parameter in xmlns ERFORDERLICH?
// 2. Wann kann der assembly-Parameter WEGGELASSEN werden?
// 3. Wie funktioniert CLR-Namespace-Mapping in XAML?
// 
// ===== ASSEMBLY-PARAMETER: WANN ERFORDERLICH? =====
// 
// ERFORDERLICH (externe Assembly):
//   xmlns:ctrl="clr-namespace:BigStar.Lib.Controls;assembly=ControlsLib"
//   - Control-Klasse ist in ANDERER Assembly/DLL
//   - Projekt hat Referenz auf ControlsLib.dll
//   - XAML-Parser muss wissen, welche DLL geladen werden soll
//   - BEISPIEL: <ctrl:IpAddress /> aus ControlsLib.dll
// 
// NICHT ERFORDERLICH (lokale Assembly):
//   xmlns:local="clr-namespace:BigStar.Lib.Graphics"
//   - Control-Klasse ist in GLEICHER Assembly
//   - Kein assembly-Parameter nötig
//   - XAML-Parser sucht automatisch in aktueller Assembly
//   - BEISPIEL: <local:Octopod /> aus GraphicsLocal-Ordner
// 
// ===== ASSEMBLY-NAME vs. NAMESPACE =====
// 
// Assembly-Name:
//   - Physische DLL-Datei (z.B. ControlsLib.dll, GraphicsLib.dll)
//   - Kompilierungs-Einheit (.csproj → .dll)
//   - In XAML: assembly=ControlsLib (OHNE .dll)
// 
// CLR-Namespace:
//   - Logische Gruppierung von Typen (z.B. BigStar.Lib.Controls)
//   - C# 'namespace' keyword
//   - In XAML: clr-namespace:BigStar.Lib.Controls
// 
// TRENNUNG:
//   - Ein Assembly kann MEHRERE Namespaces enthalten
//   - Ein Namespace kann über MEHRERE Assemblies verteilt sein
//   - Namespace-Name ist UNABHÄNGIG vom Assembly-Namen
// 
// ===== CROSS-ASSEMBLY REFERENCES =====
// 
// Voraussetzungen:
// 1. Projekt-Referenz auf externe Assembly (Add Reference)
// 2. xmlns-Deklaration mit assembly-Parameter
// 3. Control-Klasse muss 'public' sein (nicht 'internal')
// 
// Beispiel vollständige XAML-Deklaration:
//   <Window 
//     xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
//     xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
//     xmlns:ctrl="clr-namespace:BigStar.Lib.Controls;assembly=ControlsLib"
//     xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib"
//     xmlns:local="clr-namespace:MainApp">
//     
//     <!-- Externes Control aus ControlsLib.dll -->
//     <ctrl:IpAddress />
//     
//     <!-- Externes Control aus GraphicsLib.dll -->
//     <gfx:Octopod />
//     
//     <!-- Lokales Control aus gleicher Assembly -->
//     <local:MyLocalControl />
//   </Window>
namespace XamlNamespaces
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  
  // Application-Klasse für ClrRef-Demo.
  // 
  // BESONDERHEIT DIESER APP:
  // - Nutzt sowohl EXTERNE als auch LOKALE Controls
  // - Demonstriert assembly-Parameter-Verwendung
  // 
  // EXTERNE CONTROLS (erfordern assembly-Parameter):
  // - ControlsLib.dll: IpAddress, Gauge
  // - GraphicsLib.dll: Octopod, WaterBackground (falls vorhanden)
  // - XAML: xmlns:ctrl="clr-namespace:BigStar.Lib.Controls;assembly=ControlsLib"
  // 
  // LOKALE CONTROLS (KEIN assembly-Parameter):
  // - GraphicsLocal-Ordner: Octopod, WaterBackground
  // - Im gleichen Projekt (WpfApp)
  // - XAML: xmlns:local="clr-namespace:BigStar.Lib.Graphics"
  // 
  // CLR-NAMESPACE-MAPPING-REGEL:
  // - assembly-Parameter NUR bei Cross-Assembly-Referenzen
  // - Lokale Klassen: assembly-Parameter weglassen
  // - XAML-Parser prüft zuerst lokale Assembly, dann referenzierte Assemblies
  public partial class App : Application
  {
    // Keine zusätzliche Logik erforderlich.
    // 
    // APP.XAML DEFINIERT:
    // - StartupUri: Startet Window1 beim Anwendungsstart
    // - Application.Resources: Globale Ressourcen (falls vorhanden)
    // 
    // NAMESPACE-AUFLÖSUNG:
    // - WPF lädt automatisch alle referenzierten Assemblies
    // - xmlns-Deklarationen ermöglichen Typzugriff in XAML
    // - assembly-Parameter steuert Assembly-Auflösung
  }
}
