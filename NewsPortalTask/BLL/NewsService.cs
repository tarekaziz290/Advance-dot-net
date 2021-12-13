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
    public class NewsService
    {
        public static bool Add(NewsModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NewsModel, News>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            return DataAccess.NewsDataAccess().Add(data);
        }

        public static bool Edit(NewsModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NewsModel, News>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            return DataAccess.NewsDataAccess().Edit(data);
        }
        public static bool Delete(int id)
        {
            return DataAccess.NewsDataAccess().Delete(id);
        }
        public static List<NewsModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<Comment, CommentModel>();
                
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(DataAccess.NewsDataAccess().Get());
            return data;
        }
        public static NewsModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<Comment, CommentModel>();
                
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<NewsModel>(DataAccess.NewsDataAccess().Get(id));
            return data;
        }
        public static List<NewsModel> GetByDate(DateTime dateTime)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<Comment, CommentModel>();
                
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(DataAccess.NewsDataAccess().GetByDate(dateTime));
            return data;
        }
        public static List<NewsModel> GetByCategory(string category)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<Comment, CommentModel>();
               
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(DataAccess.NewsDataAccess().GetByCategory(category));
            return data;
        }
        public static List<NewsModel> GetByDateCategory(DateTime dateTime, string category)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<Comment, CommentModel>();
                
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(DataAccess.NewsDataAccess().GetByDateCategory(dateTime, category));
            return data;
        }
    }
}
