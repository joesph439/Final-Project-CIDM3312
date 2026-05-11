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

        public IList<Character> Characters { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;
        public async Task OnGetAsync()
        {
            Characters = await _context.Characters.Include(c => c.Stats).Include(c => c.Player).Skip((PageNum - 1) * PageSize).Take(PageSize).ToListAsync();

            TotalPages = (int)Math.Ceiling(_context.Characters.Count() / (double)PageSize);

            var query = _context.Characters.Include(c => c.Stats).Include(c => c.Player).AsQueryable();
            switch (CurrentSort)
            {
                case "name_asc":
                    query = query.OrderBy(c => c.Name);
                    break;

                case "name_desc":
                    query = query.OrderByDescending(c => c.Name);
                    break;

                case "class_asc":
                    query = query.OrderBy(c => c.Class);
                    break;

                case "class_desc":
                    query = query.OrderByDescending(c => c.Class);
                    break;

                case "level_asc":
                    query = query.OrderBy(c => c.Level);
                    break;

                case "level_desc":
                    query = query.OrderByDescending(c => c.Level);
                    break;

                default:
                    query = query.OrderBy(c => c.Name);
                    break;
            }

        }
    }
}
