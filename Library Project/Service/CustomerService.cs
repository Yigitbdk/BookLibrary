using Library_Project.Data;
using Library_Project.Models;
using PagedList.Core;
using System.Linq;

namespace Library_Project.Service
{
    internal class CustomerService
    {
        public IPagedList<Customer> GetPagedList(string name, string surname, int pageNumber = 1, int pageSize = 2)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                return db.Customers
                    .Where(x => x.Name.Contains(name) || string.IsNullOrEmpty(name))
                    .Where(x => x.Surname.Contains(surname) || string.IsNullOrEmpty(surname))
                    .OrderBy(p => p.ID).ToPagedList(pageNumber, pageSize);
            }

        }

        public void AddCustomer(Customer customer)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                db.Customers.Update(customer);
                db.SaveChanges();
            }
        }

        public object FillComboBox()
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                return db.Customers.OrderBy(x => x.Name).ToList();
            }

        }

    }
}
