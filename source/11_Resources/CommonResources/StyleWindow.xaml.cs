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
// System.Windows.Media: 2D-Grafik, Brushes.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;

// Namespace für CommonResources-Demos.
namespace CommonResources {
  /// <summary>
  /// Interaction logic for StyleWindow.xaml
  /// </summary>
  // 'StyleWindow': Fenster für Style-Ressourcen-Demo.
  // ZWECK: Demonstriert Definition und Anwendung von Styles.
  // STYLE-KONZEPT: Sammlung von Property-Settern, die auf Controls angewendet werden.
  // STYLE-VORTEILE:
  // - Konsistentes Look & Feel ohne Code-Duplikation
  // - Zentrale Wartung (eine Änderung betrifft alle Controls)
  // - Wiederverwendbarkeit (x:Key für explizite, TargetType für implizite Styles)
  // - Vererbung (BasedOn="{StaticResource BaseStyle}")
  // BEISPIEL XAML:
  // <Window.Resources>
  //   <Style x:Key="BlueButtonStyle" TargetType="Button">
  //     <Setter Property="Background" Value="Blue"/>
  //     <Setter Property="Foreground" Value="White"/>
  //     <Setter Property="FontSize" Value="16"/>
  //   </Style>
  // </Window.Resources>
  // <Button Style="{StaticResource BlueButtonStyle}" Content="Click"/>
  // IMPLIZITE STYLES: Style ohne x:Key wird automatisch auf alle TargetType-Controls angewendet.
  public partial class StyleWindow : Window {
    // Konstruktor: Initialisiert das Fenster.
    public StyleWindow() {
      // Lädt XAML mit Style-Definitionen.
      // XAML-DEMO: Zeigt vermutlich mehrere Buttons/Controls mit verschiedenen Styles.
      // STYLE-ANWENDUNG: Explicit (Style="{StaticResource MyStyle}") oder Implicit (TargetType).
      // SETTER: Setzen DependencyProperty-Werte (Background, FontSize, Margin, etc.).
      // TRIGGERS: EventTrigger, DataTrigger, MultiDataTrigger für dynamisches Styling.
      InitializeComponent();
    }
  }
}
