// Standard .NET Namespaces für grundlegende Funktionalität.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Namespaces: Stellen alle UI-Komponenten und Fenster-Funktionen bereit.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// Namespace der Anwendung: Gruppiert alle zusammengehörigen Klassen.
// CLR-NAMESPACE: In XAML als "clr-namespace:UnderstandNamespaces" referenziert.
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for DefaultWindow.xaml
	/// </summary>
	
	// 'DefaultWindow': Fenster, das Standard-Namespace-Verwendung demonstriert.
	// KONTEXT: Zeigt den Unterschied zwischen expliziten und impliziten Namespace-Deklarationen.
	public partial class DefaultWindow : Window {
		
		// Standard-Konstruktor für WPF-Fenster.
		public DefaultWindow() {
			// Initialisiert UI-Komponenten aus der XAML-Datei.
			InitializeComponent();
		}
	}
}
