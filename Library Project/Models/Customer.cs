using System;
using System.Collections.Generic;

namespace Library_Project.Models;

public partial class Customer
{
    public int ID { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public short? Age { get; set; }

    public string Gender { get; set; }

    public DateTime CreateDate { get; set; }

    public string TelNo { get; set; }

    public string CustomerFullName
    {
        get
        {
            return $"{Name} {Surname}";
        }
    }
}
