using Xamarin.Forms;

namespace NavigationDemo
{
	public partial class NavigationRootPage : ContentPage
	{
		public NavigationRootPage()
		{
			InitializeComponent();

			if (Application.Current.Properties.ContainsKey("firstName")) {
				firstName.Text = Application.Current.Properties["firstName"] as string;
			}

		}

		void OnBt1Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("Info", "you pressed the button", "close");
		}

		void OnBt2Clicked(object sender, System.EventArgs e)
		{
		  	Navigation.PushAsync(new MySimplePage());
		}


		void OnTextChanged(object sender, System.EventArgs e)
		{
			Application.Current.Properties["firstName"] = firstName.Text;
		}

		void OnShowSimplePage1(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new SimpleCodePage());
		}

		void OnShowSimplePage2(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new SimpleXamlPage());
		}



	
	}
}
	