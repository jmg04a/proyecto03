namespace proyecto03;

public partial class MainPage : ContentPage
{
    // Variables para guardar los números
    private int conteoIzquierda = 0;
    private int conteoDerecha = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    //   Lógica del Lado Izquierdo  

    private void OnSumarIzq(object sender, EventArgs e)
    {
        conteoIzquierda++;
        // "D2" hace que se vea como 01, 02, etc.
        LblContadorIzq.Text = conteoIzquierda.ToString("D2"); 
    }

    private void OnRestarIzq(object sender, EventArgs e)
    {
        if (conteoIzquierda > 0) // Opcional: Evitar números negativos
        {
            conteoIzquierda--;
            LblContadorIzq.Text = conteoIzquierda.ToString("D2");
        }
    }

    //   Lógica del Lado Derecho  

    private void OnSumarDer(object sender, EventArgs e)
    {
        conteoDerecha++;
        LblContadorDer.Text = conteoDerecha.ToString("D2");
    }

    private void OnRestarDer(object sender, EventArgs e)
    {
        if (conteoDerecha > 0)
        {
            conteoDerecha--;
            LblContadorDer.Text = conteoDerecha.ToString("D2");
        }
    }

    // Limpiar 

    private void OnReset(object sender, EventArgs e)
    {
        textBoxEquipo1.Text = string.Empty;
        textBoxEquipo2.Text = string.Empty;
        conteoDerecha = 0;
        conteoIzquierda = 0;
        LblContadorDer.Text="00";
        LblContadorIzq.Text="00";
    }

}