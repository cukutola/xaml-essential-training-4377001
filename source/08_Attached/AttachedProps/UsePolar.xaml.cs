using System.Windows;

namespace AttachedProps.Windows {

	/// <summary>
	/// UsePolar: Demonstriert die Verwendung des benutzerdefinierten PolarPanel.
	/// PolarPanel ist ein Custom Panel, das zwei eigene Attached Properties bereitstellt:
	/// - PolarPanel.Angle: Der Winkel in Grad (0-360°) vom Mittelpunkt aus.
	/// - PolarPanel.Radius: Der Abstand in Pixeln vom Mittelpunkt.
	/// Diese Attached Properties ermöglichen eine Polarkoordinaten-basierte Positionierung von Child-Elementen.
	/// </summary>
	public partial class UsePolar : Window {

		public UsePolar() {
			// InitializeComponent(): Lädt die XAML, wo Child-Elemente im PolarPanel
			// mit PolarPanel.Angle und PolarPanel.Radius Attached Properties positioniert werden.
			InitializeComponent();
		}

		private void mainButton_Click(object sender, RoutedEventArgs e) {
			// AUSKOMMENTIERTER CODE: Beispiel für programmatisches Hinzufügen eines Elements zum PolarPanel.
			// Zeigt wie man Attached Properties im Code-Behind verwendet:
			// 1. Element erstellen (z.B. Button)
			// 2. Element zum Panel hinzufügen: polar.Children.Add(check)
			// 3. Attached Properties setzen: PolarPanel.SetRadius(check, 100) und PolarPanel.SetAngle(check, 210)
			// Dies entspricht in XAML: <Button local:PolarPanel.Radius="100" local:PolarPanel.Angle="210" />
			
			//var check = new Button();
			//check.Width = check.Height = 40;
			//check.Content = "hello";
			//polar.Children.Add(check);
			//PolarPanel.SetRadius(check, 100);
			//PolarPanel.SetAngle(check, 210);
		}
	}
}