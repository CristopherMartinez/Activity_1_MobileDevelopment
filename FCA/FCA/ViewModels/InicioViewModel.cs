using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace FCA.ViewModels
{
    public class InicioViewModel
    {
        public InicioViewModel()
        {
            ColorAcentuacionIVM = Color.FromHex("FFFFFF");
            TxtBienvenidoIVM = "Bienvenido a la APP Oficial de la Facultad de Contaduría y Administración";
            ColorTxtBienvIVM = Color.FromHex("002E5F");
            ColorTxtGeneralIVM = Color.FromHex("002E5F");
            TxtFCAIVM = "n";

        }

        public Color ColorAcentuacionIVM { get; private set; }
        public string TxtBienvenidoIVM { get; private set; }
        public Color ColorTxtBienvIVM { get; private set; }
        public Color ColorTxtGeneralIVM { get; private set; }
        public string TxtFCAIVM { get; private set; }
    }
}
