using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.dataObjects;
using MongoDB.Driver;

namespace Dal.DBContext
{
    public class DataContext : IDataContext
    {
        /// private MongoClient DbClient;

        //public MongoClient DbClient { get; set; }
        //public IMongoDatabase Database { get; set; }
        //public IMongoCollection<Student> StuddentCollection { get; set; }
        //public IMongoCollection<Teacher> TeacherCollection { get; set; }
        //ask if is true

        //static DataContext dataContext = null!;

        //static object locker = new();

        //public static DataContext Instance
        //{
        //    get
        //    {
        //        if (dataContext == null)
        //        {
        //            lock (locker)
        //            {
        //                if (dataContext == null)
        //                {
        //                    dataContext = new DataContext();
        //                }
        //            }

        //        }
        //        return dataContext;
        //    }
        //}
        //public DataContext(Appsetting setting)
        //{// ליצור את החיבור לדטה בייס
        //    //DbClient = new MongoClient("mongodb+srv://aviya:325245223Ar@aviya.yb9cijh.mongodb.net/test?retryWrites=true&w=majority");
        //    //Database = DbClient.GetDatabase("DrivingSchool");
        //    //DbClient = 
        //    //Database = 
        //    //StuddentCollection = 
        //    //TeacherCollection = 
        //}
        public IMongoCollection<Student> StudentCollection { get; private set; }
        public IMongoCollection<Teacher> TeacherCollection { get; private set; }

        public DataContext(AppsettingConnection appsettingConnection)
        {
            var mongoClient = new MongoClient(appsettingConnection.Client);

            var mongoDatabase = mongoClient.GetDatabase(appsettingConnection.DataBase);

            StudentCollection = mongoDatabase.GetCollection<Student>(appsettingConnection.StudentCollection);

            TeacherCollection = mongoDatabase.GetCollection<Teacher>(appsettingConnection.TeacherCollection);
        }

    }
}