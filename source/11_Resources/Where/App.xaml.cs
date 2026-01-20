using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Where {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// <remarks>
	/// WHERE TO DEFINE RESOURCES - Resource-Definitionsstrategien
	/// 
	/// Diese Anwendung demonstriert verschiedene Orte, an denen Resources in WPF
	/// definiert werden können, und die Auswirkungen auf Scope und Wiederverwendbarkeit.
	/// 
	/// ORTE FÜR RESOURCE-DEFINITIONEN:
	/// 
	/// 1. APPLICATION.RESOURCES (App.xaml):
	///    <Application.Resources>
	///      <SolidColorBrush x:Key="GlobalBrush" Color="Blue"/>
	///    </Application.Resources>
	///    
	///    Eigenschaften:
	///    - Globaler Scope (gesamte Anwendung)
	///    - Verfügbar in allen Windows und Controls
	///    - Lebensdauer: Gesamte Anwendungslaufzeit
	///    - Ideal für: Anwendungsweite Themes, gemeinsame Styles, Brushes
	///    - Zugriff: Application.Current.Resources["GlobalBrush"]
	/// 
	/// 2. WINDOW.RESOURCES (MainWindow.xaml, etc.):
	///    <Window.Resources>
	///      <SolidColorBrush x:Key="WindowBrush" Color="Red"/>
	///    </Window.Resources>
	///    
	///    Eigenschaften:
	///    - Window-Scope (nur in diesem Window)
	///    - Verfügbar für alle Controls in diesem Window
	///    - Lebensdauer: Solange das Window existiert
	///    - Ideal für: Window-spezifische Styles und Resources
	///    - Zugriff: this.Resources["WindowBrush"] (im Window)
	/// 
	/// 3. CONTROL.RESOURCES (StackPanel, Grid, etc.):
	///    <StackPanel.Resources>
	///      <SolidColorBrush x:Key="PanelBrush" Color="Green"/>
	///    </StackPanel.Resources>
	///    
	///    Eigenschaften:
	///    - Control-Scope (nur für dieses Control und Children)
	///    - Höchste Priorität bei Resource-Lookup
	///    - Lebensdauer: Solange das Control existiert
	///    - Ideal für: Sehr lokale, kontextspezifische Resources
	/// 
	/// 4. EXTERNE RESOURCEDICTIONARY-DATEIEN:
	///    Separate .xaml-Dateien mit <ResourceDictionary> als Root
	///    Laden über MergedDictionaries
	///    
	///    Eigenschaften:
	///    - Wiederverwendbar über mehrere Projekte
	///    - Ideal für: Themes, gemeinsame Style-Bibliotheken
	///    - Ermöglicht Modularisierung
	/// 
	/// ENTSCHEIDUNGSKRITERIEN:
	/// 
	/// Verwende Application.Resources für:
	/// - Anwendungsweite Brushes, Colors, Fonts
	/// - Globale Styles (z.B. Standard-Button-Style)
	/// - Converter und Ressourcen, die überall verwendet werden
	/// 
	/// Verwende Window.Resources für:
	/// - Window-spezifische Styles
	/// - Resources, die nur in einem Window benötigt werden
	/// - Überschreibung von Application.Resources für ein spezielles Window
	/// 
	/// Verwende Control.Resources für:
	/// - Sehr lokale, einmalige Resources
	/// - Überschreibung von übergeordneten Resources
	/// - Kapselung und Isolation
	/// 
	/// Verwende externe Dateien für:
	/// - Wiederverwendbare Theme-Bibliotheken
	/// - Große Mengen von Resources
	/// - Team-Collaboration (separate Dateien)
	/// </remarks>
	public partial class App : Application {
	}
}
