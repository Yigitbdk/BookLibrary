using System;
using System.Collections.Generic;

namespace Library_Project.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int CustomerId { get; set; }

    public DateTime DateTake { get; set; }

    public DateTime DateReturn { get; set; }

    public virtual Book Book { get; set; }

    public virtual Customer Customer { get; set; }
}
