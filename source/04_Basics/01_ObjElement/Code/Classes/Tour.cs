// Importiert grundlegende .NET-Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace für dieses Projekt
namespace ObjectElements {
	// 'public': Diese Klasse ist von außerhalb der Assembly sichtbar und verwendbar.
	// Dies ist eine einfache POCO-Klasse (Plain Old CLR Object), die als Datenmodell dient.
	// Sie kann in XAML instanziiert und an UI-Elemente gebunden werden.
	public class Tour {
		// 'public': Property ist von außen les- und schreibbar
		// 'string': Referenztyp für Text (unveränderliche Zeichenketten)
		// '{ get; set; }': Auto-Property-Syntax. Der Compiler erzeugt automatisch
		// ein privates Backing-Field und die get/set-Accessoren.
		// Diese Property speichert den Namen der Tour.
		public string TourName { get; set; }
		
		// Auto-Property für die Stadt, in der die Tour stattfindet.
		// In XAML kann diese Property als Attribut gesetzt werden: <Tour City="Berlin" />
		public string City { get; set; }

		// 'override': Überschreibt die geerbte Methode von System.Object
		// 'ToString()': Wird aufgerufen, wenn das Objekt in einen String konvertiert wird,
		// z.B. beim Anzeigen in einer ListBox oder beim String-Formatting.
		// Nützlich für Debugging und Anzeige in UI-Elementen ohne explizites Binding.
		public override string ToString() {
			// String-Interpolation ($"..."): Moderne C#-Syntax zum Einfügen von Variablen in Strings
			// Gibt eine formatierte Darstellung der Tour zurück
			return $"Tour: {TourName},{City}";
		}
	}
}
