// 'using': Importiert Namespaces für MarkupExtension-Funktionalität und WPF-Farben.
using System;
using System.Windows.Markup; // Für MarkupExtension-Basisklasse
using System.Windows.Media; // Für Color, Brush, SolidColorBrush

// 'namespace': Organisiert die Klassen der Anwendung.
namespace AddProperties {

	// '[MarkupExtensionReturnType(typeof(Brush))]': ATTRIBUTE - Dokumentiert den Rückgabetyp.
	// ZWECK: Informiert den XAML-Designer und Intellisense über den Typ, den diese
	// MarkupExtension liefert. Verbessert die Entwicklererfahrung und Fehlererkennung.
	// WICHTIG: Dies ist nur ein Hinweis - zur Laufzeit wird nicht geprüft, ob der
	// tatsächliche Rückgabewert mit diesem Typ übereinstimmt.
	[MarkupExtensionReturnType(typeof(Brush))]
	// 'internal': Nur innerhalb dieser Assembly sichtbar (nicht für andere Projekte).
	// ': MarkupExtension': BASISKLASSE für alle Markup Extensions.
	// ZWECK: MarkupExtension ermöglicht die Erstellung von benutzerdefinierten XAML-Ausdrücken
	// die zur Laufzeit ausgewertet werden und Werte für Properties liefern.
	// BEISPIELE: {Binding}, {StaticResource}, {x:Static} sind eingebaute Markup Extensions.
	// VERWENDUNG IN XAML: <Button Background="{local:RelativeColorBrush Color=Blue, ColorAction=Lighten}" />
	internal class RelativeColorBrushExtension : MarkupExtension {
		
		// PRIVATE FELDER: Speichern den internen Zustand der MarkupExtension.
		// '_color': Die Basisfarbe, die modifiziert werden soll.
		// 'Colors.Orange': Standardwert, falls keine Farbe angegeben wird.
		private Color _color = Colors.Orange;
		
		// '_colorAction': Die Aktion, die auf die Farbe angewendet werden soll.
		// Standardwert ist 'Normal' (keine Änderung).
		private ColorAction _colorAction = ColorAction.Normal;

		// KONSTRUKTOR: Wird aufgerufen, wenn die MarkupExtension in XAML verwendet wird.
		// WICHTIG: Der Konstruktor muss parameterlos sein für die XAML-Verwendung.
		// TIMING: Wird während des XAML-Parsings aufgerufen, bevor Properties gesetzt werden.
		public RelativeColorBrushExtension() { }

		// PUBLIC PROPERTY: Kann in XAML als Property gesetzt werden.
		// VERWENDUNG IN XAML: {local:RelativeColorBrush Color=Red}
		// Der XAML-Parser verwendet TypeConverter, um "Red" in einen Color-Wert zu konvertieren.
		public Color Color
		{
			// 'get': Gibt die private _color-Variable zurück.
			get { return _color; }
			// 'set': Setzt die private _color-Variable.
			// Der XAML-Parser ruft diesen Setter auf, wenn die Property im XAML gesetzt wird.
			set { _color = value; }
		}

		// PUBLIC PROPERTY: Die Aktion, die auf die Farbe angewendet werden soll.
		// VERWENDUNG IN XAML: {local:RelativeColorBrush ColorAction=Lighten}
		// Mögliche Werte: Normal, Lighten, Darken (aus dem ColorAction-Enum).
		public ColorAction ColorAction
		{
			get { return _colorAction; }
			set { _colorAction = value; }
		}

		// 'override': Überschreibt die abstrakte Methode aus MarkupExtension.
		// 'ProvideValue': KERN-METHODE jeder MarkupExtension - liefert den tatsächlichen Wert.
		// PARAMETER:
		// - 'serviceProvider': Bietet Zugriff auf XAML-Services und Kontext-Informationen.
		//   VERWENDUNG: Kann verwendet werden, um Target-Property, Target-Object, Root-Object, etc. zu ermitteln.
		//   BEISPIEL: IProvideValueTarget, IRootObjectProvider, IXamlTypeResolver
		// TIMING: Wird aufgerufen, nachdem alle Properties der Extension gesetzt wurden.
		// AUSWIRKUNG: Der Rückgabewert wird der Property zugewiesen, für die die Extension verwendet wird.
		public override object ProvideValue(IServiceProvider serviceProvider) {
			// 'switch': Pattern Matching (C# 8.0+) für saubere Fallunterscheidung.
			// ZWECK: Wählt die passende Aktion basierend auf _colorAction aus.
			// Jeder Case erstellt eine neue SolidColorBrush mit der entsprechend modifizierten Farbe.
			var newColor = _colorAction switch
			{
				// 'ColorAction.Lighten': Hellt die Farbe auf (macht sie heller).
				ColorAction.Lighten => new SolidColorBrush(LightenColor(_color)),
				// 'ColorAction.Darken': Dunkelt die Farbe ab (macht sie dunkler).
				ColorAction.Darken => new SolidColorBrush(DarkenColor(_color)),
				// 'ColorAction.Normal': Verwendet die Farbe unverändert.
				ColorAction.Normal => new SolidColorBrush(_color),
				// '_': Default-Case für alle anderen Werte (sollte nicht vorkommen).
				_ => new SolidColorBrush(_color)
			};
			// RÜCKGABE: Eine SolidColorBrush, die der Button.Background (oder anderen Property) zugewiesen wird.
			return newColor;
		}

		// HILFSMETHODE: Hellt eine Farbe auf.
		// 'private': Nur innerhalb dieser Klasse sichtbar.
		// PARAMETER: 'currentColor' - Die Farbe, die aufgehellt werden soll.
		// RÜCKGABE: Eine neue, hellere Farbe.
		private Color LightenColor(Color currentColor) {
			// 'HslColor': Eine Hilfsklasse, die RGB in HSL (Hue, Saturation, Lightness) konvertiert.
			// VORTEIL: In HSL ist es einfacher, Farben aufzuhellen/abzudunkeln als in RGB.
			var hsl = new ColorLib.HslColor(currentColor);
			// '.Lighten(.3)': Erhöht die Helligkeit (Lightness) um 30%.
			// '.ToRgb()': Konvertiert zurück zu RGB für WPF.
			return hsl.Lighten(.3).ToRgb();
		}

		// HILFSMETHODE: Dunkelt eine Farbe ab.
		private Color DarkenColor(Color currentColor) {
			// Konvertiert zu HSL, reduziert die Helligkeit um 20%, konvertiert zurück zu RGB.
			var hsl = new ColorLib.HslColor(currentColor);
			return hsl.Darken(.2).ToRgb();
		}
	}

	// 'enum': Aufzählungstyp für die möglichen Farb-Aktionen.
	// ZWECK: Bietet typsichere, vordefinierte Werte statt Magic Strings.
	// VERWENDUNG IN XAML: ColorAction=Lighten (XAML-Parser konvertiert String zu Enum).
	public enum ColorAction {
		// Keine Änderung der Farbe.
		Normal,
		// Farbe aufhellen.
		Lighten,
		// Farbe abdunkeln.
		Darken
	}
}