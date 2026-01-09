// Standard .NET Namespaces für grundlegende Funktionalität.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Anwendungs-Namespace: Demonstriert Namespace-Konzepte in WPF/XAML.
namespace UnderstandNamespaces {
  
  // 'public class': Öffentliche Datenklasse ohne UI-Komponenten.
  // ZWECK: Repräsentiert eine Tour (Konzert/Veranstaltung).
  // EINSATZZWECK: Wird in XAML als Datenquelle für Binding verwendet.
  // XAML-NUTZUNG: Als ItemsSource für ListBox, DataGrid, etc.
  public class TourData {
    
    // 'Auto-Property': Kompakte Property-Syntax mit automatischem Backing-Field.
    // WICHTIG: 'public' + 'get/set' ermöglichen WPF Data Binding.
    
    // 'TourName': Name der Tour/des Konzerts.
    // DATA-BINDING: Kann in XAML gebunden werden: {Binding TourName}
    public string TourName { get; set; }
    
    // 'StartDate': Datum des Tour-Beginns.
    // HINWEIS: DateTime-Typ ermöglicht Formatierung in XAML: {Binding StartDate, StringFormat=d}
    public string StartDate { get; set; }
    
    // 'City': Ort der Veranstaltung.
    // VERWENDUNG: Kann für Filterung oder Gruppierung genutzt werden.
    public string City { get; set; }
  }
}
