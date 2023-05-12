using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.dataObjects
{
    public class Teacher:Persson
    {
        public Teacher(string id, string firstName,
            string lastName,
            string phone,
            string email,
            int status,
            string city,
            string street,
            string neighborhood,
            int buildingNumbere,
            DateTime dateOfBirth) :base( id,  firstName,  lastName,  phone,  email, city,  street,  neighborhood,  buildingNumbere,  dateOfBirth)
        {

        }
    }
}
