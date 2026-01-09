// 'using': Importiert Namespaces für WPF und TypeConverter-Funktionalität.
using System;
using System.Collections.Generic;
using System.ComponentModel; // Für DoubleConverter, BrushConverter
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
using WhyTypeConverters.Controls;

// 'namespace': Organisiert die Klassen der Anwendung.
namespace WhyTypeConverters {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	
	// 'partial': Die Klasse ist auf mehrere Dateien aufgeteilt.
	// ': Window': Basisklasse für WPF-Fenster.
	public partial class MainWindow : Window {
		
		// KONSTRUKTOR: Wird beim Erstellen des Fensters aufgerufen.
		public MainWindow() {
			// 'InitializeComponent()': Lädt die XAML-Datei und erstellt den Visual Tree.
			InitializeComponent();
		
			// Ruft die Demo-Methode auf, die zeigt, warum TypeConverter nützlich sind.
			SetPropertiesInCode();
		}

		// DEMO-METHODE: Demonstriert die programmatische Verwendung von TypeConverters.
		// ZWECK: Zeigt, dass TypeConverter nicht nur in XAML, sondern auch in C#-Code nützlich sind.
		// HINTERGRUND: In XAML werden TypeConverter automatisch aufgerufen, aber in C#
		// können wir sie manuell verwenden, um String-Werte zu konvertieren.
		public void SetPropertiesInCode() {
			// 'new Rating()': Erstellt eine neue Instanz des benutzerdefinierten Rating-Controls.
			var cardRating = new Rating();

			// EINFACHE PROPERTIES: String- und Zahlen-Typen können direkt zugewiesen werden.
			cardRating.HeaderText = "How would you rate your buying experience?";
			cardRating.StarCount = 5;
			
			// 'int.Parse()': Konvertiert einen String in einen Integer.
			// VERWENDUNG: Simuliert die Verarbeitung von Benutzereingaben oder Config-Dateien.
			cardRating.StarCount = int.Parse("7");
			
			// 'double.Parse()': Konvertiert einen String in einen Double.
			// HINWEIS: Verwendet die aktuelle Thread-Kultur für Dezimaltrennzeichen.
			cardRating.UserRating = double.Parse("3.5");
			
			// TYPECONVERTER-VERWENDUNG: Alternative zu Parse() mit mehr Flexibilität.
			// 'DoubleConverter': Ein eingebauter TypeConverter für double-Werte.
			var doubleConv = new DoubleConverter	();
			// 'ConvertFromString()': Bequeme Methode, die ConvertFrom() mit typeof(string) aufruft.
			// VORTEIL: Unterstützt mehr Formate und kann kulturspezifisch konvertieren.
			cardRating.UserRating = (double)doubleConv.ConvertFromString("2.5");

			// KOMMENTIERT: Diese Zeile würde NICHT funktionieren!
			// 'cardRating.StarBackground = "Red";'
			// GRUND: StarBackground ist vom Typ 'Brush', nicht 'string'.
			// C# hat keine implizite Konvertierung von string zu Brush.
			// LÖSUNG: Verwende einen BrushConverter!
			
			// 'BrushConverter': Ein eingebauter TypeConverter für Brush-Objekte.
			// ZWECK: Konvertiert Farbnamen und Hex-Werte (z.B. "#FF5733") in Brush-Objekte.
			var brushConv = new BrushConverter();

			// 'ConvertFromString("Orange")': Konvertiert den Farbnamen "Orange" in eine Brush.
			// 'as SolidColorBrush': Sichere Type-Konvertierung (gibt null zurück bei Fehler).
			// AUSWIRKUNG: Erstellt eine SolidColorBrush mit der Farbe Orange.
			// HINWEIS: In XAML würde diese Konvertierung automatisch passieren bei:
			// <Rating StarBackground="Orange" />
			cardRating.StarBackground = brushConv.ConvertFromString("Orange") as SolidColorBrush;
			
		}

		// EVENT HANDLER: Wird aufgerufen, wenn die Maus über das currentRating-Element bewegt wird.
		// 'private': Nur innerhalb dieser Klasse sichtbar.
		// PARAMETER:
		// - 'sender': Das Control, das das Event ausgelöst hat.
		// - 'e': Event-Argumente mit Informationen über Mausposition, Buttons, etc.
		private void currentRating_MouseEnter(object sender, MouseEventArgs e) {
			// HINWEIS: Diese Methode ist leer und dient nur als Platzhalter.
			// In einer echten Anwendung könnte hier z.B. ein Tooltip angezeigt werden.
		}
	}
}
