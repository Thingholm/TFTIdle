﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise : IValuable
    {
        private string itemId;
        public string ItemId { get; set; }

        public override string ToString()
        {
            return "ItemId: " + itemId;
        }
        public abstract double GetValue();
    }
}
