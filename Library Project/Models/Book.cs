using System;
using System.Collections.Generic;

namespace Library_Project.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Writer { get; set; }

    public string Genre { get; set; }

    public string PageNumber { get; set; }

    public DateTime RecordDate { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
