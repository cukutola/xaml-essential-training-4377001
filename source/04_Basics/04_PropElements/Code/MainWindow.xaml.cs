// Importiert grundlegende .NET-Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Importiert WPF-Basistypen
using System.Windows;
// Importiert WPF-Controls
using System.Windows.Controls;
// Importiert WPF-Data-Binding-Klassen
using System.Windows.Data;
// Importiert WPF-Dokument-Klassen
using System.Windows.Documents;
// Importiert WPF-Input-Klassen
using System.Windows.Input;
// Importiert WPF-Media-Klassen
using System.Windows.Media;
// Importiert WPF-Imaging-Klassen
using System.Windows.Media.Imaging;
// Importiert WPF-Navigation-Klassen
using System.Windows.Navigation;
// Importiert WPF-Shapes
using System.Windows.Shapes;

// Namespace für dieses Projekt - demonstriert Property-Element-Syntax
namespace PropertyAttributes {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  // 'public': Diese Hauptfenster-Klasse ist öffentlich zugänglich
  // 'partial': Die Klasse ist aufgeteilt. Der XAML-Compiler generiert den anderen Teil
  // mit Feldern für benannte UI-Elemente und der InitializeComponent-Methode.
  // ': Window': Erbt von der Window-Basisklasse
  public partial class MainWindow : Window {
    // Konstruktor: Wird beim Start der Anwendung aufgerufen
    public MainWindow() {
      // 'InitializeComponent': Lädt und parsed die MainWindow.xaml-Datei
      // In dieser XAML-Datei werden wahrscheinlich Beispiele für Property-Element-Syntax gezeigt:
      // 
      // PROPERTY-ELEMENT-SYNTAX wird verwendet, wenn:
      // 1. Der Property-Wert zu komplex für ein Attribut ist
      // 2. Der Wert ein komplexes Objekt ist (z.B. Gradient, Template)
      // 3. Bessere Lesbarkeit gewünscht ist (z.B. lange Strings)
      // 
      // Syntax: <ElementName>
      //           <ElementName.PropertyName>
      //             <!-- Property-Wert hier -->
      //           </ElementName.PropertyName>
      //         </ElementName>
      // 
      // Beispiel für Gradient:
      // <Rectangle>
      //   <Rectangle.Fill>
      //     <LinearGradientBrush>
      //       <GradientStop Color="Red" Offset="0" />
      //       <GradientStop Color="Blue" Offset="1" />
      //     </LinearGradientBrush>
      //   </Rectangle.Fill>
      // </Rectangle>
      InitializeComponent();
    }
  }
}
