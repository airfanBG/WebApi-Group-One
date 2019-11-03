namespace Models
{
    using Models.BaseModels;

    public class UserToken : BaseModel
    {
        public string Name { get; set; }
        public string Token { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
