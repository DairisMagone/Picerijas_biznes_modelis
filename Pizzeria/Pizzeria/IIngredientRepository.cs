using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Services;

namespace Pizzeria
{
	public interface IIngredientsRepository
	{
		void Write(string text);
		void CreateOrUpdateIngredient(Ingredient ingredient);
		List<Ingredient> GetIngredients();
		Ingredient GetIngredientById(int ingredientId);
	}
}
