using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace asp_geosystems_store.Models
{
    public class Customer
    {
        [Key]
        public int Id {get; set;}
        public string email {get; set;}
        public string password {get; set;}
        [DataType(DataType.Date)]
        public DateTime dob {get; set;}
        public int phone {get; set;}
        public string company {get; set;}
        [ForeignKey("Employee")]
        public Employee Employee {get;set;}



    }
}