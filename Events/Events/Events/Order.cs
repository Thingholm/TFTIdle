using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Order
    {
		private BonusProvider bonus;
		public BonusProvider Bonus
		{
			get { return bonus; }
			set { bonus = value; }
		}
		private List<Product> products = new List<Product>();
		public List<Product> Products
		{
			get { return products; }
			set { products = value; }
		}
		public void AddProduct(Product product)
		{
			products.Add(product);
		}
		public double GetValueOfProducts()
		{
			return products.Sum(x =>  x.Value);
		}
		public double GetBonus()
		{
			return bonus(GetValueOfProducts());
		}
		public double GetTotalPrice()
		{
			return GetValueOfProducts() - GetBonus();
		}
	}
}
