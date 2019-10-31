namespace Services.Implementations
{
    using Data;

    public class RoleManager
    {
        private StoreDbContext context;
        public RoleManager(StoreDbContext dbContext)
        {
            this.context = dbContext;

        }
    }
}
