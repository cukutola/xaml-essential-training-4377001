using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Precedence {
	/// <summary>
	/// Interaction logic for App.xaml
	/// 
	/// PRECEDENCE PROJEKT:
	/// - Demonstriert das Value Precedence System von Dependency Properties
	/// - Zeigt DependencyPropertyHelper.GetValueSource() für Debugging
	/// - Drei Demo-Fenster für verschiedene Precedence-Szenarien
	/// 
	/// VALUE PRECEDENCE SYSTEM - Das Kernkonzept:
	/// WPF wählt automatisch den Wert mit höchster Priorität:
	/// 1. Animated (während Animation aktiv)
	/// 2. Local (SetValue, XAML-Attribut)
	/// 3. Triggered (Property/Event/Data Triggers)
	/// 4. Style (Style Setter)
	/// 5. Default (PropertyMetadata.DefaultValue)
	/// 6. Inherited (von Parent-Element)
	/// 
	/// WICHTIGE METHODEN zum Manipulieren der Precedence:
	/// - SetValue(dp, value): Setzt LOCAL VALUE (überschreibt Style/Default)
	/// - SetCurrentValue(dp, value): Setzt Wert OHNE Local Precedence (gut für Animations-Endwerte)
	/// - ClearValue(dp): Entfernt LOCAL VALUE, Wert fällt zurück zu Style/Default
	/// - ReadLocalValue(dp): Liest nur LOCAL VALUE, gibt UnsetValue wenn nicht gesetzt
	/// 
	/// DEBUGGING mit DependencyPropertyHelper:
	/// - GetValueSource(): Zeigt Quelle des aktuellen Werts (BaseValueSource)
	/// - Unverzichtbar für komplexe Style-Hierarchien
	/// - Hilft bei der Diagnose von überschriebenen Styles
	/// </summary>
	public partial class App : Application {
	}
}
