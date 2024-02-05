using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim.Repos
{
    public class AmuletRepository
    {
        private List<Amulet> amulets;
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(string itemId)
        {
            return amulets.Find(x => x.ItemId == itemId);
        }
        public double GetTotalValue()
        {

        }
    }
}
