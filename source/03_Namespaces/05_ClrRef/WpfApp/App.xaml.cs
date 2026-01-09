// WPF Application-Namespace.
using System.Windows;

// 'namespace XamlNamespaces': XAML-Namespace-Demo für CLR-Referenzen.
// KONZEPT: Zeigt clr-namespace-Syntax mit und ohne assembly-Parameter.
// LERNZIEL: Verständnis, wann assembly-Parameter erforderlich ist.
namespace XamlNamespaces
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  
  // Application-Klasse für ClrRef-Demo.
  // BESONDERHEIT: Diese App nutzt sowohl externe als auch lokale Controls.
  // CLR-NAMESPACE: Lokale Controls brauchen KEIN assembly-Parameter in xmlns.
  public partial class App : Application
  {
    // Keine zusätzliche Logik.
  }
}
