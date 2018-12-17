using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTest.Model
{
    public class Employees
    {
        public int employeeId { get; set; }
        public int personId { get; set; }
        public string employeeNumber { get; set; }
        public string employedDate { get; set; }
        public string terminatedDate { get; set; }
        public Person person { get; set; }


    }
}
