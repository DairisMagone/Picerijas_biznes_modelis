using Pizzeria.DA;

namespace Pizzeria.BL

{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Save()
        {
            IngredientRepository.SaveNewIngredient(this);
        }





    }

}
