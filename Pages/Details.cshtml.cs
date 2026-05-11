using Final_Project_CIDM3312.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_CIDM3312.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public Player Player { get; set; } = default!;
        public List<Character> Characters { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Players.FirstOrDefaultAsync(p => p.PlayerID == id);

            if (player is null)
            {
                return NotFound();
            }

            Player = player;

            Characters = await _context.Characters.Include(c => c.Stats).Where(c => c.PlayerID == id).ToListAsync();

            return Page();
        }
    }
}