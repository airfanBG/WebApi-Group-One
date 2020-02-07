namespace Services.Implementations
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Services.Common;
    using Services.CustomModels;
    using Services.CustomModels.MapperSettings;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProductSalesManager
    {
        private StoreDbContext context;
       
        public ProductSalesManager(StoreDbContext data)
        {
            this.context = data;
            
        }
        public List<ProductModel> GetMostSelledProducts(int top = 10)
        {
            try
            {
                using (context)
                {
                    var getProducts = context.Products.Include(x => x.SalesOrders).OrderByDescending(x => x.SalesOrders.Sum(z => z.Quantity)).Take(top).ToList();
                    var models = MapperConfigurator.Mapper.Map<List<ProductModel>>(getProducts);

                    return models;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task AddProduct(string productId, int quantity,string userid)
        {
            
            using (context)
            {
              await Task.Run(()=>  context.UserOrders.Add(new UserOrder() {UserId=userid,ProductId=productId,Quantity=quantity }));
            }
          
        }
        public async Task<int> GetUserOrdersCount(string id)
        {
            using (context)
            {
                return await Task.Run(() => context.UserOrders
                .Where(x => x.UserId == id && !x.FinnishedDate.HasValue)
                .Count());
            }
        }
        public async Task<List<ProductSaleOrderModel>> GetUserOrders(string id)
        {
            using (context)
            {
                return await Task.Run(() => context.UserOrders
                .Where(x => x.UserId == id && !x.FinnishedDate.HasValue)
                .Select(x => new ProductSaleOrderModel()
                {
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    UserId = x.UserId
                }).ToList());
            }
        }

        public string SaleProduct(ProductSaleOrderModel model)
        {
            try
            {
                using (context)
                {
                    var getProduct = context.Products.SingleOrDefault(x => x.Id == model.ProductId);
                    if (getProduct == null)
                    {
                        return Messages.NotExistingProduct;
                    }
                    getProduct.CurrentQuantity -= model.Quantity;

                    SaleOrder saleOrder = new SaleOrder();
                    saleOrder.Quantity = model.Quantity;
                    saleOrder.Note = model.Note;
                    saleOrder.DateOfSale = model.DateOfSale;
                    saleOrder.Product = getProduct;

                    Customer customer = this.context.Customers.SingleOrDefault(x => x.UserId == model.UserId);
                    if (customer == null)
                    {
                        return Messages.NotExistingCustomer;
                    }
                    customer.SaleOrders.Add(saleOrder);
                    this.context.Products.Update(getProduct);
                    this.context.Customers.Update(customer);

                    this.context.SaveChanges();
                    return "";
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
