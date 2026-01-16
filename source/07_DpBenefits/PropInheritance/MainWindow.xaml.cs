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

namespace PropInheritance {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// 
	/// PROPERTY INHERITANCE - Hauptfenster:
	/// - Demonstriert Property Inheritance im Visual Tree
	/// - Zeigt wie Parent-Werte an Children weitergegeben werden
	/// 
	/// INHERITED VALUES in Value Precedence:
	/// - Niedrigste Priorität: Local > Style > Default > Inherited
	/// - Nur für Properties mit FrameworkPropertyMetadataOptions.Inherits
	/// - Automatische Propagation im gesamten Visual Tree
	/// 
	/// TYPISCHE INHERITABLE PROPERTIES:
	/// - FontFamily, FontSize, FontWeight, FontStyle
	/// - Foreground
	/// - DataContext (wichtig für Data Binding)
	/// - FlowDirection (für RTL-Sprachen)
	/// - Language, Culture
	/// 
	/// PERFORMANCE-ASPEKTE:
	/// - Sparse Storage: Keine Memory-Duplikation für geerbte Werte
	/// - Effiziente Change Notification im Subtree
	/// - Wert wird nur einmal im Parent gespeichert
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		/// <summary>
		/// Platzhalter für Rectangle-Demo
		/// - Würde Property Inheritance für Standard-Shapes zeigen
		/// </summary>
		private void RectButton_Click(object sender, RoutedEventArgs e) {
		
		}

		/// <summary>
		/// Öffnet das ManyStars-Fenster
		/// 
		/// PROPERTY INHERITANCE in Aktion:
		/// - Stars erben Properties vom Window/Container
		/// - Demonstriert wie ein einzelner Wert auf Parent-Ebene
		///   automatisch auf alle Children angewendet wird
		/// - Zeigt Memory Efficiency durch Sparse Storage
		/// 
		/// WICHTIG:
		/// - Custom Properties müssen explizit als Inheritable registriert werden
		/// - Standard-WPF-Properties wie FontSize sind bereits Inheritable
		/// - ClearValue() auf Child stellt Inheritance wieder her
		/// </summary>
		private void StarButton_Click(object sender, RoutedEventArgs e) {
			(new ManyStars()).Show();
		}
	}
}
