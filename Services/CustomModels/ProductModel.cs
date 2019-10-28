using Services.CustomModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CustomModels
{
    public class ProductModel : ICustomModel
    {
        public string Name { get; set; }
    }
}
