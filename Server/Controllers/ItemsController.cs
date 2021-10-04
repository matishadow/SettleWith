using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SettleWith.Server.Data;

namespace SettleWith.Server.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("/items")]
        public async Task<IActionResult> Index()
        {
            var items = await _context.Items.ToListAsync();

            return Ok(items);
        }
    }
}