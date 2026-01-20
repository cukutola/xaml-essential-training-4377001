using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF-Desktop-Anwendungen
using System.Windows;

namespace TheStarShape {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	// Application-Klasse: Einstiegspunkt der WPF-Anwendung
	// ZWECK: Verwaltet den Lebenszyklus der Anwendung (Startup, Exit, Activation)
	// PATTERN: Code-Behind Klasse für App.xaml
	// HINWEIS: App.xaml definiert Anwendungsressourcen und das StartupUri (Hauptfenster)
	public partial class App : Application {
		// Keine zusätzliche Logik erforderlich - die Basisklasse Application
		// behandelt alle Standard-Initialisierungsaufgaben automatisch.
		// STARTUP: Das MainWindow wird automatisch geladen (definiert in App.xaml als StartupUri)
	}
}
