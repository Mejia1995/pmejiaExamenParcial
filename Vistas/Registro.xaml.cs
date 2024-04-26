namespace pmejiaExamenParcial.Vistas;

public partial class Registro : ContentPage
{

    public Registro(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido : " + usuario, "cerrar");
        LblUsuario.Text = "Usuario conectado : " + usuario;



    }

    private void btnCalcularPago_Clicked(object sender, EventArgs e)
    {
        
        double montoinicio = Convert.ToDouble(txtMontoInicial.Text);
        double cuota;
        cuota = (1500 - montoinicio) / 4 + 4 % 1500;
        txtPagoMensual.Text = cuota.ToString();
        //double total = (4 * cuota) + montoinicio;
     
    }

    private void btnResumen_Clicked(object sender, EventArgs e)

    {
        string q = LblUsuario.Text;
        string nombre = txtNombre.Text; 
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = dpFecha.Date.ToString("MM/dd/yyyy");
        string ciudad = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
        string pais = pkPaises.Items[pkPaises.SelectedIndex].ToString();
        string montoinicial = txtMontoInicial.Text;
        string pagomensual = txtPagoMensual.Text;
    
        Navigation.PushAsync(new Resumen(q,nombre,apellido,edad,fecha,ciudad,pais,montoinicial,pagomensual));
        
    }
}