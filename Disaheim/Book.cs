using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book

    {
        private string itemId;
        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
            }
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public Book(string itemId, string title, double price)
        {
            this.itemId = itemId;
            this.title = title;
            this.price = price;
        }

        public Book(string itemId, string title)
            : this(itemId, title, 0)
        {
        }

        public Book(string itemId)
            : this(itemId, "")
        {
        }

        public override string ToString()
        {
            return $"ItemId: {itemId}, Title: {title}, Price: {price}";
        }

    }
    }
