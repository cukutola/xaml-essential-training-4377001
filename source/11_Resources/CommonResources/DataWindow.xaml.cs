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
  /// Interaction logic for DataWindow.xaml
  /// </summary>
  /// <remarks>
  /// DATA WINDOW - Daten ohne Custom DataTemplate
  /// 
  /// Demonstriert wie Datenobjekte OHNE DataTemplate dargestellt werden.
  /// Zeigt den Unterschied zum DataTemplateWindow, wo Custom Templates verwendet werden.
  /// 
  /// STANDARD-RENDERING OHNE DATATEMPLATE:
  /// - WPF ruft ToString() auf dem Datenobjekt auf
  /// - Zeigt typischerweise nur den Typ-Namen (z.B. "Models.Tree")
  /// - Keine benutzerdefinierte Darstellung
  /// - Nicht benutzerfreundlich für komplexe Objekte
  /// 
  /// BEISPIEL OHNE DATATEMPLATE:
  /// <ListBox ItemsSource="{Binding Trees}"/>
  /// → Zeigt: "Models.Tree", "Models.Tree", ...
  /// 
  /// ITEMSSOURCE BINDING:
  /// - Bindet eine Collection (z.B. ObservableCollection<Tree>) an ein ItemsControl
  /// - Jedes Item in der Collection wird als separates ListBoxItem dargestellt
  /// - Ohne ItemTemplate: Standard-Darstellung (ToString())
  /// - Mit ItemTemplate: Custom DataTemplate-Darstellung
  /// 
  /// CONTENTCONTROL OHNE CONTENTTEMPLATE:
  /// <ContentControl Content="{Binding SelectedTree}"/>
  /// → Zeigt: "Models.Tree" (ToString()-Ausgabe)
  /// 
  /// WARUM DIESES FENSTER?:
  /// Demonstrationszweck - Vergleich mit DataTemplateWindow:
  /// - Hier: Standard-Rendering (nicht benutzerfreundlich)
  /// - DataTemplateWindow: Custom DataTemplate (benutzerfreundlich)
  /// → Zeigt den Wert von DataTemplates
  /// 
  /// VERBESSERUNG MIT TOSTRING()-OVERRIDE:
  /// public class Tree {
  ///     public string TreeName { get; set; }
  ///     public int MaxHeight { get; set; }
  ///     
  ///     public override string ToString() {
  ///         return $"{TreeName} - {MaxHeight} feet";
  ///     }
  /// }
  /// → Bessere Standard-Darstellung, aber immer noch limitiert
  /// 
  /// BESSERE LÖSUNG - DATATEMPLATE:
  /// Siehe DataTemplateWindow.xaml für Custom DataTemplate-Implementierung
  /// </remarks>
  public partial class DataWindow : Window {
    public DataWindow() {
      // InitializeComponent() lädt das XAML
      // Wenn eine Datenquelle gebunden ist (z.B. via DataContext),
      // werden die Daten mit Standard-Rendering (ToString()) angezeigt
      InitializeComponent();
      
      // TYPISCHE DATACONTEXT-ZUWEISUNG:
      // this.DataContext = new TreesViewModel();
      // 
      // Ohne DataTemplate würde eine ListBox dann zeigen:
      // - Models.Tree
      // - Models.Tree
      // - Models.Tree
      // 
      // Mit DataTemplate (siehe DataTemplateWindow):
      // - Fir - 90 feet
      // - Oak - 60 feet
      // - Pine - 85 feet
    }
  }
}
