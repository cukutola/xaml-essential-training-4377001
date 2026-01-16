using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PackUri {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// <remarks>
	/// PACK URI DEMONSTRATION - Pack URIs für Ressourcen-Zugriff
	/// 
	/// Diese Anwendung demonstriert die Verwendung von Pack URIs (Uniform Resource Identifiers)
	/// zum Zugriff auf Ressourcen in WPF-Anwendungen.
	/// 
	/// PACK URI GRUNDLAGEN:
	/// - Pack URIs ermöglichen den Zugriff auf eingebettete Ressourcen über eine standardisierte URI-Syntax
	/// - Syntax: pack://application:,,,/AssemblyName;component/Pfad/zur/Ressource
	/// - Für lokale Assembly: pack://application:,,,/Ordner/Datei.xaml
	/// - Für externe Assembly: pack://application:,,,/ReferencedAssembly;component/Folder/File.xaml
	/// 
	/// PACK URI SCHEMA:
	/// - pack://authority/path
	/// - authority: "application:,,," für Anwendungsressourcen
	/// - authority: "siteoforigin:,,," für Ressourcen vom Ursprungsort
	/// 
	/// ANWENDUNGSFÄLLE:
	/// - Laden von Resource Dictionaries: Source="pack://application:,,,/Themes/Generic.xaml"
	/// - Zugriff auf Bilder: Source="pack://application:,,,/Images/Logo.png"
	/// - Navigation zu XAML-Seiten: NavigationService.Navigate(new Uri("pack://..."))
	/// 
	/// VORTEILE:
	/// - Plattformunabhängiger Zugriff auf Ressourcen
	/// - Unterstützung für assembly-übergreifende Ressourcen
	/// - Konsistente URI-basierte Adressierung
	/// </remarks>
	public partial class App : Application {
	}
}
