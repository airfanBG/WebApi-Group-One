using Models;
using Services.Common;
using Services.CustomModels;
using Services.CustomModels.MapperSettings;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Implementations
{
    public class CustomerManager : BaseManager<CustomerModel>
    {
        public CustomerManager():base(new Data.StoreDbContext())
        {

        }
        public override string Add(CustomerModel model)
        {
            try
            {
                using (context)
                {

                    Customer customer = MapperConfigurator.Mapper.Map<Customer>(model);
                    var user = context.Users.Single(x => x.Id == model.PersonId);
                    customer.Person = user;

                    this.context.Customers.Add(customer);
                    this.context.SaveChanges();
                    return "";
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public override string Delete(CustomerModel model)
        {
            try
            {
                using (context)
                {
                    Customer customer = MapperConfigurator.Mapper.Map<Customer>(model);
                    this.context.Customers.Remove(customer);
                    int res = this.context.SaveChanges();
                    if (res == 1)
                    {
                        return "";
                    }
                    return string.Format($"{Messages.DeleteFails} Customer Id: {model.PersonId}.");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public override CustomerModel Get(int id)
        {
            try
            {
                using (context)
                {
                    var getCustomer = this.context.Customers.SingleOrDefault(x => x.Id == id);
                    var res = MapperConfigurator.Mapper.Map<CustomerModel>(getCustomer);
                    return res;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override string Update(CustomerModel model)
        {
            try
            {
                using (context)
                {
                    Customer customer = MapperConfigurator.Mapper.Map<Customer>(model);
                    this.context.Customers.Update(customer);
                    int res = this.context.SaveChanges();
                    if (res == 1)
                    {
                        return "";
                    }
                    return string.Format($"{Messages.UpdateFails} Customer Id: {model.Id}.");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
