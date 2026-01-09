// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
// System.Configuration: App-Konfigurationsdateien.
using System.Configuration;
// System.Data: Datenbankzugriff.
using System.Data;
using System.Linq;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;

// Namespace für Attached Properties Demos.
namespace AttachedProps {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	// 'App': WPF-Anwendungsklasse für Attached Properties Demo.
	// 'partial': Ermöglicht Code-Splitting zwischen .xaml.cs und generiertem Code.
	// ': Application': Basisklasse, bietet App-Lebenszyklus und Ressourcen-Management.
	// ZWECK: Entry Point für Attached Properties Demo-Anwendung.
	// APP.XAML: Definiert StartupUri="MainWindow.xaml" und ggf. globale Styles.
	public partial class App : Application {
		// Leere Klasse: Standardkonfiguration reicht aus.
		// AUTOMATISCH GENERIERT: InitializeComponent() wird aus App.xaml generiert.
		// AUFRUF: Wird beim App-Start automatisch vom Framework aufgerufen.
	}
}
