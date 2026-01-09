// Standard .NET Namespaces
using System;
using System.Collections.Generic;
// System.Configuration: Zugriff auf Anwendungseinstellungen und Konfigurationsdateien
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
// System.Windows: Kernelement des WPF-Frameworks
using System.Windows;

namespace WorkWithXamlTools {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	// 'partial': Teilt die Klassendefinition auf. Der XAML-Compiler generiert automatisch den 
	// anderen Teil dieser Klasse aus App.xaml, der globale Ressourcen und deren Initialisierung enthält.
	// ': Application': Basisklasse für WPF-Anwendungen. Sie verwaltet den Anwendungslebenszyklus,
	// globale Ressourcen, das Hauptfenster und ermöglicht Zugriff auf anwendungsweite Einstellungen.
	public partial class App : Application {
		// Leere Klasse - alle Logik wird in App.xaml definiert oder vom XAML-Parser generiert.
		// InitializeComponent() wird automatisch generiert und lädt App.xaml beim Start.
		// Hier könnten Event-Handler wie Application_Startup oder Application_Exit hinzugefügt werden.
	}
}
