using Models.BaseModels;

namespace Models
{
    public class EmployeeCustomers: BaseModel
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
