// 'using': Importiert Namespaces für grundlegende .NET- und WPF-Funktionalität.
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

// 'namespace': Definiert den Namensraum für die Anwendung.
namespace UseCommon {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Application': Basisklasse für WPF-Anwendungen.
	// ZWECK: Verwaltet den Anwendungslebenszyklus und globale Ressourcen.
	public partial class App : Application {
		// HINWEIS: Diese Klasse ist absichtlich leer.
		// Die Konfiguration erfolgt in App.xaml.
	}
}
