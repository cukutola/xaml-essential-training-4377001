// .NET Standard-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF-Namespaces für UserControl-Entwicklung.
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// 'BigStar.Lib.Graphics': Custom Namespace für grafische Controls.
// XAML-MAPPING: xmlns:gfx="clr-namespace:BigStar.Lib.Graphics;assembly=GraphicsLib"
// NAMESPACE-TRENNUNG: Graphics und Controls sind getrennt für bessere Organisation.
// ASSEMBLY: GraphicsLib.dll muss referenziert werden.
namespace BigStar.Lib.Graphics {
	/// <summary>
	/// Interaction logic for Octopod.xaml
	/// </summary>
	
	// 'Octopod': Custom UserControl für Oktopus-Grafik.
	// EINSATZZWECK: Wiederverwendbare grafische Komponente.
	// VERWENDUNG: <gfx:Octopod /> in XAML nach Namespace-Deklaration.
	public partial class Octopod : UserControl {
		
		// Konstruktor: Initialisiert das grafische Control.
		public Octopod() {
			// Lädt XAML-Definition mit Vektor-Grafik.
			InitializeComponent();
		}
	}
}
