using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Project.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int CustomerId { get; set; }

    public DateTime BorrowDate { get; set; }

    public DateTime BorrowEndDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public virtual Book Book { get; set; }

    public virtual Customer Customer { get; set; }


    public string BookName
    {
        get
        {
            return Book?.Name;
        }
    }

    public string CustomerFullName
    {
        get
        {
            return $"{Customer.Name} {Customer.Surname}";
        }
    }
}
