namespace pmejiaExamenParcial.Vistas;

public partial class NewPage1 : ContentPage
{
    private string[,] credenciales = new string[,]
       {
            {"estudiante2024 ", "uisrael2024"},
            {"examen1" , "parcial1"},
            {"pedro", "2024"}
            
       };
    public NewPage1()
    {
        InitializeComponent();
    }

    private bool EsCredencialValida(string usuario, string contraseña)
    {
        // Verificar si las credenciales coinciden con alguna entrada en la matriz
        for (int i = 0; i < credenciales.GetLength(0); i++)
        {
            if (credenciales[i, 0] == usuario && credenciales[i, 1] == contraseña)
            {
                return true;
            }
        }
        return false; // Si no se encuentra ninguna coincidencia
    }

    private void btnIngresar_Clicked(object sender, EventArgs e)

    {
        string usuario = txtusuario.Text;
        string contraseña = txtcontraseña.Text;

        if (EsCredencialValida(usuario, contraseña))
        {

            Navigation.PushAsync(new Registro(usuario));

        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña Incorrecto", "Cerrar");
        }
       

    }

    private  void btnAcercade_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vAcercade());

    }
}