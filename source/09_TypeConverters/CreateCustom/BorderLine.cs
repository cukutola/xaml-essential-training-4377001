// 'using': Importiert den System.ComponentModel Namespace für TypeConverter-Attribute.
using System.ComponentModel;

// 'namespace': Definiert den Namensraum für Controls in diesem Projekt.
namespace CreateCustom.Controls {
	
	// HINWEIS: Diese Klasse wurde für Beispielzwecke erstellt.
	// In produktivem Code sollte der eingebaute 'Thickness'-Typ verwendet werden,
	// der bereits TypeConverter-Unterstützung und optimierte Performance bietet.
	
	// '[TypeConverter(typeof(BorderlineConverter))]': ATTRIBUTE - Registriert den TypeConverter.
	// WICHTIG: Dieses Attribut teilt dem WPF/XAML-System mit, welcher TypeConverter für 
	// diese Klasse verwendet werden soll. Ohne dieses Attribut würde XAML nicht wissen,
	// wie String-Attribute in BorderLine-Objekte konvertiert werden.
	// AUSWIRKUNG: Der XAML-Parser sucht dieses Attribut via Reflection und instanziiert
	// dann den BorderlineConverter automatisch bei Bedarf.
	[TypeConverter(typeof(BorderlineConverter))]
	// 'public': Macht die Klasse für XAML und andere Assemblies verwendbar.
	// 'class': Definiert einen Referenztyp (im Gegensatz zu 'struct' für Wertetypen).
	public class BorderLine {
		
		// 'public': Properties müssen public sein, damit XAML darauf zugreifen kann.
		// '{ get; set; }': Auto-Property mit automatisch generierten Backing Fields.
		// ZWECK: Speichert die Rahmenbreite für die obere Kante.
		// VERWENDUNG: In XAML als Teil des Parsing-Ergebnisses gesetzt.
		public double Top { get; set; }
		
		// Speichert die Rahmenbreite für die untere Kante.
		public double Bottom { get; set; }
		
		// Speichert die Rahmenbreite für die linke Kante.
		public double Left { get; set; }
		
		// Speichert die Rahmenbreite für die rechte Kante.
		public double Right { get; set; }
		
		// 'override': Überschreibt die geerbte ToString()-Methode von System.Object.
		// ZWECK: Liefert eine lesbare String-Darstellung des Objekts.
		// VERWENDUNG: Nützlich für Debugging, Logging und PropertyGrid-Anzeige.
		// '$"..."': String-Interpolation (C# 6.0+) für lesbare Formatierung.
		public override string ToString() {
			return $"Left: {Left}  Top: {Top}  Right: {Right}  Bottom: {Bottom}";
		}
	}
}
