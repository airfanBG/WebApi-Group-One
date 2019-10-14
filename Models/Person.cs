﻿using Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Person:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Too much")]
        public string Email { get; set; }
        public string Password { get; set; }
        
        public virtual Employee Employee { get; set; }
       
        public virtual Customer Customer{ get; set; }

    }
}
