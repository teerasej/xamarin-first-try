using System.Diagnostics;
using Xamarin.Forms;

namespace FormsCookBook
{
	public partial class App : Application
	{
		public App()
		{
			var userNameEntry = new Entry { Placeholder = "username" };
			var passwordEntry = new Entry { Placeholder = "password", IsPassword = true };
			var loginButton = new Button { Text = "Login" };

			loginButton.Clicked += (sender, e) =>
			{
				Debug.WriteLine(string.Format("Username: {0} - Password: {1}", userNameEntry.Text, passwordEntry.Text));
			};

			MainPage = new ContentPage
			{
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						userNameEntry,
						passwordEntry,
						loginButton
					}
				}
			};


			//InitializeComponent();

			//MainPage = new FormsCookBookPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

