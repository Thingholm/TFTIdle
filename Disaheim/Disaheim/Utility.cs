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
        private double lowQualityValue = 12.5;
        private double mediumQualityValue = 20;
        private double highQualityValue = 27.5;
        private double courseHourValue = 875;
        public double LowQualityValue {  get { return lowQualityValue; } set {  lowQualityValue = value; } }
        public double MediumQualityValue { get { return mediumQualityValue; } set {  mediumQualityValue = value; } }
        public double HighQualityValue { get { return highQualityValue; } set {  highQualityValue = value; } }
        public double CourseHourValue {  get { return courseHourValue; } set {  courseHourValue = value; } }
        public double GetValueOfCourse(Course course)
        {
            int remainder = course.DurationInMinutes % 60;
            int hours = course.DurationInMinutes / 60 + (remainder == 0 ? 0 : 1);
            double price = hours * courseHourValue;
            return price;
        }
        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Amulet)
            {
                Amulet amulet = (Amulet)merchandise;
                double price;
                switch (amulet.Quality)
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
            else if (merchandise is Book)
            {
                Book book = (Book)merchandise;
                return book.Price;
            }
            else
            {
                return 0;
            }
        }
    }
}
