using Pizzeria.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.DA
{
	public static class IngredientRepository
	{
		private static Dictionary<int, Ingredient> ingredients = new Dictionary<int, Ingredient>();

		private static int GetNewID()
		{
			int maxId = GetMaxID();
				return maxId + 1;
		}
		private static int GetMaxID()
		{
			if (ingredients.Keys.Count == 0)
				return 0;

			var maxId = ingredients.Keys.Max();
			return maxId;
		}

		public static void CreateOrUpdateIngredient(Ingredient ingredient)
		{
			bool ingredientExist = ingredients.ContainsKey(ingredient.Id);
			if (ingredientExist)
			{
				ingredients[ingredient.Id] = ingredient;
			}
			else 
			{
				ingredient.Id = GetNewID();
				ingredients.Add(ingredient.Id, ingredient);
			}
		}

		public static List<Ingredient> GetIngredients()
		{
			return ingredients.Select(x=>x.Value).ToList();
		}

		public static Ingredient GetById(int id)
		{
			Ingredient ingredient = null;
			ingredients.TryGetValue(id, out ingredient);
			return ingredient;
		}

		//public static void UpdateIngredient(Ingredient, ingredient)
		//{

		//}


	}
}
