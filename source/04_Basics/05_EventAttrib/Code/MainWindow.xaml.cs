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
// Importiert WPF-Input-Klassen (MouseEventArgs, KeyboardEventArgs, etc.)
using System.Windows.Input;
// Importiert WPF-Media-Klassen
using System.Windows.Media;
// Importiert WPF-Imaging-Klassen
using System.Windows.Media.Imaging;
// Importiert WPF-Navigation-Klassen
using System.Windows.Navigation;
// Importiert WPF-Shapes
using System.Windows.Shapes;

// Namespace für dieses Projekt - demonstriert Event-Attribute in XAML
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
      // Dabei werden auch Event-Handler registriert, die in XAML als Attribute definiert sind:
      // 
      // EVENT-ATTRIBUT-SYNTAX in XAML:
      // <Button Click="ButtonName_Click" />
      // 
      // WIE ES FUNKTIONIERT:
      // 1. Der XAML-Parser findet das Event-Attribut (z.B. "Click")
      // 2. Er sucht im Code-Behind nach einer Methode mit dem angegebenen Namen
      // 3. Er registriert diese Methode als Event-Handler mittels += Operator
      // 4. Entspricht in C#: button.Click += ButtonName_Click;
      // 
      // EVENT-HANDLER-SIGNATUR:
      // - Muss 'void' zurückgeben
      // - Benötigt zwei Parameter: (object sender, EventArgs e)
      // - sender: Das UI-Element, das das Event ausgelöst hat
      // - e: Event-spezifische Informationen (z.B. MouseEventArgs mit Position)
      InitializeComponent();
    }

  
  }
}
