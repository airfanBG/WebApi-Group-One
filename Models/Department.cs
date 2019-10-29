namespace Models
{
    using Models.BaseModels;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Department:BaseModel
    {
        public Department()
        {
            Users = new HashSet<User>();
        }
        [Required]
        [MaxLength(20)]
        public string DepartmentName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
