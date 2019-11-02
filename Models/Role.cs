using Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    [Table("Roles")]
    public class Role:BaseModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        public string RoleName { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
