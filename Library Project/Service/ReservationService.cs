using Library_Project.Data;
using Library_Project.Models;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Linq;

namespace Library_Project.Service
{
    internal class ReservationService
    {
        public IPagedList<Reservation> GetPagedList(string bookName, string customerName, DateTime? dateFrom, DateTime? dateTo, int pageNumber = 1, int pageSize = 5)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                 return db.Reservations.Include(x => x.Book).Include(x => x.Customer)
                .Where(x => x.Book.Name.Contains(bookName) || string.IsNullOrEmpty(bookName))
                .Where(x => (x.Customer.Name + " " + x.Customer.Surname).Contains(customerName) || string.IsNullOrEmpty(customerName))
                .Where(x => x.BorrowEndDate >= dateFrom || dateFrom == null)
                .Where(x => x.BorrowEndDate <= dateTo || dateTo == null)
                .OrderBy(x => x.Id).ToPagedList(pageNumber, pageSize);
            }
           
        }

        public bool BookHasReservation(int bookId)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                return db.Reservations.Where(x => x.BookId == bookId).Any();
            }

        }


        public bool CustomerHasReservation(int customerId)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                return db.Reservations.Where(x => x.CustomerId == customerId).Any();
            }

        }

        public void AddReservation(Reservation reservation)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                db.Reservations.Add(reservation);
                db.SaveChanges();
            }

        }

        public void DeleteReservation(Reservation reservation)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                db.Reservations.Remove(reservation);
                db.SaveChanges();
            }

        }

        public void ReturnBook(Reservation reservation)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                db.Reservations.Update(reservation);
                db.SaveChanges();
            }

        }


    }
}
