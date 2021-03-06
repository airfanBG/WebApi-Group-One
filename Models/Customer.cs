﻿namespace Models
{
    using Models.BaseModels;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer : BaseModel
    {
        public Customer()
        {
            EmployeeCustomers = new HashSet<EmployeeCustomers>();
            SaleOrders = new HashSet<SaleOrder>();
        }
        [MaxLength(10)]
        [Required(ErrorMessage = "Account number is required!")]
        public string AccountNumber { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<EmployeeCustomers> EmployeeCustomers { get; set; }

    }
}
