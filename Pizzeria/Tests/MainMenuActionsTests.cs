using System;
using Pizzeria.Services.Enums;
using Xunit;

namespace Tests
{
	public class MainMenuActionsTests
	{
		[Theory]
		[InlineData(MainMenuActions.None, "")]
		[InlineData(MainMenuActions.ViewPizzas, "1")]
		[InlineData(MainMenuActions.CreateNewPizza, "2")]
		[InlineData(MainMenuActions.ViewIngredients, "3")]
		[InlineData(MainMenuActions.CreateNewIngredient, "4")]
		[InlineData(MainMenuActions.EditIngredient, "5")]
		[InlineData(MainMenuActions.Exit, "99")]
		[InlineData(MainMenuActions.None, "abc")]
		[InlineData(MainMenuActions.None, "6")]

		public void StringToMainMenuAction_Test(MainMenuActions expectedValue, string optionStr)
		{
			MainMenuActions action = MainMenuActionsExtensions.StringToMainMenuAction(optionStr);
			Assert.Equal(expectedValue, action);
		}
	}
}
