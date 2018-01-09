using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace censo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        
        async void loginClick(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Vistas.inicio());
        }
	}
}
