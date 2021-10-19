using System;
using Pizzeria.BL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.UI
{
	public class IngredientUI
	{
		public static void CreateIngredient()
		{
			Console.Clear();
			
			Console.WriteLine("Enter Ingredient Name: ");
			string name = Console.ReadLine();

			Ingredient ingredient = new Ingredient();
			ingredient.Name = name;
			ingredient.Save();




			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}

	}
}
