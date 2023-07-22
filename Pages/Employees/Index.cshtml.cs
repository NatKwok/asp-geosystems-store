using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_geosystems_store.Data;
using asp_geosystems_store.Models;

namespace asp_geosystems_store.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly asp_geosystems_store.Data.ApplicationDbContext _context;

        public IndexModel(asp_geosystems_store.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employees != null)
            {
                Employee = await _context.Employees.ToListAsync();
            }
        }
    }
}
