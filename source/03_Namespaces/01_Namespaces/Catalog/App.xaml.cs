// .NET Basis-Namespaces.
using System;
using System.Collections.Generic;

// Konfigurationsverwaltung für App-Settings.
using System.Configuration;

// Datenzugriffs-Namespace (ADO.NET).
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// WPF Application-Namespace.
using System.Windows;

// Anwendungs-Namespace für Catalog-Demo.
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	
	// Application-Klasse: Einstiegspunkt und Lebenszyklus-Verwaltung.
	// WICHTIG: Erbt von 'Application' für WPF-App-Infrastruktur.
	public partial class App : Application {
		// Keine zusätzliche Logik erforderlich.
		// HINWEIS: App.xaml definiert StartupUri und Application Resources.
	}
}
