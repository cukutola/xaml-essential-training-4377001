// 'using': Importiert Namespaces für vereinfachten Zugriff auf Typen.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Kern-Namespaces für Window-Funktionalität und UI-Elemente.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// 'namespace UnderstandNamespaces': Haupt-Namespace dieser Demo-Anwendung.
// XAML-ZUGRIFF: xmlns:local="clr-namespace:UnderstandNamespaces"
// ZWECK: Demonstriert Namespace-Konzepte und deren Verwendung in XAML.
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for MainNamespace.xaml
	/// </summary>
	
	// 'public partial class': Fenster-Klasse mit XAML-Code-Behind-Pattern.
	// NAMENSGEBUNG: 'MainNamespace' deutet auf Haupt-Demo-Fenster für Namespace-Konzepte hin.
	public partial class MainNamespace : Window {
		
		// Konstruktor: Initialisiert das Fenster und lädt XAML-Definitionen.
		public MainNamespace() {
			// Lädt und verbindet die XAML-UI-Definition mit diesem Code-Behind.
			InitializeComponent();
		}
	}
}
