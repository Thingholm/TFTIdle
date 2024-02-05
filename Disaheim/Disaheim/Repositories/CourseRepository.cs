using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace Disaheim.Repositories
{
    public class CourseRepository
    {
        Utility utility = new Utility();
        private List<Course> courses = new List<Course>();
        public void AddBook(Course course)
        {
            courses.Add(course);
        }
        public Course GetCourse(string name)
        {
            return courses.Find(a => a.Name == name);
        }
        public double GetTotalValue()
        {
            return courses.Sum(a => utility.GetValueOfCourse(a));
        }
    }
}
