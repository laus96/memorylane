using Microsoft.Maui.Controls;
using System;

namespace MemoryLane.Pages.Content
{
    public partial class Sidebar : ContentView
    {
        public event EventHandler<string> MenuSelected;

        public Sidebar()
        {
            InitializeComponent();
        }

        private void OnNavigateClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is string pageName)
            {
                MenuSelected?.Invoke(this, pageName);
            }
        }
    }
}
