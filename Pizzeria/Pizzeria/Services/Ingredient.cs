using System.Collections.Generic;
using Pizzeria.DA;

namespace Pizzeria.Services
{
	public class Ingredient
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public void Save()
		{
			IngredientRepository.CreateOrUpdateIngredient(this);
		}

		public static Ingredient GetById(int id)
		{
			Ingredient ingredient = IngredientRepository.GetById(id);
			return ingredient;
		}

		public static List<Ingredient> GetIngredients()
		{
			return IngredientRepository.GetIngredients();
		}

	}

}
