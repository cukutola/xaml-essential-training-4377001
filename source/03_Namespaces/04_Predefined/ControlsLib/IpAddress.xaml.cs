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
// WICHTIG: Der assembly-Parameter ist erforderlich, wenn die Klasse in einer anderen Assembly liegt.
// NAMESPACE-STRUKTUR: Firmenname.Bibliothekstyp.Kategorie (Best Practice).
namespace BigStar.Lib.Controls {
	/// <summary>
	/// Interaction logic for IpAddress.xaml
	/// </summary>
	
	// ': UserControl': Basisklasse für zusammengesetzte Custom Controls.
	// VORTEIL: Kann in anderen XAML-Dateien wie ein Standard-Control verwendet werden.
	// EINSATZZWECK: Wiederverwendbare UI-Komponente für IP-Adress-Eingabe.
	public partial class IpAddress : UserControl {
		
		// Konstruktor: Initialisiert das UserControl.
		public IpAddress() {
			// Lädt XAML-Definition mit den vier TextBoxes für IP-Teile.
			InitializeComponent();
		}

		// 'public String': CLR-Property (nicht DependencyProperty).
		// EINSCHRÄNKUNG: Funktioniert NICHT mit WPF-Binding! Nur für direkten Code-Zugriff.
		// GRUND: CLR-Properties feuern keine PropertyChanged-Events.
		// ALTERNATIVE: Für Binding müsste DependencyProperty verwendet werden.
		// EINSATZZWECK: Einfache Aggregation der vier IP-Teile.
		public String CurrentIP {
			// 'get': Kombiniert die vier TextBox-Werte zu einem String.
			get
			{
				// 'String.Format': Effiziente String-Zusammenstellung mit Platzhaltern.
				// '{0}.{1}.{2}.{3}': Vier Platzhalter für die IP-Oktette.
				// BEISPIEL: "192.168.1.1"
				String temp = String.Format("{0}.{1}.{2}.{3}", ipPart1TextBox.Text, ipPart2TextBox.Text, ipPart3TextBox.Text, ipPart4TextBox.Text);
				return temp;
			}
			// 'set': Zerlegt einen IP-String und verteilt ihn auf die TextBoxes.
			set
			{
				// 'Split': Trennt den String an jedem Punkt-Zeichen.
				// RESULTAT: Array von vier Strings (hoffentlich).
				String[] parts = value.Split('.');
				
				// VALIDIERUNG: IP muss exakt 4 Teile haben (z.B. "192.168.1.1").
				if (parts.Length != 4)
				{
					// 'throw': Wirft eine Exception, die den Aufrufer behandeln muss.
					// 'ArgumentOutOfRangeException': Standardtyp für ungültige Parameter.
					// BEST PRACTICE: Frühe Validierung mit aussagekräftiger Fehlermeldung.
					throw new ArgumentOutOfRangeException("CurrentIP must have four values");
				}

				// Zuweisung der Teile an die internen TextBox-Controls.
				// HINWEIS: Diese TextBoxes wurden in der XAML-Datei mit x:Name definiert.
				// GENERATED CODE: InitializeComponent() macht diese als Felder verfügbar.
				ipPart1TextBox.Text = parts[0];
				ipPart2TextBox.Text = parts[1];
				ipPart3TextBox.Text = parts[2];
				ipPart4TextBox.Text = parts[3];
			}
		}
	}
}
