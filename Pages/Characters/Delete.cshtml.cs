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
    public class DeleteModel : PageModel
    {
        private readonly Final_Project_CIDM3312.Models.AppDbContext _context;

        public DeleteModel(Final_Project_CIDM3312.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Character Character { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FirstOrDefaultAsync(m => m.CharacterID == id);

            if (character is not null)
            {
                Character = character;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(id);
            if (character != null)
            {
                Character = character;
                _context.Characters.Remove(Character);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
