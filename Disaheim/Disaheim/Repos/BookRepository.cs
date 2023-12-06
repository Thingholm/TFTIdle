using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim.Repos
{
    public class BookRepository
    {
        private List<Book> books;
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(string itemId)
        {
            return books.Find(x => x.ItemId == itemId);
        }
        public double GetTotalValue()
        {
            return books.Sum(x => );
        }
    }
}
