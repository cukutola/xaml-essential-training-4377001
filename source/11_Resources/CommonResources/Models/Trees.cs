using System;
using System.Collections.ObjectModel;

namespace Models {

  /// <summary>
  /// Trees Collection - ObservableCollection für Data Binding
  /// </summary>
  /// <remarks>
  /// OBSERVABLECOLLECTION DEMONSTRATION
  /// 
  /// Diese Klasse demonstriert die Verwendung von ObservableCollection für Data Binding in WPF.
  /// ObservableCollection ist die Standard-Collection-Klasse für MVVM und Data Binding.
  /// 
  /// OBSERVABLECOLLECTION GRUNDLAGEN:
  /// - Implementiert INotifyCollectionChanged
  /// - Benachrichtigt UI automatisch bei Änderungen (Add, Remove, Clear, etc.)
  /// - Erforderlich für automatische UI-Updates bei Collection-Änderungen
  /// - Ideal für ItemsControls (ListBox, ComboBox, DataGrid, etc.)
  /// 
  /// WARUM OBSERVABLECOLLECTION?:
  /// 
  /// List<T> (normale Liste):
  /// - Keine UI-Benachrichtigung bei Add/Remove
  /// - UI wird nicht automatisch aktualisiert
  /// - Nur geeignet für statische Daten
  /// 
  /// ObservableCollection<T>:
  /// - Automatische UI-Benachrichtigung bei Add/Remove/Clear
  /// - UI aktualisiert sich automatisch
  /// - Ideal für dynamische Daten
  /// 
  /// VERWENDUNG IN XAML:
  /// <ListBox ItemsSource="{Binding Trees}"/>
  /// → Bei trees.Add(new Tree()) wird UI automatisch aktualisiert
  /// 
  /// INOTIFYCOLLECTIONCHANGED:
  /// - Interface für Collection-Änderungsbenachrichtigungen
  /// - Events: Add, Remove, Replace, Move, Reset
  /// - Wird von WPF's Data Binding Engine überwacht
  /// 
  /// CONSTRUCTOR-PATTERN:
  /// Initialisiert die Collection mit Beispieldaten im Constructor.
  /// Alternativ: Externe Initialisierung oder Datenbank-Load.
  /// </remarks>
  internal class Trees : ObservableCollection<Tree> {

    /// <summary>
    /// Constructor - Initialisiert die Collection mit Beispiel-Baumdaten
    /// </summary>
    public Trees() {
      // ADD-METHODE: Fügt Items zur ObservableCollection hinzu
      // Jedes Add() triggert CollectionChanged-Event
      // → Gebundene UI-Controls (ListBox, etc.) werden automatisch aktualisiert
      
      this.Add(new Tree { TreeName = "Fir", MaxHeight = 90 });
      this.Add(new Tree { TreeName = "Oak", MaxHeight = 60 });
      this.Add(new Tree { TreeName = "Pine", MaxHeight = 85 });
      this.Add(new Tree { TreeName = "Palm", MaxHeight = 25 });
      this.Add(new Tree { TreeName = "Cedar", MaxHeight = 95 });

      // WEITERE OBSERVABLECOLLECTION-METHODEN (Beispiele):
      // this.Remove(tree); → Entfernt Item, UI aktualisiert sich
      // this.Clear(); → Entfernt alle Items, UI aktualisiert sich
      // this.Insert(0, tree); → Fügt an Position ein, UI aktualisiert sich
      // this[0] = newTree; → Ersetzt Item, UI aktualisiert sich
      
      // WICHTIG:
      // Änderungen an Properties innerhalb der Tree-Objekte (z.B. tree.TreeName = "New")
      // werden NICHT automatisch erkannt. Dafür muss Tree selbst INotifyPropertyChanged implementieren!
    }

    // BEST PRACTICES:
    // 1. Verwende ObservableCollection für UI-gebundene Collections
    // 2. Verwende List<T> für interne, nicht-UI Collections
    // 3. Für Property-Änderungen in Items: Items müssen INotifyPropertyChanged implementieren
    // 4. Thread-Safety: ObservableCollection ist NICHT thread-safe
    //    → UI-Updates nur vom UI-Thread: Dispatcher.Invoke(() => trees.Add(item))
  }
  
  /// <summary>
  /// Tree Model - Repräsentiert einen einzelnen Baum
  /// </summary>
  /// <remarks>
  /// EINFACHES MODEL-OBJEKT
  /// 
  /// Diese Klasse ist ein einfaches Datenobjekt (POCO - Plain Old CLR Object).
  /// 
  /// PROPERTY GETTER/SETTER:
  /// - Auto-Properties mit { get; set; }
  /// - Keine INotifyPropertyChanged-Implementierung (einfaches Beispiel)
  /// 
  /// ERWEITERT MIT INOTIFYPROPERTYCHANGED (Best Practice für WPF):
  /// public class Tree : INotifyPropertyChanged {
  ///     private string _treeName;
  ///     public string TreeName {
  ///         get => _treeName;
  ///         set {
  ///             _treeName = value;
  ///             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TreeName)));
  ///         }
  ///     }
  ///     
  ///     public event PropertyChangedEventHandler PropertyChanged;
  /// }
  /// 
  /// VERWENDUNG IN DATATEMPLATES:
  /// <DataTemplate DataType="{x:Type local:Tree}">
  ///   <StackPanel>
  ///     <TextBlock Text="{Binding TreeName}"/>
  ///     <TextBlock Text="{Binding MaxHeight}"/>
  ///   </StackPanel>
  /// </DataTemplate>
  /// </remarks>
  internal class Tree {
    /// <summary>
    /// Name des Baums
    /// </summary>
    public string TreeName { get; set; }
    
    /// <summary>
    /// Maximale Höhe in Fuß
    /// </summary>
    public int MaxHeight { get; set; }
  }
}