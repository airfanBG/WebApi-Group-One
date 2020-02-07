using Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class UserOrder: BaseModel
    {
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime? FinnishedDate { get; set; }
        public virtual User User { get; set; }
    }
}
