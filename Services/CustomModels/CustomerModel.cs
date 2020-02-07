using Services.CustomModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CustomModels
{
    public class CustomerModel: ICustomModel
    {
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public string PersonId { get; set; }
        
    }
}
