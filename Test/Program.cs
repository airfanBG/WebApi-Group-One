using Services.Common;
using Services.CustomModels;
using Services.Implementations;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            // NumberGenerator.EmployeeNumberGenerator();
            // UserRolesManager um = new UserRolesManager();
            //um.Update(new UserRolesModel() { RoleIds = new System.Collections.Generic.List<int>() { 6 }, UserId = 1 });
            // var res=um.GetAll(1);
            //RoleManager rm = new RoleManager();
            //var all=rm.AllRoles;
            //ProductSalesManager psm = new ProductSalesManager(new StoreDbContext());
            // var res=psm.GetMostSelledProducts();
            //psm.SaleProduct(new ProductSaleOrderModel() { DateOfSale = DateTime.Now, Note = "test", ProductId = 1, Quantity = 1, UserId = 2 });     
            //DirectoryManagement dm = new DirectoryManagement();
            //var res=dm.GetFolderPath();
            // ProductStatisticManager psm = new ProductStatisticManager(new Data.StoreDbContext());
            //var res= psm.GetRevenuesByPeriod(new System.DateTime(2019, 01, 01), new System.DateTime(2019, 12, 12));

            ProductManager pm = new ProductManager();
            pm.Add(new ProductModel() { Name = "test", ProductPrice = 1, Description = "test", CurrentQuantity = 1 });
            
        }

    }
}
