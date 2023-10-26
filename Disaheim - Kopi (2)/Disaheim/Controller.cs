using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        private List<Book> books;
        private List<Amulet> amulets;

        public List<Book> Books { get { return books; } }
        public List<Amulet> Amulets { get { return amulets; } }

        public Controller() 
        {
            books = new List<Book>();
            amulets = new List<Amulet>();
        }

        public void AddToList(Book book)
        {
            books.Add(book);
        }
        public void AddToList(Amulet amulet)
        {
            amulets.Add(amulet);
        }
    }
}
