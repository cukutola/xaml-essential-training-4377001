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

// Graphics Library Namespace.
// XAML-MAPPING: xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib"
namespace BigStar.Lib.Graphics
	 {
	/// <summary>
	/// Interaction logic for WaterBackground.xaml
	/// </summary>
	
	// 'WaterBackground': Custom UserControl für Wasser-Hintergrund-Grafik.
	// ZWECK: Wiederverwendbare Hintergrund-Komponente.
	// EINSATZZWECK: Kann als Hintergrund für andere Controls dienen.
	public partial class WaterBackground : UserControl {
		
		// Konstruktor.
		public WaterBackground() {
			// Initialisiert XAML mit Hintergrund-Grafik.
			InitializeComponent();
		}
	}
}
