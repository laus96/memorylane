using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using MemoryLane.Pages;

namespace MemoryLane.PageModels
{
    public partial class MainLayoutPageModel : ObservableObject
    {
        private readonly MainLayout _mainLayout;

        public MainLayoutPageModel(MainLayout layout)
        {
            _mainLayout = layout;
        }

        [RelayCommand]
        public Task Navigate(string pageName)
        {
            _mainLayout.LoadPageFromModel(pageName);
            return Task.CompletedTask;
        }
    }
}