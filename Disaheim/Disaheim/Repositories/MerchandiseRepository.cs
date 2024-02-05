using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace Disaheim.Repositories
{
    public class MerchandiseRepository
    {
        Utility utility = new Utility();
        private List<Merchandise> merchandises = new List<Merchandise>();
        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId)
        {
            return merchandises.Find(x => x.ItemId == itemId);
        }
        public double GetTotaleValue()
        {
            return merchandises.Sum(m => utility.GetValueOfMerchandise(m));
        }
    }
}
