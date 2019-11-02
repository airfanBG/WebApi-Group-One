using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.CustomModels
{
    public class ProductSaleOrderModel
    {
       
        public int Quantity { get; set; }
       
        public DateTime DateOfSale { get; set; }
        
        public string Note { get; set; }

        [Required]
        public int ProductId { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
