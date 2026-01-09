// Importiert grundlegende .NET-Namespaces für Typen, Collections und Threading
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
// Importiert WPF-Application-Klasse
using System.Windows;

// Namespace für dieses Projekt - demonstriert Property-Attribute in XAML
namespace PropertyAttributes {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  // 'public': Die App-Klasse ist öffentlich zugänglich
  // 'partial': Aufgeteilte Klassendefinition. Der XAML-Parser generiert den anderen Teil
  // mit Anwendungsressourcen und StartupUri-Konfiguration.
  // ': Application': Basisklasse für WPF-Anwendungen. Sie verwaltet:
  // - Anwendungslebenszyklus (Startup, Exit, Activate, Deactivate)
  // - Globale Ressourcen (Application.Resources)
  // - Hauptfenster (MainWindow-Property)
  // - Shutdown-Modus (OnLastWindowClose, OnMainWindowClose, OnExplicitShutdown)
  public partial class App : Application {
    // Bewusst leer. Die Anwendungskonfiguration erfolgt in App.xaml (StartupUri, Resources).
    // Dieser Code-Behind wird nur benötigt, wenn Anwendungs-Events wie Application_Startup
    // oder Application_Exit behandelt werden müssen.
  }
}
