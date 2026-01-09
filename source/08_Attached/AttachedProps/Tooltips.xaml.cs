// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente und ToolTip-Control.
// WICHTIG: ToolTipService bietet Attached Properties für Tooltips!
using System.Windows.Controls;
// System.Windows.Data: Data Binding.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
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
    /// Interaction logic for TooltipExample.xaml
    /// </summary>
    // 'TooltipExample': Fenster für ToolTip Attached Properties Demo.
    // ZWECK: Demonstriert ToolTipService Attached Properties.
    // TOOLTIPSERVICE ATTACHED PROPERTIES:
    // - ToolTipService.ToolTip: Der Tooltip-Inhalt (string oder komplexes UI-Element).
    // - ToolTipService.InitialShowDelay: Verzögerung vor erstem Anzeigen (Millisekunden).
    // - ToolTipService.ShowDuration: Wie lange Tooltip angezeigt wird (Millisekunden).
    // - ToolTipService.BetweenShowDelay: Verzögerung zwischen Tooltips.
    // - ToolTipService.Placement: Wo Tooltip erscheint (Top, Bottom, Left, Right, Mouse, etc.).
    // - ToolTipService.PlacementTarget: Relativ zu welchem Element Tooltip positioniert wird.
    // - ToolTipService.HasDropShadow: Boolean für Schatten-Effekt.
    // EINSATZZWECK: Kontextuelle Hilfe, zusätzliche Informationen bei Hover.
    // BEISPIEL: <Button ToolTipService.ToolTip="Click me!" ToolTipService.InitialShowDelay="500" />
    public partial class TooltipExample : Window
    {
        // Konstruktor: Initialisiert das Fenster.
        public TooltipExample()
        {
            // Lädt XAML mit UI-Elementen, die verschiedene Tooltip-Konfigurationen zeigen.
            // XAML-DEMO: Zeigt vermutlich Buttons/Bilder mit unterschiedlichen Tooltip-Einstellungen.
            // TOOLTIP-ARTEN:
            // 1. Einfach: ToolTip="Text" (String-Wert)
            // 2. Komplex: <Button.ToolTip><StackPanel>...</StackPanel></Button.ToolTip> (UI-Baum)
            // ATTACHED PROPERTY VORTEIL: Tooltips können an JEDES UIElement angehängt werden,
            // nicht nur an Controls. Sogar Shapes (Rectangle, Ellipse) können Tooltips haben!
            InitializeComponent();
        }
    }
}
