using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {
        public static bool Add(CategoryModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryModel, Category>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(n);
            return DataAccess.CategoryDataAccess().Add(data);
        }

        public static bool Edit(CategoryModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryModel, Category>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(n);
            return DataAccess.CategoryDataAccess().Edit(data);
        }
        public static bool Delete(int id)
        {
            return DataAccess.CategoryDataAccess().Delete(id);
        }
        public static List<CategoryModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CategoryModel>>(DataAccess.CategoryDataAccess().Get());
            return data;
        }
        public static CategoryModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<CategoryModel>(DataAccess.CategoryDataAccess().Get(id));
            return data;
        }
    }
}
