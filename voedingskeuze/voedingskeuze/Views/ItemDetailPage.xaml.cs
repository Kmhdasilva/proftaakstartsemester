using System.ComponentModel;
using Xamarin.Forms;
using voedingskeuze.ViewModels;

namespace voedingskeuze.Views
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