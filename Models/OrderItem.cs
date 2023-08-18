using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace asp_geosystems_store.Models
{

    public class OrderItem
    {

        [Key]
        public int Id { get; set; }
        //public string Product {get; set;}
        public Product Product { get; set; } // NULL of custom burger is used
        public string CustomProduct { get; set; }
        public float ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

    }
}