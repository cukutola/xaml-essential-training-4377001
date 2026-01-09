// .NET Standard-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Namespaces.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// 'BigStar.Lib.Graphics': Gleicher Namespace wie externe Assembly.
// LOKALER KONTEXT: Diese Datei ist im GraphicsLocal-Ordner der MainApp.
// XAML-REFERENZ: xmlns:local="clr-namespace:BigStar.Lib.Graphics" (KEIN assembly!).
// WICHTIG: Kein assembly-Parameter nötig, da Control im gleichen Projekt ist.
namespace BigStar.Lib.Graphics {
	/// <summary>
	/// Interaction logic for Octopod.xaml
	/// </summary>
	
	// 'Octopod': Lokale Kopie des Octopod-Controls.
	// ZWECK: Demonstriert lokale vs. externe Control-Referenzierung.
	// UNTERSCHIED: Gleiches Control wie in GraphicsLib, aber lokal eingebettet.
	public partial class Octopod : UserControl {
		
		// Konstruktor.
		public Octopod() {
			// Initialisiert lokales Control.
			InitializeComponent();
		}
	}
}
