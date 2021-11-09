using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.UI
{
	public class MenuItem
	{
		public string Title { get; set; }
		public int Code { get; set; }
		public virtual string GetDisplayTitle()
		{
			return Code + " - " + Title;
		}
		public MenuItem() { }
		public MenuItem(int code, string title)
		{
			this.Code = code;
			this.Title = title;
		}
		
	}
}
