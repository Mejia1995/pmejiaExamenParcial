namespace pmejiaExamenParcial.Vistas;

public partial class Resumen : ContentPage
{
    
	public Resumen(string usuario, string nombre, string apellido, string edad, string fecha ,string ciudad, string pais, string montoInicial, string pagomensual)
	{
		InitializeComponent();

        lblusuario.Text = usuario;
        LblNombre.Text = nombre;
        Lblapellido.Text = apellido;
        Lbledad.Text = edad; 
        Lblfecha.Text = fecha;
        Lblciudad.Text = ciudad;    
        Lblpais.Text = pais;
        Lblmontoinicial.Text = montoInicial;    
        Lblpagomensual.Text = pagomensual;  
        //Lblpagototal.Text = pagototal;
    }

    private void btrREGRESAR_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage1());

    }
}