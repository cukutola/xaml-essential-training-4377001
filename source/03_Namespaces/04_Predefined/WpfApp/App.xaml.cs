// ===== WPF APPLICATION-NAMESPACE =====
// 'System.Windows': Enthält die Application-Klasse - Kern jeder WPF-Anwendung.
using System.Windows;

// 'namespace XamlNamespaces': Demo-Namespace für XAML-Namespace-Konzepte.
// 
// ===== WICHTIGE XAML-NAMESPACE-KONZEPTE =====
// 
// 1. DEFAULT XAML NAMESPACE:
//    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
//    - Wird OHNE Prefix verwendet (Standard-Namespace)
//    - Enthält alle WPF-Standard-Controls: Window, Button, Grid, TextBox, etc.
//    - Mappt auf mehrere CLR-Namespaces: System.Windows, System.Windows.Controls, etc.
//    - VERWENDUNG IN XAML: <Window>, <Button>, <Grid> (ohne Prefix)
//
// 2. XAML NAMESPACE (x:):
//    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
//    - XAML-Language-Features und Compiler-Direktiven
//    - x:Class - Verbindet XAML mit Code-Behind-Klasse
//    - x:Name - Erstellt Feld-Referenz im Code-Behind
//    - x:Key - Eindeutiger Schlüssel für Ressourcen
//    - x:Type - Repräsentiert einen .NET-Typ
//    - x:Static - Zugriff auf statische Member
//    - VERWENDUNG: <Button x:Name="myButton" />
//
// 3. CLR-NAMESPACE-MAPPING (Custom Namespaces):
//    xmlns:local="clr-namespace:NamespaceName"
//    - Für Klassen im GLEICHEN Projekt/Assembly
//    - 'local' ist Konvention (kann beliebig sein)
//    - KEIN assembly-Parameter nötig
//    - BEISPIEL: <local:MyCustomControl />
//
// 4. CLR-NAMESPACE mit ASSEMBLY-REFERENZ:
//    xmlns:ctrl="clr-namespace:BigStar.Lib.Controls;assembly=ControlsLib"
//    - Für Klassen in EXTERNER Assembly/DLL
//    - assembly-Parameter ist ERFORDERLICH
//    - Projekt muss Referenz auf ControlsLib.dll haben
//    - BEISPIEL: <ctrl:IpAddress />
//
// 5. VORDEFINIERTE CUSTOM NAMESPACES:
//    xmlns:big="http://BigStarCollectibles.com/BigStarLib"
//    - Benutzerdefinierte URI statt clr-namespace-Syntax
//    - Definiert via [assembly: XmlnsDefinition(...)]
//    - Kann mehrere CLR-Namespaces zu einer URI mappen
//    - Benutzerfreundlicher für Library-Consumers
namespace XamlNamespaces
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  
  // ===== APPLICATION-KLASSE =====
  // 'public partial class App : Application': WPF-Anwendungs-Einstiegspunkt.
  // 
  // ROLLE:
  // - Verwaltet Anwendungslebenszyklus (Startup, Exit, Shutdown)
  // - Definiert StartupUri (welches Fenster beim Start geöffnet wird)
  // - Globale Ressourcen (Application.Resources)
  // - Unbehandelte Exceptions abfangen (DispatcherUnhandledException)
  // 
  // PARTIAL CLASS:
  // - Code-Behind-Teil (diese Datei)
  // - XAML-generierter Teil (App.g.cs)
  // - Beide Teile werden zur Kompilierzeit zusammengeführt
  // 
  // APP.XAML DEFINIERT:
  // - StartupUri: Welches Window beim Start geöffnet wird
  // - Application.Resources: Globale Styles, Templates, Brushes
  // - Merged Dictionaries: Einbindung externer Ressourcen
  // 
  // NAMESPACE-KONTEXT:
  // - Diese App demonstriert externe Assembly-Referenzen
  // - GraphicsLib.dll und ControlsLib.dll werden verwendet
  // - Zeigt verschiedene Arten von xmlns-Deklarationen
  public partial class App : Application
  {
    // Keine zusätzliche Logik erforderlich.
    // 
    // HINWEIS: App.xaml definiert:
    // - StartupUri="Window1.xaml" (oder ähnlich)
    // - Merged Resource Dictionaries (falls vorhanden)
    // - Globale Styles und Templates
    // 
    // ERWEITERTE NUTZUNG (optional):
    // - OnStartup Override: Initialisierungslogik vor Fensteranzeige
    // - OnExit Override: Aufräumarbeiten beim Beenden
    // - DispatcherUnhandledException: Globale Exception-Behandlung
  }
}
