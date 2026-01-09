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

// Namespace für dieses Projekt - demonstriert Event-Handling in Code (Start-Version)
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
      // Dieses Beispiel zeigt die "Start"-Version, bei der Event-Handler-Methoden
      // noch leer sind und implementiert werden müssen.
      InitializeComponent();
    }

    // Event-Handler: Wird aufgerufen, wenn sich das ToolTip öffnet
    // 'private': Nur innerhalb dieser Klasse sichtbar (typisch für Event-Handler)
    // 'void': Gibt keinen Wert zurück (Standardsignatur für Event-Handler)
    // 'object sender': Das UI-Element, das das Event ausgelöst hat (hier: TitleTextBlock)
    // 'ToolTipEventArgs e': Event-spezifische Informationen für ToolTip-Events
    // Kann verwendet werden, um das Öffnen des ToolTips zu verhindern (e.Handled = true)
    private void TitleTextBlock_ToolTipOpening(object sender, ToolTipEventArgs e) {
      // Bewusst leer in dieser Start-Version.
      // Hier könnte z.B. der ToolTip-Inhalt dynamisch gesetzt werden:
      // var textBlock = sender as TextBlock;
      // textBlock.ToolTip = "Dynamischer Inhalt";
    }

    // Event-Handler: Wird aufgerufen, wenn sich der Text in der TextBox ändert
    // 'TextChangedEventArgs e': Enthält Informationen über die Änderung
    // (z.B. e.Changes für hinzugefügte/entfernte Zeichen)
    private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
      // Bewusst leer in dieser Start-Version.
      // Hier könnte z.B. eine Validierung oder Live-Suche implementiert werden:
      // var textBox = sender as TextBox;
      // var text = textBox.Text;
    }

    // Event-Handler: Wird aufgerufen, wenn sich die Auswahl in der ListBox ändert
    // 'SelectionChangedEventArgs e': Enthält Informationen über die Änderung
    // - e.AddedItems: Neu ausgewählte Items
    // - e.RemovedItems: Abgewählte Items
    private void TourListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
      // Bewusst leer in dieser Start-Version.
      // Hier könnte z.B. das ausgewählte Item verarbeitet werden:
      // var listBox = sender as ListBox;
      // var selectedItem = listBox.SelectedItem;
    }

    // Event-Handler: Wird aufgerufen, wenn ein Button geklickt wird
    // 'RoutedEventArgs e': Basisklasse für routed events in WPF
    // - e.Source: Das ursprüngliche Element, das das Event ausgelöst hat
    // - e.OriginalSource: Das Element, das das Event als erstes empfangen hat
    // - e.Handled: Kann auf true gesetzt werden, um Event-Bubbling zu stoppen
    private void Button_Click(object sender, RoutedEventArgs e) {
      // 'as': Sichere Typumwandlung, gibt null zurück, wenn Umwandlung fehlschlägt
      // Hier wird der sender zu Button gecastet, um auf Button-spezifische Properties zuzugreifen
      var b = sender as Button;
      // Bewusst leer in dieser Start-Version.
      // Hier könnte z.B. eine Aktion basierend auf dem Button-Content ausgeführt werden:
      // if (b != null) { MessageBox.Show(b.Content.ToString()); }
    }

    // Event-Handler: Wird aufgerufen, wenn sich die Maus über dem Rectangle bewegt
    // 'MouseEventArgs e': Enthält Informationen über die Mausposition und -tasten
    // - e.GetPosition(element): Gibt die Mausposition relativ zu einem Element zurück
    // - e.LeftButton, e.RightButton: Status der Maustasten
    // HINWEIS: MouseMove-Events feuern sehr häufig (bei jeder kleinsten Bewegung)!
    // Performanceintensive Operationen sollten hier vermieden werden.
    private void Rectangle_MouseMove(object sender, MouseEventArgs e) {
      // Bewusst leer in dieser Start-Version.
      // Hier könnte z.B. die Mausposition angezeigt werden:
      // var position = e.GetPosition(this);
      // MessageTextBlock.Text = $"X: {position.X}, Y: {position.Y}";
    }
  }
}
