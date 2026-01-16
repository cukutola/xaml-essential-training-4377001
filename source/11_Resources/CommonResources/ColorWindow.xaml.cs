using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CommonResources {
  /// <summary>
  /// Interaction logic for ColorWindow.xaml
  /// </summary>
  /// <remarks>
  /// COLOR WINDOW - Einfache Brush/Color Resources
  /// 
  /// Demonstriert die grundlegendste Form von Resources in WPF:
  /// Color- und Brush-Ressourcen, die in mehreren Controls wiederverwendet werden.
  /// 
  /// COLOR RESOURCES:
  /// - Definieren wiederverwendbare Farbwerte
  /// - Type: System.Windows.Media.Color
  /// - Verwendung: Als Wert für andere Properties oder in Brushes
  /// 
  /// Definition:
  /// <Color x:Key="PrimaryColor">#FF0066CC</Color>
  /// <Color x:Key="AccentColor">Red</Color>
  /// 
  /// Verwendung:
  /// <SolidColorBrush Color="{StaticResource PrimaryColor}"/>
  /// 
  /// BRUSH RESOURCES:
  /// - Definieren wiederverwendbare Pinsel (Brushes)
  /// - Types: SolidColorBrush, LinearGradientBrush, RadialGradientBrush, ImageBrush
  /// - Häufigster Use Case: SolidColorBrush für einheitliche Farben
  /// 
  /// SOLIDCOLORBRUSH DEFINITION:
  /// <SolidColorBrush x:Key="PrimaryBrush" Color="#FF0066CC"/>
  /// <SolidColorBrush x:Key="AccentBrush" Color="Red"/>
  /// 
  /// Oder mit Color-Resource:
  /// <SolidColorBrush x:Key="PrimaryBrush" Color="{StaticResource PrimaryColor}"/>
  /// 
  /// VERWENDUNG VON BRUSH RESOURCES:
  /// <Button Background="{StaticResource PrimaryBrush}" 
  ///         Foreground="{StaticResource AccentBrush}"
  ///         Content="Click Me"/>
  /// 
  /// <Border BorderBrush="{StaticResource PrimaryBrush}" 
  ///         Background="{StaticResource AccentBrush}"/>
  /// 
  /// GRADIENT BRUSHES:
  /// <LinearGradientBrush x:Key="GradientBrush" StartPoint="0,0" EndPoint="1,1">
  ///   <GradientStop Color="Blue" Offset="0"/>
  ///   <GradientStop Color="White" Offset="1"/>
  /// </LinearGradientBrush>
  /// 
  /// VORTEILE VON BRUSH/COLOR RESOURCES:
  /// - Konsistente Farbgebung über die gesamte Anwendung
  /// - Zentrales Color-Theming
  /// - Einfache Änderung: Eine Farbe an einem Ort ändern → wirkt sich überall aus
  /// - Wiederverwendung: Gleiche Brush in vielen Controls
  /// - Wartbarkeit: Corporate Design Colors zentral definiert
  /// 
  /// NAMING CONVENTIONS:
  /// - Semantische Namen: "PrimaryBrush", "AccentBrush", "ErrorBrush"
  /// - Nicht Farbnamen: Verwende "PrimaryBrush" statt "BlueBrush"
  /// - Grund: Bei Theme-Änderung bleibt Name relevant
  /// 
  /// FREEZABLE OPTIMIZATION:
  /// SolidColorBrush ist eine Freezable-Klasse:
  /// - Kann "eingefroren" werden für bessere Performance
  /// - Eingefrorene Brushes können Thread-übergreifend geteilt werden
  /// - WPF friert automatisch Brushes in Resources ein
  /// </remarks>
  public partial class ColorWindow : Window {
    public ColorWindow() {
      // InitializeComponent() lädt die im XAML definierten Color/Brush Resources
      // Alle Controls im Window können diese Resources via {StaticResource} verwenden
      InitializeComponent();
      
      // PROGRAMMATISCHE VERWENDUNG (optional):
      // var primaryBrush = (SolidColorBrush)this.FindResource("PrimaryBrush");
      // this.Background = primaryBrush;
      
      // RUNTIME-ÄNDERUNG:
      // this.Resources["PrimaryBrush"] = new SolidColorBrush(Colors.Green);
      // → Nur bei DynamicResource-Bindings sichtbar
    }
  }
}
