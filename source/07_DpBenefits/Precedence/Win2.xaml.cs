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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Precedence {
	/// <summary>
	/// Interaction logic for Demo2Window.xaml
	/// 
	/// PRECEDENCE DEMO 2: Style vs. Trigger vs. Local Values
	/// - Demonstriert die Value Precedence Hierarchie bei Background Property
	/// - Nutzt DependencyPropertyHelper.GetValueSource() für Debugging
	/// 
	/// VALUE PRECEDENCE SYSTEM (Priorität von hoch zu niedrig):
	/// 1. Animated (höchste Priorität während Animation läuft)
	/// 2. Local (direkte Zuweisung in XAML oder Code)
	/// 3. Triggered (durch Property/Event/Data Triggers)
	/// 4. Style (Style Setter)
	/// 5. Default (aus Dependency Property Metadata)
	/// 6. Inherited (von Parent-Element im Visual Tree)
	/// 
	/// BASEVALUESOURCE für Debugging:
	/// - Zeigt die Quelle des aktuellen Werts an
	/// - Hilft bei der Diagnose von unerwarteten Werten
	/// - Wichtig für das Verständnis der Wertpriorität
	/// </summary>
	public partial class Win2 : Window {
		DispatcherTimer _timer;
		
		public Win2() {
			InitializeComponent();
			
			// Timer für kontinuierliche Aktualisierung der BaseValueSource Anzeige
			// Zeigt in Echtzeit wie sich die Wertquelle durch User-Interaktionen ändert
			_timer = new DispatcherTimer();
			_timer.Interval = new TimeSpan(0, 0, 0, 0, 200); // 200ms Intervall
			_timer.Tick += new EventHandler(Timer_Tick);
			_timer.Start();
		}
		
		/// <summary>
		/// Aktualisiert die Anzeige der BaseValueSource für alle TextBlocks
		/// - Ermöglicht Echtzeit-Beobachtung der Value Precedence
		/// - Zeigt wie Triggers, Styles und Local Values interagieren
		/// </summary>
		void Timer_Tick(object? sender, EventArgs e) {
			tbResult4.Text = GetPrecedence(tb4);
			tbResult5.Text = GetPrecedence(tb5);
			tbResult6.Text = GetPrecedence(tb6);

		}

		/// <summary>
		/// DEPENDENCY PROPERTY HELPER - Debugging-Tool:
		/// - GetValueSource() gibt Information über die Quelle des aktuellen Werts
		/// - BaseValueSource zeigt: Default, Style, Local, Inherited, etc.
		/// - Unverzichtbar für das Debugging von komplexen Style-Hierarchien
		/// 
		/// WICHTIGE BASEVALUESOURCE WERTE:
		/// - Default: Wert aus PropertyMetadata.DefaultValue
		/// - Style: Wert aus Style Setter
		/// - Local: Direkt gesetzt via SetValue() oder XAML
		/// - ParentTemplate: Von ControlTemplate
		/// - Inherited: Von Parent-Element (z.B. FontSize)
		/// 
		/// PERFORMANCE-HINWEIS:
		/// - GetValueSource hat minimalen Overhead
		/// - Nur für Debugging verwenden, nicht in produktivem Code
		/// </summary>
		private string GetPrecedence(TextBlock current) {
			// Ermittelt die BaseValueSource für die Background Property
			// Dies zeigt welche Prioritätsstufe den aktuellen Wert liefert
			var source = DependencyPropertyHelper.GetValueSource(current as TextBlock,
																														TextBlock.BackgroundProperty).BaseValueSource;
			return source.ToString();
		}
	}
}
