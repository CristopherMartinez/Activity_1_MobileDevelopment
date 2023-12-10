using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FCA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlumnosPage : ContentPage
    {
        public AlumnosPage()
        {
            InitializeComponent();
        }

        public class Propiedades {
            public int matricula { get; set; }          
            public string nombre { get; set; }
            public string apellido_paterno { get; set; }
            public string apellido_materno { get; set; }
            public string edad { get; set; }

            //Propiedad que me concatena y retorna el nombre + apellido_paterno + apellido_materno del alumno
            public string nombreCompleto
            {
                get { return $"{nombre} {apellido_paterno} {apellido_materno}"; }
            }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage();
            //Como estoy utilizando un emulador de Android si pongo 'localhost' en la URL,
            //en el contexto del emulador se refiere al propio emulador, no a mi máquina host.
            //Entonces para solucionar esto, agrego la IP de mi pc para poder acceder al servidor
            //de mi máquina host desde el emulador Android.
            request.RequestUri = new Uri("http://192.168.100.11/API_FCA/controller/alumnos.php?op=traer_alumnos");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode==HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado=JsonConvert.DeserializeObject<List<Propiedades>>(content);
                ListDemo.ItemsSource = resultado;
            }
        }

        private async void ListDemo_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Propiedades alumno)
            {
                await DisplayAlert("Edad", $"La edad del alumno es {alumno.edad}", "OK");
            }

          ((ListView)sender).SelectedItem = null;
        }

    }
}