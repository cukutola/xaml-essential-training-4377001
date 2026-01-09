// Standard .NET Namespaces
using System;
using System.Collections.Generic;
// System.Configuration: Zugriff auf app.config und Anwendungseinstellungen
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
// System.Windows: Kernelement des WPF-Frameworks für Desktop-Anwendungen
using System.Windows;

namespace BigStarCollectiblesDesktop {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	// 'partial': Teilt die Klassendefinition auf. Der XAML-Compiler generiert automatisch den 
	// anderen Teil aus App.xaml, der globale Ressourcen (Styles, Templates, DataTemplates) 
	// und deren Initialisierung enthält.
	// ': Application': Basisklasse für WPF-Anwendungen. Sie verwaltet den Anwendungslebenszyklus,
	// globale Ressourcen und das Hauptfenster. Bietet Events wie Startup, Exit, DispatcherUnhandledException.
	public partial class App : Application {
		// Leere Klasse - die gesamte Logik wird in App.xaml definiert oder vom XAML-Parser generiert.
		// InitializeComponent() wird automatisch generiert und lädt App.xaml beim Start.
		// Hier könnten globale Event-Handler oder Dependency Injection Container initialisiert werden.
	}
}
