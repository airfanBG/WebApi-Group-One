namespace Models
{
    using Microsoft.AspNetCore.Identity;
    using Models.BaseModels;
    using Models.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Roles")]
    public class Role : IdentityRole<string>, IAuditInfo, IBaseModel
    {
       
        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        public string RoleName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
