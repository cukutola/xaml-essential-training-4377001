using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoadResourceFile {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// <remarks>
	/// HAUPTFENSTER - Externe ResourceDictionary-Dateien
	/// 
	/// Demonstriert das Laden und Verwenden von Resources aus externen XAML-Dateien.
	/// Die eigentliche Konfiguration erfolgt typischerweise im XAML über MergedDictionaries.
	/// 
	/// XAML-KONFIGURATION (typischerweise in MainWindow.xaml):
	/// <Window.Resources>
	///   <ResourceDictionary>
	///     <ResourceDictionary.MergedDictionaries>
	///       <!-- Lokale Resource-Datei -->
	///       <ResourceDictionary Source="/Styles/ButtonStyles.xaml"/>
	///       
	///       <!-- Resource aus anderer Assembly -->
	///       <ResourceDictionary Source="pack://application:,,,/MyLibrary;component/Themes/Generic.xaml"/>
	///       
	///       <!-- Weitere Dictionaries -->
	///       <ResourceDictionary Source="/Themes/Colors.xaml"/>
	///       <ResourceDictionary Source="/Themes/Fonts.xaml"/>
	///     </ResourceDictionary.MergedDictionaries>
	///     
	///     <!-- Lokale Resources (überschreiben MergedDictionaries bei Konflikten) -->
	///     <SolidColorBrush x:Key="OverrideBrush" Color="Red"/>
	///   </ResourceDictionary>
	/// </Window.Resources>
	/// 
	/// MERGE-REIHENFOLGE UND PRIORITÄT:
	/// - MergedDictionaries werden in der Reihenfolge verarbeitet, in der sie definiert sind
	/// - Bei Key-Konflikten: Spätere Dictionaries überschreiben frühere
	/// - Lokale Resources (nicht in MergedDictionaries) haben höchste Priorität
	/// 
	/// VORTEILE DER MODULARISIERUNG:
	/// - Trennung von Concerns (Buttons, TextBoxes, Colors separat)
	/// - Wiederverwendung über mehrere Windows
	/// - Einfacheres Theming
	/// - Bessere Wartbarkeit und Übersichtlichkeit
	/// </remarks>
	public partial class MainWindow : Window {
		public MainWindow() {
			// InitializeComponent() lädt automatisch alle MergedDictionaries,
			// die im XAML definiert sind.
			// 
			// Die Resource-Dateien werden beim Parsen des XAML geladen und
			// ihre Inhalte stehen sofort für StaticResource-Referenzen zur Verfügung.
			InitializeComponent();
			
			// PROGRAMMATISCHES LADEN (Alternative zu XAML-Definition):
			// var externalDict = new ResourceDictionary();
			// externalDict.Source = new Uri("/Themes/MyTheme.xaml", UriKind.Relative);
			// this.Resources.MergedDictionaries.Add(externalDict);
		}
	}
}
