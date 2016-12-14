using System;

using Xamarin.Forms;

namespace NavigationDemo
{
	public class SimpleCodePage : ContentPage
	{
		public SimpleCodePage()
		{

			var picker = new Picker { Title = "Pick a fruit" };
			picker.Items.Add("Apple");
			picker.Items.Add("Orange");
			picker.Items.Add("Banana");

			Content = new StackLayout
			{
				Children = {
					new Label { Text = "A Page written in C#." },
					new Button { Text = "OK" },
					new SearchBar {  Placeholder ="enter text" },
					picker
				}
			};

		}
	}
}

