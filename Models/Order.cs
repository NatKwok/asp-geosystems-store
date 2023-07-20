using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace asp_geosystems_store.Models {

    public class Order {

        [Key]
        public int Id {get; set;}
        public IdentityUser Customer {get; set;}

        [Column(TypeName="money")]
        public decimal Total {get; set;}

        [Column(TypeName="money")]
        public decimal DeliveryCost {get; set;}

        [Column(TypeName="money")]
        public decimal Tax {get; set;}
        public ICollection<Product> Products {get; set;}
    }
}