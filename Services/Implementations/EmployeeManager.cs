namespace Services.Implementations
{
    using Models;
    using Services.Common;
    using Services.CustomModels;
    using Services.CustomModels.MapperSettings;
    using Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeeManager : BaseManager<EmployeeModel>
    {
        public List<EmployeeModel> AllEmployees
        {
            get
            {
                var models = MapperConfigurator.Mapper.Map<List<EmployeeModel>>(this.context.Employees.ToList());
                return models;
            }
        }
        public EmployeeManager() : base(new Data.StoreDbContext())
        {

        }

        public override string Add(EmployeeModel model)
        {
            try
            {
                using (context)
                {

                    Employee employee = MapperConfigurator.Mapper.Map<Employee>(model);
                    employee.EmployeeNumber = NumberGenerator.EmployeeNumberGenerator(context);

                    this.context.Employees.Add(employee);
                    this.context.SaveChanges();
                    return "";
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public override string Delete(EmployeeModel model)
        {
            try
            {
                using (context)
                {
                    Employee employee = MapperConfigurator.Mapper.Map<Employee>(model);
                    this.context.Employees.Remove(employee);
                    int res = this.context.SaveChanges();
                    if (res == 1)
                    {
                        return "";
                    }
                    return string.Format($"{Messages.DeleteFails} Person Id: {model.PersonId}.");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public override string Update(EmployeeModel model)
        {
            try
            {
                using (context)
                {
                    Employee employee = MapperConfigurator.Mapper.Map<Employee>(model);
                    this.context.Employees.Update(employee);
                    int res = this.context.SaveChanges();
                    if (res == 1)
                    {
                        return "";
                    }
                    return string.Format($"{Messages.UpdateFails} Employee Id: {model.Id}, Person Id {model.PersonId}.");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public override EmployeeModel Get(int id)
        {
            try
            {
                using (context)
                {
                    var getEmployee = this.context.Departments.SingleOrDefault(x => x.Id == id);
                    var res = MapperConfigurator.Mapper.Map<EmployeeModel>(getEmployee);
                    return res;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
