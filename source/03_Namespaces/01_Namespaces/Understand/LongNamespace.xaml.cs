// .NET Standard-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Namespaces für UI-Komponenten.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// Anwendungs-Namespace für Namespace-Verständnis-Demo.
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for MainNamespace.xaml
	/// </summary>
	
	// 'LongNamespace': Fenster-Klasse, die lange Namespace-Deklarationen demonstriert.
	// LERNZIEL: Zeigt Unterschied zwischen vollqualifizierten und abgekürzten Namespace-Referenzen.
	// KONTEXT: Illustriert, warum Namespace-Aliase in XAML nützlich sind.
	public partial class LongNamespace : Window {
		
		// Konstruktor: Initialisiert Fenster für Namespace-Demo.
		public LongNamespace() {
			// Lädt XAML-Definition und initialisiert UI.
			InitializeComponent();
		}
	}
}
