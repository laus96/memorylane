using Microsoft.Maui.Controls;
using System;
using MemoryLane.Pages.Content;

namespace MemoryLane.Pages
{
    public partial class MainLayout : ContentPage
    {
        public MainLayout()
        {
            InitializeComponent();
            SidebarPanel.MenuSelected += OnMenuSelected;
            LoadPageFromModel("Home");
        }

        private void OnMenuSelected(object sender, string pageName)
        {
            LoadPageFromModel(pageName);
        }

        public void LoadPageFromModel(string pageName)
        {
            ContentView view = pageName switch
            {
                "Home" => new HomePage(),
                "Organize" => new OrganizerPage(),
                "Duplicates" => new DuplicatesPage(),
                "Profiles" => new ProfilesPage(),
                "Settings" => new SettingsPage(),
                _ => new ErrorPage(),
            };

            ContentArea.Content = view;
        }
    }
}