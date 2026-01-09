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
  /// Interaction logic for DataWindow.xaml
  /// </summary>
  // 'DataWindow': Fenster für Daten-Ressourcen-Demo.
  // ZWECK: Demonstriert Definition und Verwendung von Daten-Objekten als Ressourcen.
  // DATEN-RESSOURCEN: Objekt-Instanzen im ResourceDictionary speichern.
  // EINSATZZWECK: Gemeinsame Datenquellen, Lookup-Tables, Enumerations, Konstanten.
  // BEISPIEL XAML:
  // <Window.Resources>
  //   <models:Trees x:Key="TreeData"/>
  // </Window.Resources>
  // <ListBox ItemsSource="{StaticResource TreeData}"/>
  // VORTEIL: Daten sind in XAML definiert, nicht im Code-Behind - deklarativer Ansatz.
  // VERWENDUNG: FindResource("TreeData") in Code oder {StaticResource TreeData} in XAML.
  public partial class DataWindow : Window {
    // Konstruktor: Initialisiert das Fenster.
    public DataWindow() {
      // Lädt XAML mit Daten-Ressourcen-Definitionen.
      // XAML-DEMO: Zeigt vermutlich ListBox oder ComboBox mit Trees-Collection als Ressource.
      // RESSOURCEN-DEFINITION: xmlns:models="clr-namespace:Models" für Trees-Klasse.
      // DATA-BINDING: ItemsSource bindet an Ressource, DisplayMemberPath zeigt Property an.
      InitializeComponent();
    }
  }
}
