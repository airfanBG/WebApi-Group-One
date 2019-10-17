using Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class User:BaseModel
    {
        public User()
        {
            UserTokens = new HashSet<UserToken>();
            UserRoles = new HashSet<UserRoles>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]        
        [StringLength(maximumLength:50, MinimumLength =5)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        
        public virtual Employee Employee { get; set; }
        
        public virtual Customer Customer{ get; set; }
        public virtual ICollection<UserToken> UserTokens { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }

    }
}
