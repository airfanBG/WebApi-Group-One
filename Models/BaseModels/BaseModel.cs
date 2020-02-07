namespace Models.BaseModels
{
    using Models.Interfaces;
    using System;

    public class BaseModel : IBaseModel, IAuditInfo
    {

        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        
    }
}
