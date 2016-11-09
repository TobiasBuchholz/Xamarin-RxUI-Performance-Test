using System;
using ReactiveUI;

namespace PerfMatters.Core
{
	public interface IMainViewModel : IReactiveObject
	{
		IReadOnlyReactiveList<IRecipeViewModel> RecipeViewModels { get; }
	}
}
