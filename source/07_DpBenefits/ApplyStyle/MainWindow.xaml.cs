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

namespace ApplyStyle {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// 
	/// HAUPTFENSTER für Style-Demonstrationen:
	/// - Zeigt zwei Beispiele: Rectangles und Stars
	/// - Beide demonstrieren Style-Anwendung auf Dependency Properties
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		/// <summary>
		/// Öffnet das Rectangle-Demo-Fenster
		/// - Zeigt Style-Anwendung auf Standard-WPF-Shapes
		/// - Demonstriert STYLE VALUE in der Value Precedence Hierarchie
		/// </summary>
		private void RectButton_Click(object sender, RoutedEventArgs e) {
			(new ManyRectangles()).Show();
		}

		/// <summary>
		/// Öffnet das Star-Demo-Fenster
		/// - Zeigt Style-Anwendung auf Custom Controls
		/// - Demonstriert wie Custom Dependency Properties mit Styles funktionieren
		/// - Wichtig: Custom DPs müssen korrekt registriert sein für Style-Support
		/// </summary>
		private void StarButton_Click(object sender, RoutedEventArgs e) {
			(new ManyStars()).Show();
		}
	}
}
