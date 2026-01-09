// 'using': Importiert Namespaces für MarkupExtension-Funktionalität und WPF-Farben.
using System;
using System.Windows.Markup; // Für MarkupExtension-Basisklasse
using System.Windows.Media; // Für Color, Brush, SolidColorBrush

// 'namespace': Organisiert die Klassen der Anwendung.
namespace CustomMarkupExt {

	// NAMENSKONVENTION: Der Suffix "Extension" ist Konvention, aber in XAML kann der kürzere Name verwendet werden.
	// In XAML: {local:RelativeColorBrush} statt {local:RelativeColorBrushExtension}
	// XAML-Parser entfernt automatisch das "Extension"-Suffix beim Parsen.
	
	// '[MarkupExtensionReturnType(typeof(Brush))]': ATTRIBUTE - Dokumentiert den Rückgabetyp.
	// ZWECK: Informiert Designer und Entwickler über den erwarteten Rückgabetyp.
	// WICHTIG: Dies ist nur Dokumentation - keine Runtime-Validierung!
	[MarkupExtensionReturnType(typeof(Brush))]
	// 'internal': Nur innerhalb dieser Assembly sichtbar.
	// ': MarkupExtension': BASISKLASSE - ermöglicht die Verwendung in geschweiften Klammern {...} in XAML.
	// KONZEPT: MarkupExtensions sind "Funktionen" die zur XAML-Parse-Zeit ausgeführt werden.
	// VERGLEICH: Ähnlich wie {Binding}, {StaticResource}, {x:Type} - alle sind MarkupExtensions.
	internal class RelativeColorBrushExtension : MarkupExtension {
		
		// PRIVATE FELD: Speichert die Farbe, die verwendet werden soll.
		// 'Colors.Orange': Standardwert - wird verwendet, wenn keine Farbe in XAML angegeben wird.
		// ZWECK: Demonstriert die Verwendung eines fest codierten Wertes in einer MarkupExtension.
		private Color _color = Colors.Orange;

		// KONSTRUKTOR: Parameterlos - erforderlich für XAML-Verwendung.
		// WICHTIG: XAML kann nur Klassen mit parameterlosem Konstruktor instanziieren.
		// TIMING: Wird während des XAML-Parsings aufgerufen, wenn die Extension gefunden wird.
		public RelativeColorBrushExtension() {
			// HINWEIS: Dieser Konstruktor ist leer, da die Initialisierung bereits
			// in den Feld-Deklarationen erfolgt ist.
		}

		// 'override': Überschreibt die abstrakte Methode aus MarkupExtension.
		// 'ProvideValue': KERN-METHODE - wird vom XAML-Parser aufgerufen, um den eigentlichen Wert zu erhalten.
		// PARAMETER:
		// - 'IServiceProvider serviceProvider': Bietet Zugriff auf XAML-Services und Kontext.
		//   SERVICES: IProvideValueTarget (Target-Property, Target-Object), IRootObjectProvider (Root-Element),
		//   IXamlTypeResolver (Typ-Auflösung), IUriContext (Basis-URI für relative URIs).
		// TIMING: Wird aufgerufen, nachdem alle Properties der Extension gesetzt wurden (falls vorhanden).
		// AUSWIRKUNG: Der Rückgabewert wird der Property zugewiesen, für die diese Extension verwendet wird.
		// BEISPIEL XAML: <Button Background="{local:RelativeColorBrush}" />
		// → ProvideValue wird aufgerufen, Ergebnis wird Button.Background zugewiesen.
		public override object ProvideValue(IServiceProvider serviceProvider) {
			// 'new SolidColorBrush(_color)': Erstellt eine einfarbige Brush aus der gespeicherten Farbe.
			// RÜCKGABE: Ein Brush-Objekt, das von WPF für Hintergrund/Vordergrund/etc. verwendet werden kann.
			// HINWEIS: In dieser einfachen Version wird immer dieselbe Farbe (Orange) zurückgegeben.
			// ERWEITERUNG: Man könnte serviceProvider verwenden, um auf das Target-Objekt zuzugreifen
			// und die Farbe basierend auf Kontext zu ändern.
			return new SolidColorBrush(_color);
		}
	}
}