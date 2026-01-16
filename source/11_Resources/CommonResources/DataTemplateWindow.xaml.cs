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
using System.Windows.Shapes;

namespace CommonResources {
	/// <summary>
	/// Interaction logic for DataTemplateWindow.xaml
	/// </summary>
	/// <remarks>
	/// DATATEMPLATE WINDOW - Custom Data Rendering mit DataTemplates
	/// 
	/// Demonstriert die Verwendung von DataTemplates zur Steuerung, wie Datenobjekte
	/// visuell dargestellt werden.
	/// 
	/// DATATEMPLATE GRUNDLAGEN:
	/// - Definiert die visuelle Struktur für Datenobjekte
	/// - Wird verwendet in: ContentControl, ItemsControl, ListBox, ComboBox, etc.
	/// - Ermöglicht Trennung von Daten und Präsentation
	/// - Unterstützt Data Binding zum gebundenen Datenobjekt
	/// 
	/// DATATEMPLATE DEFINITION (im XAML dieser Window):
	/// <Window.Resources>
	///   <DataTemplate x:Key="TreeTemplate" DataType="{x:Type local:Tree}">
	///     <StackPanel Orientation="Horizontal">
	///       <TextBlock Text="{Binding TreeName}" FontWeight="Bold" Margin="5"/>
	///       <TextBlock Text="-" Margin="5"/>
	///       <TextBlock Text="{Binding MaxHeight}" Margin="5"/>
	///       <TextBlock Text="feet" Margin="5"/>
	///     </StackPanel>
	///   </DataTemplate>
	/// </Window.Resources>
	/// 
	/// VERWENDUNG VON DATATEMPLATES:
	/// 
	/// 1. EXPLIZITE ZUWEISUNG:
	///    <ContentControl Content="{Binding SelectedTree}" 
	///                    ContentTemplate="{StaticResource TreeTemplate}"/>
	///    
	/// 2. ITEMTEMPLATE IN ITEMSCONTROLS:
	///    <ListBox ItemsSource="{Binding Trees}" 
	///             ItemTemplate="{StaticResource TreeTemplate}"/>
	///    
	/// 3. IMPLIZITES DATATEMPLATE (ohne x:Key):
	///    <DataTemplate DataType="{x:Type local:Tree}">
	///      <!-- Template-Inhalt -->
	///    </DataTemplate>
	///    → Wird automatisch für alle Tree-Objekte verwendet
	/// 
	/// DATA BINDING IM DATATEMPLATE:
	/// - Der DataContext des Templates ist das gebundene Datenobjekt
	/// - {Binding TreeName} bindet an die TreeName-Property des Tree-Objekts
	/// - Voller Zugriff auf alle Properties des Datenobjekts
	/// - Kann Converter und StringFormat verwenden
	/// 
	/// VORTEILE VON DATATEMPLATES:
	/// - Wiederverwendbarkeit: Ein Template für viele Instanzen
	/// - Konsistenz: Alle Objekte gleichen Typs sehen gleich aus
	/// - Wartbarkeit: Änderung an einem Ort wirkt sich überall aus
	/// - Trennung: Geschäftslogik (Model) getrennt von UI (Template)
	/// - Flexibilität: Verschiedene Templates für verschiedene Kontexte
	/// 
	/// ERWEITERTE FEATURES:
	/// - DataTemplateSelector: Programmatische Template-Auswahl
	/// - HierarchicalDataTemplate: Für hierarchische Daten (TreeView)
	/// - Triggers in DataTemplates: Conditional Formatting
	/// </remarks>
	public partial class DataTemplateWindow : Window {
		public DataTemplateWindow() {
			// InitializeComponent() lädt die im XAML definierten DataTemplates
			// Die Templates sind dann verfügbar für ItemTemplate, ContentTemplate, etc.
			InitializeComponent();
			
			// In einer echten Anwendung würde der DataContext hier gesetzt:
			// this.DataContext = new TreeViewModel();
			// 
			// Die Datenquelle (z.B. ObservableCollection<Tree>) würde dann
			// automatisch mit dem definierten DataTemplate gerendert werden
		}
	}
}
