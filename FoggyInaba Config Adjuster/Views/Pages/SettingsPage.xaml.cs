﻿using FoggyInaba_Config_Adjuster.ViewModels.Pages;
using FoggyInaba_Config_Adjuster.Views.Windows;
using System.Windows;
using Wpf.Ui.Controls;

namespace FoggyInaba_Config_Adjuster.Views.Pages
{
    public partial class SettingsPage : INavigableView<SettingsViewModel>
    {
        public SettingsViewModel ViewModel { get; }

        public SettingsPage(SettingsViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;
            InitializeComponent();
        }
    }
}
