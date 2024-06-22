namespace aReyesExamen.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        Dictionary<string, string> usersBD = new Dictionary<string, string>
                {
                    {"estudiante", "moviles" },
                    {"uisrael", "2024"},
                };

        var nombre = txtUser.Text;
        var contrasena = txtPassword.Text;

        if (!string.IsNullOrEmpty(nombre) || !string.IsNullOrEmpty(contrasena))
        {
            Dictionary<string, string> credencialesEntry = new Dictionary<string, string>
                {
                    {"Usuario",txtUser.Text},
                    {"Contraseña",txtPassword.Text}
                };

            if (usersBD.Keys.Contains(txtUser.Text) && usersBD.Values.Contains(txtPassword.Text))
            {
                Navigation.PushAsync(new Registro(txtUser.Text));// solo abre la pagina Home
            }
            else
            {
                DisplayAlert("ALERTA", "NO EXISTE NINGÚN USUARIO CON ESE NOMBRE Y CLAVE", "OK");
            }
        }

        }
}