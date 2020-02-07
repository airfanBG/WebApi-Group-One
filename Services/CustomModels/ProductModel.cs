namespace Services.CustomModels
{
    using Microsoft.AspNetCore.Http;
    using Services.CustomModels.Interfaces;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ProductModel : ICustomModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="Product  name is required!")]
        [MinLength(2)]
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal ProductPrice { get; set; }

        public int CurrentQuantity { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}
