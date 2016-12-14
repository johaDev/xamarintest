using System;

using Xamarin.Forms;

namespace NavigationDemo
{
	public class SimpleCodePage : ContentPage
	{
		public SimpleCodePage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "A Page written in C#." },
					new Button { Text = "OK" },
					new SearchBar {  Placeholder ="enter text" },
					new Picker { Title ="Title"}
				}
			};
		}
	}
}

