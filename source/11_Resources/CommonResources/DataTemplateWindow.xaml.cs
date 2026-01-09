// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente (ListBox, ContentControl, etc.).
using System.Windows.Controls;
// System.Windows.Data: Data Binding.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;

// Namespace für CommonResources-Demos.
namespace CommonResources {
	/// <summary>
	/// Interaction logic for DataTemplateWindow.xaml
	/// </summary>
	// 'DataTemplateWindow': Fenster für DataTemplate-Ressourcen-Demo.
	// ZWECK: Demonstriert Definition und Verwendung von DataTemplates.
	// DATATEMPLATE-KONZEPT: Definiert, WIE Datenobjekte visuell dargestellt werden.
	// UNTERSCHIED zu ToString(): Statt String-Darstellung → volle XAML-UI-Struktur.
	// EINSATZZWECK: Custom Rendering von Items in ListBox, ComboBox, ContentControl.
	// DATATEMPLATE-VORTEILE:
	// - Volle Kontrolle über visuelle Darstellung von Daten
	// - Data Binding innerhalb des Templates
	// - Wiederverwendbare Templates als Ressourcen
	// - Trennung von Daten und Präsentation (MVVM-Pattern)
	// BEISPIEL XAML:
	// <Window.Resources>
	//   <DataTemplate x:Key="TreeTemplate">
	//     <StackPanel>
	//       <TextBlock Text="{Binding TreeName}" FontWeight="Bold"/>
	//       <TextBlock Text="{Binding MaxHeight, StringFormat={}Height: {0}m}"/>
	//     </StackPanel>
	//   </DataTemplate>
	// </Window.Resources>
	// <ListBox ItemsSource="{StaticResource TreeData}" 
	//          ItemTemplate="{StaticResource TreeTemplate}"/>
	// BINDING-CONTEXT: DataContext innerhalb des Templates ist das Datenobjekt (Tree).
	public partial class DataTemplateWindow : Window {
		// Konstruktor: Initialisiert das Fenster.
		public DataTemplateWindow() {
			// Lädt XAML mit DataTemplate-Definitionen.
			// XAML-DEMO: Zeigt vermutlich ListBox mit Trees-Collection und custom DataTemplate.
			// TEMPLATE-ANWENDUNG: ItemTemplate, ContentTemplate, oder CellTemplate.
			// HIERARCHICAL DATA: HierarchicalDataTemplate für Baum-Strukturen (TreeView).
			InitializeComponent();
		}
	}
}
