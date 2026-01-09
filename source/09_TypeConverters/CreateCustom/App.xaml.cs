// 'using': Importiert Namespaces für grundlegende .NET- und WPF-Funktionalität.
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

// 'namespace': Definiert den Namensraum für die Anwendung.
namespace CreateCustom {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// HINTERGRUND: Der XAML-Compiler generiert eine zweite partial-Klasse aus App.xaml,
	// die Application-Ressourcen und Startup-Logik enthält.
	// ': Application': Basisklasse für WPF-Anwendungen.
	// ZWECK: Verwaltet den Anwendungslebenszyklus, Ressourcen und Fenster.
	// WICHTIG: Jede WPF-Anwendung hat genau eine Application-Instanz.
	// EVENTS: Bietet Startup, Exit, DispatcherUnhandledException Events.
	public partial class App : Application {
		// HINWEIS: Diese Klasse ist absichtlich leer.
		// Die eigentliche Logik (z.B. StartupUri, Ressourcen) wird in App.xaml definiert.
		// Der XAML-Compiler fügt automatisch Code hinzu, der:
		// - Die XAML-Ressourcen lädt
		// - Das StartupUri-Fenster öffnet
		// - Event-Handler verbindet
	}
}
