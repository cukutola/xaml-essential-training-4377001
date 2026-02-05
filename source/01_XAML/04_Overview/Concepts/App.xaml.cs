// 'using': Importiert Namespaces, damit deren Typen ohne vollständigen Pfad verwendet werden können.
// 'System': Basis-Namespace mit fundamentalen Klassen wie String, Int32, DateTime, Exception.
using System;
// 'System.Collections.Generic': Stellt generische Auflistungstypen (List<T>, Dictionary<TKey, TValue>) bereit.
using System.Collections.Generic;
// 'System.Configuration': Ermöglicht den Zugriff auf Konfigurationsdateien (app.config, web.config).
using System.Configuration;
// 'System.Data': Bietet ADO.NET-Klassen für Datenbankzugriffe und Datenmanipulation.
using System.Data;
// 'System.Linq': Language Integrated Query - ermöglicht SQL-ähnliche Abfragen auf Objektsammlungen.
using System.Linq;
// 'System.Windows': Kernnamespace für WPF mit Basisklassen wie Application, Window, UIElement.
using System.Windows;

// 'namespace': Organisiert Code in logische Gruppen und verhindert Namenskonflikte.
// Namespaces erstellen hierarchische Strukturen, die die Architektur der Anwendung widerspiegeln.
namespace Concepts {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  // 'public': Macht die Klasse von außen zugänglich - erforderlich, da das Framework die App instanziieren muss.
  // 'partial': Teilt die Klassendefinition auf mehrere Dateien auf. Der XAML-Compiler generiert
  // den zweiten Teil automatisch aus der App.xaml-Datei, der Ressourcen, Startup-Events und 
  // Anwendungseinstellungen enthält.
  // ': Application': Erbt von der WPF-Basisklasse Application. Diese Klasse repräsentiert die
  // gesamte Anwendung und verwaltet den Anwendungslebenszyklus (Startup, Exit, Activation),
  // globale Ressourcen, anwendungsweite Events und den Haupt-UI-Thread (Dispatcher).
  // WICHTIG: Jede WPF-Anwendung hat genau EINE Application-Instanz.
  public partial class App : Application {
    // Hier könnten anwendungsweite Ereignishandler (Application_Startup, Application_Exit)
    // oder globale Ressourcen-Dictionaries hinzugefügt werden.
    // HINWEIS: Oft wird diese Klasse leer gelassen, wenn keine spezielle Initialisierungslogik
    // benötigt wird, da die XAML-Datei (App.xaml) die meisten Einstellungen deklarativ definiert.
  }
}
