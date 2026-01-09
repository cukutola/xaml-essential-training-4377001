// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente.
using System.Windows.Controls;
// System.Windows.Data: Data Binding.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms.
using System.Windows.Media;
// System.Windows.Media.Animation: WPF-Animationssystem.
// WICHTIG: Dieses Fenster demonstriert Animation-Precedence!
// ANIMATIONS-PRECEDENCE: Animated-Werte haben höchste Priorität (noch über Local).
using System.Windows.Media.Animation;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;
// System.Windows.Threading: Timer und Dispatcher.
using System.Windows.Threading;

// Namespace für die Precedence-Demo.
namespace Precedence {
	/// <summary>
	/// Interaction logic for Demo3Window.xaml
	/// </summary>
	// 'Win3': Drittes Fenster der Precedence-Demo-Serie.
	// ZWECK: Demonstriert Animation-Precedence - die höchste Priorität im Value System!
	// ANIMATIONS-PRECEDENCE: Animated > Local > Triggered > Style > ... > Default
	// WICHTIG: Animationen überschreiben sogar lokale Werte temporär.
	// EINSATZZWECK: Zeigt, dass Animationen Vorrang vor allen anderen Wertquellen haben.
	public partial class Win3 : Window {
		// DispatcherTimer für periodische Precedence-Updates.
		DispatcherTimer _timer;
		
		// Konstruktor: Initialisiert Fenster und Timer.
		public Win3() {
			// Lädt XAML mit TextBlock und Storyboard-Animation.
			InitializeComponent();
			
			// Timer-Setup: 200ms-Intervall.
			_timer = new DispatcherTimer();
			_timer.Interval = new TimeSpan(0, 0, 0, 0, 200);
			
			// Timer Tick-Event registrieren.
			_timer.Tick += Timer_Tick;
			
			// Startet Timer für kontinuierliche Precedence-Überwachung.
			// ZWECK: Zeigt Wechsel zwischen "Animated" und "Default/Local" während Animation.
			_timer.Start();
		}
		
		// Timer Tick-Handler: Aktualisiert Precedence-Anzeige.
		void Timer_Tick(object? sender, EventArgs e) {
			// Zeigt Precedence-Quelle des AnimatedTextBlock.
			// ERWARTET: "Animated" während Animation läuft, sonst BaseValueSource.
			tbResult7.Text = GetPrecedence(AnimatedTextBlock);
			

		}

		// Hilfsmethode: Ermittelt Precedence-Quelle, berücksichtigt Animationen.
		// BESONDERHEIT: Prüft IsAnimated-Flag zusätzlich zu BaseValueSource.
		// WICHTIG: Animation-Status ist separate Information in ValueSource.
		private string GetPrecedence(TextBlock current) {
			// 'GetValueSource': Ermittelt Wertquelle für FontSizeProperty.
			// HINWEIS: Kein '.BaseValueSource' am Ende - wir brauchen das ganze ValueSource-Objekt.
			var source = DependencyPropertyHelper.GetValueSource(current as TextBlock,
																														TextBlock.FontSizeProperty);
			// 'IsAnimated': Prüft, ob die Property gerade animiert wird.
			// PRECEDENCE: Animation hat höchste Priorität, überschreibt alle anderen Quellen.
			if (source.IsAnimated)
			{
				// Gibt "Animated" zurück, wenn aktive Animation läuft.
				// BEDEUTUNG: Der angezeigte Wert kommt von der Storyboard-Animation.
				return "Animated";
			}
			// Keine Animation: Gibt normale BaseValueSource zurück.
			// MÖGLICHE WERTE: Local, Style, Default, etc.
			return source.BaseValueSource.ToString();
		}
		
		// Event-Handler für Animate-Button Click.
		// ZWECK: Startet die Storyboard-Animation, die FontSize animiert.
		// EFFEKT: Nach Start zeigt GetPrecedence() "Animated" an.
		private void AnimateButton_Click(object sender, RoutedEventArgs e) {
			// 'FindResource': Sucht Ressource im Resource-Dictionary des Fensters.
			// "Storyboard1": Der x:Key des Storyboards in XAML (Window.Resources).
			// 'as Storyboard': Sichere Typumwandlung, gibt null bei Fehler.
			// RESSOURCEN-LOOKUP: Sucht zuerst lokal, dann in Parent-Elementen, dann in App.xaml.
			Storyboard? sb = this.FindResource("Storyboard1") as Storyboard;

			// 'Begin()': Startet die Animation.
			// EFFEKT: Animiert die im Storyboard definierten Properties (z.B. FontSize).
			// PRECEDENCE-EFFEKT: Während Animation läuft, wird IsAnimated = true.
			// Nach Animation (ohne FillBehavior=HoldEnd) kehrt Value zur BaseValueSource zurück.
			sb.Begin();

		
		}

	
	}
}
