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

// Graphics Namespace - lokal im Projekt.
// CLR-NAMESPACE-DEMO: Zeigt Verwendung ohne assembly-Parameter.
namespace BigStar.Lib.Graphics
	 {
	/// <summary>
	/// Interaction logic for WaterBackground.xaml
	/// </summary>
	
	// 'WaterBackground': Lokale Kopie des WaterBackground-Controls.
	// KONTEXT: Im GraphicsLocal-Ordner, nicht in externer Assembly.
	// XAML-VERWENDUNG: <local:WaterBackground /> ohne assembly-Referenz.
	public partial class WaterBackground : UserControl {
		
		// Konstruktor.
		public WaterBackground() {
			// Initialisiert lokales grafisches Control.
			InitializeComponent();
		}
	}
}
