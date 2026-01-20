using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ResourcesProperty {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// <remarks>
	/// RESOURCEDICTIONARY PROPERTY DEMONSTRATION
	/// 
	/// Diese Anwendung demonstriert die programmatische Verwendung der Resources-Property
	/// und des ResourceDictionary-Objekts in WPF.
	/// 
	/// RESOURCEDICTIONARY GRUNDLAGEN:
	/// - Jedes FrameworkElement besitzt eine Resources-Property vom Typ ResourceDictionary
	/// - ResourceDictionary ist eine Dictionary-Implementierung für WPF-Ressourcen
	/// - Speichert Key-Value-Paare (object-Keys, object-Values)
	/// - Unterstützt sowohl XAML- als auch Code-Behind-Definition
	/// 
	/// RESOURCEDICTIONARY API:
	/// - Add(key, value) - Fügt Resource hinzu
	/// - Remove(key) - Entfernt Resource
	/// - Contains(key) - Prüft Existenz einer Resource
	/// - this[key] - Indexer für Zugriff und Zuweisung
	/// - Clear() - Entfernt alle Resources
	/// - MergedDictionaries - Collection für zusammengeführte Dictionaries
	/// 
	/// RESOURCES PROPERTY:
	/// - Type: ResourceDictionary
	/// - Verfügbar auf: Application, Window, FrameworkElement
	/// - Kann zur Laufzeit ersetzt werden (this.Resources = new ResourceDictionary())
	/// - Kann zur Laufzeit modifiziert werden (this.Resources.Add(...))
	/// 
	/// ANWENDUNGSFÄLLE:
	/// - Dynamisches Laden von Theme-Ressourcen
	/// - Programmatische Resource-Erstellung
	/// - Runtime-Manipulation von Styles
	/// - Conditional Resource Loading
	/// </remarks>
	public partial class App : Application {
	}
}
