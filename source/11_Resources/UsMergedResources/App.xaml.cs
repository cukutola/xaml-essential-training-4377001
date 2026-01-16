using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UseMergedResources {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// <remarks>
	/// MERGED DICTIONARIES DEMONSTRATION
	/// 
	/// Diese Anwendung demonstriert die Verwendung von MergedDictionaries für modulare
	/// und wiederverwendbare Resource-Definitionen in WPF.
	/// 
	/// MERGEDDICTIONARIES KONZEPT:
	/// - Ermöglicht das Kombinieren mehrerer ResourceDictionaries
	/// - Resources aus allen Dictionaries sind transparent verfügbar
	/// - Unterstützt Modularisierung und Wiederverwendung
	/// - Ideal für Theme-Management und Bibliotheks-Resources
	/// 
	/// VERWENDUNG VON MERGEDDICTIONARIES:
	/// 
	/// In App.xaml (Application-Level):
	/// <Application.Resources>
	///   <ResourceDictionary>
	///     <ResourceDictionary.MergedDictionaries>
	///       <ResourceDictionary Source="Themes/Colors.xaml"/>
	///       <ResourceDictionary Source="Themes/Brushes.xaml"/>
	///       <ResourceDictionary Source="Styles/Buttons.xaml"/>
	///       <ResourceDictionary Source="pack://application:,,,/MyLibrary;component/Styles/Generic.xaml"/>
	///     </ResourceDictionary.MergedDictionaries>
	///   </ResourceDictionary>
	/// </Application.Resources>
	/// 
	/// In Window.xaml (Window-Level):
	/// <Window.Resources>
	///   <ResourceDictionary>
	///     <ResourceDictionary.MergedDictionaries>
	///       <ResourceDictionary Source="WindowSpecificStyles.xaml"/>
	///     </ResourceDictionary.MergedDictionaries>
	///     <!-- Lokale Resources können zusätzlich definiert werden -->
	///     <SolidColorBrush x:Key="LocalBrush" Color="Red"/>
	///   </ResourceDictionary>
	/// </Window.Resources>
	/// 
	/// MERGE-REIHENFOLGE UND ÜBERSCHREIBUNG:
	/// - Dictionaries werden in der Reihenfolge ihrer Definition verarbeitet
	/// - Bei Key-Konflikten: Das LETZTE Dictionary in der Liste gewinnt
	/// - Lokale Resources (außerhalb MergedDictionaries) haben höchste Priorität
	/// 
	/// Beispiel:
	/// <ResourceDictionary.MergedDictionaries>
	///   <ResourceDictionary Source="Theme1.xaml"/> <!-- MainBrush = Blue -->
	///   <ResourceDictionary Source="Theme2.xaml"/> <!-- MainBrush = Red -->
	/// </ResourceDictionary.MergedDictionaries>
	/// <SolidColorBrush x:Key="MainBrush" Color="Green"/> <!-- Gewinnt! -->
	/// → MainBrush ist Green (lokale Definition überschreibt)
	/// 
	/// VORTEILE VON MERGEDDICTIONARIES:
	/// - Modularisierung: Trennung nach Funktionalität (Colors, Brushes, Styles, etc.)
	/// - Wiederverwendung: Gleiche Dictionary in mehreren Projekten
	/// - Theme-Switching: Austausch kompletter Theme-Dictionaries zur Laufzeit
	/// - Wartbarkeit: Kleinere, fokussierte Resource-Dateien
	/// - Team-Collaboration: Verschiedene Entwickler arbeiten an verschiedenen Dictionaries
	/// 
	/// PROGRAMMATI SCHES MERGEN:
	/// var dict = new ResourceDictionary();
	/// dict.Source = new Uri("/Themes/Dark.xaml", UriKind.Relative);
	/// Application.Current.Resources.MergedDictionaries.Add(dict);
	/// 
	/// THEME-SWITCHING ZUR LAUFZEIT:
	/// Application.Current.Resources.MergedDictionaries.Clear();
	/// Application.Current.Resources.MergedDictionaries.Add(darkTheme);
	/// → Alle DynamicResource-Bindings aktualisieren sich automatisch
	/// </remarks>
	public partial class App : Application {
	}
}
