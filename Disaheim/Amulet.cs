﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
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

        private string design;
        public string Design
        {
            get
            {
                return design;
            }
            set
            {
                design = value;
            }
        }

        private Level quality;
        public Level Quality
        {
            get 
            { 
                return quality; 
            }
            set 
            { 
                quality = value; 
            }
        }

        public Amulet(string itemId, Level quality, string design)
        {
            this.itemId = itemId;
            this.Quality = quality;
            this.Design = design;
        }

        public Amulet(string itemId, Level quality):
            this(itemId, quality, "")
        {
        }

        public Amulet(string itemId) 
            :this(itemId, Level.medium, "")
        {
        }

        public override string ToString()
        {
            return $"ItemId: {itemId}, Quality: {quality}, Design: {design}";
        }
    }

}