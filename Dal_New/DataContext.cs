using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Dal
{
    public class DataContext
    {
        public MongoClient DbClient { get; set; }
        public IMongoDatabase Database { get; set; }
        static DataContext dataContext;

        static object locker = new();

        public static DataContext Instance
        {
            get
            {
                if (dataContext == null)
                {
                    lock (locker)
                    {
                        if (dataContext == null)
                        {
                            dataContext = new DataContext();
                        }
                    }

                }
                return dataContext;
            }
        }
        public DataContext()
        {
            DbClient = new MongoClient("mongodb+srv://aviya:325245223Ar@aviya.yb9cijh.mongodb.net/test?retryWrites=true&w=majority");
            Database = DbClient.GetDatabase("DrivingSchool");
        }
    }
}
