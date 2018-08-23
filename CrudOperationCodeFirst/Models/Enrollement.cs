using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudOperationCodeFirst.Models
{
    public class Enrollement
    {
        public int EnrollementID { get; set; }
        public Nullable<decimal> Band { get; set; }
        public int DepatmentID { get; set; }
        public int EmployeeID { get; set; }

        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
    }
}