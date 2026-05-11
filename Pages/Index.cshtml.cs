using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Final_Project_CIDM3312.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_CIDM3312.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public List<Player> Players { get; set; } = default!;

    public async Task OnGetAsync()
    {

        Players = await _context.Players.Include(p => p.Characters).ToListAsync();
    }
}