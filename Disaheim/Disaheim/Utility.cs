using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20.0;
        public double HighQualityValue = 27.5;
        public double CourseHourValue = 875.0;

        public double GetValueOfBook (Book book)
        {
            double bookValue = 0;
            if (book != null)
            {
                bookValue = book.Price;
            }

            return bookValue;
        }

        public double GetValueOfAmulet (Amulet amulet)
        {
            double amuletValue = 0;
            if (amulet != null)
            {
                switch (amulet.Quality)
                {
                    case Level.low:
                        amuletValue = 12.5;
                        break;
                    case Level.medium:
                        amuletValue = 20.0;
                        break;
                    case Level.high:
                        amuletValue = 27.5;
                        break;
                }
            }
            return amuletValue;
        }

        public double GetValueOfMerchandise (Merchandise merchandise)
        {
            double result = 0;
            if (merchandise is Amulet)
                return GetValueOfAmulet(merchandise as Amulet);
            else if (merchandise is Book)
                return GetValueOfBook(merchandise as Book);
            else if (merchandise is Course)
                return GetValueOfCourse(merchandise as Course);

            return result;
        }


        public double GetValueOfCourse (Course course)
        {
            // Leif's version:
            //int hoursStarted = course.DurationInMinutes / 60;
            //bool anyMinutes = course.DurationInMinutes % 60 != 0;
            //return anyMinutes ? (hoursStarted + 1) * 875 : hoursStarted * 875; // ternary operator
            // ---------------

            //int excess = course.DurationInMinutes % 60;
            //int actual = course.DurationInMinutes - excess;

            // Rasmus' Method ---------------------------------------
            //Double result = 0;
            //int remainder = course.DurationInMinutes % 60;

            //if (remainder > 0)
            //{
            //    result = (course.DurationInMinutes / 60 + 1) * 875;
            //} else if (remainder == 0)
            //{
            //    result = course.DurationInMinutes / 60 * 875;
            //}
            //return result;
            // ------------------------------------------------------


            // Own method -------------------------------------------
            int hours = 0;
            int minutes = 0;
            int remaining = course.DurationInMinutes;
            while (remaining > 0)
            {
                minutes += 1;
                remaining -= 1;
                if (minutes == 60)
                {
                    hours += 1;
                    minutes = 0;
                }
            }

            // Add the most-recently started hour for billing as well
            if (minutes > 0)
            {
                hours += 1;
            }

            double valuePerHour = 875.00;
            return hours * valuePerHour;
            // ------------------------------------------------------
        }
    }
}
