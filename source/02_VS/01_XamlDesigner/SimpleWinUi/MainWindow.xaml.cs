// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

// Microsoft.UI.Xaml: Kernelement des WinUI 3 Frameworks
using Microsoft.UI.Xaml;
// Microsoft.UI.Xaml.Controls: Alle Standard-UI-Steuerelemente (Button, TextBox, Grid, etc.)
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
// Microsoft.UI.Xaml.Data: Datenbindung zwischen UI und Datenmodellen
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
// Standard .NET Namespaces
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SimpleWinUi {
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	// 'public': Macht das Fenster für andere Teile der Anwendung zugänglich, z.B. für die 
	// Erstellung in App.xaml.cs.
	// 'sealed': Verhindert Vererbung von dieser Klasse. Dies ist eine Performance-Optimierung 
	// in WinUI 3, da das Framework keine virtuellen Methodenaufrufe mehr prüfen muss.
	// 'partial': Teilt die Klassendefinition auf. Der XAML-Compiler generiert automatisch den 
	// anderen Teil dieser Klasse aus MainWindow.xaml, der alle UI-Elemente (Buttons, Grids, etc.) 
	// als Felder enthält und deren Initialisierung durchführt.
	// ': Window': Basisklasse für Top-Level-Fenster in WinUI 3. Im Gegensatz zu UWP können 
	// WinUI 3 Desktop-Apps mehrere unabhängige Fenster haben (MDI-Pattern möglich).
	public sealed partial class MainWindow : Window {
		// Konstruktor: Wird aufgerufen, wenn das Fenster erstellt wird (in App.OnLaunched).
		public MainWindow() {
			// 'InitializeComponent()': KRITISCH! Diese vom XAML-Compiler generierte Methode:
			// 1. Lädt und parst die MainWindow.xaml-Datei
			// 2. Erstellt alle in XAML definierten UI-Elemente (Buttons, TextBoxes, Layouts)
			// 3. Setzt Properties basierend auf XAML-Attributen (Farben, Größen, Text, etc.)
			// 4. Verbindet Event-Handler (z.B. Click-Events) mit den hier definierten Methoden
			// 5. Verknüpft benannte Elemente (x:Name="myButton") mit Feldern in dieser Klasse
			// Ohne diesen Aufruf wäre das Fenster leer und alle x:Name-Referenzen wären null!
			this.InitializeComponent();
		}

		// Event-Handler für den Button-Click.
		// 'private void': Methode ist nur innerhalb dieser Klasse sichtbar und gibt nichts zurück.
		// 'object sender': Das UI-Element, das den Event ausgelöst hat (in diesem Fall der Button).
		// 'RoutedEventArgs e': Event-Argumente, die zusätzliche Informationen über den Event enthalten.
		// WPF/WinUI verwenden 'Routed Events', die durch den visuellen Baum "bubbling" können.
		private void myButton_Click(object sender, RoutedEventArgs e) {
			// Ändert den Inhalt (Text) des Buttons nach dem Klick.
			// 'myButton': Automatisch generiertes Feld durch x:Name="myButton" im XAML.
			// 'Content': Property des Button-Controls, das den angezeigten Inhalt definiert.
			// Dies kann Text, ein Bild oder sogar komplexe XAML-Strukturen sein.
			myButton.Content = "Clicked";
		}
	}
}
