namespace Models
{
    using Models.BaseModels;

    public class EmployeeCustomers : BaseModel
    {
        public string EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
