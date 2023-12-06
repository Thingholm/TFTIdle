using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        private static double lowQualityValue = 12.5;
        private static double mediumQualityValue = 20;
        private static double highQualityValue = 27.5;
        private Level quality;
        public double LowQualityValue { get { return lowQualityValue; } set { lowQualityValue = value; } }
        public double MediumQualityValue { get { return mediumQualityValue; } set { mediumQualityValue = value; } }
        public double HighQualityValue { get { return highQualityValue; } set { highQualityValue = value; } }
        public string Design { get; set; }

        public Level Quality { get { return quality; } set { quality = value; } }
        public Amulet(string itemId)
        {
            ItemId = itemId;
            this.quality = Level.medium;

        }

        public Amulet(string itemId, Level quality) : this(itemId)
        {
            this.quality = quality;
        }

        public Amulet(string itemId, Level quality, string design) : this(itemId, quality)
        { 
            Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
        public override double GetValue()
        {
            double price;
            switch (quality)
            {
                case Level.low:
                    price = lowQualityValue;
                    break;
                case Level.medium:
                    price = mediumQualityValue;
                    break;
                case Level.high:
                    price = highQualityValue;
                    break;
                default:
                    price = 0;
                    break;
            }
            return price;
        }
    }

}
