using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        private double price;
        public string Title { get; set; }
        public double Price { get { return price; } set { price = value; } }


        public Book(string itemId)
        {
            ItemId = itemId;
        }

        public Book(string itemId, string title) : this (itemId)
        {
            Title = title;
        }
        public Book(string itemId, string title, double price) : this (itemId, title)
        {
            this.price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
        public override double GetValue()
        {
            return price;
        }
    }

}
