// .NET Standard-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 'namespace XmlNamespaces': Demonstriert Namespace-Konzepte.
// HINWEIS: Dieser Namespace zeigt den Unterschied zwischen XML-Namespaces und CLR-Namespaces.
// KONTEXT: XML-Namespaces (xmlns) vs. CLR-Namespaces (namespace keyword).
namespace XmlNamespaces {
	
	// 'internal class': Nur innerhalb dieser Assembly sichtbar.
	// UNTERSCHIED zu 'public': Kann nicht von außerhalb der Assembly referenziert werden.
	// EINSATZZWECK: Interne Implementierungsdetails verbergen.
	internal class Program {
		
		// 'static void Main': Einstiegspunkt für Konsolenanwendungen.
		// WICHTIG: Der Compiler sucht nach dieser Methode zum Programmstart.
		// 'string[] args': Kommandozeilen-Argumente, die beim Start übergeben werden.
		static void Main(string[] args) {
			// Leere Main-Methode: Demonstrationszwecke für Namespace-Konzepte.
			// HINWEIS: In echten Apps würde hier die Programm-Logik stehen.
		}
	}
}
