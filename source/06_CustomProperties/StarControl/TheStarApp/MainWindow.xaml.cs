// Standard .NET Namespaces für allgemeine Funktionalität.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF-Anwendungen.
using System.Windows;
// System.Windows.Controls: Enthält alle Standard-UI-Steuerelemente (Button, TextBox, Slider, etc.).
using System.Windows.Controls;
// System.Windows.Data: Data Binding-Infrastruktur für MVVM-Pattern.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung (FlowDocument, Paragraph, etc.).
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung (Maus, Tastatur, Touch, Commands).
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Colors, Transforms, Animationen.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung und -anzeige.
using System.Windows.Media.Imaging;
// System.Windows.Navigation: Navigation zwischen Seiten/Frames in WPF.
using System.Windows.Navigation;
// System.Windows.Shapes: Vektorgrafikelemente (Rectangle, Ellipse, Line, Polygon).
using System.Windows.Shapes;

// Namespace für die Stern-Demo-Anwendung.
// KONTEXT: Demonstriert Custom Dependency Properties am Beispiel eines Stern-UserControls.
namespace TheStarShape {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// 'public partial class MainWindow : Window': Hauptfenster der Star-Demo-Anwendung.
	// 'partial': Teilt die Klasse auf. Der XAML-Compiler generiert den anderen Teil aus MainWindow.xaml
	// mit allen UI-Elementen als Felder (TheStar, Slider, etc.).
	// ': Window': Basisklasse für WPF-Fenster. Bietet Fenster-Management, Dialog-Unterstützung.
	// ZWECK: Demonstriert Interaktion mit Custom DependencyProperties eines UserControls.
	public partial class MainWindow : Window {
		// Konstruktor: Wird beim Erstellen des Fensters aufgerufen.
		// ZEITPUNKT: Vor dem Anzeigen des Fensters.
		public MainWindow() {
			// 'InitializeComponent()': KRITISCH! Diese vom XAML-Compiler generierte Methode:
			// 1. Lädt und parst die MainWindow.xaml-Datei
			// 2. Erstellt alle in XAML definierten UI-Elemente (Star-Control, Slider, Buttons, etc.)
			// 3. Setzt Properties basierend auf XAML-Attributen
			// 4. Verbindet Event-Handler (Click, ValueChanged, etc.) mit Code-Behind-Methoden
			// 5. Verknüpft benannte Elemente (x:Name="TheStar") mit Feldern dieser Klasse
			// Ohne diesen Aufruf wäre das Fenster leer und alle x:Name-Referenzen wären null!
			InitializeComponent();
		}

		// Event-Handler für Button-Click-Events.
		// 'private void': Nur innerhalb dieser Klasse sichtbar, gibt nichts zurück.
		// 'object sender': Das UI-Element, das den Event ausgelöst hat (der Button).
		// 'RoutedEventArgs e': Event-Argumente mit zusätzlichen Informationen über den Event.
		// ROUTED EVENTS: In WPF können Events durch den visuellen Baum "bubbling" oder "tunneling".
		// HINWEIS: Auskommentierter Code zeigt zwei Wege, DependencyProperty-Werte zu setzen:
		// 1. Über CLR-Wrapper: BottomStar.Points = 5 (üblich, lesbar)
		// 2. Direkt über SetValue: BottomStar.SetValue(StarShape.PointsProperty, 6) (WPF-intern)
		private void Button_Click(object sender, RoutedEventArgs e) {
		//	BottomStar.Points = 5;
     // BottomStar.SetValue(StarShape.PointsProperty, 6);
     
		}

		// Event-Handler für Slider ValueChanged-Event.
		// ZWECK: Synchronisiert Slider-Wert mit der Points-DependencyProperty des Star-Controls.
		// 'RoutedPropertyChangedEventArgs<double>': Generischer Event-Args-Typ für Property-Änderungen.
		// Enthält OldValue und NewValue für Vergleiche oder Validierungen.
		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
			// 'TheStar.Points': Setzt die Points-DependencyProperty des Star-UserControls.
			// '(int)e.NewValue': Cast von double zu int, da Points ein int ist.
			// BINDING-ALTERNATIVE: In XAML könnte man auch {Binding Value, ElementName=Slider} verwenden.
			// VORTEIL VON CODE: Ermöglicht Validierung oder Transformation vor der Zuweisung.
			TheStar.Points = (int)e.NewValue;
		}

		// Event-Handler für InnerSize-Slider ValueChanged-Event.
		// ZWECK: Steuert die Größe der inneren Sternzacken über die InnerSize-DependencyProperty.
		// UNTERSCHIED zu Slider_ValueChanged: Keine Konvertierung nötig, da beide double sind.
		private void InnerSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
		// 'TheStar.InnerSize': DependencyProperty für die Skalierung der inneren Sternelemente.
		// 'e.NewValue': Der neue Wert des Sliders (0.0 bis 1.0 typischerweise).
		TheStar.InnerSize = (double)e.NewValue;
		}

		// Event-Handler für MouseUp-Event auf Vordergrund-Farbrechtecken.
		// ZWECK: Ermöglicht Farbauswahl durch Klick auf farbige Rechtecke.
		// PATTERN: Color-Picker-ähnliche Funktionalität ohne zusätzliche Dialoge.
		// 'MouseButtonEventArgs e': Enthält Informationen über Mausbutton, Position, Click-Count, etc.
		private void ForeRectangle_MouseUp(object sender, MouseButtonEventArgs e) {

			// 'as Rectangle': Sichere Typumwandlung (Safe Cast). Gibt null zurück bei Fehler.
			// VORTEIL gegenüber (Rectangle)sender: Keine Exception bei falschemTyp.
			// EINSATZZWECK: Der sender sollte immer ein Rectangle sein, aber Sicherheit schadet nicht.
			var currentRect = sender as Rectangle;
			// Null-Check: Stellt sicher, dass die Umwandlung erfolgreich war.
			if (currentRect != null)
			{

			// 'TheStar.Foreground': Setzt die Foreground-Brush des Star-Controls.
			// 'currentRect.Fill': Kopiert die Brush des geklickten Rechtecks.
			// WICHTIG: Fill ist eine Brush (SolidColorBrush, LinearGradientBrush, etc.).
			// WPF-FEATURE: Brushes werden intern geteilt (Frozen), wenn möglich, für Performance.
			TheStar.Foreground = currentRect.Fill;
			}

		}

		// Event-Handler für MouseUp-Event auf Hintergrund-Farbrechtecken.
		// ZWECK: Analog zu ForeRectangle_MouseUp, aber für Hintergrundfarbe.
		// PATTERN: Code-Duplikation könnte durch gemeinsamen Handler mit Parameter vermieden werden.
		private void BackRectangle_MouseUp(object sender, MouseButtonEventArgs e) {
			// Sichere Typumwandlung zum Rectangle-Typ.
			var currentRect = sender as Rectangle;
			// Validierung: Nur fortfahren, wenn die Umwandlung erfolgreich war.
			if (currentRect != null)
			{

				// Setzt die Background-Brush des Star-Controls auf die Fill-Brush des Rechtecks.
				// UNTERSCHIED zu Foreground: Background beeinflusst andere Teile des Star-Visuals.
				TheStar.Background = currentRect.Fill;
			}
		}

		// Event-Handler für CheckBox Checked-Event.
		// ZWECK: Aktiviert den Hintergrund-Effekt des Star-Controls.
		// PATTERN: Einfache Boolean-Zuweisung an DependencyProperty.
		private void CheckBox_Checked(object sender, RoutedEventArgs e) {
			// 'TheStar.BackEffectVisible': Custom DependencyProperty vom Typ bool.
			// EFFEKT: Macht einen visuellen Hintergrundeffekt (z.B. Glow, Shadow) sichtbar.
			TheStar.BackEffectVisible = true;
		}

		// Event-Handler für CheckBox Unchecked-Event.
		// ZWECK: Deaktiviert den Hintergrund-Effekt des Star-Controls.
		// SYMMETRIE: Gegenstück zu CheckBox_Checked für vollständige Toggle-Funktionalität.
		private void CheckBox_Unchecked(object sender, RoutedEventArgs e) {
			// Versteckt den Hintergrundeffekt durch Setzen auf false.
			// WPF-INTERN: Dies triggert den PropertyChangedCallback der BackEffectVisible-DP.
			TheStar.BackEffectVisible = false;
		}
	}
}
