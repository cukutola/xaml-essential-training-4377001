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

// 'BigStar.Lib.Controls': Custom Namespace für wiederverwendbare Controls.
// XAML-MAPPING: xmlns:ctrl="clr-namespace:BigStar.Lib.Controls;assembly=ControlsLib"
// ASSEMBLY-REFERENZ: Erfordert assembly-Parameter, da Control in externer DLL.
namespace BigStar.Lib.Controls {
	/// <summary>
	/// Interaction logic for IpAddress.xaml
	/// </summary>
	
	// ': UserControl': Basisklasse für Custom Controls.
	// EINSATZZWECK: IP-Adress-Eingabe Control (4 Oktette).
	public partial class IpAddress : UserControl {
		
		// Konstruktor.
		public IpAddress() {
			// Lädt XAML mit vier TextBoxes.
			InitializeComponent();
		}

		// 'public String': CLR-Property (nicht DependencyProperty).
		// EINSCHRÄNKUNG: NICHT Data-Bindable in WPF.
		// VERWENDUNG: Nur für direkten Code-Zugriff.
		public String CurrentIP {
			// 'get': Kombiniert vier IP-Teile zu einem String.
			get
			{
				// 'String.Format': Formatierung als "xxx.xxx.xxx.xxx".
				String temp = String.Format("{0}.{1}.{2}.{3}", ipPart1TextBox.Text, ipPart2TextBox.Text, ipPart3TextBox.Text, ipPart4TextBox.Text);
				return temp;
			}
			// 'set': Zerlegt IP-String und verteilt auf TextBoxes.
			set
			{
				// 'Split': Trennt an Punkt-Zeichen.
				String[] parts = value.Split('.');
				
				// Validierung: Muss 4 Teile haben.
				if (parts.Length != 4)
				{
					// 'throw': Exception bei ungültiger IP.
					throw new ArgumentOutOfRangeException("CurrentIP must have four values");
				}

				// Zuweisung an XAML-Controls (x:Name).
				ipPart1TextBox.Text = parts[0];
				ipPart2TextBox.Text = parts[1];
				ipPart3TextBox.Text = parts[2];
				ipPart4TextBox.Text = parts[3];
			}
		}
	}
}
