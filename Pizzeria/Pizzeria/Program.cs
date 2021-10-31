using System;
using Pizzeria.Services;
using Pizzeria.DA;
using Pizzeria.Services.Enums;
using Pizzeria.UI;

namespace Pizzeria
{
	class Program
	{
		static void Main(string[] args)
		{
			bool exit = false;
			while (!exit)
			{
				MainMenu.ShowMainMenu();
				string option = Console.ReadLine();

				MainMenuActions action = MainmenuActionsExtensions.StringToMainMenuAction(option);
				exit = DoAction(action);
			}
			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}
		public static bool DoAction(MainMenuActions action)
		{
			bool exit = false;

			switch (action)
			{
				case MainMenuActions.ViewPizzas:
					ViewPizzas();
					break;
				case MainMenuActions.CreateNewPizza:
					CreatePizza();
					break;
				case MainMenuActions.ViewIngredients:
					IngredientUI.PrintIngredients(true);
					break;
				case MainMenuActions.CreateNewIngredient:
					IngredientUI.CreateIngredient();
					break;
				case MainMenuActions.EditIngredient:
					IngredientUI.EditIngredients();
					break;
				case MainMenuActions.Exit:
					exit = true;
					break;

				case MainMenuActions.None:
				default:
					Console.WriteLine("Unknown action");
					break;
			}

			return exit;
		}
		static void ViewPizzas()
		{
			Console.Clear();
			Console.WriteLine("There will be list of all Pizzas");
			Console.ReadLine();
		}

		static void CreatePizza()
		{
			Console.Clear();
			Console.WriteLine("There we will create Pizza");
			Console.ReadLine();
		}

		//1. Testu 
		//3. Interface
	}
}


