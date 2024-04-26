namespace gguachaminExamen.Vistas;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario, string nombre, string apellido, int? edad, DateTime? fecha, string? pais, string? ciudad, double? montoInit, double? pagoMensual)
	{
		InitializeComponent();
        lblUsuarioConectado.Text = "Usuario conectado: " + usuario;
		lblNombre.Text = nombre;
		lblApellido.Text = apellido;
		lblEdad.Text = edad.ToString();
		lblFecha.Text = fecha.ToString();
		lblPais.Text = pais.ToString();
		lblCiudad.Text = ciudad.ToString();
		lblMontoInicial.Text = montoInit.ToString();
		lblPagoMensual.Text = pagoMensual.ToString();
		lblPagoTotal.Text = ((pagoMensual*4)+montoInit).ToString();
    }
}