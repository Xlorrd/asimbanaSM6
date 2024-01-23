namespace asimbanaSM6.Vistas;
using asimbanaSM6.Modelos;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
public partial class Home : ContentPage
{
    private const string Url = "http://127.0.0.1/moviles/post.php";
    private readonly HttpClient cliente = new HttpClient();
    private ObservableCollection<Estudiante> estud;
    public Home()
	{
		InitializeComponent();
        Obtener();
    }

    public async void Obtener()
    {
        var content = await cliente.GetStringAsync(Url);
        List<Estudiante> mostrarEstudiante = JsonConvert.DeserializeObject<List<Estudiante>>(content);
        estud = new ObservableCollection<Estudiante>(mostrarEstudiante);
        listaEstudiante.ItemsSource = estud;


    }
    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Agregar());
    }
    private void listaEstudiante_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var objetoestudiante = (Estudiante)e.SelectedItem;
        Navigation.PushAsync(new ActualizarEliminar(objetoestudiante));
    }
}