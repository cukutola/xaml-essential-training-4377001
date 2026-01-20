using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PropInheritance {
	/// <summary>
	/// Interaction logic for App.xaml
	/// 
	/// PROPINHERITANCE PROJEKT:
	/// - Demonstriert Property Inheritance als wichtigen Vorteil von Dependency Properties
	/// - Zeigt wie Werte durch den Visual Tree propagiert werden
	/// 
	/// PROPERTY INHERITANCE - Kernkonzepte:
	/// 
	/// 1. WAS IST PROPERTY INHERITANCE?
	///    - Automatische Weitergabe von Property-Werten von Parent zu Child
	///    - Teil des Value Precedence Systems (niedrigste Priorität)
	///    - Aktiviert durch FrameworkPropertyMetadataOptions.Inherits
	/// 
	/// 2. VALUE PRECEDENCE mit Inheritance:
	///    - Local > Style > Default > Inherited (niedrigste)
	///    - Child kann geerbten Wert mit eigenem Local/Style überschreiben
	///    - ClearValue() auf Child stellt Inheritance wieder her
	/// 
	/// 3. VISUAL TREE TRAVERSAL:
	///    - Bei Zugriff: WPF sucht im Visual Tree nach oben
	///    - Stoppt beim ersten gesetzten Wert
	///    - Sehr effizient durch interne Optimierungen
	/// 
	/// 4. TYPISCHE INHERITABLE PROPERTIES:
	///    - Font-Properties: FontFamily, FontSize, FontWeight, FontStyle
	///    - Foreground: Farbe wird vererbt
	///    - DataContext: Zentral für Data Binding
	///    - FlowDirection: Für Rechts-nach-Links Sprachen
	/// 
	/// 5. PERFORMANCE-VORTEILE:
	///    - SPARSE STORAGE: Geerbte Werte brauchen KEINEN Speicher im Child
	///    - Memory Efficiency: Ein Wert für tausende Children
	///    - Automatische Change Notification: Änderung am Parent → alle Children
	/// 
	/// 6. EIGENE INHERITABLE PROPERTIES erstellen:
	///    - Bei DP-Registrierung: FrameworkPropertyMetadataOptions.Inherits setzen
	///    - Beispiel: DependencyProperty.Register(..., new FrameworkPropertyMetadata(
	///                defaultValue, FrameworkPropertyMetadataOptions.Inherits))
	/// 
	/// VERGLEICH zu normalen Properties:
	/// - Normale Properties: Jeder Wert muss einzeln gesetzt werden
	/// - Inheritable DPs: Ein Wert auf Root → automatisch in allen Children
	/// - Riesiger Vorteil für konsistentes Look & Feel
	/// </summary>
	public partial class App : Application {
	}
}
