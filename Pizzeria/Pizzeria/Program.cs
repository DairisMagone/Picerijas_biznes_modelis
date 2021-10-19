using System;
using Pizzeria.UI;

namespace Pizzeria
{
	class Program
	{
		static void Main(string[] args)
		{
			bool exit = false;
			while (exit == false)
			{
				MainMenu.ShowMainMenu();
				string option = Console.ReadLine();

				exit = DoActionBySelectedOption(option);

			}
		}
		public static bool DoActionBySelectedOption(string action)
		{
			bool exit = false;

			switch (action)
			{
				case "1":
					ViewPizzas();
					break;
				case "2":
					CreatePizza();
					break;
				case "3":
					ViewIngredients();
					break;
				case "4":
					IngredientUI.CreateIngredient();
					break;
				case "0":
					exit = true;
					break;

				default:
					break;
			}

			return exit;
		}
		static void ViewPizzas()
		{
			Console.WriteLine("There will be list of all Pizzas");
			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}

		static void CreatePizza()
		{
			Console.WriteLine("There we will create Pizza");
			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}
		static void ViewIngredients()
		{
			Console.WriteLine("There will be list of all Ingredients");
			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}

	}
}
