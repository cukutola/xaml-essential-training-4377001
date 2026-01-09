// 'using': Importiert Namespaces für grundlegende .NET- und WPF-Funktionalität.
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

// 'namespace': Definiert den Namensraum für die Anwendung.
namespace ShowTypeConverters {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// HINTERGRUND: Der XAML-Compiler generiert eine zweite partial-Klasse aus App.xaml,
	// die Application-Ressourcen und Startup-Logik enthält.
	// ': Application': Basisklasse für WPF-Anwendungen.
	// ZWECK: Verwaltet den Anwendungslebenszyklus (Startup, Exit), globale Ressourcen und Fenster.
	// WICHTIG: Jede WPF-App hat genau eine Application-Instanz, die als Einstiegspunkt dient.
	public partial class App : Application {
		// HINWEIS: Diese Klasse ist absichtlich leer.
		// Die eigentliche Logik (StartupUri, Ressourcen) wird in App.xaml definiert.
	}
}
