using Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee:BaseModel
    {
        public Employee()
        {
            EmployeeCustomers = new HashSet<EmployeeCustomers>();
        }
        public string EmployeeNumber { get; set; }
        public string Telephone { get; set; }
        public int BankAccount { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<EmployeeCustomers> EmployeeCustomers { get; set; }
    }
    
}
