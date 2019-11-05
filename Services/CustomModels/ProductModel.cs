namespace Services.CustomModels
{
    using Microsoft.AspNetCore.Http;
    using Services.CustomModels.Interfaces;
    using System.Collections.Generic;

    public class ProductModel : ICustomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal ProductPrice { get; set; }

        public int CurrentQuantity { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}
