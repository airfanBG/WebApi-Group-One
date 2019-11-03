using Services.CustomModels.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.CustomModels
{
    public class EmployeeModel: ICustomModel
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
       
        public string Telephone { get; set; }
       
        public int BankAccount { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        
    }
}
