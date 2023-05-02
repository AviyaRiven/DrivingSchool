using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DBContext
{
    public class CollectionConfiguration:ICollectionConfiguration
    {
        public string Client { get; set; }
        public string DataBase { get; set; }
        public string StudentCollection { get; set; }
        public string TeacherCollection { get; set; }

        public CollectionConfiguration(string json)
        {
            //Client = json.client;
            //DataBase = json.dataBase;
            //StudentCollection = json.studentCollection;
            //TeacherCollection = json.teacherCollection;

        }

        public CollectionConfiguration()
        {
        }
    }
}
