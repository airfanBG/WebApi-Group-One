namespace Models
{
    using Models.BaseModels;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Employee : BaseModel
    {
        public Employee()
        {
            EmployeeCustomers = new HashSet<EmployeeCustomers>();
        }
        [Required(ErrorMessage = "EmployeeNumber is required!")]
        public string EmployeeNumber { get; set; }
        [Required(ErrorMessage = "Telephone is required!")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Bank account is required!")]
        public int BankAccount { get; set; }
        public int? PersonId { get; set; }
        public virtual User Person { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<EmployeeCustomers> EmployeeCustomers { get; set; }
    }

}
