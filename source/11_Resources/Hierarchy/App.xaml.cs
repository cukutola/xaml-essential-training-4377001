using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Hierarchy {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// <remarks>
	/// RESOURCE HIERARCHY DEMONSTRATION - Application.Resources vs. Window.Resources
	/// 
	/// Diese Anwendung demonstriert die hierarchische Struktur des Resource-Lookup-Mechanismus in WPF.
	/// 
	/// RESOURCE HIERARCHY (von innen nach außen):
	/// 1. Control.Resources (z.B. Button.Resources)
	///    - Höchste Priorität, gilt nur für dieses Control und seine Children
	/// 2. Parent Control.Resources
	///    - Resources der übergeordneten Controls in der visuellen Hierarchie
	/// 3. Window.Resources
	///    - Resources für alle Controls im Window
	/// 4. Application.Resources
	///    - Globale Resources für die gesamte Anwendung
	/// 5. System Resources
	///    - Standard-WPF System Resources (z.B. SystemColors.WindowBrush)
	/// 
	/// RESOURCE LOOKUP PROZESS:
	/// - WPF sucht eine Resource beginnend beim aktuellen Element
	/// - Durchläuft die visuelle Hierarchie nach oben (Visual Tree)
	/// - Stoppt beim ersten gefundenen Match
	/// - Wirft Exception bei StaticResource, wenn nicht gefunden
	/// - Gibt null zurück bei DynamicResource, wenn nicht gefunden
	/// 
	/// APPLICATION.RESOURCES:
	/// - Definiert in App.xaml
	/// - Zugriff über Application.Current.Resources
	/// - Ideal für anwendungsweite Styles, Brushes, Converter
	/// - Lebensdauer: gesamte Anwendungslaufzeit
	/// 
	/// WINDOW.RESOURCES:
	/// - Definiert in Window.xaml
	/// - Gilt für alle Controls im Window
	/// - Ideal für fenster-spezifische Resources
	/// - Lebensdauer: Solange das Window existiert
	/// 
	/// BEST PRACTICES:
	/// - Globale Resources in Application.Resources
	/// - Window-spezifische Resources in Window.Resources
	/// - Control-spezifische Resources in Control.Resources
	/// - Vermeidung von Duplikaten durch richtige Hierarchie-Nutzung
	/// </remarks>
	public partial class App : Application {
	}
}
