// Importiert grundlegende .NET-Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Importiert WPF-Basistypen wie UIElement und DependencyObject
using System.Windows;
// Importiert WPF-Typen für Grafik und Rendering (Brushes, Transforms, etc.)
using System.Windows.Media;

// Namespace für dieses Projekt
namespace ObjectElements {
	// 'internal': Nur innerhalb dieser Assembly sichtbar
	// ': UIElement': Basisklasse für visuelle Elemente in WPF. UIElement bietet:
	// - Rendering-Unterstützung (OnRender-Methode)
	// - Input-Handling (Mouse, Keyboard, Touch)
	// - Layout-Teilnahme (Measure/Arrange)
	// - Hit-Testing
	// Diese Klasse könnte erweitert werden, um ein benutzerdefiniertes visuelles Element zu erstellen.
	internal class Orb : UIElement {
		// Die Klasse ist bewusst leer. Sie demonstriert die Vererbungshierarchie in WPF.
		// Um einen funktionsfähigen Orb zu erstellen, müsste OnRender überschrieben werden,
		// um die visuelle Darstellung (z.B. einen Kreis mit DrawingContext) zu zeichnen.
	}
}
