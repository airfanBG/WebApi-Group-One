using Models.BaseModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Product:BaseModel
    {
        public Product()
        {
            SalesOrders = new HashSet<SaleOrder>();
        }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CurrentQuantity { get; set; }
        public virtual ICollection<SaleOrder> SalesOrders { get; set; }
    }
}
