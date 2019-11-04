using Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Photo:BaseModel
    {
        public string PhotoDir { get; set; }
        public string ImageType { get; set; }
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
