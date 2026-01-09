// 'using': Importiert grundlegende .NET-Namespaces.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 'namespace': Definiert den Namensraum für Farb-Hilfsklassen.
namespace ColorLib
{
	// 'public': Macht die Klasse für andere Assemblies verwendbar.
	// ZWECK: Stellt eine Farbe im HSL-Farbraum (Hue, Saturation, Lightness) dar.
	// VORTEIL: HSL ist intuitiver für Farbmanipulationen als RGB.
	// - Hue (Farbton): 0-360 Grad auf dem Farbkreis
	// - Saturation (Sättigung): 0-1, wie intensiv die Farbe ist
	// - Lightness (Helligkeit): 0-1, wie hell/dunkel die Farbe ist
	// - Alpha (Transparenz): 0-1, Deckkraft
	public class HslColor {
		
		// 'readonly': Die Felder können nur im Konstruktor gesetzt werden.
		// ZWECK: Macht die Klasse immutable (unveränderlich) - sicherer und thread-safe.
		// 'public': Ermöglicht direkten Lesezugriff auf die Werte.
		public readonly double h, s, l, a;

		// KONSTRUKTOR 1: Erstellt eine HSL-Farbe aus direkten HSL-Werten.
		// PARAMETER:
		// - 'h': Hue (Farbton) 0-360 Grad
		// - 's': Saturation (Sättigung) 0-1
		// - 'l': Lightness (Helligkeit) 0-1
		// - 'a': Alpha (Transparenz) 0-1
		public HslColor(double h, double s, double l, double a) {
			// 'this.h': Bezieht sich auf das readonly Feld der Klasse.
			// Weist die Parameter-Werte den Feldern zu.
			this.h = h;
			this.s = s;
			this.l = l;
			this.a = a;
		}

		// KONSTRUKTOR 2: Konvertiert eine WPF RGB-Farbe in HSL.
		// PARAMETER: 'rgbColor' - Eine System.Windows.Media.Color (ARGB-Format).
		// VERWENDUNG: Ermöglicht die Konvertierung von WPF-Farben zu HSL für Manipulationen.
		public HslColor(System.Windows.Media.Color rgbColor) {
			// 'RgbToHls': Statische Hilfsmethode für die RGB→HSL-Konvertierung.
			// 'out h, out l, out s': Die readonly Felder werden direkt als out-Parameter übergeben.
			// WICHTIG: Dies ist nur im Konstruktor erlaubt, da readonly Felder dort noch nicht initialisiert sind.
			RgbToHls(rgbColor.R, rgbColor.G, rgbColor.B, out h, out l, out s);
			// 'rgbColor.A': Alpha-Kanal (0-255), wird zu 0-1 normalisiert.
			a = rgbColor.A / 255.0;
		}

		// METHODE: Konvertiert die HSL-Farbe zurück zu WPF RGB.
		// RÜCKGABE: System.Windows.Media.Color im ARGB-Format.
		// VERWENDUNG: Nach HSL-Manipulationen wird die Farbe für WPF zurückkonvertiert.
		public System.Windows.Media.Color ToRgb() {
			// 'out'-Parameter: Die RGB-Werte werden in diese Variablen geschrieben.
			int r, g, b;
			// 'HlsToRgb': Statische Hilfsmethode für die HSL→RGB-Konvertierung.
			HlsToRgb(h, l, s, out r, out g, out b);
			// 'Color.FromArgb': Erstellt eine WPF-Color aus ARGB-Komponenten.
			// '(byte)(a * 255.0)': Konvertiert Alpha von 0-1 zu 0-255.
			// '(byte)r': Castet die int-Werte zu byte (0-255).
			return System.Windows.Media.Color.FromArgb((byte)(a * 255.0), (byte)r, (byte)g, (byte)b);
		}

		// METHODE: Erstellt eine hellere Version dieser Farbe.
		// PARAMETER: 'amount' - Wie viel heller (z.B. 0.3 = 30% heller).
		// RÜCKGABE: Eine neue HslColor-Instanz (die Original-Farbe bleibt unverändert).
		// ALGORITHMUS: Erhöht die Lightness (l) um den angegebenen Prozentsatz.
		public HslColor Lighten(double amount) {
			// 'l * (1 + amount)': Wenn l=0.5 und amount=0.3 → 0.5 * 1.3 = 0.65
			// 'Clamp(..., 0, 1)': Stellt sicher, dass der Wert im gültigen Bereich 0-1 bleibt.
			// 'new HslColor(...)': Erstellt eine neue Instanz mit derselben Hue/Saturation/Alpha.
			return new HslColor(h, s, Clamp(l * (1 + amount), 0, 1), a);
		}
		
		// METHODE: Erstellt eine dunklere Version dieser Farbe.
		// PARAMETER: 'amount' - Wie viel dunkler (z.B. 0.2 = 20% dunkler).
		// ALGORITHMUS: Reduziert die Lightness (l) um den angegebenen Prozentsatz.
		public HslColor Darken(double amount) {
			// 'l * (1 - amount)': Wenn l=0.5 und amount=0.2 → 0.5 * 0.8 = 0.4
			return new HslColor(h, s, Clamp(l * (1- amount), 0, 1), a);
		}

		// HILFSMETHODE: Begrenzt einen Wert auf einen Min/Max-Bereich.
		// 'static': Keine Instanz erforderlich, da sie nicht auf Instanz-Felder zugreift.
		// 'private': Nur innerhalb dieser Klasse verwendbar.
		// ZWECK: Verhindert ungültige Werte außerhalb des 0-1 Bereichs.
		private static double Clamp(double value, double min, double max) {
			// Wenn der Wert zu klein ist, gib 'min' zurück.
			if (value < min)
				return min;
			// Wenn der Wert zu groß ist, gib 'max' zurück.
			if (value > max)
				return max;

			// Sonst gib den ursprünglichen Wert zurück.
			return value;
		}

		// KONVERTIERUNGSMETHODE: RGB → HSL
		// 'static void': Statische Methode ohne Rückgabewert (verwendet out-Parameter stattdessen).
		// PARAMETER:
		// - 'r, g, b': RGB-Werte (0-255)
		// - 'out h, out l, out s': HSL-Werte werden hier ausgegeben (h: 0-360, l/s: 0-1)
		// ALGORITHMUS: Standard-RGB-zu-HSL-Konvertierung aus der Farbtheorie.
		static void RgbToHls(int r, int g, int b,
				out double h, out double l, out double s) {
			// SCHRITT 1: RGB-Werte in den Bereich 0.0 bis 1.0 konvertieren.
			double double_r = r / 255.0;
			double double_g = g / 255.0;
			double double_b = b / 255.0;

			// SCHRITT 2: Maximum und Minimum der RGB-Komponenten finden.
			// 'max': Die hellste Farbkomponente.
			double max = double_r;
			if (max < double_g) max = double_g;
			if (max < double_b) max = double_b;

			// 'min': Die dunkelste Farbkomponente.
			double min = double_r;
			if (min > double_g) min = double_g;
			if (min > double_b) min = double_b;

			// 'diff': Der Unterschied zwischen hellster und dunkelster Komponente.
			// Wird für Sättigung und Farbton-Berechnungen benötigt.
			double diff = max - min;
			
			// SCHRITT 3: Lightness (Helligkeit) berechnen.
			// 'l': Durchschnitt von max und min.
			l = (max + min) / 2;
			
			// SCHRITT 4: Sättigung und Farbton berechnen.
			// 'Math.Abs(diff) < 0.00001': Prüft, ob diff praktisch null ist (Graustufe).
			if (Math.Abs(diff) < 0.00001)
			{
				// Keine Farbsättigung → Graustufe (Schwarz/Grau/Weiß).
				s = 0;
				h = 0;  // H ist wirklich undefiniert bei Graustufen, wir setzen ihn auf 0.
			}
			else
			{
				// Sättigung berechnen (abhängig von Lightness).
				// Bei dunklen/hellen Farben (l ≤ 0.5) andere Formel als bei mittleren.
				if (l <= 0.5) s = diff / (max + min);
				else s = diff / (2 - max - min);

				// Farbton (Hue) berechnen basierend auf der dominanten Farbe.
				// 'r_dist, g_dist, b_dist': Relative Abstände jeder Komponente vom Maximum.
				double r_dist = (max - double_r) / diff;
				double g_dist = (max - double_g) / diff;
				double b_dist = (max - double_b) / diff;

				// Berechne Hue basierend darauf, welche RGB-Komponente maximal ist.
				// Rot dominant: Hue zwischen Magenta und Gelb (0-60° oder 300-360°).
				if (double_r == max) h = b_dist - g_dist;
				// Grün dominant: Hue zwischen Gelb und Cyan (60-180°).
				else if (double_g == max) h = 2 + r_dist - b_dist;
				// Blau dominant: Hue zwischen Cyan und Magenta (180-300°).
				else h = 4 + g_dist - r_dist;

				// Konvertiere zu Grad (0-360).
				h = h * 60;
				// Stelle sicher, dass h nicht negativ ist.
				if (h < 0) h += 360;
			}
		}

		// KONVERTIERUNGSMETHODE: HSL → RGB
		// 'static void': Statische Methode ohne Rückgabewert (verwendet out-Parameter).
		// PARAMETER:
		// - 'h, l, s': HSL-Werte (h: 0-360, l/s: 0-1)
		// - 'out r, out g, out b': RGB-Werte werden hier ausgegeben (0-255)
		// ALGORITHMUS: Standard-HSL-zu-RGB-Konvertierung.
		static void HlsToRgb(double h, double l, double s,
				out int r, out int g, out int b) {
			// SCHRITT 1: Hilfsgrößen p1 und p2 berechnen.
			// Diese Werte werden für die RGB-Berechnung benötigt.
			double p2;
			if (l <= 0.5) p2 = l * (1 + s);
			else p2 = l + s - l * s;

			double p1 = 2 * l - p2;
			
			double double_r, double_g, double_b;
			
			// SCHRITT 2: Spezialfall für Graustufen (s == 0).
			if (s == 0)
			{
				// Keine Sättigung → alle RGB-Komponenten sind gleich (Graustufe).
				double_r = l;
				double_g = l;
				double_b = l;
			}
			else
			{
				// SCHRITT 3: Berechne RGB-Komponenten aus HSL.
				// Jede Komponente wird mit einem verschobenen Hue-Wert berechnet.
				// Rot: h + 120° (ein Drittel des Farbkreises verschoben).
				double_r = QqhToRgb(p1, p2, h + 120);
				// Grün: h (keine Verschiebung).
				double_g = QqhToRgb(p1, p2, h);
				// Blau: h - 120° (ein Drittel in die andere Richtung).
				double_b = QqhToRgb(p1, p2, h - 120);
			}

			// SCHRITT 4: Konvertiere RGB-Werte in den Bereich 0 bis 255.
			r = (int)(double_r * 255.0);
			g = (int)(double_g * 255.0);
			b = (int)(double_b * 255.0);
		}

		// HILFSMETHODE: Berechnet eine einzelne RGB-Komponente aus HSL.
		// 'private static': Nur innerhalb dieser Klasse verwendbar, keine Instanz erforderlich.
		// PARAMETER:
		// - 'q1, q2': Hilfswerte aus HlsToRgb
		// - 'hue': Der Farbton (mit Verschiebung für R/G/B-Komponenten)
		// RÜCKGABE: RGB-Komponente im Bereich 0-1.
		// ALGORITHMUS: Stückweise lineare Funktion basierend auf Hue-Bereichen.
		private static double QqhToRgb(double q1, double q2, double hue) {
			// Normalisiere Hue in den Bereich 0-360.
			if (hue > 360) hue -= 360;
			else if (hue < 0) hue += 360;

			// Berechne RGB-Wert basierend auf dem Hue-Bereich.
			// 0-60°: Linearer Anstieg von q1 zu q2.
			if (hue < 60) return q1 + (q2 - q1) * hue / 60;
			// 60-180°: Plateau bei q2 (volle Intensität).
			if (hue < 180) return q2;
			// 180-240°: Linearer Abstieg von q2 zu q1.
			if (hue < 240) return q1 + (q2 - q1) * (240 - hue) / 60;
			// 240-360°: Plateau bei q1 (minimale Intensität).
			return q1;
		}
	}
}
