using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project_CIDM3312.Models;

namespace Final_Project_CIDM3312.Pages_Characters
{
    public class IndexModel : PageModel
    {
        private readonly Final_Project_CIDM3312.Models.AppDbContext _context;

        public IndexModel(Final_Project_CIDM3312.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Character = await _context.Characters.ToListAsync();
        }
    }
}
