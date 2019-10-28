namespace Models
{
    using Models.BaseModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class SaleOrder:BaseModel
    {
        public SaleOrder()
        {
            Customers = new HashSet<Customer>();
        }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime DateOfSale { get; set; }
        [MaxLength(200)]
        public string Note { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
       
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
