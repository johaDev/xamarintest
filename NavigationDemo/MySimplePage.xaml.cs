using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationDemo
{
	public partial class MySimplePage : ContentPage
	{
		public MySimplePage()
		{
			InitializeComponent();
			this.Title = "Hello, Title";
		}

		void OnBack(object sender, System.EventArgs e)
		{
			Navigation.PopAsync();
		}

		void OnDiveIn(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new MySimplePage());
		}

		void OnGoHome(object sender, EventArgs e)
		{
			Navigation.PopToRootAsync(true);
		}
	}
}
