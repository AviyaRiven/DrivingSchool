using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.dataObjects
{
    public class Persson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Adress Adress { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Persson(string id,
            string firstName,
            string lastName, 
            string phone, 
            string email, 
            string city, 
            string street, 
            string neighborhood, 
            int buildingNumber, 
            DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Phone = phone;
            Email = email;
            Adress = new Adress(city,neighborhood,street,buildingNumber);
            DateOfBirth = dateOfBirth;
        }
    }
}
