using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim.Repositories
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();
        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string id)
        {
            IValuable valuable1 = null;
            foreach (var valuable in valuables)
            {
                if (valuable is Merchandise)
                {
                    Merchandise merchandise = (Merchandise)valuable;
                    if (merchandise.ItemId == id)
                    {
                        valuable1 = merchandise;
                        break;
                    }
                }
                else if (valuable is Course)
                {
                    Course course = (Course)valuable;
                    if (course.Name == id)
                    {
                        valuable1 = course;
                        break;
                    }
                }
            }
            return valuable1;
        }
        public double GetTotalValue()
        {
            return valuables.Sum(v => v.GetValue());
        }
        public int Count()
        {
            return valuables.Count();
        }
    }
}
