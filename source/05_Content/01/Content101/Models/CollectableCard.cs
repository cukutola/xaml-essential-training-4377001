// 'using': Importiert grundlegende .NET-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 'namespace': Definiert den Namensraum für Datenmodelle.
namespace BigStar.Models
	
{
	// 'public': Macht die Klasse für XAML und andere Assemblies verfügbar.
	// ZWECK: Repräsentiert eine Sammelkarte (Collectable Card) - ein Business-Objekt/Model.
	// VERWENDUNG: Wird in Data Binding verwendet, um Karten-Daten im UI anzuzeigen.
	// KONZEPT: Dies ist ein Plain Old CLR Object (POCO) - keine WPF-spezifischen Abhängigkeiten.
	public class CollectableCard
	{

		// AUTO-PROPERTIES: Speichern Daten über die Sammelkarte.
		// Diese Properties werden via Data Binding an UI-Elemente gebunden.
		
		// 'int': Eindeutige ID der Karte.
		public int Id { get; set; }
		// 'string': Name der Karte/Charakters.
		public string Name { get; set; }
		// Slogan/Motto der Karte.
		public string Slogan { get; set; }
		

	

		// 'TeamNames': Enum-Typ für Teamnamen.
		public TeamNames TeamName { get; set; }
		// 'decimal': Katalogpreis (genaue Dezimalwerte für Geld).
		public decimal CatalogPrice { get; set; }
		// Gebotspreis/Verkaufspreis.
		public decimal BidPrice { get; set; }
		// Kurzbeschreibung der Karte.
		public string ShortDescription { get; set; }
	
		
	
		// BERECHNETE PROPERTY: Verkaufspreis mit optionalem Rabatt.
		// 'get-only': Nur lesbar, Wert wird zur Laufzeit berechnet.
		// ZWECK: Demonstriert Business-Logik im Model.
		public decimal SalePrice
		{
			get
			{
				// 'IsDiscounted': Prüft, ob Rabatt gewährt wird.
				if (IsDiscounted)
				{
					// '.75M': 25% Rabatt (M = decimal literal).
					return BidPrice * .75M;
				}
				else
				{
					return BidPrice;
				}

			}
		}
		// URI zum Bild der Karte.
		public string ImageUri { get; set; }
	
		// Popularitätsindex - beeinflusst Rabatt.
		public int PopularityIndex { get; set; }

		// 'CardFamily': Enum für Karten-Kategorien (Monsters, Aliens, etc.).
		public CardFamily CardFamily { get; set; }

		// Ausführliche Beschreibung.
		public string Description { get; set; }
		// Anzahl der Augen (relevant für Monster/Aliens).
		public int EyeCount { get; set; }
		
		// BERECHNETE PROPERTY: Rabatt basierend auf Popularität.
		// LOGIK: Unpopuläre Karten (Index < 450) werden rabattiert.
		public bool IsDiscounted
		{
			get { return PopularityIndex < 450; }

		}
		// 'Dictionary': Zusätzliche Details als Key-Value-Paare.
		// 'new Dictionary...': Inline-Initialisierung (C# 6.0+).
		public Dictionary<string, string> Details { get; set; } = new Dictionary<string, string>();
	}
	
	// 'enum': Aufzählungstyp für Karten-Kategorien.
	// ZWECK: Typsichere Werte statt Magic Strings.
	public enum CardFamily
	{
		Monsters,
		Aliens,
		Robots,
		Animals
	}
	
	// 'enum': Aufzählungstyp für Teamnamen.
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
