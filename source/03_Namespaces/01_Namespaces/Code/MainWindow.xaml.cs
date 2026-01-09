// Basis-Namespaces für allgemeine .NET-Funktionalität.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Namespaces für UI-Entwicklung.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// 'System.Windows.Navigation': Namespace für Navigation zwischen Seiten/Fenstern.
// EINSATZZWECK: Frame, NavigationService, Hyperlinks.
using System.Windows.Navigation;
using System.Windows.Shapes;

// Anwendungs-Namespace: Container für alle Typen dieser Anwendung.
namespace UnderstandNamespaces {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// 'MainWindow': Hauptfenster der Namespace-Demo-Anwendung.
	// ROLLE: Einstiegspunkt für Benutzer-Interaktion.
	public partial class MainWindow : Window {
		
		// Konstruktor: Wird beim Start der Anwendung aufgerufen.
		public MainWindow() {
			// Lädt XAML-UI und initialisiert alle Steuerelemente.
			InitializeComponent();
		}
	}
}
