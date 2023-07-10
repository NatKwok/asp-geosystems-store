using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace asp_geosystems_store.Models
{
    public class Employee
    {
        [Key]
        public int Id {get; set;}
        public string email {get; set;}
        public string password {get; set;}
        [DataType(DataType.Date)]
        public DateTime dob {get; set;}
        public int phone {get; set;}
        public string department {get; set;}

    }
}