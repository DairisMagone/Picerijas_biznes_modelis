using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Exceptions;

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
	public static class MainMenuActionsExtensions
	{
		public static MainMenuActions StringToMainMenuAction(string optionStr)
		{
			bool isIntValid = int.TryParse(optionStr, out int optionInt);
			if (isIntValid)
			{
				if (typeof(MainMenuActions).IsEnumDefined(optionInt))
				{
					return (MainMenuActions)optionInt;
				}
			}
			throw new MainMenuActionDoesnotExsistException($"{optionStr} is not valid value for Main Menu Action");

		//	return MainMenuActions.None;
		}
	}

}
