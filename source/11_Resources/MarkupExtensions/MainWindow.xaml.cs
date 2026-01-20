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

namespace MarkupExtensions {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// <remarks>
	/// HAUPTFENSTER - StaticResource vs. DynamicResource Demonstration
	/// 
	/// Zeigt den praktischen Unterschied zwischen StaticResource und DynamicResource
	/// durch Runtime-Manipulation des ResourceDictionary.
	/// 
	/// XAML-SETUP (typisch):
	/// Im XAML werden Controls mit beiden Markup Extensions definiert:
	/// 
	/// <!-- StaticResource-Beispiel -->
	/// <TextBlock Background="{StaticResource MainBrush}" Text="Static" />
	/// 
	/// <!-- DynamicResource-Beispiel -->
	/// <TextBlock Background="{DynamicResource MainBrush}" Text="Dynamic" />
	/// 
	/// ERWARTETES VERHALTEN:
	/// - Bei Button-Click wird this.Resources komplett ersetzt
	/// - StaticResource-gebundene Controls behalten ihren ursprünglichen Wert
	/// - DynamicResource-gebundene Controls aktualisieren sich automatisch
	/// </remarks>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		/// <summary>
		/// Event Handler für Resource-Änderung - Demonstriert StaticResource vs. DynamicResource
		/// </summary>
		private void ChangeResource_Click(object sender, RoutedEventArgs e) {
			// ERSTELLEN EINES NEUEN RESOURCEDICTIONARY
			// Dies simuliert einen Theme-Wechsel oder eine dynamische Resource-Änderung
			var dictionary = new ResourceDictionary();

			// DEFINIEREN NEUER RESOURCES MIT DENSELBEN KEYS
			// Die Keys sind identisch mit den ursprünglichen Resources,
			// aber die Werte (Farben) sind unterschiedlich
			
			// MainBrush wird von der ursprünglichen Farbe zu Lavender geändert
			dictionary.Add(key: "MainBrush", value: new SolidColorBrush(Colors.Lavender));
			
			// AccentBrush wird zu Gold geändert
			dictionary.Add(key: "AccentBrush", value: new SolidColorBrush(Colors.Gold));
			
			// ERSETZEN DES GESAMTEN RESOURCEDICTIONARY
			// WICHTIG: Dies ist eine komplette Ersetzung, keine Modifikation!
			this.Resources = dictionary;
			
			// AUSWIRKUNGEN:
			// 
			// StaticResource-Bindings:
			// - Werden NICHT aktualisiert
			// - Behalten ihre ursprünglichen Werte (die beim Laden gesetzt wurden)
			// - Grund: StaticResource ist eine einmalige Auflösung zur Parse-Zeit
			// 
			// DynamicResource-Bindings:
			// - Werden SOFORT aktualisiert
			// - Überwachen das ResourceDictionary auf Änderungen
			// - Holen sich automatisch die neuen Werte
			// 
			// ALTERNATIVE ANSÄTZE:
			// 1. Modifikation statt Ersetzung:
			//    this.Resources["MainBrush"] = new SolidColorBrush(Colors.Lavender);
			//    → Würde auch DynamicResource aktualisieren
			// 
			// 2. MergedDictionaries verwenden:
			//    this.Resources.MergedDictionaries.Clear();
			//    this.Resources.MergedDictionaries.Add(dictionary);
			//    → Sauberere Trennung von Theme-Resources
			
			// Feedback-Nachricht für Benutzer
			MessageTextBlock.Text = "Dictionary replaced...";
		}
	}
}
