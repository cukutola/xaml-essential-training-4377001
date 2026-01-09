// Standard .NET Namespaces
using System;
using System.Collections.Generic;
// System.Configuration: Zugriff auf Konfigurationsdateien (app.config, web.config)
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
// System.Windows: Kernelement des WPF-Frameworks für Desktop-Anwendungen
using System.Windows;

namespace SimpleWpf {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	// 'partial': Teilt die Klassendefinition auf. Der XAML-Compiler generiert automatisch den 
	// anderen Teil dieser Klasse aus App.xaml, der globale Ressourcen (Styles, Templates, Brushes,
	// Dictionaries) und deren Initialisierung enthält.
	// ': Application': Basisklasse für WPF-Anwendungen. Sie verwaltet den Anwendungslebenszyklus
	// (Startup, Exit, Activated, Deactivated), globale Ressourcen und das Hauptfenster (MainWindow).
	// WPF ist das klassische Desktop-UI-Framework für Windows und Vorgänger von WinUI.
	public partial class App : Application {
		// Leere Klasse - alle Logik wird in App.xaml definiert oder in der XAML-generierten Partial-Klasse.
		// Der XAML-Parser generiert InitializeComponent() und andere Methoden automatisch.
		// Normalerweise könnte hier Startup-Logik, Event-Handler oder globale Services hinzugefügt werden.
	}
}
