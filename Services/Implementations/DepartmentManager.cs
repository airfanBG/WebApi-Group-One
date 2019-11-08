using Models;
using Services.Common;
using Services.CustomModels;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Implementations
{
    public class DepartmentManager : BaseManager<DepartmentModel>
    {
        public DepartmentManager():base(new Data.StoreDbContext())
        {

        }
        public override string Add(DepartmentModel model)
        {
            try
            {
                using (context)
                {
                    var getDepartment = this.context.Departments.SingleOrDefault(x => x.DepartmentName == model.DepartmentName);
                    if (getDepartment==null)
                    {
                        this.context.Add(new Department()
                        {
                            DepartmentName = model.DepartmentName
                        });
                        this.context.SaveChanges();
                        return "";
                    }
                    return Messages.DepartmentExists;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override string Delete(DepartmentModel model)
        {
            try
            {
                using (context)
                {
                    if (model.Id!=0)
                    {
                        var getDepartment = this.context.Departments.SingleOrDefault(x => x.Id == model.Id);
                        if (getDepartment != null)
                        {
                            this.context.Remove(getDepartment);
                            this.context.SaveChanges();
                            return "";
                        }
                        return string.Format($"Not deleted {model.DepartmentName}");
                    }
                    else
                    {
                        var getDepartment = this.context.Departments.SingleOrDefault(x => x.DepartmentName == model.DepartmentName);
                        if (getDepartment != null)
                        {
                            this.context.Remove(getDepartment);
                            this.context.SaveChanges();
                            return "";
                        }
                        return string.Format($"Not deleted {model.DepartmentName}");
                    }
                    
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
       
        public override string Update(DepartmentModel model)
        {
            try
            {
                using (context)
                {
                    var getDepartment = this.context.Departments.SingleOrDefault(x => x.Id==model.Id);
                    if (getDepartment != null)
                    {
                        getDepartment.DepartmentName = model.DepartmentName;

                        this.context.Update(getDepartment);
                        this.context.SaveChanges();
                        return "";
                    }
                    return string.Format($"Not updated {model.Id}");
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
