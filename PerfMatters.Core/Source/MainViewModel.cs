using System;
using System.Collections.Generic;
using ReactiveUI;

namespace PerfMatters.Core
{
	public class MainViewModel : ReactiveObject, IMainViewModel
	{
		private readonly ReactiveList<IRecipeViewModel> _recipeViewModels = new ReactiveList<IRecipeViewModel>();
		public IReadOnlyReactiveList<IRecipeViewModel> RecipeViewModels
		{
			get { return _recipeViewModels; }
		}

		public MainViewModel()
		{
			_recipeViewModels.AddRange(CreateMockedRecipeViewModels());
		}

		private IList<IRecipeViewModel> CreateMockedRecipeViewModels()
		{
			var viewModels = new List<IRecipeViewModel>();
			for(int i = 0; i < 96; i++) {
				viewModels.Add(new RecipeViewModel(new Recipe { 
					PublishedAt = i + "10.2010",
					Title = "Title " + i,
					Description = "Description " + i,
					Step1 = "Step1 " + i,
					Step2 = "Step2 " + i,
					Step3 = "Step3 " + i,
					Step4 = "Step4 " + i,
					Step5 = "Step5 " + i,
					Ingredients = "Ingredients " + i,
					ImageUrl = "https://lh6.ggpht.com/YXtcy5SeHevSEqTMUNuyhSXVwiGWKkOX-QvoLQDFA1cxQqOaDcXD7cGSiwJYQFOLTg=w300", 
				}, i));
			}
			return viewModels;
		}
	}
}
