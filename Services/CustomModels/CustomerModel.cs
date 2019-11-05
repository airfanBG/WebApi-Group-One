using Services.CustomModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CustomModels
{
    public class CustomerModel: ICustomModel
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public int? PersonId { get; set; }
        
    }
}
