// System-Namespaces für grundlegende .NET-Funktionalität
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
// Windows.UI.Xaml: Kernelement des UWP-UI-Frameworks
using Windows.UI.Xaml;
// Windows.UI.Xaml.Controls: Enthält alle Standard-UI-Steuerelemente wie Buttons, TextBoxes, etc.
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
// Windows.UI.Xaml.Data: Unterstützung für Datenbindung zwischen UI und Datenmodellen
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
// Windows.UI.Xaml.Navigation: Klassen für die Seitennavigation in UWP
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SimpleUwa
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    // 'public': Macht die Seite für andere Teile der Anwendung zugänglich, insbesondere für 
    // die Navigation durch Frame.Navigate().
    // 'sealed': Verhindert Vererbung von dieser Klasse. Dies ist eine Performance-Optimierung 
    // und Best Practice in UWP, da das Framework keine weiteren virtuellen Methodenaufrufe prüfen muss.
    // 'partial': Teilt die Klassendefinition auf. Der XAML-Compiler generiert automatisch den 
    // anderen Teil dieser Klasse aus MainPage.xaml, der alle UI-Elemente (Buttons, Grids, etc.) 
    // als Felder enthält und deren Initialisierung durchführt.
    // ': Page': Basisklasse für navigierbare Seiten in UWP. Sie bietet Funktionalität für 
    // Navigation, Zustandsverwaltung und Integration in den Frame-Navigationsstack.
    public sealed partial class MainPage : Page
    {
        // Konstruktor: Wird aufgerufen, wenn eine neue Instanz der Seite erstellt wird.
        // Dies geschieht typischerweise, wenn Frame.Navigate(typeof(MainPage)) aufgerufen wird.
        public MainPage()
        {
            // 'InitializeComponent()': KRITISCH! Diese vom XAML-Parser generierte Methode:
            // 1. Lädt und parst die MainPage.xaml-Datei
            // 2. Erstellt alle in XAML definierten UI-Elemente (Buttons, TextBoxes, Layouts)
            // 3. Setzt Properties basierend auf XAML-Attributen
            // 4. Verbindet Event-Handler (z.B. Click-Events) mit den in XAML definierten Methoden
            // 5. Verknüpft benannte Elemente (x:Name) mit Feldern in dieser Klasse
            // Ohne diesen Aufruf wäre die Seite leer und alle x:Name-Referenzen wären null!
            this.InitializeComponent();
        }
    }
}
