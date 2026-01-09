// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
// System.Configuration: Zugriff auf App-Konfigurationsdateien (app.config).
using System.Configuration;
// System.Data: ADO.NET für Datenbankzugriff (hier nicht verwendet, aber Standard-Import).
using System.Data;
using System.Linq;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF-Anwendungen.
using System.Windows;

// Namespace für die Star-Control-Demo-Anwendung.
// KONTEXT: Demonstriert Custom DependencyProperties am Stern-UserControl.
namespace TheStarShape {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	// 'public partial class App : Application': WPF-Anwendungsklasse.
	// 'partial': Teilt die Klasse auf. Der XAML-Compiler generiert den anderen Teil aus App.xaml.
	// ': Application': Basisklasse für WPF-Apps, verwaltet Lebenszyklus und globale Ressourcen.
	// LEBENSZYKLUS-EVENTS: Startup, Exit, Activated, Deactivated, DispatcherUnhandledException.
	// APP.XAML: Definiert StartupUri (Startfenster) und globale Ressourcen (Styles, Templates).
	// SINGLETON: Es gibt nur eine Application-Instanz pro App (Application.Current).
	public partial class App : Application {
		// Leere Klasse: Alle Logik ist in App.xaml definiert.
		// XAML-GENERIERT: InitializeComponent() wird automatisch generiert und lädt App.xaml.
		// TYPISCHE ERWEITERUNGEN:
		// - Application_Startup Event-Handler für Init-Logik
		// - Application_Exit für Cleanup
		// - Globale Exception-Handler (DispatcherUnhandledException)
		// - Dependency Injection Container Setup
	}
}
