using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTest.Model
{
    public class Person
    {
        public int personId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime birthDate { get; set; }
        public List<Employees> employee{ get; set; }
    }
}
