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

namespace Hierarchy {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// <remarks>
	/// HAUPTFENSTER - Resource Hierarchy Demonstration
	/// 
	/// Demonstriert den hierarchischen Resource-Lookup-Mechanismus in WPF durch
	/// Definieren derselben Resource-Keys auf verschiedenen Hierarchie-Ebenen.
	/// 
	/// RESOURCE LOOKUP DEMONSTRATION:
	/// Im XAML werden Resources auf mehreren Ebenen definiert:
	/// - Application.Resources (in App.xaml)
	/// - Window.Resources (in MainWindow.xaml)
	/// - Control.Resources (z.B. in StackPanel.Resources)
	/// 
	/// LOOKUP-REIHENFOLGE BEISPIEL:
	/// Wenn ein Button {StaticResource MyBrush} verwendet:
	/// 1. Suche in Button.Resources → nicht gefunden
	/// 2. Suche in Parent (StackPanel).Resources → gefunden! (Verwendung dieser Resource)
	/// 3. (Optional) Suche in Window.Resources → übersprungen, da bereits gefunden
	/// 4. (Optional) Suche in Application.Resources → übersprungen, da bereits gefunden
	/// 
	/// ÜBERSCHREIBUNG VON RESOURCES:
	/// - Resources in inneren Elementen überschreiben äußere Resources mit gleichem Key
	/// - Ermöglicht lokale Anpassungen ohne globale Änderungen
	/// - Nützlich für Theming und kontextabhängige Styles
	/// 
	/// PRAKTISCHES BEISPIEL:
	/// Application.Resources: ButtonBackground = Blue (Standard für gesamte App)
	/// Window.Resources: ButtonBackground = Red (überschreibt für dieses Window)
	/// StackPanel.Resources: ButtonBackground = Green (überschreibt nur für dieses Panel)
	/// 
	/// VORTEILE DER HIERARCHIE:
	/// - Flexibilität durch kontextabhängige Überschreibung
	/// - Wiederverwendung durch globale Definition
	/// - Kapselung durch lokale Definition
	/// - Weniger Code-Duplikation
	/// </remarks>
	public partial class MainWindow : Window {
		public MainWindow() {
			// InitializeComponent() initialisiert alle Resources in der Hierarchie:
			// 1. Lädt Application.Resources (falls in App.xaml definiert)
			// 2. Lädt Window.Resources aus dem XAML
			// 3. Lädt alle Control.Resources im Visual Tree
			// 4. Baut die Resource-Lookup-Chain auf
			InitializeComponent();
		}
	}
}
