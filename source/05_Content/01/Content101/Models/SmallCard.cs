// 'using': Importiert grundlegende .NET-Namespaces.
using BigStar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 'namespace': Definiert den Namensraum für Datenmodelle.
namespace BigStar.Models{
	// 'internal': Nur innerhalb dieser Assembly sichtbar.
	// ZWECK: Vereinfachte Version von CollectableCard mit weniger Properties.
	// VERWENDUNG: Für Übersichtslisten, wo nicht alle Details benötigt werden.
	internal class SmallCard {
		
		// AUTO-PROPERTIES: Speichern grundlegende Kartendaten.
		// Diese Properties werden via Data Binding an UI-Elemente gebunden.
		
		// Eindeutige ID.
		public int Id { get; set; }
		// Kartenname.
		public string CardName { get; set; }
		// Preis als Dezimalwert.
		public decimal Price { get; set; }
		// Team-Zugehörigkeit (Enum).
		public TeamNames Team { get; set; }

		// 'override': Überschreibt ToString() von Object.
		// ZWECK: Liefert lesbare String-Darstellung für Debugging/Logging.
		// 'C': Currency-Formatierung für Price (z.B. "$5.99").
		public override string ToString() {
			return $"Card: {CardName}, {Team}, {Price:C}";
		}
	}
}