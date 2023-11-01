using Library_Project.Data;
using Library_Project.Models;
using PagedList.Core;
using System;
using System.Linq;

namespace Library_Project.Service
{
    internal class BookService
    {

        public IPagedList<Book> GetPagedList(string bookName, string writer, string genre, DateTime? dateFrom, DateTime? dateTo,
          int pageNumber = 1, int pageSize = 7)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                return db.Books
                    .Where(x => x.Name.Contains(bookName) || string.IsNullOrEmpty(bookName))
                    .Where(x => x.Writer.Contains(writer) || string.IsNullOrEmpty(writer))
                    .Where(x => x.Genre.Contains(genre) || string.IsNullOrEmpty(genre))
                    .Where(x => x.RecordDate >= dateFrom || dateFrom == null)
                    .Where(x => x.RecordDate <= dateTo || dateTo == null)
                    .OrderBy(p => p.Id).ToPagedList(pageNumber, pageSize);
            }

        }

        public void AddBook(Book book)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }

        }

        public void DeleteBook(Book book)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }

        }

        public void UpdateBook(Book book)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                db.Books.Update(book);
                db.SaveChanges();
            }

        }
        
        public object FillComboBox()
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                return db.Books.OrderBy(x => x.Name).ToList();
            }
            
        }


    }
}
