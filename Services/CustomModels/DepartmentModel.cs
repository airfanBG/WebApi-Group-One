using Services.CustomModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CustomModels
{
    public class DepartmentModel: ICustomModel
    {
        public string DepartmentName { get; set; }
        public int Id { get; set; }
    }
}
