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

namespace Precedence {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// 
	/// PRECEDENCE PROJEKT - Hauptfenster:
	/// - Zeigt drei verschiedene Demos zur Value Precedence
	/// - Demonstriert das Kernkonzept von Dependency Properties
	/// 
	/// VALUE PRECEDENCE SYSTEM (von hoch zu niedrig):
	/// 1. Animated (während Animation läuft)
	/// 2. Local (direkte Zuweisung in XAML/Code)
	/// 3. Triggered (Property/Event/Data Triggers)
	/// 4. Style (Style Setter)
	/// 5. Default (PropertyMetadata.DefaultValue)
	/// 6. Inherited (von Parent im Visual Tree)
	/// 
	/// WICHTIGE METHODEN:
	/// - SetValue(): Setzt LOCAL VALUE (hohe Priorität)
	/// - SetCurrentValue(): Setzt Wert ohne Local Precedence (respektiert Bindings)
	/// - ClearValue(): Entfernt LOCAL VALUE, fällt zurück auf Style/Default
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		/// <summary>
		/// Öffnet Demo 1: Grundlegende Precedence
		/// - Zeigt Local vs. Style vs. Default Werte
		/// - Demonstriert DependencyPropertyHelper.GetValueSource()
		/// - Wichtig: FontWeight Property als Beispiel
		/// </summary>
		private void FirstDemoButton_Click(object sender, RoutedEventArgs e) {
			(new Win1()).Show();
		}

		/// <summary>
		/// Öffnet Demo 2: Trigger Precedence
		/// - Zeigt wie Triggers in die Precedence Hierarchie passen
		/// - Demonstriert Background Property mit verschiedenen Quellen
		/// - Trigger haben Priorität zwischen Local und Style
		/// </summary>
		private void SecondDemoButton_Click(object sender, RoutedEventArgs e) {
			(new Win2()).Show();
		}

		/// <summary>
		/// Öffnet Demo 3: Animation Precedence
		/// - Zeigt dass Animated die höchste Priorität hat
		/// - Demonstriert IsAnimated Flag
		/// - Animation überschreibt temporär sogar LOCAL VALUES
		/// </summary>
		private void ThirdDemoButton_Click(object sender, RoutedEventArgs e) {
			(new Win3()).Show();
		}
	}
}
