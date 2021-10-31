using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Services.Enums
{
	public enum MainMenuActions
	{
		None = 0,
		ViewPizzas = 1,
		CreateNewPizza = 2,
		ViewIngredients = 3,
		CreateNewIngredient = 4,
		EditIngredient = 5,

		Exit = 99,
	}
	public static class MainmenuActionsExtensions
	{
		public static MainMenuActions StringToMainMenuAction(string optionStr)
		{
			bool canParse = int.TryParse(optionStr, out int optionInt);
			if (canParse && typeof(MainMenuActions).IsEnumDefined(optionInt))
			{
				return (MainMenuActions)optionInt;
			}
			return MainMenuActions.None;
		}

	}

}
