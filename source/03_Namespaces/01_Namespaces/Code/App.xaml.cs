// Standard .NET Namespaces.
using System;
using System.Collections.Generic;

// 'System.Configuration': Namespace für Zugriff auf App-Konfigurationsdateien.
// EINSATZZWECK: ConfigurationManager, AppSettings, ConnectionStrings.
using System.Configuration;

// 'System.Data': Basis-Namespace für Datenzugriff (ADO.NET).
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// 'System.Windows': Enthält Application-Klasse - Herzstück jeder WPF-App.
using System.Windows;

// Namespace für diese Namespace-Demo-Anwendung.
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	
	// 'public partial class App : Application': Anwendungs-Klasse.
	// WICHTIG: Erbt von 'Application' - zentrale Klasse für WPF-App-Lebenszyklus.
	// ROLLE:
	// - Einstiegspunkt der Anwendung
	// - Verwaltung von Startup/Exit-Events
	// - Globale Ressourcen (Application.Resources)
	// - Unbehandelte Exceptions abfangen
	// PARTIAL: XAML-Teil definiert StartupUri und Application-Level Resources.
	public partial class App : Application {
		// Kein Code erforderlich: App.xaml definiert StartupUri für MainWindow.
		// HINWEIS: Startup-Logik kann über OnStartup-Override hinzugefügt werden.
	}
}
