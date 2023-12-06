using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        private static double courseHourValue = 875;
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private int durationInMinutes;
        public int DurationInMinutes { get { return durationInMinutes; } set { durationInMinutes = value; } }
        public static double CourseHourValue { get { return courseHourValue; } set { courseHourValue = value; } }
        public Course(string name)
        { 
            this.name = name;
        }
        public Course(string name, int durationInMinutes)
        {
            this.name = name;
            this.durationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            return $"Name: {name}, Duration in Minutes: {durationInMinutes}, Value: {GetValue()}";
        }
        public double GetValue() 
        {
            int remainder = DurationInMinutes % 60;
            int hours = DurationInMinutes / 60 + (remainder == 0 ? 0 : 1);
            double price = hours * courseHourValue;
            return price;
        }
    }
}
