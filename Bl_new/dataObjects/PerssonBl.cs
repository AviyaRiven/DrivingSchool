using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.dataObjects
{
    public class PerssonBl
    {
   
        //public string Id { get; set; }
        public string TZ { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public AddressBl Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        //public PerssonBl(string id,
        //    string firstName,
        //    string lastName,
        //    string phone,
        //    string email,
        //    string city,
        //    string street,
        //    string neighborhood,
        //    int buildingNumber,
        //    DateTime dateOfBirth)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Id = id;
        //    Phone = phone;
        //    Email = email;
        //    Adress = new AddressBl(
        //      //  city, neighborhood, street, buildingNumber
        //        );
        //    DateOfBirth = dateOfBirth;
        //}
    }
}
