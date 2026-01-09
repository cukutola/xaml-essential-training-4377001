// 'using': Importiert Namespaces für WPF und XAML-Funktionalität.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup; // Für ContentProperty-Attribut

// 'namespace': Organisiert Mock-Klassen für Demonstrationszwecke.
namespace Content101.Mocks {

	// '[ContentProperty("Text")]': ATTRIBUT - definiert die Standard-Content-Property.
	// ZWECK: Teilt dem XAML-Parser mit, welche Property als Standard-Content verwendet wird.
	// AUSWIRKUNG: Ermöglicht vereinfachte XAML-Syntax:
	// OHNE ContentProperty: <TextBox Text="Hello" />
	// MIT ContentProperty: <TextBox>Hello</TextBox>
	// HINTERGRUND: ContentProperty ist ein zentrales Konzept in WPF für lesbareres XAML.
	// BEISPIELE: ContentControl.Content, ItemsControl.Items, Panel.Children sind ContentProperties.
	[ContentProperty("Text")]
	// 'internal': Nur innerhalb dieser Assembly sichtbar.
	// ': UIElement': Erbt von UIElement - die Basisklasse für alle sichtbaren WPF-Elemente.
	// HINWEIS: Dies ist eine vereinfachte Mock-Implementierung für Demonstrationszwecke.
	// Eine echte TextBox würde von TextBoxBase erben und viel mehr Funktionalität bieten.
	internal class TextBox : UIElement {
		
		// 'public': Properties müssen public sein, damit XAML darauf zugreifen kann.
		// 'int': Anzahl der ausgewählten Zeichen.
		// VERWENDUNG: Wird in echten TextBoxen verwendet, um Text-Selektion zu verwalten.
		public int SelectionLength { get; set; }
		
		// 'string': Der Textinhalt der TextBox.
		// WICHTIG: Dies ist die ContentProperty (siehe Attribut oben).
		// VERWENDUNG: In XAML kann man schreiben: <TextBox>Mein Text</TextBox>
		// Der XAML-Parser weist "Mein Text" automatisch dieser Property zu.
		public string Text { get; set; }
		
		// 'TextWrapping': Enum für Textumbruch-Verhalten.
		// WERTE: NoWrap, Wrap, WrapWithOverflow
		// ZWECK: Steuert, ob Text bei Zeilenende umbrochen wird.
		public TextWrapping Wrap { get; set; }
		
		// 'TextAlignment': Enum für Textausrichtung.
		// WERTE: Left, Center, Right, Justify
		// ZWECK: Steuert die horizontale Ausrichtung des Textes.
		public TextAlignment Alignment { get; set; }
		
		// 'int': Anzahl der Zeilen im Text.
		// VERWENDUNG: Schreibgeschützt in echten TextBoxen, wird automatisch berechnet.
		public int LineCount { get; set; }
		
		// HINWEIS: In einer echten TextBox gäbe es ~20 weitere Properties wie:
		// - MaxLength: Maximale Textlänge
		// - IsReadOnly: Schreibschutz
		// - AcceptsReturn: Erlaubt mehrzeiligen Text
		// - SpellCheck: Rechtschreibprüfung
		// - etc.
		
	}
}

