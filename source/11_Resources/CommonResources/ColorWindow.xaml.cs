// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente.
using System.Windows.Controls;
// System.Windows.Data: Data Binding.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Colors.
// WICHTIG: Dieses Fenster demonstriert Color- und Brush-Ressourcen!
// RESSOURCEN-ARTEN:
// 1. Color-Ressource: <Color x:Key="MyColor">#FF0000</Color>
// 2. Brush-Ressource: <SolidColorBrush x:Key="MyBrush" Color="{StaticResource MyColor}"/>
// 3. Gradient-Brushes: <LinearGradientBrush>, <RadialGradientBrush>
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente (Rectangle, Ellipse).
using System.Windows.Shapes;

// Namespace für CommonResources-Demos.
namespace CommonResources {
  /// <summary>
  /// Interaction logic for ColorWindow.xaml
  /// </summary>
  // 'ColorWindow': Fenster für Color/Brush-Ressourcen-Demo.
  // ZWECK: Demonstriert Definition und Verwendung von Color- und Brush-Ressourcen.
  // RESSOURCEN-VORTEILE:
  // - Zentrale Definition von Farben (Theming)
  // - Wiederverwendung ohne Code-Duplikation
  // - Einfache Theme-Änderungen (nur Ressource ändern, nicht jedes Element)
  // - StaticResource vs. DynamicResource (Lookup-Timing)
  // BEISPIEL XAML:
  // <Window.Resources>
  //   <SolidColorBrush x:Key="AccentBrush" Color="Blue"/>
  // </Window.Resources>
  // <Button Background="{StaticResource AccentBrush}"/>
  public partial class ColorWindow : Window {
    // Konstruktor: Initialisiert das Fenster.
    public ColorWindow() {
      // Lädt XAML mit Color/Brush-Ressourcen-Definitionen.
      // XAML-DEMO: Zeigt vermutlich verschiedene Shapes/Buttons mit ressourcenbasierten Farben.
      // RESSOURCEN-LOOKUP: {StaticResource MyBrush} wird zur Compile-Zeit aufgelöst.
      // STATISCHE VS. DYNAMISCHE: StaticResource ist schneller, DynamicResource erlaubt Runtime-Änderungen.
      InitializeComponent();
    }
  }
}
