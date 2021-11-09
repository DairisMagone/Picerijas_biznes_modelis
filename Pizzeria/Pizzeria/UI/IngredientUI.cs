using System;
using Pizzeria.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.UI
{
	public class IngredientUI
	{
		IIngredientsRepository _repository;
		public IngredientUI(IIngredientsRepository repository)
		{
			_repository = repository;
		}

		public void CreateIngredient()
		{
			Console.Clear();

			Console.WriteLine("Enter Ingredient Name: ");
			string name = Console.ReadLine();

			Ingredient ingredient = new Ingredient() { Name = name };
			_repository.CreateOrUpdateIngredient(ingredient);

			Console.WriteLine("Press any key to continue.");
			Console.ReadLine();
		}

		public void PrintIngredients(bool needReadLine)
		{
			Console.Clear();
			var myIngredients = _repository.GetIngredients();
			foreach (var eachIngr in myIngredients)
			{
				Console.WriteLine($"Ingredient ID: {eachIngr.Id}, Ingredient: {eachIngr.Name}");
			}
			if (needReadLine)
			{
				Console.ReadLine();
			}
		}

		public void EditIngredients()
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
				ingredient = _repository.GetIngredientById(ingredientIdToUpdate);
				if (ingredient == null)
				{
					Console.WriteLine($"Unknown Ingredient ID {ingredientIdToUpdateText} ");
				}
				else
				{
					Console.WriteLine("Enter Ingredient Name: ");
					string name = Console.ReadLine();
					ingredient.Name = name;
					_repository.CreateOrUpdateIngredient(ingredient);
				}
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
