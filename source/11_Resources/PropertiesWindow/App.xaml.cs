using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PropertiesWindow {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// <remarks>
	/// PROPERTIES WINDOW DEMONSTRATION - FindResource und TryFindResource
	/// 
	/// Diese Anwendung demonstriert die programmatischen Methoden zum Auffinden
	/// von Resources in WPF: FindResource() und TryFindResource().
	/// 
	/// FINDRESOURCE() METHODE:
	/// Syntax: object resource = frameworkElement.FindResource(object resourceKey)
	/// 
	/// Eigenschaften:
	/// - Durchsucht die Resource-Hierarchie (Control → Parent → Window → Application)
	/// - Wirft ResourceReferenceKeyNotFoundException wenn nicht gefunden
	/// - Äquivalent zu {StaticResource} in XAML
	/// - Return-Type: object (muss gecastet werden)
	/// 
	/// Beispiel:
	/// var brush = (SolidColorBrush)this.FindResource("MainBrush");
	/// button.Background = brush;
	/// 
	/// TRYFINDRESOURCE() METHODE:
	/// Syntax: object resource = frameworkElement.TryFindResource(object resourceKey)
	/// 
	/// Eigenschaften:
	/// - Durchsucht die Resource-Hierarchie wie FindResource()
	/// - Gibt NULL zurück wenn nicht gefunden (keine Exception)
	/// - Sicherer für optionale Resources
	/// - Äquivalent zu {DynamicResource} in XAML (in Bezug auf fehlertolerantes Verhalten)
	/// - Return-Type: object (muss gecastet werden)
	/// 
	/// Beispiel:
	/// var brush = this.TryFindResource("MainBrush") as SolidColorBrush;
	/// if (brush != null) {
	///     button.Background = brush;
	/// }
	/// 
	/// VERGLEICH FINDRESOURCE VS. TRYFINDRESOURCE:
	/// 
	/// FindResource:
	/// + Exception macht Fehler sofort sichtbar
	/// + Erzwingt Vorhandensein der Resource
	/// - Kann zu Runtime-Crashes führen
	/// - Erfordert try-catch für optionale Resources
	/// 
	/// TryFindResource:
	/// + Keine Exception bei fehlender Resource
	/// + Ideal für optionale Resources
	/// + Sicherer für dynamische Szenarien
	/// - Fehler werden erst später sichtbar (null-Reference)
	/// - Erfordert null-Checks
	/// 
	/// WANN WELCHE METHODE VERWENDEN:
	/// 
	/// Verwende FindResource() wenn:
	/// - Die Resource MUSS existieren
	/// - Fehlen der Resource ist ein kritischer Fehler
	/// - In kontrollierten Umgebungen (z.B. bekannte Themes)
	/// 
	/// Verwende TryFindResource() wenn:
	/// - Die Resource optional ist
	/// - Fallback-Logik implementiert werden soll
	/// - In dynamischen Szenarien (Plugin-System, User-Themes)
	/// - Bei unsicheren Resource-Quellen
	/// 
	/// APPLICATION.CURRENT.FINDRESOURCE():
	/// - Sucht nur in Application.Resources (nicht in Window/Control-Resources)
	/// - Nützlich für garantiert globale Resources
	/// 
	/// RESOURCE-LOOKUP-HIERARCHIE:
	/// 1. this.FindResource("Key") - sucht ab aktuellem Element aufwärts
	/// 2. Durchsucht visuelle Hierarchie (Parents)
	/// 3. Durchsucht Window.Resources
	/// 4. Durchsucht Application.Resources
	/// 5. Durchsucht System Resources
	/// </remarks>
	public partial class App : Application {
	}
}
