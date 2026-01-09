// Standard .NET Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Namespace für die Datenmodelle der BigStar Sammelkarten-Anwendung
namespace BigStar.Models
	
{
	// Datenmodell für eine Sammelkarte (Collectable Card).
	// Diese Klasse repräsentiert eine einzelne Karte in der Sammlung und enthält alle 
	// relevanten Eigenschaften wie Name, Preis, Beschreibung, etc.
	// In WPF würde diese Klasse typischerweise INotifyPropertyChanged implementieren,
	// um UI-Updates bei Datenänderungen zu ermöglichen. Hier wird sie als einfaches POCO 
	// (Plain Old CLR Object) verwendet, da die Daten nur gelesen werden.
	public class CollectableCard
	{

		// Auto-Property für die eindeutige Kartennummer/ID.
		// 'get; set;': Automatisch generierte Getter und Setter. Der Compiler erstellt 
		// ein privates Backing-Field automatisch.
		// 'int': Ganzzahliger Typ für eindeutige Identifikation.
		public int Id { get; set; }
		// Name der Karte (z.B. "Violette", "Mingle")
		// 'string': Referenztyp für Texte, kann null sein
		public string Name { get; set; }
		// Slogan oder Untertitel der Karte
		public string Slogan { get; set; }
		// Anzahl der Augen - ein charakteristisches Merkmal der Figur
		public int EyeCount { get; set; }

		// Dictionary für zusätzliche Details der Karte (Key-Value-Paare).
		// 'Dictionary<string, string>': Assoziatives Array mit String-Keys und String-Values.
		// Beispiele: "Best Smile" => "Yes", "Antenna" => "None"
		// '= new Dictionary<string, string>()': Initialisierung direkt bei der Deklaration.
		// Dies ist ein C# 6.0 Feature (Auto-Property Initializer) und verhindert NullReferenceExceptions.
		public Dictionary<string, string> Details { get; set; } = new Dictionary<string, string>();

		// Teamname der Figur (Enum-Typ für typsichere Werte)
		// Verwendung eines Enums statt string verhindert Tippfehler und ermöglicht IntelliSense.
		public TeamNames TeamName { get; set; }

		// Beschreibung/Hintergrundgeschichte der Figur
		// Kann längerer Text mit HTML-Tags sein
		public string Description { get; set; }
		// Katalogpreis der Karte
		// 'decimal': Dezimaltyp für präzise Geldwerte (besser als float/double für Währungen,
		// da keine Rundungsfehler bei Dezimalbrüchen auftreten)
		public decimal CatalogPrice { get; set; }
		// Gebotspreis / aktueller Verkaufspreis
		public decimal BidPrice { get; set; }
	
		// Berechnete Property für den Verkaufspreis (Read-Only Property mit Geschäftslogik).
		// Diese Property hat nur einen Getter, keinen Setter - der Wert wird dynamisch berechnet.
		// Dies ist nützlich in WPF für Datenbindung: Die UI zeigt automatisch den berechneten Wert an.
		public decimal SalePrice
		{
			get
			{
				// Geschäftslogik: Wenn die Karte rabattiert ist (IsDiscounted == true),
				// wird 25% Rabatt auf den BidPrice gewährt.
				if (IsDiscounted)
				{
					// '.75M': Das 'M' Suffix kennzeichnet einen decimal-Literal (nicht double).
					// Berechnet 75% des BidPrice (= 25% Rabatt)
					return BidPrice * .75M;
				}
				else
				{
					// Kein Rabatt: Voller BidPrice wird zurückgegeben
					return BidPrice;
				}

			}
		}
		// URI/Pfad zum Kartenbild (relativ oder absolut)
		// In WPF kann dies direkt für Image.Source verwendet werden
		public string ImageUri { get; set; }
		// Gekürzte Version der Beschreibung (für Vorschau in Listen)
		// Wird in CardSource.GetShortText() generiert
		public string ShortDescription { get; set; }
		// Popularitätsindex der Karte (bestimmt Rabatt-Berechtigung)
		// Höherer Wert = beliebter. Werte < 450 führen zu Rabatten.
		public int PopularityIndex { get; set; }

		// Familie/Kategorie der Karte (Monsters, Aliens, etc.)
		// Enum für typsichere Kategorisierung
		public CardFamily CardFamily { get; set; }
		

		// Berechnete Property: Bestimmt, ob die Karte rabattiert ist (Read-Only).
		// Nur Getter, kein Setter - Wert wird aus PopularityIndex abgeleitet.
		// Dies ist ein Beispiel für berechnete Properties, die häufig in MVVM-Pattern verwendet werden.
		public bool IsDiscounted
		{
			get { 
				// Geschäftsregel: Karten mit Popularitätsindex < 450 erhalten einen Rabatt.
				// Dies zeigt, wie Geschäftslogik direkt im Modell implementiert werden kann.
				return PopularityIndex < 450; 
			}

		}
		
	}
	// Enum für Kartenfamilien/Kategorien
	// 'enum': Aufzählungstyp für eine feste Menge benannter Konstanten.
	// Dies verhindert "Magic Strings" und ermöglicht typsichere Zuweisungen.
	// Der Compiler wandelt diese in Ganzzahlen um (0, 1, 2, 3...).
	public enum CardFamily
	{
		Monsters,  // Wert: 0
		Aliens,    // Wert: 1
		Robots,    // Wert: 2
		Animals    // Wert: 3
	}
	// Enum für Teamnamen
	// Verwendet für die TeamName-Property in CollectableCard.
	// Enums bieten IntelliSense, Typsicherheit und verhindern Rechtschreibfehler.
	public enum TeamNames
	{ 
		BlueShadows,
		ThunderHeads,
		SpookTones,
		Crashmasters,
		Mavericks,
		LaserPhasers,
		Helios,
		Farsiders,
		SuperNovas
	}
	
}
