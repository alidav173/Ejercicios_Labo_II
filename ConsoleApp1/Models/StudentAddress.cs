using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class StudentAddress
    {
        public int StudentId { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual Student Student { get; set; }
    }
}
