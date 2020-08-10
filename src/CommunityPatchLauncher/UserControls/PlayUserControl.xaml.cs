﻿using CommunityPatchLauncher.ViewModels;
using System.Windows.Controls;

namespace CommunityPatchLauncher.UserControls
{
    /// <summary>
    /// Interaction logic for PlayUserControl.xaml
    /// </summary>
    public partial class PlayUserControl : UserControl
    {
        public PlayUserControl()
        {
            InitializeComponent();
            DataContext = new LaunchGameViewModel();
        }

        /// <summary>
        /// Unload event of this control
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The arguments of the event</param>
        private void UserControl_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (DataContext is BaseViewModel viewModel)
            {
                viewModel.Dispose();
            }
        }
    }
}
