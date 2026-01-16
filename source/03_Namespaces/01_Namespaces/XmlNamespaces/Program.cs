// .NET Standard-Namespaces.
// 'using': Importiert Typen aus Namespaces für vereinfachten Zugriff.
// ALTERNATIVE: Ohne 'using' müssten vollqualifizierte Namen verwendet werden (z.B. System.Console).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ===== XML NAMESPACES vs. CLR NAMESPACES =====
// Diese Demo erklärt den fundamentalen Unterschied zwischen XML- und CLR-Namespaces:
//
// 1. CLR-NAMESPACE (C# 'namespace' keyword):
//    - Organisiert .NET-Typen in logische Gruppen
//    - Beispiel: namespace MyCompany.MyApp.Controls { ... }
//    - Verhindert Namenskonflikte zwischen Klassen
//    - Teil der .NET-Laufzeitumgebung
//
// 2. XML-NAMESPACE (xmlns in XAML):
//    - URI/URL zur eindeutigen Identifikation von XML-Elementen
//    - Beispiel: xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
//    - Nicht notwendigerweise eine echte Web-Adresse (nur eindeutiger Identifier)
//    - Standard XML-Konzept (nicht .NET-spezifisch)
//
// 3. VERBINDUNG IN XAML:
//    - xmlns mappt XML-Namespaces auf CLR-Namespaces
//    - Syntax: xmlns:prefix="clr-namespace:NamespaceName;assembly=AssemblyName"
//    - Der XAML-Parser übersetzt XML-Namespaces in CLR-Typen
//    - Ermöglicht Verwendung von .NET-Klassen in XAML
//
// BEISPIELE:
// - xmlns="http://..." (Default-Namespace) → System.Windows.Controls, etc.
// - xmlns:x="http://..." (XAML-Namespace) → XAML-spezifische Features (x:Name, x:Key)
// - xmlns:local="clr-namespace:MyNamespace" → Lokale Klassen im gleichen Projekt
// - xmlns:lib="clr-namespace:MyNamespace;assembly=MyLib" → Externe Assembly-Klassen

// 'namespace XmlNamespaces': CLR-Namespace dieser Demo-Anwendung.
// WICHTIG: Dies ist ein C#-Namespace, NICHT ein XML-Namespace!
// XAML-MAPPING: Um diese Klassen in XAML zu nutzen:
//               xmlns:local="clr-namespace:XmlNamespaces"
// UNTERSCHIED: Der obige xmlns-String ist ein XML-Namespace, der auf diesen CLR-Namespace verweist.
namespace XmlNamespaces {
	
	// 'internal class': Nur innerhalb dieser Assembly sichtbar.
	// UNTERSCHIED zu 'public': Kann nicht von außerhalb der Assembly referenziert werden.
	// EINSATZZWECK: Interne Implementierungsdetails verbergen.
	// HINWEIS: 'internal' Klassen können NICHT in XAML aus anderen Assemblies verwendet werden!
	internal class Program {
		
		// 'static void Main': Einstiegspunkt für Konsolenanwendungen.
		// WICHTIG: Der Compiler sucht nach dieser Methode zum Programmstart.
		// 'string[] args': Kommandozeilen-Argumente, die beim Start übergeben werden.
		// KONTEXT: Diese Demo ist eine Konsolen-App zur Erklärung von Namespace-Konzepten.
		static void Main(string[] args) {
			// ===== NAMESPACE-KONZEPTE ZUSAMMENFASSUNG =====
			//
			// CLR-NAMESPACE:
			// - C#-Konzept zur Organisation von Typen
			// - Verwendet 'namespace' keyword
			// - Verwendet 'using' für Import
			//
			// XML-NAMESPACE:
			// - XML-Standard zur Vermeidung von Element-Namenskonflikten
			// - URI-basierte Identifikation (z.B. http://schemas.microsoft.com/...)
			// - In XAML mit 'xmlns' deklariert
			//
			// CLR-NAMESPACE-MAPPING in XAML:
			// - xmlns:prefix="clr-namespace:NamespaceName" (lokales Projekt)
			// - xmlns:prefix="clr-namespace:NamespaceName;assembly=AssemblyName" (externe DLL)
			// - Ermöglicht Zugriff auf .NET-Klassen aus XAML heraus
			//
			// DEFAULT XAML NAMESPACES:
			// - xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
			//   → WPF-Standard-Controls (Button, TextBox, Grid, etc.)
			// - xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
			//   → XAML-Language-Features (x:Name, x:Key, x:Type, etc.)
		}
	}
}
