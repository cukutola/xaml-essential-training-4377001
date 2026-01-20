using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ApplyStyle {
	/// <summary>
	/// Interaction logic for App.xaml
	/// 
	/// APPLYSTYLE PROJEKT:
	/// - Demonstriert Style-Anwendung als Performance-Vorteil von Dependency Properties
	/// - Zeigt Memory Efficiency durch Sparse Storage
	/// 
	/// STYLE-KONZEPTE:
	/// - Styles nutzen Setter um Dependency Property Werte zu setzen
	/// - Style-Werte haben mittlere Priorität: Local > Style > Default > Inherited
	/// - Ein Style kann auf hunderte Elemente angewendet werden ohne Memory-Overhead
	/// 
	/// PERFORMANCE-VORTEILE:
	/// - Sparse Storage: Nur gesetzte Properties verbrauchen Speicher
	/// - Shared Resources: Style-Werte werden zwischen Instanzen geteilt
	/// - Effiziente Updates: Änderungen am Style propagieren automatisch
	/// 
	/// TRIGGERS in Styles:
	/// - Property Triggers reagieren auf Dependency Property Änderungen
	/// - Event Triggers können Animationen starten
	/// - Data Triggers arbeiten mit Bindings
	/// </summary>
	public partial class App : Application {
	}
}
