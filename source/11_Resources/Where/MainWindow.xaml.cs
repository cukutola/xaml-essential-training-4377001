using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WhereResource {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  /// <remarks>
  /// HAUPTFENSTER - Programmatische Resource-Definition
  /// 
  /// Demonstriert die programmatische Erstellung und Zuweisung von Resources
  /// im Code-Behind als Alternative zur XAML-Definition.
  /// 
  /// PROGRAMMATISCHE VS. XAML RESOURCE-DEFINITION:
  /// 
  /// Code-Behind (wie hier):
  /// + Dynamische Erstellung basierend auf Runtime-Bedingungen
  /// + Programmatische Logik möglich
  /// + Nützlich für berechnete Werte
  /// - Weniger deklarativ
  /// - Schwieriger zu warten
  /// - Keine Design-Zeit-Vorschau
  /// 
  /// XAML:
  /// + Deklarativ und übersichtlich
  /// + Design-Zeit-Vorschau in Visual Studio
  /// + Einfacher zu warten
  /// + Standard-Ansatz
  /// - Statisch (keine Runtime-Logik)
  /// 
  /// WANN CODE-BEHIND RESOURCE-DEFINITION VERWENDEN:
  /// - Theme-Loading basierend auf Benutzereinstellungen
  /// - Ressourcen-Generierung basierend auf Datenbank-Werten
  /// - Dynamische Style-Generierung
  /// - Plugin-Systeme mit Runtime-Resources
  /// </remarks>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();

      // ERSTELLEN EINES NEUEN RESOURCEDICTIONARY
      // Alternative zu <Window.Resources> in XAML
      var dictionary = new ResourceDictionary();

      // HINZUFÜGEN VON RESOURCES
      // MainBrush: Lavender-farbener SolidColorBrush
      // Kann in XAML referenziert werden: {StaticResource MainBrush} oder {DynamicResource MainBrush}
      dictionary.Add(key: "MainBrush", value: new SolidColorBrush(Colors.Lavender));
      
      // AccentBrush: Gold-farbener SolidColorBrush
      // Typischerweise für Hervorhebungen und Akzente verwendet
      dictionary.Add(key: "AccentBrush", value: new SolidColorBrush(Colors.Gold));

      // WEITERE MÖGLICHE RESOURCE-TYPEN (Beispiele):
      // Styles:
      // var buttonStyle = new Style(typeof(Button));
      // buttonStyle.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Blue));
      // dictionary.Add("MyButtonStyle", buttonStyle);
      //
      // DataTemplates:
      // var template = new DataTemplate();
      // dictionary.Add("MyTemplate", template);
      //
      // Converter:
      // dictionary.Add("MyConverter", new MyValueConverter());

      // ZUWEISUNG ZUR WINDOW.RESOURCES PROPERTY
      // Ersetzt alle in XAML definierten Window.Resources
      // StaticResource-Referenzen im XAML werden nun mit diesen Resources aufgelöst
      this.Resources = dictionary;
      
      // ALTERNATIVE: ERGÄNZEN STATT ERSETZEN
      // this.Resources.Add("MainBrush", new SolidColorBrush(Colors.Lavender));
      // → Behält XAML-definierte Resources und fügt neue hinzu
      
      // ALTERNATIVE: MERGEDDICTIONARIES
      // this.Resources.MergedDictionaries.Add(dictionary);
      // → Sauberere Trennung zwischen XAML- und Code-Resources


    }
  }
}
