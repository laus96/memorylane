namespace MemoryLane
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Initialize the main page within the window creation method to avoid using the deprecated MainPage property.  
            var window = new Window(new MemoryLane.Pages.MainLayout());
            return window;
        }
    }
}