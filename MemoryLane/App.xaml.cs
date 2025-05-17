using MemoryLane.Pages;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MemoryLane
{
    public partial class App : Application
    {
        //this method uses IServideProvider as a parameter to get the MainPage
        //to avoid a problem that happens when you use StaticResource. 
        //the problem is Colors.xaml is not loaded yet when the MainPage is created
        //so you can not access the resources. 
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            var systemTheme = RequestedTheme;
            SetThemeColors(systemTheme);

            RequestedThemeChanged += (s, e) =>
            {
                SetThemeColors(e.RequestedTheme);
            };

            // This line uses DI to retrieve your main page
            MainPage = serviceProvider.GetRequiredService<MainLayout>();
        }
        private void SetThemeColors(AppTheme theme)
        {

            if (theme == AppTheme.Dark)
            {
                Resources["AppBackgroundColor"] = Color.FromArgb("#1B1D2A");
                Resources["SideBarColor"] = Color.FromArgb("#0D0D0D");
                Resources["SideBarColorHover"] = Color.FromArgb("010101");
                Resources["AppTextColor"] = Color.FromArgb("#E7E5EB");
                Resources["SidebarTextColor"] = Color.FromArgb("#CBD5E0");
            }
            else
            {
                Resources["AppBackgroundColor"] = Color.FromArgb("#F8F9FB");
                Resources["SideBarColor"] = Color.FromArgb("#2A2D43");
                Resources["SideBarColorHover"] = Color.FromArgb("#1A1D2F");
                Resources["AppTextColor"] = Color.FromArgb("#E7E5EB");
                Resources["SidebarTextColor"] = Color.FromArgb("#212121");
            }
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    // Initialize the main page within the window creation method to avoid using the deprecated MainPage property.  
        //    var window = new Window(new MemoryLane.Pages.MainLayout());
       //     return window;
       // }
    }
}