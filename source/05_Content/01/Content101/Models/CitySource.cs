// 'using': Importiert grundlegende .NET-Namespaces.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // Für ObservableCollection
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 'namespace': Definiert den Namensraum für Datenmodelle.
namespace BigStar.Models{
	// 'public': Macht die Klasse für XAML und andere Assemblies verfügbar.
	// ZWECK: Stellt eine Datenquelle für Städtenamen bereit.
	// VERWENDUNG: Wird als ItemsSource für ListBox/ComboBox verwendet.
	public class CitySource {

		// 'private': Das private Backing-Field für die Städte-Collection.
		// 'ObservableCollection<string>': WICHTIG! Benachrichtigt UI automatisch bei Änderungen.
		// HINTERGRUND: ObservableCollection implementiert INotifyCollectionChanged.
		// Wenn Items hinzugefügt/entfernt werden, wird das UI automatisch aktualisiert.
		// UNTERSCHIED zu List<T>: List<T> würde UI nicht bei Änderungen benachrichtigen.
		private ObservableCollection<string> _cities;
		
		// KONSTRUKTOR: Initialisiert die Städte-Collection.
		public CitySource() {
			// 'new ObservableCollection<string> { ... }': Collection-Initialisierer-Syntax.
			// Erstellt die Collection und fügt sofort die Anfangswerte hinzu.
			_cities = new ObservableCollection<string> { "Barcelona", "São Paulo", "Singapore", "Bangkok" };
		}
		
		// PUBLIC PROPERTY: Gibt die Städte-Collection zurück.
		// 'get-only': Nur lesbar von außen (die Collection selbst kann aber modifiziert werden).
		// VERWENDUNG IN XAML: ItemsSource="{Binding Cities}"
		public ObservableCollection<string> Cities
		{
			get
			{
				return _cities;
			}
		}

	}
}
