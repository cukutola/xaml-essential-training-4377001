using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Concepts {
	/// <summary>
	/// Interaction logic for Basics.xaml
	/// </summary>
	// 'public partial class Basics : Window': Fensterklasse, die WPF-Grundlagen demonstriert.
	// 'partial': Ermöglicht die Aufteilung zwischen XAML-generiertem Code und Code-Behind.
	// ': Window': Basisklasse für alle Anwendungsfenster mit Rahmen, Titel und Systemschaltflächen.
	public partial class Basics : Window {
		public Basics() {
			// 'InitializeComponent()': Lädt die XAML-Datei und initialisiert alle deklarierten UI-Elemente.
			// Muss IMMER vor jedem Zugriff auf UI-Elemente aufgerufen werden.
			InitializeComponent();

			// BEISPIEL: Programmatische UI-Erstellung in C# (als Alternative zu XAML)
			// Dies zeigt die Äquivalenz zwischen XAML und C#-Code.

			// 'new StackPanel()': Erstellt ein vertikales Layout-Panel im Speicher.
			// StackPanel ordnet Kindelemente automatisch untereinander (Orientation.Vertical ist Standard).
			var stack = new StackPanel();

			// 'new TextBlock()': Erstellt ein leichtgewichtiges, nicht editierbares Textelement.
			// TextBlock ist performanter als Label, da es weniger Features hat (kein Content-Property, kein Mnemonics).
			var titleText = new TextBlock();
			// 'Text': Setzt den anzuzeigenden Text. Dies ist eine einfache CLR-Property (keine DependencyProperty hier).
			titleText.Text = "Tour Stops";

			// 'new CheckBox()': Erstellt ein Kontrollkästchen mit drei möglichen Zuständen (wenn IsThreeState=true).
			var kids = new CheckBox();
			// 'IsChecked': DependencyProperty vom Typ bool?. Kann true, false oder null sein.
			// Durch DependencyProperty kann diese Eigenschaft gebunden und animiert werden.
			kids.IsChecked = true;
			// 'Content': ContentControl-Eigenschaft. Kann nicht nur Text, sondern BELIEBIGE Objekte enthalten
			// (Bilder, andere Controls, komplexe Layouts). WPF rendert den Inhalt über DataTemplates.
			kids.Content = "Kid Friendly";

			// 'Children.Add()': Fügt Elemente zur Children-Collection des StackPanel hinzu.
			// REIHENFOLGE: Die Reihenfolge der Add()-Aufrufe bestimmt die visuelle Reihenfolge von oben nach unten.
			stack.Children.Add(titleText);
			stack.Children.Add(kids);

			// HINWEIS: Dieser Code erstellt Elemente, zeigt sie aber NICHT an, da 'stack' nirgendwo
			// dem visuellen Baum hinzugefügt wird. Normalerweise würde man 'this.Content = stack;' aufrufen,
			// um das StackPanel als Hauptinhalt des Fensters zu setzen.
		}
	}
}
