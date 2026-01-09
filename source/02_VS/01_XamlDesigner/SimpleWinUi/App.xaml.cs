// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

// Microsoft.UI.Xaml: Kernelement des WinUI 3 Frameworks (Nachfolger von UWP)
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
// Microsoft.UI.Xaml.Data: Datenbindung zwischen UI und Geschäftslogik
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
// Standard .NET Namespaces
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
// Windows.ApplicationModel: Lebenszyklus-Management für Windows-Apps
using Windows.ApplicationModel;
// Windows.ApplicationModel.Activation: Verschiedene App-Aktivierungsszenarien
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SimpleWinUi {
	/// <summary>
	/// Provides application-specific behavior to supplement the default Application class.
	/// </summary>
	// 'partial': Teilt die Klasse auf. Der XAML-Compiler generiert den anderen Teil aus App.xaml,
	// der globale Ressourcen (Styles, Templates, Brushes) und deren Initialisierung enthält.
	// ': Application': Basisklasse für WinUI 3 Desktop-Anwendungen. Sie verwaltet den App-Lebenszyklus,
	// globale Ressourcen und Fenster. WinUI 3 unterscheidet sich von UWP dadurch, dass Apps mehrere
	// Fenster haben können.
	public partial class App : Application {
		/// <summary>
		/// Initializes the singleton application object.  This is the first line of authored code
		/// executed, and as such is the logical equivalent of main() or WinMain().
		/// </summary>
		// Konstruktor: Der Einstiegspunkt für selbst geschriebenen Code in WinUI 3 Apps.
		// Dies ist vergleichbar mit main() in Konsolenanwendungen oder WinMain() in Win32-Apps.
		// Die App-Klasse ist ein Singleton - es gibt nur eine Instanz während der App-Laufzeit.
		public App() {
			// 'InitializeComponent()': KRITISCH! Diese vom XAML-Compiler generierte Methode:
			// 1. Lädt die App.xaml-Datei und parst sie
			// 2. Initialisiert alle globalen Ressourcen (Styles, Brushes, Templates)
			// 3. Verbindet Event-Handler mit ihren Zielen
			// Dies muss vor jeglicher UI-Arbeit aufgerufen werden.
			this.InitializeComponent();
		}

		/// <summary>
		/// Invoked when the application is launched.
		/// </summary>
		/// <param name="args">Details about the launch request and process.</param>
		// 'protected override': Überschreibt die OnLaunched-Methode der Application-Basisklasse.
		// Dies ist der Haupteinstiegspunkt, wenn die WinUI 3 App gestartet wird.
		// 'LaunchActivatedEventArgs args': Enthält Informationen über den App-Start, z.B. Kommandozeilen-
		// argumente oder ob die App durch ein Protokoll aktiviert wurde.
		protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args) {
			// Erstellt das Hauptfenster der Anwendung. 
			// WICHTIG: Im Gegensatz zu UWP können WinUI 3 Apps mehrere Fenster haben.
			// Jedes Fenster ist eine eigenständige Top-Level-Instanz mit eigenem Inhalt.
			// 'm_window' ist ein privates Feld, das die Referenz zum Fenster speichert.
			m_window = new MainWindow();
			// 'Activate()': Macht das Fenster sichtbar und bringt es in den Vordergrund.
			// Ohne diesen Aufruf würde das Fenster erstellt, aber unsichtbar bleiben.
			// Dies ist der letzte Schritt beim App-Start und macht die UI für den Benutzer sichtbar.
			m_window.Activate();
		}

		// Privates Feld zur Speicherung der Hauptfenster-Referenz.
		// 'Window': Basisklasse für Top-Level-Fenster in WinUI 3. Im Gegensatz zu UWP's einzelnem
		// Window.Current können WinUI 3 Apps mehrere Window-Instanzen verwalten.
		// Diese Referenz verhindert, dass das Fenster vom Garbage Collector entfernt wird.
		private Window m_window;
	}
}
