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

// Namespace für dieses Projekt - demonstriert Event-Handling in Code (Done-Version)
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
      // Dabei werden auch Event-Handler registriert, die in XAML definiert sind.
      // Diese "Done"-Version zeigt die implementierten Event-Handler.
      InitializeComponent();
    }

    // Event-Handler: Wird aufgerufen, wenn sich das ToolTip öffnet
    // 'private': Nur innerhalb dieser Klasse sichtbar (typisch für Event-Handler)
    // 'void': Gibt keinen Wert zurück (Standardsignatur für Event-Handler)
    // 'object sender': Das UI-Element, das das Event ausgelöst hat (hier: TitleTextBlock)
    // 'ToolTipEventArgs e': Event-spezifische Informationen für ToolTip-Events
    private void TitleTextBlock_ToolTipOpening(object sender, ToolTipEventArgs e) {
      // Bewusst leer. Wird nur als Beispiel für Event-Handler-Registrierung verwendet.
    }

    // Event-Handler: Wird aufgerufen, wenn sich der Text in der TextBox ändert
    // 'TextChangedEventArgs e': Enthält Informationen über die Textänderung
    private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
      // Bewusst leer. Wird nur als Beispiel für Event-Handler-Registrierung verwendet.
    }

    // Event-Handler: Wird aufgerufen, wenn sich die Auswahl in der ListBox ändert
    // Dieses Beispiel zeigt eine typische Implementierung für SelectionChanged
    private void TourListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
      // 'as ListBoxItem': Sichere Typumwandlung des ausgewählten Items
      // SelectedItem gibt object zurück, daher muss es zum konkreten Typ gecastet werden
      var item = TourListBox.SelectedItem as ListBoxItem;
      
      // 'String.Format mit $': String-Interpolation (moderne C#-Syntax)
      // Erstellt eine formatierte Nachricht mit dem Content des ausgewählten Items
      string message = String.Format($"You'll love our {item.Content.ToString()} tour ");
      
      // 'MessageTextBlock.Text': Setzt den Text eines benannten TextBlocks
      // MessageTextBlock muss in XAML mit x:Name="MessageTextBlock" definiert sein
      // Der XAML-Compiler generiert automatisch ein Feld dafür in der partial-Klasse
      MessageTextBlock.Text = message;
    }

    // Event-Handler: Wird aufgerufen, wenn ein Button geklickt wird
    // Zeigt verschiedene Event-Handler-Techniken
    private void Button_Click(object sender, RoutedEventArgs e) {
      // 'as Button': Sichere Typumwandlung von object zu Button
      var b = sender as Button;
      
      // 'if (b != null)': Null-Check vor Zugriff auf Properties
      // WICHTIG: Immer prüfen, ob die Typumwandlung erfolgreich war!
      if (b!= null)
      {
        // Greift auf Button.Content zu und zeigt es in MessageTextBlock an
        // Content kann verschiedene Typen haben (string, UIElement, etc.)
        // .ToString() konvertiert es zu einem anzeigbaren String
        MessageTextBlock.Text = b.Content.ToString();
      }
      // Alternative moderne Syntax (C# 6+): b?.Content?.ToString()
      // Der ?. Operator prüft automatisch auf null
    }

    // Event-Handler: Wird aufgerufen, wenn sich die Maus über dem Rectangle bewegt
    // MouseMove-Events feuern sehr häufig - Vorsicht bei performanceintensiven Operationen!
    private void Rectangle_MouseMove(object sender, MouseEventArgs e) {
      // 'e.GetPosition(this)': Gibt die Mausposition relativ zu diesem Fenster zurück
      // 'this' bezieht sich auf das MainWindow
      // Alternative: e.GetPosition(sender as IInputElement) für Position relativ zum Rectangle
      string message = String.Format($"{e.GetPosition(this).X}-{e.GetPosition(this).Y}");
      
      // Zeigt die aktuelle Mausposition im MessageTextBlock an
      // HINWEIS: Dies wird sehr häufig aktualisiert und könnte die UI-Performance beeinträchtigen
      MessageTextBlock.Text = message;
    }
  }
}
