using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.DTOs
{
    public class StudentDTO:PersonDTO
    {
        public int Status { get; set; }
        public StudentDTO(string id, string firstName,
            string lastName,
            string phone,
            string email,
            string city,
            string street,
            string neighborhood,
            int buildingNumbere,
            DateTime dateOfBirth,
            int status) : base(id, firstName, lastName, phone, email, city, street, neighborhood, buildingNumbere, dateOfBirth)
        {
            Status = status;
        }
    }
}
