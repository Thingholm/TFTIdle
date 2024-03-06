using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }

        public double GetValueOfProducts()
        {
            return _products.Sum(product => product.Value);
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
