using System;
using Newtonsoft.Json;
using static FCA.Views.AlumnosPage;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Collections.ObjectModel;
using FCA.Models;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FCA.ViewModels
{
    public class ServiciosPageViewModel : BaseViewModel
    {
        private ObservableCollection<Servicio> servicios;

        public ObservableCollection<Servicio> Servicios
        {
            get { return servicios; }
            set
            {
                servicios = value;
                OnPropertyChanged(); //Notificar los cambios
            }
        }

        public ServiciosPageViewModel()
        {
            Servicios = new ObservableCollection<Servicio>(); 

            TraerServicios(); //Llamamos a la funcion que trae los datos

        }

      


        public async void TraerServicios()
        {
            try
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri("http://192.168.100.24/API_FCA/controller/servicios.php?op=traer_servicios");
                request.Method = HttpMethod.Get;
                request.Headers.Add("Accept", "application/json");
                var client = new HttpClient();
                HttpResponseMessage response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    ObservableCollection<Servicio> serviciosDeserializados = JsonConvert.DeserializeObject<ObservableCollection<Servicio>>(content);

                    
                    Servicios = serviciosDeserializados;
                }
                else
                {
                    
                    await DisplayAlert("Error", "Ocurrio un error", "OK");

                }
            }
            catch (Exception ex)
            {
                
                await DisplayAlert("Error", "Ocurrio un error: " +ex , "OK");
                return;

            }
        }



        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }

}

