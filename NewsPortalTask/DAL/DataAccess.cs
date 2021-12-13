using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        static NewsPortalEntities db;
        static DataAccess()
        {
            db = new NewsPortalEntities();
        }
        public static IRepository<News, int> NewsDataAccess()
        {
            return new NewsRepo(db);
        }
        public static IRepository<Category, int> CategoryDataAccess()
        {
            return new CategoryRepo(db);
        }
        
        public static IRepository<Comment, int> CommentDataAccess()
        {
            return new CommentRepo(db);
        }
    }
}
