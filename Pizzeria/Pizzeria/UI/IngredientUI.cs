using System;
using Pizzeria.Services;
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
		public static void PrintIngredients(bool needReadLine)
		{
			Console.Clear();
			var myIngredients = Ingredient.GetIngredients();
			foreach (var eachIngr in myIngredients)
			{
				Console.WriteLine($"Ingredient ID: {eachIngr.Id}, Ingredient: {eachIngr.Name}");
			}
			if (needReadLine)
			{
				Console.ReadLine();
			}
		}

		public static void EditIngredients()
		{
			Console.Clear();
			PrintIngredients(false);
			Console.WriteLine("Chose Ingredient ID to update: ");
			Console.WriteLine("Press '0' to cancel.");
			var ingredientIdToUpdateText = Console.ReadLine();
			if (ingredientIdToUpdateText == "0")
				return;

			if (int.TryParse(ingredientIdToUpdateText, out int ingredientIdToUpdate))
			{
				Ingredient ingredient = null;
				ingredient = Ingredient.GetById(ingredientIdToUpdate);
				if (ingredient == null)
				{
					Console.WriteLine($"Unknown Ingredient ID {ingredientIdToUpdateText} "); // izdomāt kā apvienot vienādās CW rindas.
				}
				else
				{
					Console.WriteLine("Enter Ingredient Name: ");
					string name = Console.ReadLine();
					ingredient.Name = name;
					ingredient.Save();
				}

				//Updating ingredient with ID ID=ingredirntToUpdate.
			}
			else
			{
				Console.WriteLine($"Unknown Ingredient ID {ingredientIdToUpdateText} ");
			}

			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}
	}
}
