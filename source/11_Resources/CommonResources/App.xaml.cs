using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CommonResources {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	/// <remarks>
	/// COMMON RESOURCES DEMONSTRATION - Styles, DataTemplates und ControlTemplates
	/// 
	/// Diese Anwendung demonstriert die Haupttypen von wiederverwendbaren Resources in WPF:
	/// - Styles für konsistente Control-Formatierung
	/// - DataTemplates für Custom Data Rendering
	/// - ControlTemplates für komplette Control-Neugestaltung
	/// 
	/// STYLES:
	/// - Definieren Eigenschaftswerte für einen Control-Typ
	/// - Ermöglichen konsistentes Aussehen über die gesamte Anwendung
	/// - Unterstützen Vererbung (BasedOn)
	/// - Können implizit (ohne x:Key) oder explizit sein
	/// 
	/// Style-Struktur:
	/// <Style x:Key="MyButtonStyle" TargetType="Button">
	///   <Setter Property="Background" Value="Blue"/>
	///   <Setter Property="Foreground" Value="White"/>
	///   <Setter Property="Padding" Value="10,5"/>
	/// </Style>
	/// 
	/// TARGETTYPE:
	/// - Gibt den Control-Typ an, für den der Style gilt
	/// - Ermöglicht Type-Safe Property-Setter
	/// - Bei impliziten Styles: Automatische Anwendung auf alle Controls dieses Typs
	/// 
	/// DATATEMPLATES:
	/// - Definieren das visuelle Erscheinungsbild von Daten-Objekten
	/// - Verwendet in ContentControl, ItemsControl, etc.
	/// - Ermöglichen Custom Rendering von Business Objects
	/// - Unterstützen Data Binding innerhalb des Templates
	/// 
	/// DataTemplate-Struktur:
	/// <DataTemplate x:Key="PersonTemplate" DataType="{x:Type local:Person}">
	///   <StackPanel>
	///     <TextBlock Text="{Binding Name}" FontWeight="Bold"/>
	///     <TextBlock Text="{Binding Email}"/>
	///   </StackPanel>
	/// </DataTemplate>
	/// 
	/// CONTROLTEMPLATES:
	/// - Definieren die komplette visuelle Struktur eines Controls
	/// - Ersetzen das Standard-Aussehen komplett
	/// - Beinhalten TemplateBinding für Control-Properties
	/// - Ermöglichen völlig neue Control-Designs
	/// 
	/// ControlTemplate-Struktur:
	/// <ControlTemplate TargetType="Button">
	///   <Border Background="{TemplateBinding Background}">
	///     <ContentPresenter HorizontalAlignment="Center"/>
	///   </Border>
	/// </ControlTemplate>
	/// 
	/// SETTERS IN STYLES:
	/// - Setzen Properties auf spezifische Werte
	/// - Syntax: <Setter Property="PropertyName" Value="PropertyValue"/>
	/// - Können komplexe Werte verwenden (Brushes, Templates, etc.)
	/// - Werden auf alle Controls angewendet, die den Style verwenden
	/// 
	/// VERWENDUNG IN DIESER DEMO:
	/// Verschiedene Windows demonstrieren jeweils einen Aspekt:
	/// - ColorWindow: Einfache Color/Brush Resources
	/// - StyleWindow: Style-Definition und Anwendung
	/// - DataWindow: Daten-Objekte mit Standard-Rendering
	/// - DataTemplateWindow: Custom DataTemplate für Daten-Objekte
	/// </remarks>
	public partial class App : Application {
	}
}
