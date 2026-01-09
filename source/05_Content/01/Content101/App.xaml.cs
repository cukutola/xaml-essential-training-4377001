// 'using': Importiert Namespaces für grundlegende .NET- und WPF-Funktionalität.
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

// 'namespace': Definiert den Namensraum für die Anwendung.
namespace Content101 {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Application': Basisklasse für WPF-Anwendungen.
	// ZWECK: Verwaltet den Anwendungslebenszyklus, globale Ressourcen und Event-Handler.
	// WICHTIG: Jede WPF-Anwendung hat genau eine Application-Instanz.
	public partial class App : Application {
		// HINWEIS: Diese Klasse ist absichtlich leer.
		// Die Konfiguration (StartupUri, Ressourcen) erfolgt in App.xaml.
	}
}
