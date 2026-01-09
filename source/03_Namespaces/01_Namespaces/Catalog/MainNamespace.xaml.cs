// Standard .NET Namespaces für allgemeine Funktionalität.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Kern-Namespaces für UI-Entwicklung.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// Namespace der Demo-Anwendung.
// XAML-REFERENZ: xmlns:local="clr-namespace:UnderstandNamespaces"
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for MainNamespace.xaml
	/// </summary>
	
	// Window-Klasse für Namespace-Katalog-Demo.
	// KONTEXT: Teil der "Catalog"-Demo, die Namespace-Nutzung mit Datenklassen zeigt.
	public partial class MainNamespace : Window {
		
		// Konstruktor: Initialisiert das Fenster.
		public MainNamespace() {
			// Lädt und verbindet XAML-UI.
			InitializeComponent();
		}
	}
}
