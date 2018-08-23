using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudOperationCodeFirst.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Nullable<System.DateTime> JoiningDate { get; set; }
        public virtual ICollection<Enrollement> Enrollements { get; set; }
    }
}