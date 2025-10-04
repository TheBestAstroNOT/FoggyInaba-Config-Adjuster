// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using CommunityToolkit.Mvvm.ComponentModel;
using FoggyInaba_Config_Adjuster.Views.Pages;
using System.Collections.ObjectModel;
using Wpf.Ui.Controls;
using FoggyInabaConfig.Localisation.LocalisationResources;

namespace FoggyInaba_Config_Adjuster.ViewModels.Windows;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
	private string _applicationTitle = "P4 Fog Restoration Config";

	[ObservableProperty]
	private ObservableCollection<object> _footerMenuItems = new()
	{
		new NavigationViewItem()
		{
			Content = Resources.Settings,
			Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
			TargetPageType = typeof(Views.Pages.SettingsPage),
            ToolTip = Resources.Settings
        }
	};

	[ObservableProperty]
	private ObservableCollection<MenuItem> _trayMenuItems = new()
	{
		new MenuItem { Header = "Home", Tag = "tray_home" }
    };

    public NavigationViewItem[] MenuItems { get; } =
    [/*
        new NavigationViewItem()
        {
            Content = Resources.Home,
            Icon = new SymbolIcon { Symbol = SymbolRegular.Home16 },
            TargetPageType = typeof(Views.Pages.Categories.Category_Main),
            ToolTip = Resources.Home
        },*/
        new NavigationViewItem()
        {
            Content = "Textures",
            Icon = new SymbolIcon { Symbol = SymbolRegular.PaintBrush16 },
            TargetPageType = typeof(Views.Pages.Categories.Category_Textures),
            ToolTip = "Textures"
        },
        new NavigationViewItem()
        {
            Content = "Inaba",
            Icon = new SymbolIcon { Symbol = SymbolRegular.BuildingTownhouse20 },
            TargetPageType = typeof(Views.Pages.Categories.Category_ENVINABA),
            ToolTip = "ENV - Inaba",

        },
        new NavigationViewItem()
        {
            Content = "TV Wor..",
            Icon = new SymbolIcon { Symbol = SymbolRegular.Tv16 },
			TargetPageType = typeof(Views.Pages.Categories.Category_ENVTV),
            ToolTip = "ENV - TV World"
        },
        new NavigationViewItem()
        {
            Content = "Field..",
            Icon = new SymbolIcon { Symbol = SymbolRegular.Cube16 },
            TargetPageType = typeof(Views.Pages.Categories.Category_Field),
            ToolTip = "Field Imports and Models"
        }
    ];
}
