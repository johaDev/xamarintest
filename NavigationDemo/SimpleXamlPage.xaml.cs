using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;

namespace NavigationDemo
{
	public partial class SimpleXamlPage : ContentPage  /*, INotifyPropertyChanged */
	{
		public SimpleXamlPage()
		{
			InitializeComponent();

			BindingContext = this;
		}

		public string LabelText { get; set; } = "My Label-title from the Code";

		private string _firstName = "Donald";
		public string FirstName {
			get {
				return _firstName;
			}
			set {
				_firstName = value;
				OnPropertyChanged(nameof(FirstName));
			}
		}

		/*
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propName)
		{
			var changed = PropertyChanged;
			if (changed != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}
*/
	}
}
