﻿namespace Services.Implementations
{
    using Data;
    using Microsoft.AspNetCore.Http;
    using Models;
    using Services.Common;
    using Services.CustomModels;
    using Services.CustomModels.MapperSettings;
    using Services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ProductManager : BaseManager<ProductModel>
    {
        public List<ProductModel> AllProducts
        {
            get
            {
                var res = MapperConfigurator.Mapper.Map<List<ProductModel>>(this.context.Products.ToList());

                return res;
            }
        }
        public ProductManager() : base(new StoreDbContext())
        {

        }
        public override string Add(ProductModel model)
        {
            try
            {
                using (context)
                {

                    Product product = MapperConfigurator.Mapper.Map<Product>(model);
                    List<Photo> photos=null;

                    if (model.Files!=null)
                    {
                        if (model.Files.Count > 0)
                        {
                            photos = Photos(model.Files);
                            product.Photos = photos;
                        }
                    }                  
                   

                    this.context.Products.Add(product);
                    this.context.SaveChanges();
                    return "";
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public string Delete(string id)
        {
            return Delete(new ProductModel() { Id = id });
        }
        public override string Delete(ProductModel model)
        {
            try
            {
                using (context)
                {
                    Product product = MapperConfigurator.Mapper.Map<Product>(model);
                    this.context.Products.Remove(product);
                    int res = this.context.SaveChanges();
                    if (res == 1)
                    {
                        return "";
                    }
                    return string.Format($"{Messages.DeleteFails} {model.Name}.");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public override string Update(ProductModel model)
        {
            try
            {
                using (context)
                {
                    Product product = MapperConfigurator.Mapper.Map<Product>(model);
                    List<Photo> photos = null;

                    if (model.Files.Count > 0)
                    {
                        photos = Photos(model.Files);
                        product.Photos = photos;
                    }

                    this.context.Products.Update(product);
                    int res = this.context.SaveChanges();
                    if (res == 1)
                    {
                        return "";
                    }
                    return string.Format($"{Messages.UpdateFails} {model.Name}.");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private List<Photo> Photos(List<IFormFile> files)
        {           
                DirectoryManagement dm = new DirectoryManagement();
                List<Photo> photos = new List<Photo>();
                foreach (var file in files)
                {
                    if (file.Length > 0 && file != null)
                    {
                        var path = dm.GetFolderPath();

                        var fileName = FileNameManipulator.GenerateName();
                        var fullPath = Path.Combine(path, fileName);
                        var fileType = Path.GetExtension(file.FileName);

                        photos.Add(new Photo() { ImageType = fileType, PhotoDir = fullPath });
                       
                        using (var str=new FileStream(fullPath+fileType,FileMode.Create))
                        {
                            file.CopyTo(str);
                        }
                    }
                }
                return photos;          
        }

        public override ProductModel Get(string id)
        {
            try
            {
                using (context)
                {
                    var getProduct = this.context.Products.SingleOrDefault(x => x.Id == id);
                    var res = MapperConfigurator.Mapper.Map<ProductModel>(getProduct);
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
