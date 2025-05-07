namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    
    
        protected override Window CreateWindow(IActivationState ActivationState)
        {

            var window = base.CreateWindow(ActivationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
            
     
     }//Fecha Classe

}//Fechar namespace
