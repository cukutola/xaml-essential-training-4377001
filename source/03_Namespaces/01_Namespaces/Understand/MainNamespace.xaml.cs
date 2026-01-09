// .NET Basis-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF UI-Namespaces.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// Haupt-Namespace der Namespace-Demo-Anwendung.
// CLR-NAMESPACE: In XAML referenziert als "clr-namespace:UnderstandNamespaces"
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for MainNamespace.xaml
	/// </summary>
	
	// MainNamespace-Window: Demonstriert grundlegende Namespace-Konzepte.
	// ZWECK: Zeigt Namespace-Deklaration und Verwendung in XAML.
	public partial class MainNamespace : Window {
		
		// Konstruktor.
		public MainNamespace() {
			// Initialisiert UI-Elemente aus XAML.
			InitializeComponent();
		}
	}
}
