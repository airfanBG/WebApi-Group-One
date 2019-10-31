using Models;
using Newtonsoft.Json;
using Services.Common;
using Services.CustomModels.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.CustomModels
{
    public class TokenRequestModel
    {
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }


        [Required]
        [JsonProperty("password")]
        [Password(8, true, true, true, ErrorMessage = "Password not reply to demands")]

        [Compare("ConfirmPassword", ErrorMessage = "Passwords do not match!")]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public ICollection<Role> Roles { get; set; }

    }
}
