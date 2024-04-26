namespace gguachaminExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        Dictionary<string, string> Credenciales = new Dictionary<string, string>();
        Credenciales.Add("estudiante2024", "uisrael2024");
        Credenciales.Add("examen1", "parcial1");

        string usuario = TxtUsuario.Text;
        string clave = TxtContrasena.Text;
        try
        {
            if (clave == Credenciales[usuario])
            {
                Navigation.PushAsync(new Vistas.RegistroEstudiantes(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
                TxtContrasena.Text = "";
                TxtUsuario.Text = "";
            }
        }
        catch 
        {
            DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
            TxtContrasena.Text = "";
            TxtUsuario.Text = "";
        }
        
    }
}