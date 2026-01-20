using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LoadResourceFile {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// <remarks>
	/// LADEN VON EXTERNEN RESOURCE-DATEIEN
	/// 
	/// Diese Anwendung demonstriert das Laden von ResourceDictionaries aus externen XAML-Dateien.
	/// Dies ist ein wichtiger Aspekt für modulare und wartbare WPF-Anwendungen.
	/// 
	/// EXTERNE RESOURCEDICTIONARY-DATEIEN:
	/// - Separate XAML-Dateien die nur Resources enthalten
	/// - Root-Element: <ResourceDictionary>
	/// - Typischerweise in Ordnern wie /Themes, /Styles, /Resources organisiert
	/// - Build Action: "Resource" oder "Page"
	/// 
	/// LADEN VON RESOURCE-DATEIEN - METHODEN:
	/// 
	/// 1. MERGED DICTIONARIES IN XAML:
	///    <Window.Resources>
	///      <ResourceDictionary>
	///        <ResourceDictionary.MergedDictionaries>
	///          <ResourceDictionary Source="Themes/MyTheme.xaml"/>
	///          <ResourceDictionary Source="pack://application:,,,/Library;component/Styles.xaml"/>
	///        </ResourceDictionary.MergedDictionaries>
	///      </ResourceDictionary>
	///    </Window.Resources>
	/// 
	/// 2. PROGRAMMATISCHES LADEN IN CODE-BEHIND:
	///    var dict = new ResourceDictionary();
	///    dict.Source = new Uri("/Themes/MyTheme.xaml", UriKind.Relative);
	///    this.Resources.MergedDictionaries.Add(dict);
	/// 
	/// 3. DYNAMISCHES LADEN MIT PACK URI:
	///    var uri = new Uri("pack://application:,,,/MyAssembly;component/Themes/Dark.xaml");
	///    var dict = new ResourceDictionary { Source = uri };
	///    Application.Current.Resources.MergedDictionaries.Add(dict);
	/// 
	/// MERGEDDICTIONARIES PROPERTY:
	/// - Collection<ResourceDictionary> für zusammengeführte Dictionaries
	/// - Resources aus allen MergedDictionaries sind verfügbar
	/// - Spätere Dictionaries überschreiben frühere bei Key-Konflikten
	/// - Ermöglicht Modularisierung und Theme-Switching
	/// 
	/// VORTEILE EXTERNER RESOURCE-DATEIEN:
	/// - Wiederverwendbarkeit über mehrere Windows/Controls
	/// - Bessere Organisation und Wartbarkeit
	/// - Theme-Unterstützung (Light/Dark)
	/// - Lazy Loading möglich
	/// - Team-Collaboration (getrennte Dateien)
	/// </remarks>
	public partial class App : Application {
	}
}
