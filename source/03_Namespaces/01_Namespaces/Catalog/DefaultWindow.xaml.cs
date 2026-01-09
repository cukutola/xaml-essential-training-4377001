// .NET Basis-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Namespaces für Fenster und UI-Komponenten.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// Anwendungs-Namespace.
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for DefaultWindow.xaml
	/// </summary>
	
	// DefaultWindow: Demonstriert Standard-Namespace-Verwendung.
	// ZWECK: Zeigt Default-Namespace-Deklarationen in XAML.
	public partial class DefaultWindow : Window {
		
		// Standard-Konstruktor.
		public DefaultWindow() {
			// Initialisiert XAML-UI-Komponenten.
			InitializeComponent();
		}
	}
}
