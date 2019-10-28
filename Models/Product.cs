namespace Models
{
    using Models.BaseModels;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product:BaseModel
    {
        public Product()
        {
            SalesOrders = new HashSet<SaleOrder>();
        }
        [Required(ErrorMessage ="Product name is required!")]
        [MaxLength(20)]
        [MinLength(2)]
        public string ProductName { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        
        public int CurrentQuantity { get; set; }
        public virtual ICollection<SaleOrder> SalesOrders { get; set; }
    }
}
