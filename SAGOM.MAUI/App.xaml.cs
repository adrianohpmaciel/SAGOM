namespace SAGOM.MAUI
{
    public partial class App : IApplication
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}