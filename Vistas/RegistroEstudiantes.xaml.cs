namespace gguachaminExamen.Vistas;
public partial class RegistroEstudiantes : ContentPage
{
    const double valorBase = 1500.00;
    const double costoExtra = valorBase * 0.04;
    double cuotaMensual = 0.00;
    string usuarioConectado;
    public RegistroEstudiantes(string usuario)
	{
		InitializeComponent();
        lblUsuarioConectado.Text = "Usuario conectado: " + usuario;
        usuarioConectado = usuario;
    }

    private void btnCalcularPagoMensual_Clicked(object sender, EventArgs e)
    {
        double montoInicial = Convert.ToDouble(TxtMontoInicial.Text);
        if (montoInicial > 0)
        {
            double cuotaMensualSinExtra = ((valorBase - montoInicial) / 4);
            cuotaMensual = cuotaMensualSinExtra + costoExtra;
            TxtPagoMensual.Text = cuotaMensual.ToString();
        }
    }

    private void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        if (pkCiudades.SelectedIndex == -1 || pkPaises.SelectedIndex == -1)
        {
            DisplayAlert("Alerta de Validación", "Seleccione un país o ciudad!", "Cerrar");
        }
        else
        {
            string nombreEstudiante = TxtNombre.Text;
            string apellidoEstudiante = TxtApellido.Text;
            int edadEstudiante = Convert.ToInt32(TxtEdad.Text);
            DateTime fechaPagoEstudiante = dpFecha.Date;
            string paisEstudiante = pkPaises.SelectedItem.ToString();
            string ciudadEstudiante = pkCiudades.SelectedItem.ToString();
            double montoInicialEstudiante = Convert.ToDouble(TxtMontoInicial.Text);
            double pagoMensualEstudiante = Convert.ToDouble(TxtPagoMensual.Text);
            Navigation.PushAsync(new Resumen(usuarioConectado, nombreEstudiante, apellidoEstudiante, edadEstudiante, fechaPagoEstudiante, paisEstudiante, ciudadEstudiante, montoInicialEstudiante, pagoMensualEstudiante));
        }
    }
}