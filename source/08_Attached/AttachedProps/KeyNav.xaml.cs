// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente.
using System.Windows.Controls;
// System.Windows.Data: Data Binding.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung und Keyboard-Navigation.
// WICHTIG: KeyboardNavigation ist eine Klasse mit Attached Properties für Tab-Navigation!
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;

// Namespace für Attached Properties Demos.
namespace AttachedProps
{
    /// <summary>
    /// Interaction logic for KeyNav.xaml
    /// </summary>
    // 'KeyNav': Fenster für Keyboard Navigation Attached Properties Demo.
    // ZWECK: Demonstriert KeyboardNavigation Attached Properties.
    // KEYBOARD NAVIGATION ATTACHED PROPERTIES:
    // - KeyboardNavigation.TabIndex: Bestimmt Tab-Reihenfolge (0, 1, 2, ...).
    // - KeyboardNavigation.TabNavigation: Kontrolliert Tab-Verhalten (Local, Cycle, Continue, None, Contained, Once).
    // - KeyboardNavigation.ControlTabNavigation: Für Ctrl+Tab Navigation.
    // - KeyboardNavigation.DirectionalNavigation: Für Pfeiltasten-Navigation (Local, Cycle, Continue, None, Contained, Once).
    // - KeyboardNavigation.IsTabStop: Boolean, ob Element Tab-Stopp ist.
    // EINSATZZWECK: Barrierefreiheit und benutzerfreundliche Tastatur-Navigation.
    // BEISPIEL: <Button KeyboardNavigation.TabIndex="1" /> legt Tab-Reihenfolge fest.
    public partial class KeyNav : Window
    {
        // Konstruktor: Initialisiert das Fenster.
        public KeyNav()
        {
            // Lädt XAML mit Controls, die KeyboardNavigation Attached Properties demonstrieren.
            // XAML-DEMO: Zeigt vermutlich Buttons/TextBoxes mit unterschiedlichen TabIndex-Werten.
            // TEST: Benutzer kann Tab drücken und sieht benutzerdefinierte Navigations-Reihenfolge.
            // TAB-NAVIGATION: Normalerweise ist Reihenfolge = Visual Tree Reihenfolge.
            // MIT TABINDEX: Kann Reihenfolge überschreiben (TabIndex=0 kommt vor TabIndex=1, etc.).
            InitializeComponent();
        }
    }
}
