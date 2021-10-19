using Pizzeria.BL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.DA
{
	public static class IngredientRepository
	{

		// te ir lietots List. Vai nav kāds labāks variants?
		// Hint: kaut kas, kas kontrolē, ka ID ir unikāls
		private static List<Ingredient> ingredients = new List<Ingredient>();

		private static int GetNewID()
		{
			int maxId = GetMaxID();
			return maxId + 1;
		}

		private static int GetMaxID()
		{
			/*
			 * Failā atradīs lielāko Max Ingredient ID (kā no lista dabūt maxID? (google))
			 */
			return 1;
		}

		public static void SaveNewIngredient(Ingredient ingredient)
		{
			ingredient.Id = GetNewID();

			// ToDo - atrast kā pievienot ingeredientu listam

		}


	}
}
