using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Product
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private double value;
		public double Value
		{
			get { return value; }
			set { this.value = value; }
		}
	}
}
