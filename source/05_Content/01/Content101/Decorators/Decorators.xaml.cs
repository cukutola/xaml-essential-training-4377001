// 'using': Importiert Namespaces für WPF-Controls und .NET-Basisfunktionalität.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// 'namespace': Organisiert Beispiel-Fenster in einem separaten Namespace.
namespace Content101.Windows {
	/// <summary>
	/// Interaction logic for DecoratorExample.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	// ZWECK: Demonstriert Decorator-Controls - spezielle ContentControls mit visuellen Effekten.
	// KONZEPT: Decorators sind Controls, die genau ein Child-Element haben und diesem
	// visuelle Eigenschaften hinzufügen (Rahmen, Schatten, Skalierung, etc.).
	// BEISPIELE:
	// - Border: Fügt Rahmen und Hintergrund hinzu
	// - Viewbox: Skaliert das Child-Element automatisch
	// - BulletDecorator: Fügt ein Bullet/Icon vor dem Child hinzu
	// - InkPresenter: Für Ink/Stift-Eingabe
	// VERERBUNG: Alle Decorators erben von System.Windows.Controls.Decorator.
	public partial class DecoratorExample : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public DecoratorExample() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			// In der XAML-Datei werden verschiedene Decorators demonstriert:
			// - Border mit BorderBrush, BorderThickness, CornerRadius
			// - Viewbox mit Stretch-Modi (Fill, Uniform, UniformToFill)
			// - BulletDecorator mit Bullet und Child
			InitializeComponent();
		}
	}
}
