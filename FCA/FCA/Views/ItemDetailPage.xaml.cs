using FCA.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FCA.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}