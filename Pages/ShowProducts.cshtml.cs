using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_geosystems_store.Data;
using asp_geosystems_store.Models;
using System.Runtime.CompilerServices;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

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

        public async Task OnGetAsync() {
            Products = await db.Products.ToListAsync();
            OrderItems = await db.OrderItems.Include(oi => oi.Product).ToListAsync();

        }

        public async Task<IActionResult> OnPostAsync() {

            return Page();

        }

    }
}
