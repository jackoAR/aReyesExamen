namespace aReyesExamen.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    public Registro(string user)
    {
        InitializeComponent();
        lblDocente.Text = "Usuario Conectado: " + user;
        
    }

    double pmensual;

    private void btnPagoMensual_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(EntryMontoInicial.Text))
        {


            double montoIni = double.Parse(EntryMontoInicial.Text);


            if (montoIni != 0 && montoIni > 1500)
            {

                double porcentage = 1500 * 0.04;

                pmensual = (1500 - montoIni) / 4 + porcentage;

                EntryCalculoPagoMensual.Text = pmensual.ToString();

            }
            else
            {
                DisplayAlert("Alerta", "El monto inicial debe ser menor a 1500", "OK");
            }
        }
        else
        {
            DisplayAlert("Alerta", "El campo monto inicial esta vacio","OK");
        }
    }
}