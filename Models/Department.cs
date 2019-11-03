namespace Models
{
    using Models.BaseModels;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Department : BaseModel
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        [Required]
        [MaxLength(20)]
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
