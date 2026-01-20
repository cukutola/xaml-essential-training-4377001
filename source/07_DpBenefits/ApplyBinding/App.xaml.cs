using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ApplyBinding {
	/// <summary>
	/// Interaction logic for App.xaml
	/// 
	/// APPLYBINDING PROJEKT:
	/// - Demonstriert Data Binding mit Dependency Properties
	/// - Binding ist ein zentraler Vorteil von Dependency Properties
	/// - Ermöglicht deklarative Verknüpfung von UI-Elementen
	/// 
	/// DEPENDENCY PROPERTY VORTEILE für Binding:
	/// - Change Notification: Automatische Benachrichtigung bei Wertänderungen
	/// - Value Precedence: Binding respektiert die Wertpriorität (Local > Binding > Style > Default)
	/// - Memory Efficiency: Sparse Storage speichert nur tatsächlich gesetzte Werte
	/// </summary>
	public partial class App : Application {
	}
}
