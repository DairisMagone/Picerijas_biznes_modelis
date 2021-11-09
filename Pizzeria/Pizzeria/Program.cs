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
			IngredientRepository repository = new IngredientRepository();
			IngredientUI ui = new IngredientUI(repository);
			MainMenu menu = new MainMenu();

			bool exit = false;
			while (!exit)
			{
				menu.ShowMainMenu();
				string option = Console.ReadLine();

				MainMenuActions action = MainMenuActionsExtensions.StringToMainMenuAction(option);
				exit = DoAction(action, ui);
			}
			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}

		public static bool DoAction(MainMenuActions action, IngredientUI ui)
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
					ui.PrintIngredients(true);
					break;
				case MainMenuActions.CreateNewIngredient:
					ui.CreateIngredient();
					break;
				case MainMenuActions.EditIngredient:
					ui.EditIngredients();
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
		//3. Interface
	}
}


