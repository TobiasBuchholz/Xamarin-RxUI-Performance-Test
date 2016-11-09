
using System;
using System.Linq;

using Android.Content;
using Android.Views;
using Android.Widget;
using ReactiveUI;
using PerfMatters.Core;
using System.Reactive.Linq;
using Android.Graphics;

namespace PerfMatters.Droid
{
	public class RecipeItemView : ReactiveViewHost<IRecipeViewModel>
	{
		public LinearLayout LayoutContainer { get; private set; }
		public TextView PublishedDateLabel { get; private set; }
		public TextView TitleLabel { get; private set; }
		public TextView Step1Label { get; private set; }
		public TextView Step2Label { get; private set; }
		public TextView Step3Label { get; private set; }
		public TextView Step4Label { get; private set; }
		public TextView Step5Label { get; private set; }
		public TextView IngredientsLabel { get; private set; }
		public TextView DescriptionLabel { get; private set; }

		public RecipeItemView(IRecipeViewModel viewModel, Context context, ViewGroup parent) 
			: base(context, Resource.Layout.layout_recipe_item, parent)
		{
			ViewModel = viewModel;
			BindViewsToViewModel();
		}

		private void BindViewsToViewModel()
		{
			this.OneWayBind(ViewModel, viewModel => viewModel.Recipe.PublishedAt, view => view.PublishedDateLabel.Text);
			this.OneWayBind(ViewModel, viewModel => viewModel.Recipe.Title, view => view.TitleLabel.Text);
			this.OneWayBind(ViewModel, viewModel => viewModel.Recipe.Description, view => view.DescriptionLabel.Text);
			this.OneWayBind(ViewModel, viewModel => viewModel.Recipe.Step1, view => view.Step1Label.Text);
			this.OneWayBind(ViewModel, viewModel => viewModel.Recipe.Step2, view => view.Step2Label.Text);
			this.OneWayBind(ViewModel, viewModel => viewModel.Recipe.Step3, view => view.Step3Label.Text);
			this.OneWayBind(ViewModel, viewModel => viewModel.Recipe.Step4, view => view.Step4Label.Text);
			this.OneWayBind(ViewModel, viewModel => viewModel.Recipe.Step5, view => view.Step5Label.Text);
			this.OneWayBind(ViewModel, viewModel => viewModel.Recipe.Ingredients, view => view.IngredientsLabel.Text);
			this.WhenAnyValue(view => view.ViewModel.Index)
			    .Select(index => index % 2 == 0 ? Color.Orange : Color.GreenYellow)
			    .Subscribe(LayoutContainer.SetBackgroundColor, LogError);
		}

		private void LogError(Exception e)
		{
			System.Diagnostics.Debug.WriteLine(e.Message);
		}
	}
}
