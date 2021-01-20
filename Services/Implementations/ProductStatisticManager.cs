namespace Services.Implementations
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Services.Common;
    using Services.CustomModels;
    using Services.CustomModels.MapperSettings;
    using Services.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductStatisticManager
    {
        protected StoreDbContext Context;

        public ProductStatisticManager(StoreDbContext dbContext)
        {
            this.Context = dbContext;
        }
        /// <summary>
        /// Returns the sum of counts per product selled by period
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public List<SalesStatistics> GetBestSelledForPeriod(DateTime from, DateTime to)
        {
            try
            {
                using (Context)
                {
                   var res= Context.Products.Include(x => x.SalesOrders).Where(x => x.CreatedAt.Date >= from.Date && x.CreatedAt.Date <= to.Date).ToList();
                    //this type of query works only in EF Core 3.0v. More info: https://docs.microsoft.com/en-us/ef/core/what-is-new/ef-core-3.0/breaking-changes#linq-queries-are-no-longer-evaluated-on-the-client https://devblogs.microsoft.com/dotnet/announcing-entity-framework-core-3-0-preview-9-and-entity-framework-6-3-preview-9/
                    var all =
                        Context.SalesOrders
                        .Include(x => x.Product)
                        .Where(x => x.DateOfSale.Date >= from.Date && x.DateOfSale.Date <= to.Date)
                        .AsEnumerable()
                        .GroupBy(x => x.Product.ProductName)
                        .Select(x => new SalesStatistics()
                        {
                            ProductName = x.Key,
                            Count = x.Sum(a => a.Quantity),
                            Total = x.Sum(a => a.Product.ProductPrice)
                        })
                        .OrderByDescending(x=>x.Count)
                        .ToList();
                  
                    return all;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Gets the sum of product money incomes ordered descending
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public decimal GetRevenuesByPeriod(DateTime from, DateTime to)
        {
            try
            {
                using (Context)
                {
                    //this type of query works only in EF Core 3.0v. More info: https://docs.microsoft.com/en-us/ef/core/what-is-new/ef-core-3.0/breaking-changes#linq-queries-are-no-longer-evaluated-on-the-client https://devblogs.microsoft.com/dotnet/announcing-entity-framework-core-3-0-preview-9-and-entity-framework-6-3-preview-9/
                    var all =
                        Context.SalesOrders
                        .Where(x => x.DateOfSale.Date >= from.Date && x.DateOfSale.Date <= to.Date)
                        .Include(x => x.Product)
                        .AsEnumerable()
                        .GroupBy(x => x.Product.Id)
                        .Select(x => 
                        new
                        {
                            Total = x.Sum(a=>a.Quantity*a.Product.ProductPrice)
                        })                        
                        .Sum(x=>x.Total);

                    return all;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
