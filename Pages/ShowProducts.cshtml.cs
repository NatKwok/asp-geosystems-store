using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_geosystems_store.Data;
using asp_geosystems_store.Models;

namespace asp_geosystems_store.Pages
{
    public class ShowProductsModel : PageModel
    {
        public int Id { get; set; }
        private ApplicationDbContext db;
        public ShowProductsModel(ApplicationDbContext db) => this.db = db;

        public List<Product> Products {get; set;}
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Product Product {get; set;}
        public int totalItems { get; set; } = 0;
        public double totalPrice { get; set; } = 0;
        public double totalTax { get; set; } = 0;
        public double grandTotal { get; set; } = 0;
        public string ShoppingCartId { get; set; }


        public async Task OnGetAsync() {
            Products = await db.Products.ToListAsync();
            OrderItems = await db.OrderItems.Include(oi => oi.Product).ToListAsync();

        }

        public async Task<IActionResult> OnPostAsync() {

            string itemIndex = Request.Form["Order"];
            int itemInt = Int32.Parse(itemIndex);
            Product add = db.Products.ToList().ElementAt(itemInt - 1);

            //Define cartItem
            //Retreive cartItem
            //If cartItem not found, then add new one
            //If cartItem is found, add quantity
            OrderItem cartItem = new OrderItem { Product = add, CustomProduct = add.Name, ProductPrice = (float)add.Price, Quantity = 1 };

            if (OrderItems.Contains(cartItem))
            {   
                foreach(OrderItem item in OrderItems){
                    if (item.Equals(cartItem)) {
                        item.Quantity++;
                        
                    }
                } 

            }

            else {
                db.OrderItems.Add(cartItem);

            }
            // db.OrderItems.Add(cartItem);
            db.SaveChanges();

            Products = await db.Products.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();

            return Page();

        }

    }
}
