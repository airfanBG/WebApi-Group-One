﻿namespace Services.CustomModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ProductSaleOrderModel
    {

        public int Quantity { get; set; }

        public DateTime DateOfSale { get; set; }

        public string Note { get; set; }

        [Required]
        public string ProductId { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}
