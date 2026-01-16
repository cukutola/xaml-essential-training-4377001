using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF-Desktop-Anwendungen
using System.Windows;
// System.Windows.Controls: Alle Standard-UI-Steuerelemente (Button, TextBox, etc.)
using System.Windows.Controls;
// System.Windows.Data: Datenbindung zwischen UI und Geschäftslogik
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung (FlowDocument, Paragraph, etc.)
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung (Maus, Tastatur, Touch, Commands)
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms, Animationen
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung und -anzeige
using System.Windows.Media.Imaging;
// System.Windows.Navigation: Navigation zwischen Seiten/Frames
using System.Windows.Navigation;
// System.Windows.Shapes: Vektorgrafikelemente (Rectangle, Ellipse, Line, Polygon)
using System.Windows.Shapes;

namespace TheStarShape {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	// MainWindow-Klasse: Hauptfenster der Anwendung
	// ZWECK: Demonstriert die Verwendung des Star-Controls mit Custom DependencyProperties
	// PATTERN: Code-Behind Klasse für MainWindow.xaml
	public partial class MainWindow : Window {
		// Instanz-Konstruktor: Wird beim Erstellen des Hauptfensters aufgerufen
		public MainWindow() {
			// 'InitializeComponent': Lädt und initialisiert die XAML-UI-Definition
			InitializeComponent();
		}

		// Event-Handler: Wird aufgerufen, wenn der Button geklickt wird
		// HINWEIS: Dieser Handler ist aktuell leer - auskommentierte Zeilen zeigen mögliche Verwendungen
		private void Button_Click(object sender, RoutedEventArgs e) {
			// BEISPIEL 1: Setzen der Points-Property über den CLR-Wrapper
		//	BottomStar.Points = 5;
			
			// BEISPIEL 2: Setzen der Property direkt über SetValue (umgeht den CLR-Wrapper)
			// WICHTIG: Beide Ansätze führen zum gleichen Ergebnis, da der Wrapper nur GetValue/SetValue aufruft
     // BottomStar.SetValue(StarShape.PointsProperty, 6);
     
		}

		// Event-Handler: Wird aufgerufen, wenn sich der Slider-Wert ändert
		// ZWECK: Steuert die Anzahl der Sternspitzen dynamisch über die Points-Property
		// 'e.NewValue': Der neue Wert des Sliders (double), muss zu int gecastet werden
		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
			// DEPENDENCY PROPERTY MANIPULATION: Setze Points-Property des Star-Controls
			// BINDING-ALTERNATIVE: Dies könnte auch über XAML Binding gelöst werden:
			// <Star Points="{Binding ElementName=MySlider, Path=Value}" />
			TheStar.Points = (int)e.NewValue;
		}

		// Event-Handler: Wird aufgerufen, wenn sich der InnerSize-Slider ändert
		// ZWECK: Steuert die Skalierung der inneren Ellipsen dynamisch
		// EFFEKT: Ermöglicht Live-Anpassung der Stern-Form während der Laufzeit
		private void InnerSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
			// DEPENDENCY PROPERTY MANIPULATION: Setze InnerSize-Property des Star-Controls
			// Der neue Wert ist bereits vom Typ double, kein Cast erforderlich
		TheStar.InnerSize = (double)e.NewValue;
		}

		// Event-Handler: Wird aufgerufen, wenn auf ein Rechteck (Farbauswahl) geklickt wird
		// ZWECK: Ändert die Vordergrundfarbe des Sterns basierend auf der Farbauswahl
		// PATTERN: Wiederverwendbarer Event-Handler für mehrere Rechtecke
		private void ForeRectangle_MouseUp(object sender, MouseButtonEventArgs e) {

			// Cast des Senders zu Rectangle, um Zugriff auf die Fill-Property zu erhalten
			var currentRect = sender as Rectangle;
			if (currentRect != null)
			{
				// BRUSH-ZUWEISUNG: Setze die Foreground-Property des Star-Controls
				// 'currentRect.Fill': Der Brush (SolidColorBrush) des angeklickten Rechtecks
				// EFFEKT: Die Farbe der Sternspitzen ändert sich zur gewählten Farbe
			TheStar.Foreground = currentRect.Fill;
			}

		}

		// Event-Handler: Wird aufgerufen, wenn auf ein Rechteck (Hintergrundfarbe) geklickt wird
		// ZWECK: Ändert die Hintergrundfarbe des Sterns basierend auf der Farbauswahl
		private void BackRectangle_MouseUp(object sender, MouseButtonEventArgs e) {
			// Cast des Senders zu Rectangle
			var currentRect = sender as Rectangle;
			if (currentRect != null)
			{
				// BRUSH-ZUWEISUNG: Setze die Background-Property des Star-Controls
				// EFFEKT: Die Hintergrundfarbe des Sterns ändert sich zur gewählten Farbe
				TheStar.Background = currentRect.Fill;
			}
		}

		// Event-Handler: Wird aufgerufen, wenn die CheckBox aktiviert wird
		// ZWECK: Aktiviert den Hintergrund-Leuchteffekt des Sterns
		private void CheckBox_Checked(object sender, RoutedEventArgs e) {
			// DEPENDENCY PROPERTY MANIPULATION: Setze BackEffectVisible auf true
			// EFFEKT: Der BackCircle im Star-Control wird sichtbar (Visibility.Visible)
			TheStar.BackEffectVisible = true;
		}

		// Event-Handler: Wird aufgerufen, wenn die CheckBox deaktiviert wird
		// ZWECK: Deaktiviert den Hintergrund-Leuchteffekt des Sterns
		private void CheckBox_Unchecked(object sender, RoutedEventArgs e) {
			// DEPENDENCY PROPERTY MANIPULATION: Setze BackEffectVisible auf false
			// EFFEKT: Der BackCircle im Star-Control wird unsichtbar (Visibility.Collapsed)
			TheStar.BackEffectVisible = false;
		}
	}
}
