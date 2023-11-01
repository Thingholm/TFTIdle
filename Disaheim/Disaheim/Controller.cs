using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        private List<Book> _books;
        public List<Book> Books { get { return _books; } set { _books = value; } }
        private List<Amulet> _amulets;
        public List<Amulet> Amulets { get { return _amulets; } set { _amulets = value; } }
        private List<Course> _courses;
        public List<Course> Courses { get { return _courses; } set { _courses = value; } }

        public Controller ()
        {
            Books = new List<Book> ();
            Amulets = new List<Amulet> ();
            Courses = new List<Course> ();
        }

        public void AddToList (Book book)
        {
            Books.Add(book);
        }

        public void AddToList (Amulet amulet)
        {
            Amulets.Add(amulet);
        }

        public void AddToList (Course course)
        {
            Courses.Add(course);
        }
    }
}
