// ===== WPF-BASIS-NAMESPACES =====
// 'using System.Windows': Enthält grundlegende WPF-Typen (Window, Application, UIElement, etc.).
// 'using System.Windows.Controls': Enthält UI-Steuerelemente (Button, TextBox, Grid, etc.).
// HINWEIS: Diese Namespaces entsprechen dem Default-XAML-Namespace:
//          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
using System.Windows;
using System.Windows.Controls;

// ===== NAMESPACE-DEKLARATION =====
// 'namespace MainApp': Hauptanwendungs-Namespace dieser Demo.
// 
// KONTEXT: Diese Demo zeigt die Verwendung von VORDEFINIERTEN Custom Namespaces.
// 
// WICHTIGE KONZEPTE:
// 1. VORDEFINIERTE XAML-NAMESPACES:
//    - WPF definiert einige Namespaces mit benutzerfreundlichen URIs
//    - Beispiel: xmlns:big='http://BigStarCollectibles.com/BigStarLib'
//    - Diese URIs werden intern auf CLR-Namespaces gemappt
//    - Vorteil: Leichter zu merken als "clr-namespace:..." Syntax
//
// 2. NAMESPACE-MAPPING-DEFINITION:
//    - In AssemblyInfo.cs oder als Attribut definiert
//    - [assembly: XmlnsDefinition("http://...", "CLR.Namespace")]
//    - Ermöglicht vordefinierte, wiederverwendbare Namespace-URIs
//
// 3. VERWENDUNG IN XAML:
//    - xmlns:big='http://BigStarCollectibles.com/BigStarLib'
//    - Statt: xmlns:big='clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib'
//    - Kein assembly-Parameter nötig (wird durch Mapping aufgelöst)
//
// 4. CROSS-ASSEMBLY REFERENCES:
//    - GraphicsLib.dll und ControlsLib.dll werden referenziert
//    - Controls können über vordefinierten Namespace verwendet werden
//    - XAML: <big:Octopod /> und <big:WaterBackground />
namespace MainApp
{
  // Demo-Kommentar im Original-Code beibehalten.

    // 'Window1': Hauptfenster der Predefined-Namespace-Demo.
    // 
    // ZWECK: Demonstriert Verwendung von VORDEFINIERTEN XML-Namespaces in XAML.
    // 
    // ASSEMBLY-REFERENZ: Nutzt Controls aus externen Assemblies:
    //    - GraphicsLib.dll (Octopod, WaterBackground)
    //    - ControlsLib.dll (IpAddress, Gauge - falls verwendet)
    //
    // XAML-NAMESPACE-DEKLARATION:
    //    xmlns:big='http://BigStarCollectibles.com/BigStarLib'
    //    
    // VORTEIL: Diese URI ist benutzerfreundlicher als:
    //    xmlns:gfx='clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib'
    //    xmlns:ctrl='clr-namespace:BigStar.Lib.Controls;assembly=ControlsLib'
    //    
    // FUNKTIONSWEISE: XmlnsDefinition-Attribut mappt die URI auf CLR-Namespaces.
    public partial class Window1 : Window
    {
        // Konstruktor: Initialisiert Fenster und lädt XAML.
        public Window1()
        {
            // InitializeComponent(): Lädt und parst XAML-Datei.
            // 
            // ABLAUF:
            // 1. XAML-Parser liest Window1.xaml
            // 2. Findet xmlns:big='http://BigStarCollectibles.com/BigStarLib'
            // 3. Löst URI über XmlnsDefinition-Attribute auf
            // 4. Mappt auf BigStar.Lib.Graphics und BigStar.Lib.Controls
            // 5. Lädt Controls (Octopod, WaterBackground) aus GraphicsLib.dll
            // 6. Instanziiert alle UI-Elemente
            // 7. Verbindet Code-Behind mit XAML
            InitializeComponent();
        }
    }
}
