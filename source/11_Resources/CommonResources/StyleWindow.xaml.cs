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
  /// Interaction logic for StyleWindow.xaml
  /// </summary>
  /// <remarks>
  /// STYLE WINDOW - WPF Styles Demonstration
  /// 
  /// Demonstriert die Definition und Verwendung von Styles in WPF.
  /// Styles sind eine der wichtigsten Resource-Typen für konsistentes UI-Design.
  /// 
  /// STYLE GRUNDLAGEN:
  /// - Container für wiederverwendbare Property-Werte
  /// - Ermöglichen konsistente Formatierung über die gesamte Anwendung
  /// - Vergleichbar mit CSS-Klassen im Web-Development
  /// - Können vererbt werden (BasedOn)
  /// 
  /// STYLE DEFINITION:
  /// <Style x:Key="MyButtonStyle" TargetType="Button">
  ///   <Setter Property="Background" Value="Blue"/>
  ///   <Setter Property="Foreground" Value="White"/>
  ///   <Setter Property="FontSize" Value="14"/>
  ///   <Setter Property="Padding" Value="10,5"/>
  ///   <Setter Property="Margin" Value="5"/>
  /// </Style>
  /// 
  /// TARGETTYPE PROPERTY:
  /// - Gibt den Control-Typ an, für den der Style bestimmt ist
  /// - Ermöglicht Type-Safe Property-Zugriff (IntelliSense in Visual Studio)
  /// - Erforderlich für implizite Styles
  /// - Beispiel: TargetType="Button", TargetType="{x:Type Button}"
  /// 
  /// SETTER:
  /// - Setzen eine einzelne Property auf einen Wert
  /// - Syntax: <Setter Property="PropertyName" Value="PropertyValue"/>
  /// - Können einfache Werte (Strings, Zahlen) oder komplexe Objekte (Brushes, Templates) verwenden
  /// - Werden in der Reihenfolge ihrer Definition angewendet
  /// 
  /// EXPLIZITE VS. IMPLIZITE STYLES:
  /// 
  /// Explizit (mit x:Key):
  /// <Style x:Key="PrimaryButton" TargetType="Button">
  ///   <!-- Setters -->
  /// </Style>
  /// <Button Style="{StaticResource PrimaryButton}" Content="Click"/>
  /// → Muss explizit zugewiesen werden
  /// 
  /// Implizit (ohne x:Key):
  /// <Style TargetType="Button">
  ///   <!-- Setters -->
  /// </Style>
  /// <Button Content="Click"/>
  /// → Wird automatisch auf alle Buttons angewendet
  /// 
  /// STYLE-VERERBUNG MIT BASEDON:
  /// <Style x:Key="BaseButtonStyle" TargetType="Button">
  ///   <Setter Property="Padding" Value="10,5"/>
  ///   <Setter Property="Margin" Value="5"/>
  /// </Style>
  /// 
  /// <Style x:Key="PrimaryButton" TargetType="Button" 
  ///        BasedOn="{StaticResource BaseButtonStyle}">
  ///   <Setter Property="Background" Value="Blue"/>
  ///   <Setter Property="Foreground" Value="White"/>
  /// </Style>
  /// → Erbt alle Setters von BaseButtonStyle und fügt eigene hinzu
  /// 
  /// STYLE-TRIGGER (Erweitert):
  /// <Style TargetType="Button">
  ///   <Setter Property="Background" Value="LightGray"/>
  ///   <Style.Triggers>
  ///     <Trigger Property="IsMouseOver" Value="True">
  ///       <Setter Property="Background" Value="DarkGray"/>
  ///     </Trigger>
  ///   </Style.Triggers>
  /// </Style>
  /// → Ändert Properties basierend auf Bedingungen
  /// 
  /// VORTEILE VON STYLES:
  /// - DRY-Prinzip: Definition einmal, Verwendung mehrfach
  /// - Konsistenz: Alle Controls gleichen Typs sehen gleich aus
  /// - Wartbarkeit: Änderung an einem Ort wirkt sich überall aus
  /// - Zentrales Theming: Alle Styles an einem Ort
  /// </remarks>
  public partial class StyleWindow : Window {
    public StyleWindow() {
      // InitializeComponent() lädt die im XAML definierten Styles
      // Implizite Styles werden automatisch auf alle passenden Controls angewendet
      // Explizite Styles stehen für {StaticResource} Referenzen bereit
      InitializeComponent();
    }
  }
}
