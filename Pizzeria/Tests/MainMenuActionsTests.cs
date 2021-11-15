using System;
using Pizzeria.Exceptions;
using Pizzeria.Services.Enums;
using Xunit;

namespace Tests
{
	public class MainMenuActionsTests
	{
		[Theory]
		[InlineData(MainMenuActions.ViewPizzas, "1")]
		[InlineData(MainMenuActions.CreateNewPizza, "2")]
		[InlineData(MainMenuActions.ViewIngredients, "3")]
		[InlineData(MainMenuActions.CreateNewIngredient, "4")]
		[InlineData(MainMenuActions.EditIngredient, "5")]
		[InlineData(MainMenuActions.Exit, "99")]
		public void StringToMainMenuAction_Test(MainMenuActions expectedValue, string optionStr)
		{
			MainMenuActions action = MainMenuActionsExtensions.StringToMainMenuAction(optionStr);
			Assert.Equal(expectedValue, action);
		}

		[Theory]
		[InlineData("")]
		[InlineData("abc")]
		[InlineData("6")]
		public void StringToMainMenuAction_Test_EndsWithException(string optionStr)
		{
			Assert.Throws<MainMenuActionDoesnotExsistException>(() => MainMenuActionsExtensions.StringToMainMenuAction(optionStr));
		}
	}
}
