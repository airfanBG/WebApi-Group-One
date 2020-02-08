namespace Models
{
    using Microsoft.AspNetCore.Identity;
    using Models.BaseModels;
    using Models.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User : IdentityUser, IAuditInfo

    {
        public User()
        {
            UserTokens = new HashSet<UserToken>();
            UserRoles = new HashSet<UserRoles>();
        }
        [Required(ErrorMessage = "First name is required!")]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required!")]
        [MaxLength(20)]
        public string LastName { get; set; }

        //[Required]
        //[StringLength(maximumLength: 50, MinimumLength = 5)]
        //public string Email { get; set; }
        //[Required]
        //public string Password { get; set; }

       
        public virtual ICollection<UserToken> UserTokens { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<UserOrder> UserOrders{ get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
