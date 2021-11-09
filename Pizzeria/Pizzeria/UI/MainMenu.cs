using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.UI
{
	public class MainMenu : MenuItem
	{
		List<MenuItem> menuItems = new List<MenuItem>()
		{
			new MenuItem(1, "View Pizzas"),
			new MenuItem(2, "Create New Pizza"),
			new MenuItem(3, "View Ingredients"),
			new MenuItem(4, "Create New Ingredient"),
			new MenuItem(5, "Edit Ingredient"),
			new MenuItem(99, "Exit"),
		};
		public override string GetDisplayTitle() 
		{
			string mainMenuText = @"
Welcome to My Pizza Menu!

Choose option:
";
			foreach (var menuItem in this.menuItems)
			{
				mainMenuText += Environment.NewLine;
				bool isExitMenu = menuItem.Code == 99;
				if (isExitMenu) 
				{
					mainMenuText += Environment.NewLine; 
					mainMenuText += Environment.NewLine;
				}
				mainMenuText += menuItem.GetDisplayTitle();
			}

			return mainMenuText;
		}
		public void ShowMainMenu()
		{
			Console.Clear();
			string mainMenuText = this.GetDisplayTitle();
			Console.WriteLine(mainMenuText);
		}
	}
}

