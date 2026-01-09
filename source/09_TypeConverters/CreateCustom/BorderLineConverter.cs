// 'using': Importiert benötigte Namespaces für Typen, die in dieser Datei verwendet werden.
using CreateCustom.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 'namespace': Organisiert Code in logische Gruppen und verhindert Namenskonflikte.
namespace CreateCustom
{

	// 'public': Macht diese Klasse für alle anderen Assemblies sichtbar und verwendbar.
	// ': TypeConverter': Erbt von der TypeConverter-Basisklasse aus System.ComponentModel.
	// ZWECK: Ermöglicht die Konvertierung von String-Werten aus XAML in BorderLine-Objekte.
	// HINTERGRUND: Ohne TypeConverter müssten komplexe Properties in XAML als Element-Syntax 
	// mit verschachtelten Tags geschrieben werden. Der TypeConverter ermöglicht die kompakte 
	// Attribut-Syntax (z.B. BorderThickness="5,10,5,10").
	// AUSWIRKUNG: Wird vom XAML-Parser automatisch aufgerufen, wenn ein Property-Attribut 
	// vom Typ BorderLine gesetzt wird.
	public class BorderlineConverter : TypeConverter {
		
		// 'override': Überschreibt die Basismethode aus TypeConverter.
		// 'CanConvertFrom': Informiert den XAML-Parser, ob dieser Converter einen bestimmten 
		// Quelltyp in BorderLine konvertieren kann.
		// PARAMETER:
		// - 'context': Liefert Kontext-Informationen über die Property, z.B. in welchem Control 
		//   sie verwendet wird. Kann 'null' sein bei Verwendung außerhalb von XAML.
		// - 'sourceType': Der Typ des Quellwerts (in XAML fast immer 'typeof(string)').
		// WICHTIG: Muss 'true' für 'typeof(string)' zurückgeben, damit XAML-Attribut-Syntax 
		// funktioniert. Der XAML-Parser ruft diese Methode auf, bevor er 'ConvertFrom' aufruft.
		// RÜCKGABE: 'true' wenn Konvertierung möglich ist, sonst 'false'.
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {
			// 'typeof(string)': Prüft, ob der Quelltyp ein String ist.
			// XAML-Attribute liefern immer Strings, daher ist diese Prüfung essentiell.
			if (sourceType == typeof(string))
			{
				// Gibt 'true' zurück um zu signalisieren: "Ja, ich kann Strings konvertieren."
				return true;
			}
			// 'base.CanConvertFrom': Delegiert an die Basisklasse für alle anderen Typen.
			// Ermöglicht zukünftige Erweiterungen ohne Breaking Changes.
			return base.CanConvertFrom(context, sourceType);
		}
		
		// 'ConvertFrom': Die zentrale Konvertierungslogik - wird vom XAML-Parser zur Laufzeit aufgerufen.
		// PARAMETER:
		// - 'context': Kontext-Informationen über die Property und deren Container.
		// - 'culture': Kultur-Informationen für lokalisierte Konvertierung (z.B. Dezimaltrennzeichen).
		//   In Deutschland würde "3,5" als Kommazahl erkannt, in USA als "3.5".
		// - 'value': Der zu konvertierende Wert (typischerweise ein String aus dem XAML-Attribut).
		// AUSWIRKUNG: Diese Methode wird aufgerufen, wenn XAML geparst wird oder wenn 
		// TypeDescriptor.GetConverter().ConvertFrom() programmatisch aufgerufen wird.
		// RÜCKGABE: Ein BorderLine-Objekt mit den geparsten Werten.
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
			// 'is string': Typ-Prüfung zur Laufzeit (Type Pattern Matching).
			// Sicherstellt, dass der Wert tatsächlich ein String ist, bevor wir ihn verarbeiten.
			if (value != null && value is string)
			{
				// 'ToString()': Konvertiert das 'object' explizit zu String für die weitere Verarbeitung.
				var valueString = value.ToString();
				// 'RemoveWhitespace': Entfernt alle Leerzeichen, damit Formate wie "5, 10, 5, 10" 
				// genauso behandelt werden wie "5,10,5,10". Erhöht die Benutzerfreundlichkeit.
				var cleaned = RemoveWhitespace(valueString);
				// 'Split(',')': Teilt den String an Kommata in ein Array auf.
				// Beispiel: "5,10,15,20" → ["5", "10", "15", "20"]
				var results = cleaned.Split(',');

				// SYNTAX-UNTERSTÜTZUNG: Erlaubt drei verschiedene Formate, ähnlich wie CSS margin/padding.
				// Format 1: Ein Wert (z.B. "5") → alle vier Seiten bekommen denselben Wert.
				if (results.Length == 1)
				{
					// 'new BorderLine { ... }': Objekt-Initialisierer-Syntax für kompakte Erstellung.
					// 'double.Parse': Konvertiert String zu double. ACHTUNG: Wirft Exception bei ungültiger Eingabe!
					// VERBESSERUNGSPOTENTIAL: double.TryParse würde fehlertoleranter sein.
					return new BorderLine
					{
						Left = double.Parse(results[0]),
						Right = double.Parse(results[0]),
						Top = double.Parse(results[0]),
						Bottom = double.Parse(results[0])
					};
				}
				// Format 2: Zwei Werte (z.B. "5,10") → Horizontale und vertikale Werte.
				// results[0] wird für Left/Right verwendet, results[1] für Top/Bottom.
				if (results.Length == 2)
				{
					return new BorderLine
					{
						Left = double.Parse(results[0]),
						Right = double.Parse(results[0]),
						Top = double.Parse(results[1]),
						Bottom = double.Parse(results[1])
					};
				}
				// Format 3: Vier Werte (z.B. "5,10,15,20") → Jede Seite individuell.
				// Reihenfolge: Left, Top, Right, Bottom (wie in CSS: Uhrzeigersinn ab links).
				if (results.Length == 4)
				{
					return new BorderLine
					{
						Left = double.Parse(results[0]),
						Right = double.Parse(results[2]),
						Top = double.Parse(results[1]),
						Bottom = double.Parse(results[3])
					};
				}
				else
				{
					// FEHLERBEHANDLUNG: Wirft eine Exception, wenn das Format ungültig ist.
					// Der XAML-Parser fängt diese Exception und zeigt eine Designer-Fehlermeldung an.
					throw new ArgumentOutOfRangeException(
					"Invalid format for Borderline");
				}

			}
			// 'base.ConvertFrom': Delegiert an die Basisklasse, falls der Wert kein String ist.
			// Dies ermöglicht Erweiterbarkeit für andere Quelltypen in der Zukunft.
			return base.ConvertFrom(context, culture, value);
		}


		// 'CanConvertTo': Prüft, ob eine Konvertierung VON BorderLine ZU einem anderen Typ möglich ist.
		// VERWENDUNG: Wird z.B. für PropertyGrid oder Serialisierung benötigt.
		// HIER: Nicht implementiert, da wir nur die Hin-Konvertierung (String → BorderLine) benötigen.
		// Die Rück-Konvertierung (BorderLine → String) ist für XAML-Parsing nicht erforderlich.
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
			// Delegiert komplett an die Basisklasse - keine eigene Logik.
			return base.CanConvertTo(context, destinationType);
		}
		
		// 'ConvertTo': Konvertiert ein BorderLine-Objekt in einen anderen Typ.
		// HIER: Nicht implementiert, da für XAML-Attribute nur die Hin-Konvertierung relevant ist.
		// VERWENDUNG: Würde für PropertyGrid oder ToString()-Optimierung benötigt.
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) {
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// HILFSMETHODE: Entfernt alle Whitespace-Zeichen (Leerzeichen, Tabs, Zeilenumbrüche).
		// ZWECK: Ermöglicht flexible Eingabe-Formate wie "5, 10, 15, 20" oder "5,10,15,20".
		// 'public': Könnte auch private sein, aber public ermöglicht Wiederverwendung in Tests.
		// IMPLEMENTIERUNG: Verwendet LINQ für eine funktionale, kompakte Lösung.
		public string RemoveWhitespace(string input) {
			// 'ToCharArray()': Konvertiert String in char-Array für die Iteration.
			// 'Where': LINQ-Filter - behält nur Zeichen, die keine Whitespaces sind.
			// 'Char.IsWhiteSpace': Prüft auf alle Arten von Whitespace (nicht nur Leerzeichen).
			// 'ToArray()': Konvertiert IEnumerable<char> zurück in char[].
			// 'new string(...)': Erstellt einen neuen String aus dem char-Array.
			return new string(input.ToCharArray()
					.Where(c => !Char.IsWhiteSpace(c))
					.ToArray());
		}
	}
}
