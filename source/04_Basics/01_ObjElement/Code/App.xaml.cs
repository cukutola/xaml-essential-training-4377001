// Importiert grundlegende .NET-Namespaces für Typen, Collections und Threading
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
// Importiert den WPF-Namespace für Application-Klasse und UI-Elemente
using System.Windows;

// Namespace für dieses Projekt - gruppiert alle zusammengehörigen Klassen
namespace ObjectElements {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	// 'public': Macht die Anwendungsklasse von außen zugänglich
	// 'partial': Teilt die Klassendefinition auf. Der XAML-Parser generiert einen weiteren Teil
	// dieser Klasse, der z.B. das StartupUri und Ressourcen definiert.
	// ': Application': Basisklasse für WPF-Anwendungen. Sie verwaltet den Anwendungslebenszyklus,
	// Startup/Exit-Events und globale Ressourcen.
	public partial class App : Application {
		// Diese Klasse ist bewusst leer. Die Anwendungslogik wird in App.xaml definiert
		// (z.B. StartupUri, globale Ressourcen). Der C#-Teil wird nur benötigt, wenn
		// Anwendungs-Events wie Startup oder Exit behandelt werden müssen.
	}
}
