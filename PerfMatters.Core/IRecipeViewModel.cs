using System;
using ReactiveUI;

namespace PerfMatters.Core
{
	public interface IRecipeViewModel : IReactiveObject
	{
		Recipe Recipe { get; }
		int Index { get; }
	}
}
