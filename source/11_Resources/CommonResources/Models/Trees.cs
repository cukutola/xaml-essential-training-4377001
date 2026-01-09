// Standard .NET Namespaces.
using System;
// System.Collections.ObjectModel: ObservableCollection für Data Binding.
// WICHTIG: ObservableCollection ist die Standardklasse für bindbare Collections in WPF!
using System.Collections.ObjectModel;

// Namespace für Datenmodelle in der CommonResources-Demo.
namespace Models {

  // 'Trees': Collection von Tree-Objekten, erbt von ObservableCollection.
  // ': ObservableCollection<Tree>': Basisklasse für observable, bindbare Collections.
  // OBSERVABLE COLLECTION: Implementiert INotifyCollectionChanged automatisch.
  // VORTEIL: UI updates automatisch bei Add/Remove/Clear - KEIN manueller Code nötig!
  // UNTERSCHIED zu List<T>: List sendet keine Change-Notifications an UI.
  // EINSATZZWECK: ItemsSource für ListBox, ComboBox, DataGrid in WPF.
  // BINDING-BEISPIEL: <ListBox ItemsSource="{Binding}" /> mit DataContext = new Trees()
  internal class Trees : ObservableCollection<Tree> {

    // Konstruktor: Initialisiert Collection mit Demo-Daten.
    // 'internal': Nur innerhalb dieser Assembly sichtbar, nicht für andere Projekte.
    // PATTERN: Seed-Data für Demos und Prototypen.
    public Trees() {
      // 'Add': Fügt Tree-Objekt zur Collection hinzu.
      // EFFEKT: INotifyCollectionChanged.CollectionChanged Event wird gefeuert.
      // UI-UPDATE: Gebundene Controls (ListBox, etc.) fügen automatisch neues Item hinzu.
      // OBJECT INITIALIZER: { TreeName = "...", MaxHeight = ... } setzt Properties direkt.
      this.Add(new Tree { TreeName = "Fir", MaxHeight = 90 });
      this.Add(new Tree { TreeName = "Oak", MaxHeight = 60 });
      this.Add(new Tree { TreeName = "Pine", MaxHeight = 85 });
      this.Add(new Tree { TreeName = "Palm", MaxHeight = 25 });
      this.Add(new Tree { TreeName = "Cedar", MaxHeight = 95 });

      // DEMO-DATEN: Verschiedene Baumarten mit maximalen Höhen in Metern.
      // VERWENDUNG: Wird in DataTemplateWindow oder DataWindow als ItemsSource gebunden.
    }

    
  }
  
  // 'Tree': Datenmodell für einen einzelnen Baum.
  // SIMPLE POCO: Plain Old CLR Object ohne INotifyPropertyChanged.
  // HINWEIS: Properties sind nicht observable - nur für Read-Only-Daten geeignet.
  // FÜR EDITABLE DATA: Sollte INotifyPropertyChanged implementieren.
  internal class Tree {
    // 'TreeName': Name des Baums (z.B. "Oak", "Pine").
    // AUTO-PROPERTY: Compiler generiert automatisch Backing-Field.
    // 'get; set;': Öffentlicher Getter und Setter.
    // BINDING: Kann in XAML gebunden werden: {Binding TreeName}
    public string TreeName { get; set; }
    
    // 'MaxHeight': Maximale Höhe des Baums in Metern.
    // 'int': Ganzzahl-Typ für Höhenangaben.
    // BINDING-BEISPIEL: {Binding MaxHeight} zeigt Zahl an.
    // FORMATTING: In XAML formatierbar: {Binding MaxHeight, StringFormat={}{0}m}
    public int MaxHeight { get; set; }
  }
}