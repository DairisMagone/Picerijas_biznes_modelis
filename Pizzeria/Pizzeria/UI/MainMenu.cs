using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.UI
{
	public static class MainMenu
	{
		public static void ShowMainMenu()
		{
			string mainMenu = @"
Welcome to My Pizza Menu!

Choose option:

1-View Pizzas
2-Create New Pizza
3-View Ingredients
4-Create New Ingredient

0-Exit
";
			Console.Clear();
			Console.WriteLine(mainMenu);
		}
	}
}

