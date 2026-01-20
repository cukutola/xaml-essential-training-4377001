using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ResourcesProperty {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// <remarks>
	/// HAUPTFENSTER - Programmatische ResourceDictionary-Manipulation
	/// 
	/// Demonstriert die Erstellung und Zuweisung eines ResourceDictionary im Code-Behind.
	/// Dies ist eine Alternative zur XAML-basierten Resource-Definition.
	/// 
	/// PROGRAMMATISCHE RESOURCE-DEFINITION:
	/// Zeigt wie Resources komplett im C#-Code erstellt und zugewiesen werden können,
	/// anstatt sie in XAML zu definieren.
	/// </remarks>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

			// ERSTELLEN EINES NEUEN RESOURCEDICTIONARY
			// ResourceDictionary ist die Basisklasse für alle Resource-Container in WPF
			// Kann Key-Value-Paare beliebiger Objekt-Typen speichern
			var dictionary = new ResourceDictionary();

			// HINZUFÜGEN VON RESOURCES MIT ADD-METHODE
			// Syntax: dictionary.Add(key: "ResourceKey", value: ResourceObject)
			
			// Resource 1: MainBrush - SolidColorBrush mit Lavender-Farbe
			// - Key: "MainBrush" (String) - wird für {StaticResource MainBrush} verwendet
			// - Value: SolidColorBrush - kann für Background, Foreground, etc. verwendet werden
			// - SolidColorBrush ist eine Freezable-Klasse und sollte idealerweise gefreezed werden
			dictionary.Add(key: "MainBrush", value: new SolidColorBrush(Colors.Lavender));
			
			// Resource 2: AccentBrush - SolidColorBrush mit Gold-Farbe
			// - Wird typischerweise für Hervorhebungen und Akzente verwendet
			// - Named Arguments (key:, value:) verbessern Lesbarkeit
			dictionary.Add(key: "AccentBrush", value: new SolidColorBrush(Colors.Gold));

			// WEITERE MÖGLICHKEITEN (hier nicht verwendet):
			// dictionary["ThirdBrush"] = new SolidColorBrush(Colors.Blue); // Indexer-Syntax
			// dictionary.Remove("MainBrush"); // Entfernen einer Resource
			// if (dictionary.Contains("MainBrush")) { ... } // Prüfen auf Existenz


			// ZUWEISUNG DES DICTIONARY ZUR RESOURCES-PROPERTY
			// this.Resources = dictionary ersetzt das gesamte ResourceDictionary des Windows
			// WICHTIG: 
			// - Alle vorher in XAML definierten Window.Resources werden überschrieben
			// - Dies geschieht VOR dem vollständigen Aufbau des Visual Trees
			// - StaticResource-Referenzen im XAML werden zur Laufzeit aufgelöst
			// - DynamicResource-Referenzen würden auch nach dieser Zuweisung funktionieren
			this.Resources = dictionary;
			
			// ALTERNATIVE ANSÄTZE:
			// 1. Erweitern statt Ersetzen:
			//    this.Resources.Add("MainBrush", new SolidColorBrush(Colors.Lavender));
			// 2. MergedDictionaries verwenden:
			//    this.Resources.MergedDictionaries.Add(dictionary);
			// 3. Zur Laufzeit ändern:
			//    this.Resources["MainBrush"] = new SolidColorBrush(Colors.Red);
		}
	}
}
