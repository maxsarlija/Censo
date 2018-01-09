using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace censo.Vistas.Inicio
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class nuevoCenso : ContentPage
	{
		public nuevoCenso ()
		{
			InitializeComponent ();
		}
        async void btnCompraenMayorista(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Vistas.Popup.compraenmayorista());

        }

        async void btnMejoras(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Vistas.Popup.mejoras());

        }

        async void btnTieneproductos(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Vistas.Popup.tieneProductos());
        }
       
    }
}