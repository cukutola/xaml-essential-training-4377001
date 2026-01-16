using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UseMergedResources
{
    /// <summary>
    /// Interaction logic for DoneWindow.xaml
    /// </summary>
    /// <remarks>
    /// DONE WINDOW - MergedDictionaries Abschluss-Demonstration
    /// 
    /// Dieses Window zeigt das Endergebnis der MergedDictionaries-Demonstration.
    /// Es verwendet die zusammengeführten ResourceDictionaries aus verschiedenen Quellen.
    /// 
    /// MERGEDDICTIONARIES IN DER PRAXIS:
    /// Dieses Window nutzt typischerweise Resources aus:
    /// - Application.Resources (globale Resources)
    /// - Externe ResourceDictionary-Dateien (über MergedDictionaries)
    /// - Lokale Window.Resources (optionale Überschreibungen)
    /// 
    /// RESOURCE-ZUGRIFF:
    /// Alle zusammengeführten Resources sind transparent verfügbar:
    /// <Button Style="{StaticResource MyButtonStyle}"/>
    /// 
    /// Die Quelle der Resource (Application, Merged Dictionary, oder lokal)
    /// ist für das verwendende Control irrelevant - WPF findet sie automatisch
    /// durch den hierarchischen Lookup-Mechanismus.
    /// </remarks>
    public partial class DoneWindow : Window
    {
        public DoneWindow()
        {
            // InitializeComponent() lädt:
            // 1. Alle MergedDictionaries aus Application.Resources
            // 2. Alle MergedDictionaries aus Window.Resources
            // 3. Alle lokalen Resources
            // 
            // Alle diese Resources stehen dann für StaticResource/DynamicResource
            // Markup Extensions zur Verfügung
            InitializeComponent();
        }
    }
}
