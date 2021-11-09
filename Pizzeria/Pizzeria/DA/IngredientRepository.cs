using Pizzeria.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.DA
{
	public class IngredientRepository : IIngredientsRepository
	{
		private  Dictionary<int, Ingredient> ingredients = new Dictionary<int, Ingredient>();

		private int GetNewID()
		{
			int maxId = GetMaxID();
				return maxId + 1;
		}
		private int GetMaxID()
		{
			if (ingredients.Keys.Count == 0)
				return 0;

			var maxId = ingredients.Keys.Max();
			return maxId;
		}

		public void CreateOrUpdateIngredient(Ingredient ingredient)
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

		public List<Ingredient> GetIngredients()
		{
			return ingredients.Select(x=>x.Value).ToList();
		}

		public Ingredient GetIngredientById(int id)
		{
			Ingredient ingredient = null;
			ingredients.TryGetValue(id, out ingredient);
			return ingredient;
		}

		public void Write(string text)
		{
			File.AppendAllText("Ingr_Reposiory.txt",text + Environment.NewLine);
		}

	}
}
