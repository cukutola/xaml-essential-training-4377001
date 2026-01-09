// Standard .NET Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// System.Windows: Kernnamespace für WPF.
using System.Windows;
// System.Windows.Controls: UI-Steuerelemente (TextBlock, etc.).
using System.Windows.Controls;
// System.Windows.Data: Data Binding-Funktionalität.
using System.Windows.Data;
// System.Windows.Documents: Rich-Text-Unterstützung.
using System.Windows.Documents;
// System.Windows.Input: Eingabeverarbeitung.
using System.Windows.Input;
// System.Windows.Media: 2D-Grafik, Brushes, Transforms.
using System.Windows.Media;
// System.Windows.Media.Imaging: Bildverarbeitung.
using System.Windows.Media.Imaging;
// System.Windows.Shapes: Vektorgrafikelemente.
using System.Windows.Shapes;
// System.Windows.Threading: Timer und Dispatcher.
using System.Windows.Threading;

// Namespace für die Precedence-Demo.
namespace Precedence {
	/// <summary>
	/// Interaction logic for Demo2Window.xaml
	/// </summary>
	// 'Win2': Zweites Fenster der Precedence-Demo-Serie.
	// ZWECK: Demonstriert Background-Property Precedence (anstatt FontWeight wie in Win1).
	// UNTERSCHIED zu Win1: Untersucht eine andere DependencyProperty (BackgroundProperty).
	// KONZEPT: Jede DP hat dieselbe Precedence-Hierarchie, unabhängig vom Property-Typ.
	public partial class Win2 : Window {
		// DispatcherTimer für periodische UI-Updates.
		// ZWECK: Zeigt Precedence-Änderungen in Echtzeit (z.B. durch Hover, Focus).
		DispatcherTimer _timer;
		
		// Konstruktor: Initialisiert Fenster und Timer.
		public Win2() {
			// Lädt XAML mit TextBlocks, die unterschiedliche Background-Quellen demonstrieren.
			InitializeComponent();
			
			// Erstellt Timer-Instanz.
			_timer = new DispatcherTimer();
			
			// Timer-Intervall: 200ms (5 Updates pro Sekunde).
			_timer.Interval = new TimeSpan(0, 0, 0, 0, 200);
			
			// Event-Handler registrieren (explizite EventHandler-Syntax).
			// ALTERNATIV: _timer.Tick += Timer_Tick; (implizit)
			_timer.Tick += new EventHandler(Timer_Tick);
			
			// Startet den Timer.
			_timer.Start();
		}
		
		// Timer Tick-Handler: Aktualisiert Precedence-Anzeigen.
		// 'void': Kein Rückgabewert (Event-Handler-Standard).
		// 'object? sender': Nullable sender (C# 8.0+ nullable reference types).
		void Timer_Tick(object? sender, EventArgs e) {
			// Aktualisiert Precedence-Info für tb4, tb5, tb6.
			// BACKGROUND-PROPERTY: Zeigt, woher die Background-Brush kommt (Local, Style, etc.).
			tbResult4.Text = GetPrecedence(tb4);
			tbResult5.Text = GetPrecedence(tb5);
			tbResult6.Text = GetPrecedence(tb6);

		}

		// Hilfsmethode: Ermittelt Precedence-Quelle für Background-Property.
		// UNTERSCHIED zu Win1: Untersucht BackgroundProperty statt FontWeightProperty.
		// ANWENDUNG: Zeigt, dass Precedence-System für alle DPs gleich funktioniert.
		private string GetPrecedence(TextBlock current) {
			// 'DependencyPropertyHelper.GetValueSource': Ermittelt Value-Source.
			// 'TextBlock.BackgroundProperty': Die zu untersuchende DP (Background-Brush).
			// MÖGLICHE QUELLEN: Local, Style, TemplateTrigger, ParentTemplate, Inherited, Default.
			var source = DependencyPropertyHelper.GetValueSource(current as TextBlock,
																														TextBlock.BackgroundProperty).BaseValueSource;
			// Konvertiert Enum zu String für UI-Anzeige.
			return source.ToString();
		}
	}
}
