﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace censo.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class inicio : ContentPage
	{
		public inicio ()
		{
			InitializeComponent ();
		}

        async void nuevoCenso(object sender, EventArgs e){

            await Navigation.PushAsync(new Vistas.Inicio.nuevoCenso());
        }
}
}