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

namespace PackUri {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// <remarks>
	/// HAUPTFENSTER - Pack URI Demonstration
	/// 
	/// Dieses Fenster demonstriert die praktische Verwendung von Pack URIs für den
	/// Zugriff auf verschiedene Arten von Ressourcen in WPF-Anwendungen.
	/// 
	/// PACK URI VERWENDUNG IM XAML:
	/// Die eigentliche Demonstration erfolgt im XAML-Code, wo Pack URIs verwendet werden für:
	/// 
	/// 1. RESOURCE DICTIONARY REFERENZEN:
	///    - <ResourceDictionary Source="pack://application:,,,/ResourceDictionary.xaml"/>
	///    - Lädt externe ResourceDictionaries zur Laufzeit
	///    - Ermöglicht Modularisierung von Styles und Templates
	/// 
	/// 2. BILDRESSOURCEN:
	///    - <Image Source="pack://application:,,,/Images/MyImage.png"/>
	///    - Zugriff auf eingebettete Bilddateien
	///    - Build Action muss auf "Resource" gesetzt sein
	/// 
	/// 3. ASSEMBLY-ÜBERGREIFENDE RESSOURCEN:
	///    - pack://application:,,,/MyLibrary;component/Styles/Buttons.xaml
	///    - Zugriff auf Ressourcen in referenzierten Assemblies
	///    - ";component" kennzeichnet externe Assembly-Ressourcen
	/// 
	/// WICHTIGE HINWEISE:
	/// - Pack URIs werden zur Compile-Zeit aufgelöst
	/// - Fehlerhafte URIs führen zu Runtime-Exceptions
	/// - Ressourcen müssen mit korrekter Build Action markiert sein
	/// - Alternative: Relative URIs (z.B. "/Ordner/Datei.xaml") für lokale Ressourcen
	/// </remarks>
	public partial class MainWindow : Window {
		public MainWindow() {
			// InitializeComponent() lädt und parst die XAML-Datei
			// Dabei werden alle Pack URIs im XAML aufgelöst und die Ressourcen geladen
			InitializeComponent();
		}
	}
}
