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

namespace PropertiesWindow {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// <remarks>
	/// HAUPTFENSTER - FindResource/TryFindResource Demonstration
	/// 
	/// Demonstriert die programmatische Suche und Verwendung von Resources
	/// mittels FindResource() und TryFindResource() Methoden.
	/// 
	/// PRAKTISCHE ANWENDUNGSBEISPIELE:
	/// 
	/// Im Code-Behind dieses Windows könnten folgende Szenarien implementiert sein:
	/// 
	/// 1. DIREKTE RESOURCE-ANWENDUNG:
	///    var mainBrush = (SolidColorBrush)this.FindResource("MainBrush");
	///    myButton.Background = mainBrush;
	///    
	/// 2. OPTIONALE RESOURCE MIT FALLBACK:
	///    var customBrush = this.TryFindResource("CustomBrush") as SolidColorBrush;
	///    myButton.Background = customBrush ?? Brushes.Gray;
	///    
	/// 3. STYLE-ANWENDUNG:
	///    var buttonStyle = (Style)this.FindResource("MyButtonStyle");
	///    myButton.Style = buttonStyle;
	///    
	/// 4. DATATEMPLATE-ANWENDUNG:
	///    var template = (DataTemplate)this.FindResource("PersonTemplate");
	///    contentControl.ContentTemplate = template;
	/// 
	/// 5. DYNAMISCHES THEMING:
	///    private void ApplyTheme(string themeName) {
	///        var primaryBrush = this.TryFindResource($"{themeName}PrimaryBrush") as SolidColorBrush;
	///        var secondaryBrush = this.TryFindResource($"{themeName}SecondaryBrush") as SolidColorBrush;
	///        
	///        if (primaryBrush != null) {
	///            // Theme anwenden
	///        } else {
	///            // Fallback Theme verwenden
	///        }
	///    }
	/// 
	/// 6. RESOURCE-EXISTENZ-PRÜFUNG:
	///    if (this.TryFindResource("DebugMode") != null) {
	///        // Debug-spezifisches Verhalten
	///    }
	/// 
	/// FEHLERBEHANDLUNG:
	/// 
	/// Mit FindResource:
	/// try {
	///     var resource = this.FindResource("MaybeExistingResource");
	///     // Verwenden der Resource
	/// } catch (ResourceReferenceKeyNotFoundException) {
	///     // Fehlerbehandlung oder Fallback
	/// }
	/// 
	/// Mit TryFindResource (bevorzugt):
	/// var resource = this.TryFindResource("MaybeExistingResource");
	/// if (resource != null) {
	///     // Verwenden der Resource
	/// } else {
	///     // Fallback-Logik
	/// }
	/// 
	/// PERFORMANCE-ÜBERLEGUNGEN:
	/// - Beide Methoden durchsuchen die gesamte Hierarchie
	/// - Caching bei häufiger Verwendung erwägen:
	///   private SolidColorBrush _cachedBrush;
	///   _cachedBrush ??= (SolidColorBrush)this.FindResource("MainBrush");
	/// </remarks>
	public partial class MainWindow : Window {
		public MainWindow() {
			// InitializeComponent() lädt alle XAML-definierten Resources
			// Danach sind sie via FindResource/TryFindResource verfügbar
			InitializeComponent();
			
			// BEISPIEL: Programmatische Resource-Verwendung
			// (In einer echten Anwendung würde hier Code stehen, der FindResource/TryFindResource verwendet)
			
			// Beispiel mit FindResource (wirft Exception wenn nicht gefunden):
			// var mainBrush = (SolidColorBrush)this.FindResource("MainBrush");
			// this.Background = mainBrush;
			
			// Beispiel mit TryFindResource (gibt null zurück wenn nicht gefunden):
			// var accentBrush = this.TryFindResource("AccentBrush") as SolidColorBrush;
			// if (accentBrush != null) {
			//     this.BorderBrush = accentBrush;
			// }
		}
	}
}
