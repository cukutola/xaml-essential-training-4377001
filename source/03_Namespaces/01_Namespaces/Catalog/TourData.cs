// ===== .NET STANDARD-NAMESPACES =====
// Standard .NET Namespaces für grundlegende Funktionalität.
// Diese werden für grundlegende Datenstrukturen und LINQ benötigt.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ===== DATENKLASSEN UND NAMESPACES =====
// Anwendungs-Namespace: Demonstriert Namespace-Konzepte in WPF/XAML.
// 
// KONTEXT: Diese Datei zeigt, wie Datenklassen in Namespaces organisiert werden.
// 
// WICHTIGE KONZEPTE:
// 
// 1. DATENKLASSEN IN XAML VERWENDEN:
//    - Datenklassen (ohne UI) können in XAML als Datenquellen dienen
//    - xmlns:local="clr-namespace:UnderstandNamespaces"
//    - Beispiel: <local:TourData /> als Ressource oder DataContext
// 
// 2. NAMESPACE-ORGANISATION:
//    - UI-Klassen (Window, UserControl) und Datenklassen im gleichen Namespace
//    - ALTERNATIVE: Separate Namespaces (UnderstandNamespaces.Models, etc.)
//    - VORTEIL gleicher Namespace: Einfachere XAML-Referenzierung
//    - VORTEIL getrennter Namespace: Bessere logische Trennung
// 
// 3. VERWENDUNG IN XAML (Beispiele):
//    
//    A) Als Ressource:
//       <Window.Resources>
//         <local:TourData x:Key="tourData" TourName="Summer Tour" />
//       </Window.Resources>
//    
//    B) Als DataContext:
//       <Window xmlns:local="clr-namespace:UnderstandNamespaces">
//         <Window.DataContext>
//           <local:TourData TourName="Summer Tour" />
//         </Window.DataContext>
//       </Window>
//    
//    C) Als ItemsSource (Collection):
//       <ListBox ItemsSource="{Binding TourList}" />
//       // TourList ist List<TourData>
// 
// 4. NAMESPACE FÜR DATENKLASSEN:
//    - Gleicher Namespace wie UI-Klassen: UnderstandNamespaces
//    - XAML-Deklaration: xmlns:local="clr-namespace:UnderstandNamespaces"
//    - VORTEIL: Eine xmlns-Deklaration für UI und Daten
//    - VERWENDUNG: <local:TourData /> und <local:MainWindow />
namespace UnderstandNamespaces {
  
  // ===== DATENKLASSE (POCO - Plain Old CLR Object) =====
  // 'public class': Öffentliche Datenklasse ohne UI-Komponenten.
  // 
  // ZWECK:
  // - Repräsentiert eine Tour (Konzert/Veranstaltung)
  // - Kapselt tourenbezogene Daten
  // - Trennt Datenmodell von UI-Logik (MVVM-Pattern)
  // 
  // EINSATZZWECK IN WPF:
  // - Datenquelle für Data Binding
  // - ItemsSource für ListBox, DataGrid, ComboBox
  // - DataContext für Window oder UserControl
  // - Collection-Element (List<TourData>, ObservableCollection<TourData>)
  // 
  // XAML-INSTANZIIERUNG:
  //   <local:TourData 
  //     TourName="Summer Festival 2024"
  //     StartDate="2024-06-15"
  //     City="Berlin" />
  // 
  // XAML-BINDING:
  //   <TextBlock Text="{Binding TourName}" />
  //   <TextBlock Text="{Binding StartDate}" />
  //   <TextBlock Text="{Binding City}" />
  // 
  // NAMESPACE-KONTEXT:
  // - Teil von UnderstandNamespaces (gleich wie Window-Klassen)
  // - In XAML referenzierbar über xmlns:local="clr-namespace:UnderstandNamespaces"
  // - Keine separate xmlns-Deklaration nötig
  public class TourData {
    
    // ===== AUTO-PROPERTIES =====
    // 'Auto-Property': Kompakte Property-Syntax mit automatischem Backing-Field.
    // 
    // SYNTAX:
    //   public Type PropertyName { get; set; }
    // 
    // COMPILER GENERIERT:
    //   private string _tourName;  // Backing-Field (automatisch)
    //   public string TourName {
    //     get { return _tourName; }
    //     set { _tourName = value; }
    //   }
    // 
    // WICHTIG FÜR WPF DATA BINDING:
    // - 'public' → Property ist von außen sichtbar
    // - 'get' → Property kann gelesen werden (für UI-Anzeige)
    // - 'set' → Property kann geschrieben werden (für UI-Eingabe)
    // - BEIDE (get/set) ermöglichen bidirektionales Binding
    // 
    // EINSCHRÄNKUNG:
    // - Auto-Properties feuern KEINE PropertyChanged-Events
    // - Änderungen werden nicht automatisch an UI propagiert
    // - FÜR DYNAMISCHE UPDATES: INotifyPropertyChanged implementieren
    // 
    // FÜR STATISCHE DATEN (wie hier) ist Auto-Property ausreichend:
    // - Daten werden einmal gesetzt (im Konstruktor oder XAML)
    // - Keine nachträglichen Änderungen erwartet
    // - UI muss nicht über Änderungen benachrichtigt werden
    
    // 'TourName': Name der Tour/des Konzerts.
    // 
    // XAML-INSTANZIIERUNG:
    //   <local:TourData TourName="Summer Festival 2024" />
    // 
    // XAML-BINDING (Anzeige):
    //   <TextBlock Text="{Binding TourName}" />
    // 
    // CODE-ZUGRIFF:
    //   TourData tour = new TourData();
    //   tour.TourName = "Summer Festival 2024";
    //   string name = tour.TourName;
    public string TourName { get; set; }
    
    // 'StartDate': Datum des Tour-Beginns.
    // 
    // DATENTYP: string (nicht DateTime)
    // GRUND: Flexiblere Formatierung in XAML
    // ALTERNATIVE: DateTime mit StringFormat in Binding
    // 
    // XAML-BINDING MIT FORMATIERUNG:
    //   <TextBlock Text="{Binding StartDate}" />
    //   // Falls DateTime: <TextBlock Text="{Binding StartDate, StringFormat=d}" />
    // 
    // VERWENDUNG:
    //   tour.StartDate = "2024-06-15";
    //   tour.StartDate = "June 15, 2024";
    //   tour.StartDate = "15.06.2024";
    public string StartDate { get; set; }
    
    // 'City': Ort der Veranstaltung.
    // 
    // VERWENDUNG IN XAML:
    // - Anzeige: <TextBlock Text="{Binding City}" />
    // - Filterung: CollectionViewSource mit Filter
    // - Gruppierung: GroupDescription nach City
    // - Sortierung: SortDescription nach City
    // 
    // ERWEITERTE NUTZUNG:
    //   // Gruppierung nach Stadt
    //   <CollectionViewSource Source="{Binding Tours}">
    //     <CollectionViewSource.GroupDescriptions>
    //       <PropertyGroupDescription PropertyName="City" />
    //     </CollectionViewSource.GroupDescriptions>
    //   </CollectionViewSource>
    public string City { get; set; }
    
    // ===== HINWEISE ZUR VERWENDUNG =====
    // 
    // 1. COLLECTION IN XAML:
    //    <Window.Resources>
    //      <x:Array x:Key="tours" Type="local:TourData">
    //        <local:TourData TourName="Summer" StartDate="2024-06-15" City="Berlin" />
    //        <local:TourData TourName="Winter" StartDate="2024-12-20" City="München" />
    //      </x:Array>
    //    </Window.Resources>
    // 
    // 2. LISTBOX-BINDING:
    //    <ListBox ItemsSource="{StaticResource tours}">
    //      <ListBox.ItemTemplate>
    //        <DataTemplate>
    //          <StackPanel>
    //            <TextBlock Text="{Binding TourName}" />
    //            <TextBlock Text="{Binding City}" />
    //          </StackPanel>
    //        </DataTemplate>
    //      </ListBox.ItemTemplate>
    //    </ListBox>
    // 
    // 3. CODE-BEHIND-ERSTELLUNG:
    //    List<TourData> tours = new List<TourData> {
    //      new TourData { TourName = "Summer", StartDate = "2024-06-15", City = "Berlin" },
    //      new TourData { TourName = "Winter", StartDate = "2024-12-20", City = "München" }
    //    };
    //    myListBox.ItemsSource = tours;
    // 
    // 4. NAMESPACE-VORTEIL:
    //    - TourData im gleichen Namespace wie MainWindow
    //    - Eine xmlns-Deklaration reicht: xmlns:local="clr-namespace:UnderstandNamespaces"
    //    - Nutzung: <local:TourData /> und <local:MainWindow />
  }
}
