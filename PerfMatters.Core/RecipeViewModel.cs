using System;
using ReactiveUI;

namespace PerfMatters.Core
{
	public class RecipeViewModel : ReactiveObject, IRecipeViewModel
	{
		public Recipe Recipe { get; }
		public int Index { get; }

		public RecipeViewModel(Recipe recipe, int index)
		{
			Recipe = recipe;
			Index = index;
		}
	}
}
