// System-Namespaces für grundlegende .NET-Funktionalität
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
// Windows.ApplicationModel: Zugriff auf den Anwendungslebenszyklus (Start, Beenden, Suspend)
using Windows.ApplicationModel;
// Windows.ApplicationModel.Activation: Enthält Klassen für verschiedene App-Aktivierungsszenarien
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
// Windows.UI.Xaml: Kernelement des UWP-UI-Frameworks für XAML-basierte Anwendungen
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
// Windows.UI.Xaml.Navigation: Unterstützung für die Seitennavigation in UWP-Apps
using Windows.UI.Xaml.Navigation;

namespace SimpleUwa
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    // 'sealed': Verhindert, dass andere Klassen von dieser App-Klasse erben. Dies ist eine 
    // Sicherheitsmaßnahme und Optimierung bei UWP-Anwendungen.
    // 'partial': Teilt die Klassendefinition auf. Der XAML-Compiler generiert automatisch den 
    // anderen Teil dieser Klasse basierend auf App.xaml, der UI-Definitionen und Ressourcen enthält.
    // ': Application': Basisklasse für UWP-Apps. Sie verwaltet den Anwendungslebenszyklus, 
    // globale Ressourcen und das Hauptfenster.
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        // Konstruktor: Wird aufgerufen, wenn die UWP-Anwendung startet. Dies ist der Einstiegspunkt 
        // für selbst geschriebenen Code - vergleichbar mit main() in Konsolenanwendungen.
        // Die App-Klasse ist ein Singleton: Es gibt nur eine Instanz während der Laufzeit.
        public App()
        {
            // 'InitializeComponent': KRITISCH! Diese vom XAML-Parser generierte Methode lädt die 
            // App.xaml-Datei, initialisiert alle dort definierten Ressourcen (Styles, Templates, 
            // Brushes) und verbindet Event-Handler mit ihren Zielen.
            this.InitializeComponent();
            // Event-Handler für Suspending-Event registrieren: Wird ausgelöst, wenn das Betriebssystem
            // die App in den Hintergrund versetzt (z.B. Benutzer wechselt zu anderer App).
            // UWP-Apps müssen ihren Zustand speichern, da sie jederzeit beendet werden können.
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        // 'protected override': Überschreibt die OnLaunched-Methode der Application-Basisklasse.
        // Dies ist der Haupteinstiegspunkt, wenn der Benutzer die App normal startet (z.B. durch 
        // Klick auf das App-Icon). Andere Einstiegspunkte existieren für Szenarien wie das Öffnen 
        // einer Datei oder die Aktivierung durch einen Vertrag.
        // 'LaunchActivatedEventArgs e': Enthält wichtige Informationen über den Start, z.B. 
        // vorherigen Ausführungsstatus, Startargumente und ob es sich um einen Prelaunch handelt.
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            // 'Frame': Das Navigationselement in UWP. Es funktioniert wie ein Browser und verwaltet
            // einen Stack von Seiten. Benutzer können vorwärts/rückwärts navigieren.
            // 'Window.Current.Content': Das Hauptfenster der UWP-App. Jede UWP-App hat genau ein Window.
            // 'as Frame': Sichere Typumwandlung - gibt null zurück, wenn Content kein Frame ist.
            Frame rootFrame = Window.Current.Content as Frame;

            // Verhindert doppelte Initialisierung: Wenn das Fenster bereits einen Frame enthält,
            // überspringen wir die Initialisierung und aktivieren nur das Fenster.
            // Dies kann passieren, wenn die App aus dem Suspend-Zustand reaktiviert wird.
            if (rootFrame == null)
            {
                // Erstellt einen neuen Frame als Navigationskontext. Der Frame verwaltet den 
                // Seitenverlauf und ermöglicht Navigation zwischen verschiedenen Seiten (Pages).
                // Dies entspricht dem Navigation-Pattern in UWP-Anwendungen.
                rootFrame = new Frame();

                // Event-Handler für Navigationsfehler registrieren: Wird ausgelöst, wenn die 
                // Navigation zu einer Seite fehlschlägt (z.B. Seite nicht gefunden, Fehler beim Laden).
                rootFrame.NavigationFailed += OnNavigationFailed;

                // Prüft, ob die App zuvor beendet wurde (nicht nur suspended).
                // 'ApplicationExecutionState.Terminated': Die App wurde vom OS beendet, z.B. wegen 
                // Speichermangel. In diesem Fall sollte der gespeicherte Zustand wiederhergestellt werden.
                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Zustand aus zuvor suspendierter Anwendung laden
                    // Hier würden Sie normalerweise gespeicherte Daten wiederherstellen, z.B. 
                    // Benutzereingaben, Scroll-Position, geöffnete Dokumente, etc.
                }

                // Setzt den Frame als Inhalt des Hauptfensters. Ab jetzt ist der Frame für die 
                // Anzeige aller UI-Inhalte verantwortlich.
                Window.Current.Content = rootFrame;
            }

            // 'PrelaunchActivated': Windows 10 Feature zur Performance-Optimierung. Das System kann 
            // Apps im Hintergrund vorab starten, um den tatsächlichen Start zu beschleunigen.
            // Bei Prelaunch sollten wir das Fenster NICHT aktivieren, nur vorbereiten.
            if (e.PrelaunchActivated == false)
            {
                // Prüft, ob der Frame bereits Inhalt hat (z.B. nach Rückkehr aus Suspension).
                // Wenn nicht, navigieren wir zur Startseite der Anwendung.
                if (rootFrame.Content == null)
                {
                    // Navigiert zur ersten Seite (MainPage). 
                    // 'typeof(MainPage)': Übergibt den Typ der Zielseite - der Frame instanziiert sie.
                    // 'e.Arguments': Optionale Startparameter, z.B. wenn die App durch einen Toast 
                    // oder ein Tile aktiviert wurde. Diese können in MainPage.OnNavigatedTo verwendet werden.
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // Macht das Fenster sichtbar und aktiviert es. Ohne diesen Aufruf bleibt die App 
                // unsichtbar. Dies ist der letzte Schritt beim App-Start.
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        // Event-Handler für fehlgeschlagene Navigationen. Wird vom Frame aufgerufen, wenn die 
        // Navigation zu einer Seite nicht funktioniert hat.
        // 'object sender': Der Frame, der die Navigation versuchte. Als object für Flexibilität.
        // 'NavigationFailedEventArgs e': Enthält Details über den Fehler, z.B. den Seitentyp 
        // und die ursprüngliche Exception.
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            // Wirft eine Exception mit Details über die fehlgeschlagene Seite.
            // 'e.SourcePageType.FullName': Vollständiger Name der Seite, die nicht geladen werden konnte.
            // In Produktion sollte dies eleganter behandelt werden (Logging, Fehlerseite anzeigen).
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        // Event-Handler für das Suspending-Event. Wird aufgerufen, wenn das OS die App in den 
        // Hintergrund versetzt. WICHTIG: Die App hat nur wenige Sekunden (ca. 5 Sek.) Zeit, um 
        // ihren Zustand zu speichern, bevor sie möglicherweise beendet wird.
        // 'SuspendingEventArgs e': Enthält eine SuspendingOperation mit Deadline-Informationen.
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            // 'GetDeferral()': Fordert zusätzliche Zeit zum Speichern an. Dies ist notwendig, wenn 
            // asynchrone Operationen (z.B. Dateischreiben) durchgeführt werden müssen.
            // Ohne Deferral würde die Methode sofort zurückkehren und async-Operationen könnten 
            // abgebrochen werden. WICHTIG: Deferral.Complete() muss aufgerufen werden!
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Anwendungszustand speichern und Hintergrundaktivitäten stoppen
            // Hier sollten Sie: 
            // - Benutzerdaten speichern (z.B. in LocalSettings oder einer Datei)
            // - Aktuelle Navigationshistorie sichern
            // - Netzwerkverbindungen trennen
            // - Laufende Timer/Animationen stoppen
            // Signalisiert, dass das Speichern abgeschlossen ist. Das OS kann die App nun beenden.
            // Nach diesem Aufruf sollte kein weiterer Code mehr ausgeführt werden.
            deferral.Complete();
        }
    }
}
