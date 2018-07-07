using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*Compliler performs compile-time checking of XAML, notifying the user of any errors.
  removes some of the load and instantiation time for XAML elements.
  helps to reduce the file size of the final assembly by no longer including .xaml files.*/

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Calculator
{
	public class App : Application
	{
        
		public App()
		{
			// The root page of your application
           // MainPage = new OldMainPage();
            MainPage = new MainPage();
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
