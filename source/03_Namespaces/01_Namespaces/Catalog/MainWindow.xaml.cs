// .NET Standard-Namespaces.
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

// Navigation-Namespace für WPF-Seitennavigation.
using System.Windows.Navigation;
using System.Windows.Shapes;

// Namespace der Catalog-Demo-Anwendung.
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// MainWindow: Hauptfenster der Catalog-Demo.
	// KONTEXT: Zeigt Verwendung von TourData-Klasse mit Namespaces.
	public partial class MainWindow : Window {
		
		// Konstruktor: Initialisiert Hauptfenster.
		public MainWindow() {
			// Lädt XAML und initialisiert UI-Elemente.
			InitializeComponent();
		}
	}
}
