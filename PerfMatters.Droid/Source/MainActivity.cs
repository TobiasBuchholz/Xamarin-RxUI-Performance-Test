using Android.App;
using Android.Widget;
using Android.OS;
using ReactiveUI;
using PerfMatters.Core;

namespace PerfMatters.Droid
{
	[Activity(Label = "PerfMatters", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : ReactiveActivity<IMainViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_main);

			ViewModel = new MainViewModel();

			var gridView = FindViewById<GridView>(Resource.Id.gridview);
			var adapter = new ReactiveListAdapter<IRecipeViewModel>(ViewModel.RecipeViewModels, (viewModel, parent) => new RecipeItemView(viewModel, this, parent));
			gridView.Adapter = adapter;
		}
	}
}

