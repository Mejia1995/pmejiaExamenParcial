namespace pmejiaExamenParcial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.NewPage1());// se creo con NewPage1 la primera vista pero le cambien el nombre a login pero sigue saliendo NewPage1
        }
    }
}
