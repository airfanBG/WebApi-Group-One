using Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Customer: BaseModel
    {
        public Customer()
        {
            EmployeeCustomers = new HashSet<EmployeeCustomers>();
        }
        public string AccountNumber { get; set; }
        public int? PersonId { get; set; }
        public virtual User Person { get; set; }
        public int? SaleOrderId { get; set; }
        public virtual SaleOrder SaleOrder { get; set; }
        public virtual ICollection<EmployeeCustomers> EmployeeCustomers { get; set; }
        
    }
}
