// .NET Standard-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Kern-Namespaces.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// Navigation-Namespace für Seiten/Fenster-Navigation.
using System.Windows.Navigation;
using System.Windows.Shapes;

// Namespace der Understand-Demo.
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// MainWindow: Einstiegspunkt der Namespace-Verständnis-Demo.
	// ZWECK: Demonstriert, wie Namespaces WPF-Anwendungen organisieren.
	public partial class MainWindow : Window {
		
		// Konstruktor.
		public MainWindow() {
			// Lädt und initialisiert XAML-UI.
			InitializeComponent();
		}
	}
}
