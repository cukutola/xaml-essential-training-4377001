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

namespace UseMergedResources {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// <remarks>
	/// HAUPTFENSTER - MergedDictionaries Demonstration
	/// 
	/// Dieses Window demonstriert die Verwendung von zusammengeführten ResourceDictionaries.
	/// Die eigentliche Konfiguration erfolgt im XAML über MergedDictionaries.
	/// 
	/// TYPISCHE MERGEDDICTIONARIES-STRUKTUR IM XAML:
	/// <Window.Resources>
	///   <ResourceDictionary>
	///     <ResourceDictionary.MergedDictionaries>
	///       <!-- Theme-Dictionaries -->
	///       <ResourceDictionary Source="/Themes/Colors.xaml"/>
	///       <ResourceDictionary Source="/Themes/Brushes.xaml"/>
	///       
	///       <!-- Style-Dictionaries -->
	///       <ResourceDictionary Source="/Styles/ButtonStyles.xaml"/>
	///       <ResourceDictionary Source="/Styles/TextBoxStyles.xaml"/>
	///       
	///       <!-- Externe Assembly-Resources -->
	///       <ResourceDictionary Source="pack://application:,,,/StyleLibrary;component/Generic.xaml"/>
	///     </ResourceDictionary.MergedDictionaries>
	///     
	///     <!-- Window-spezifische Überschreibungen -->
	///     <SolidColorBrush x:Key="SpecialBrush" Color="Purple"/>
	///   </ResourceDictionary>
	/// </Window.Resources>
	/// 
	/// RESOURCE-LOOKUP MIT MERGEDDICTIONARIES:
	/// Wenn ein Control {StaticResource MyBrush} verwendet:
	/// 1. Suche in lokalen Window.Resources → nicht gefunden
	/// 2. Suche in MergedDictionaries (in umgekehrter Reihenfolge)
	/// 3. Suche in Parent-Resources (Application.Resources)
	/// 4. Suche in Application.Resources.MergedDictionaries
	/// 
	/// VORTEILE IN DIESEM BEISPIEL:
	/// - Mehrere Windows können dieselben Style-Dateien verwenden
	/// - Theme-Wechsel durch Austausch der Color/Brush-Dictionaries
	/// - Klare Trennung von Concerns (Colors vs. Styles vs. Templates)
	/// - Einfache Wartung durch kleine, fokussierte Dateien
	/// </remarks>
	public partial class MainWindow : Window {
		public MainWindow() {
			// InitializeComponent() lädt:
			// 1. Alle in Application.Resources.MergedDictionaries definierten Dictionaries
			// 2. Alle in Window.Resources.MergedDictionaries definierten Dictionaries
			// 3. Alle lokalen Resources
			// 
			// Die Resource-Lookup-Chain wird aufgebaut, sodass alle Resources
			// aus allen MergedDictionaries transparent verfügbar sind
			InitializeComponent();
		}
	}
}
