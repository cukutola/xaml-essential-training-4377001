// WPF Application-Namespace.
using System.Windows;

// 'namespace XamlNamespaces': Demo-Namespace für XAML-Namespace-Konzepte.
// ZWECK: Zeigt, wie XAML-Namespaces (xmlns) CLR-Namespaces referenzieren.
// KONZEPT: XML-Namespaces (xmlns) vs. CLR-Namespaces (C# namespace keyword).
namespace XamlNamespaces
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  
  // Application-Klasse: Einstiegspunkt der WPF-Anwendung.
  // ROLLE: Verwaltet Anwendungslebenszyklus und referenziert externe Assemblies.
  // BESONDERHEIT: Diese App nutzt Custom Controls aus separaten Assemblies.
  public partial class App : Application
  {
    // Keine zusätzliche Logik erforderlich.
    // HINWEIS: App.xaml definiert StartupUri und Merged Dictionaries.
  }
}
