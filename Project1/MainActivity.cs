using Android.App;
using Android.Widget;
using Android.OS;

namespace Project1
{
	[Activity(Label = "Project1", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
		}
	}
}

