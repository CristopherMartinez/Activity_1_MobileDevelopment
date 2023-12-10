using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Text;
using FCA.Models;
using FCA.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using Button = Xamarin.Forms.Button;

namespace FCA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiciosPage : ContentPage
    {
        public ServiciosPage()
        {
            InitializeComponent();
            //BindingContext = new ServiciosPageViewModel();

        }

        public class Propiedades
        {
            public int idServicio { get; set; }

        }

        public class HorariosVirtuales
        {
            public int idServicio { get; set; }

            public string horariosVirtuales { get; set; }


        }

        public class HorariosPresenciales
        {
            public int idServicio { get; set; }

            public string horariosPresenciales { get; set; }
        }

        public async void traerHorariosVirtuales(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender; // El 'sender' es el botón que se hizo clic
            Servicio servicio = (Servicio)button.BindingContext;


            Propiedades objecto = new Propiedades
            {
                idServicio = servicio.idServicio
            };

            Uri RequestUri = new Uri("http://192.168.100.11/API_FCA/controller/servicios.php?op=traerHorariosVirtuales");
            var client = new HttpClient();

            //convertimos el objeto a json
            var json = JsonConvert.SerializeObject(objecto);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(RequestUri, contentJson);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                //ponemos en una lista con el modelo de HorariosPresVir 
                List<HorariosVirtuales> horarios = JsonConvert.DeserializeObject<List<HorariosVirtuales>>(content);

                //Mostramos de la lista el unico objeto que hay que esta en posicion 0 y mostramos los horariosVirtuales 
                await DisplayAlert("Horarios virtuales", horarios[0].horariosVirtuales, "OK");
            }
            else
            {
                await DisplayAlert("Error", "ocurrio un error", "OK");
            }

        }

        public async void traerHorariosPresenciales(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender; // El 'sender' es el botón que se hizo clic
            Servicio servicio = (Servicio)button.BindingContext;


            Propiedades objecto = new Propiedades
            {
                idServicio = servicio.idServicio
            };

            Uri RequestUri = new Uri("http://192.168.100.11/API_FCA/controller/servicios.php?op=traerHorariosPresenciales");
            var client = new HttpClient();

            //convertimos el objeto a json
            var json = JsonConvert.SerializeObject(objecto);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(RequestUri, contentJson);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                //ponemos en una lista con el modelo de HorariosPresVir 
                List<HorariosPresenciales> horarios = JsonConvert.DeserializeObject<List<HorariosPresenciales>>(content);

                //Mostramos de la lista el unico objeto que hay que esta en posicion 0 y mostramos los horariosVirtuales 
                await DisplayAlert("Horarios presenciales", horarios[0].horariosPresenciales, "OK");
            }
            else
            {
                await DisplayAlert("Error", "ocurrio un error", "OK");
            }
        }

    }

}

