using System;
using System.Collections.Generic;

namespace Library_Project.Models;

public partial class Customer
{
    public int Id { get; set; }

    public int FkBookId { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public short? Age { get; set; }

    public bool? Male { get; set; }

    public DateTime CreateDate { get; set; }

    public string TelNr { get; set; }

    public virtual Book FkBook { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
