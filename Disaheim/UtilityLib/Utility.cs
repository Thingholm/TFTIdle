using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace UtilityLib
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public double GetValueOfAmulet(Amulet amulet)
        {
            double price;
            switch (amulet.Quality)
            {
                case Level.low:
                    price = 12.5;
                    break;
                case Level.medium:
                    price = 20;
                    break;
                case Level.high:
                    price = 27.5;
                    break;
                default:
                    price = 0; 
                    break;
            }
            return price;
        }
        public double GetValueOfCourse(Course course)
        {
            int remainder = course.DurationInMinutes % 60;
            int hours = course.DurationInMinutes / 60 + (remainder == 0 ? 0 : 1);
            double price = hours * 875;
            return price;
        }
    }
}
