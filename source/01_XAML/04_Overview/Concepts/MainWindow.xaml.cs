// 'using': Importiert Namespaces für den Zugriff auf benötigte Typen ohne vollqualifizierte Namen.
using System;
using System.Collections.Generic;
// 'System.Linq': Ermöglicht LINQ-Abfragen (Where, Select, OrderBy) auf Objektsammlungen.
using System.Linq;
// 'System.Text': Bietet StringBuilder und Encoding-Klassen für Textverarbeitung.
using System.Text;
// 'System.Windows': WPF-Kernnamespace mit Window, Application, DependencyObject, UIElement.
using System.Windows;
// 'System.Windows.Controls': Enthält alle Standard-Steuerelemente (Button, TextBox, ListBox, etc.).
using System.Windows.Controls;
// 'System.Windows.Data': Bietet Binding-Klassen für die Datenbindung zwischen UI und Datenmodellen.
using System.Windows.Data;
// 'System.Windows.Documents': Stellt Dokumentklassen bereit (FlowDocument, Paragraph, Run).
using System.Windows.Documents;
// 'System.Windows.Input': Enthält Input-bezogene Klassen (Keyboard, Mouse, Commands, Gestures).
using System.Windows.Input;
// 'System.Windows.Media': Bietet Klassen für 2D-Grafik (Brushes, Pens, Geometries, Transforms).
using System.Windows.Media;
// 'System.Windows.Media.Imaging': Enthält Klassen für Bildverarbeitung (BitmapImage, BitmapSource).
using System.Windows.Media.Imaging;
// 'System.Windows.Navigation': Stellt Navigationsklassen für Page-basierte Anwendungen bereit.
using System.Windows.Navigation;
// 'System.Windows.Shapes': Bietet vordefinierte Formen (Rectangle, Ellipse, Path, Polygon).
using System.Windows.Shapes;

namespace Concepts {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  // 'public': Macht die Klasse außerhalb des Assemblys zugänglich - erforderlich für XAML-Instanziierung.
  // 'partial': Klassendefinition ist auf mehrere Dateien verteilt. Der XAML-Parser generiert
  // automatisch den zweiten Teil mit Feldern für benannte UI-Elemente (x:Name) und 
  // der InitializeComponent()-Methode.
  // ': Window': Erbt von der WPF-Window-Klasse, die ein Anwendungsfenster repräsentiert.
  // Window bietet Titel, Größe, Position, Zustand (minimiert/maximiert), Menüleiste und
  // Ereignisse wie Loaded, Closing, Closed. Es kann nur EIN Kind-Element enthalten (meist Grid/Panel).
  public partial class MainWindow : Window {
    // Konstruktor: Wird beim Erstellen einer MainWindow-Instanz aufgerufen.
    // EINSATZZWECK: Hier werden UI-Komponenten initialisiert und Event-Handler registriert.
    public MainWindow() {
      // 'InitializeComponent()': KRITISCH! Vom XAML-Compiler generierte Methode.
      // FUNKTION: 
      // 1. Lädt und parst die zugehörige XAML-Datei (MainWindow.xaml)
      // 2. Erstellt alle UI-Elemente aus dem XAML-Markup
      // 3. Verbindet Event-Handler aus XAML mit Code-Behind-Methoden
      // 4. Weist benannten Elementen (x:Name="myButton") ihre Feldverweise zu
      // 5. Setzt DataContext und andere XAML-definierte Eigenschaften
      // WICHTIG: Muss IMMER als erste Anweisung im Konstruktor aufgerufen werden,
      // bevor auf UI-Elemente zugegriffen wird, sonst sind diese null!
      InitializeComponent();
      
      // Nach InitializeComponent() können hier weitere Initialisierungen erfolgen:
      // - Event-Handler programmatisch hinzufügen
      // - Daten laden und DataContext setzen
      // - UI-Elemente konfigurieren, die nicht in XAML definiert sind
    }
  }
}
