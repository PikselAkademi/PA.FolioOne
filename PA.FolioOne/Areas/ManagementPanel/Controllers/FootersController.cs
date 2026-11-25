using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PA.FolioOne.Models;
using PA.FolioOne.Models.Entities;

namespace PA.FolioOne.Areas.ManagementPanel.Controllers
{
    [Area("ManagementPanel")]
    public class FootersController : Controller
    {
        private readonly FolioOneDbContext _context;

        public FootersController(FolioOneDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _context.Footers.FirstOrDefaultAsync();
            if (model is null)
            {
                model = new Footer
                {
                    Id = Guid.NewGuid(),
                    CreditText = string.Empty,
                    CreditLink = string.Empty,
                    Copyright = string.Empty,
                };

                await _context.Footers.AddAsync(model);
                await _context.SaveChangesAsync();
            }

            return View(model);
        }
    }
}
