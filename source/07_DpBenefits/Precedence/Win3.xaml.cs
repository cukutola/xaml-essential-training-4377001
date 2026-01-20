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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Precedence {
	/// <summary>
	/// Interaction logic for Demo3Window.xaml
	/// 
	/// PRECEDENCE DEMO 3: Animation Precedence
	/// - Demonstriert dass ANIMATED die höchste Priorität hat
	/// - Zeigt wie Animationen alle anderen Werte überschreiben
	/// 
	/// VALUE PRECEDENCE mit Animationen:
	/// 1. Animated (HÖCHSTE - während Animation aktiv ist)
	/// 2. Local
	/// 3. Triggered
	/// 4. Style
	/// 5. Default
	/// 6. Inherited
	/// 
	/// WICHTIG:
	/// - Animated überschreibt sogar LOCAL VALUES
	/// - Nach Ende der Animation fällt der Wert zurück zur nächsten Priorität
	/// - FillBehavior="Stop" entfernt Animation nach Ende
	/// - FillBehavior="HoldEnd" behält den End-Wert als Animated Value
	/// 
	/// DEBUGGING mit IsAnimated:
	/// - ValueSource.IsAnimated zeigt ob Property aktuell animiert wird
	/// - Kombiniert mit BaseValueSource für vollständige Information
	/// </summary>
	public partial class Win3 : Window {
		DispatcherTimer _timer;
		
		public Win3() {
			InitializeComponent();
			
			// Timer für Echtzeit-Überwachung des Animation-Status
			// Zeigt wie IsAnimated sich während der Animation ändert
			_timer = new DispatcherTimer();
			_timer.Interval = new TimeSpan(0, 0, 0, 0, 200); // 200ms Updates
			_timer.Tick += Timer_Tick;
			_timer.Start();
		}
		
		/// <summary>
		/// Aktualisiert die Anzeige der Value Source
		/// - Zeigt "Animated" während Animation läuft
		/// - Zeigt BaseValueSource wenn keine Animation aktiv ist
		/// </summary>
		void Timer_Tick(object? sender, EventArgs e) {
			tbResult7.Text = GetPrecedence(AnimatedTextBlock);
			

		}

		/// <summary>
		/// ERWEITERTER PRECEDENCE CHECK mit Animation-Support:
		/// - Prüft zuerst ob Property animiert wird (IsAnimated)
		/// - Falls nicht animiert, zeigt BaseValueSource
		/// 
		/// ISANIMATED Property:
		/// - True: Wert kommt von aktiver Animation (höchste Priorität)
		/// - False: Wert kommt von BaseValueSource
		/// 
		/// WICHTIG für FontSize:
		/// - Kann animiert werden (Double Property)
		/// - Animation überschreibt alle anderen Werte temporär
		/// - Nach Animation: Rückfall zu Local/Style/Default
		/// </summary>
		private string GetPrecedence(TextBlock current) {
			// GetValueSource gibt umfassende Information über die Wertquelle
			var source = DependencyPropertyHelper.GetValueSource(current as TextBlock,
																														TextBlock.FontSizeProperty);
			// Animation hat Vorrang vor allen anderen Quellen
			if (source.IsAnimated)
			{
				return "Animated";
			}
			return source.BaseValueSource.ToString();
		}
		
		/// <summary>
		/// Startet die Storyboard-Animation
		/// 
		/// ANIMATION und PRECEDENCE:
		/// - FindResource() holt das Storyboard aus den Resources
		/// - Begin() startet die Animation
		/// - Während der Animation: IsAnimated = true, höchste Priorität
		/// - Animation überschreibt Local, Style und alle anderen Werte
		/// 
		/// STORYBOARD-VERHALTEN:
		/// - Kann mehrere Properties gleichzeitig animieren
		/// - FillBehavior steuert Verhalten nach Ende der Animation
		/// - Resources nutzen Sparse Storage für effiziente Speicherverwaltung
		/// </summary>
		private void AnimateButton_Click(object sender, RoutedEventArgs e) {
			// Storyboard aus XAML Resources laden
			Storyboard? sb = this.FindResource("Storyboard1") as Storyboard;

			// Animation starten - Property erhält ANIMATED Precedence
			sb.Begin();

		
		}

	
	}
}
