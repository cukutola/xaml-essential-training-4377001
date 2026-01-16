using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MarkupExtensions {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// <remarks>
	/// MARKUP EXTENSIONS DEMONSTRATION - StaticResource vs. DynamicResource
	/// 
	/// Diese Anwendung demonstriert den Unterschied zwischen StaticResource und DynamicResource
	/// Markup Extensions in WPF und deren Auswirkungen auf Resource-Lookups.
	/// 
	/// MARKUP EXTENSIONS GRUNDLAGEN:
	/// - Spezielle XAML-Syntax mit geschweiften Klammern: {MarkupExtension ...}
	/// - Erweitern XAML-Funktionalität zur Laufzeit
	/// - Implementieren System.Windows.Markup.MarkupExtension
	/// - Werden vom XAML-Parser speziell behandelt
	/// 
	/// STATICRESOURCE MARKUP EXTENSION:
	/// Syntax: {StaticResource ResourceKey}
	/// - COMPILE-TIME LOOKUP: Resource wird beim Laden des XAML aufgelöst
	/// - Einmalige Auflösung während der Initialisierung
	/// - Bessere Performance (keine Runtime-Überwachung)
	/// - Resource MUSS existieren beim Laden, sonst Exception
	/// - Änderungen an der Resource zur Laufzeit werden NICHT reflektiert
	/// - Standard-Wahl für statische Resources (Brushes, Styles, Templates)
	/// 
	/// DYNAMICRESOURCE MARKUP EXTENSION:
	/// Syntax: {DynamicResource ResourceKey}
	/// - RUNTIME LOOKUP: Resource wird zur Laufzeit aufgelöst und überwacht
	/// - Aktualisiert sich automatisch bei Resource-Änderungen
	/// - Höherer Speicher- und Performance-Overhead
	/// - Resource kann initial fehlen (kein Fehler)
	/// - Ideal für Theme-Switching und dynamische Resource-Änderungen
	/// - Verwendet bei Styles, die sich zur Laufzeit ändern können
	/// 
	/// VERGLEICH STATICRESOURCE VS. DYNAMICRESOURCE:
	/// 
	/// StaticResource:
	/// + Schneller (einmalige Auflösung)
	/// + Weniger Speicherverbrauch
	/// + Fehler sofort sichtbar (Compile/Load-Zeit)
	/// - Keine Unterstützung für Runtime-Änderungen
	/// - Muss bei XAML-Parse existieren
	/// 
	/// DynamicResource:
	/// + Unterstützt Runtime-Änderungen
	/// + Resource kann später definiert werden
	/// + Ideal für Theming
	/// - Langsamer (Lookup-Overhead)
	/// - Höherer Speicherverbrauch
	/// - Fehler erst zur Laufzeit sichtbar
	/// 
	/// ANDERE WICHTIGE MARKUP EXTENSIONS:
	/// - {Binding} - Data Binding
	/// - {x:Static} - Zugriff auf statische Eigenschaften/Felder
	/// - {x:Type} - Type-Referenzen
	/// - {x:Null} - Null-Wert
	/// - {TemplateBinding} - Binding in ControlTemplates
	/// - {RelativeSource} - Relative Binding-Quellen
	/// 
	/// X:STATIC MARKUP EXTENSION:
	/// Syntax: {x:Static Member=Typ.StatischeMember}
	/// Beispiel: {x:Static SystemColors.WindowBrush}
	/// - Zugriff auf statische Properties, Fields, Enums
	/// - Nützlich für System-Konstanten und Enum-Werte
	/// </remarks>
	public partial class App : Application {
	}
}
