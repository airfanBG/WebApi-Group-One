namespace Services.CustomModels
{
    using Services.CustomModels.Interfaces;

    public class ProductModel : ICustomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal ProductPrice { get; set; }

        public int CurrentQuantity { get; set; }
    }
}
