using Dal.dataObjects;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DBContext
{
    public class DBStudentCollection:DataContext<Student>
    {
        //public IMongoCollection<Student> Collection { get {
        //        var collection = Database.GetCollection<Teacher>("Teachers");
        //        return collection;
        //    }
        //    set { }
        }
    }
}
