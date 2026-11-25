using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PA.FolioOne.Models;
using PA.FolioOne.Models.Entities;

namespace PA.FolioOne.Areas.ManagementPanel.Controllers
{
    [Area("ManagementPanel")]
    public class SocialLinksController : Controller
    {
        private readonly FolioOneDbContext _context;

        public SocialLinksController(FolioOneDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _context.SocialLinks
                .AsNoTracking()
                .OrderBy(x => x.Order)
                .ToListAsync();

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SocialLink model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var order = await _context.SocialLinks.MaxAsync(x => x.Order);

            model.Id = Guid.NewGuid();
            model.Order = (byte)(order + 1);
            await _context.SocialLinks.AddAsync(model);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(Guid id)
        {
            var model = await _context.SocialLinks.FindAsync(id);

            if (model is null)
                return RedirectToAction(nameof(Index));

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Guid id, SocialLink model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _context.SocialLinks.Update(model);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var model = await _context.SocialLinks.FindAsync(id);
            if (model is null)
                return Json(new { Success = false, Message = "Model bulunamadı!" });

            var items = await _context.SocialLinks
                .Where(x => x.Order > model.Order)
                .ToListAsync();

            foreach (var item in items)
                item.Order--;

            _context.SocialLinks.UpdateRange(items);

            _context.SocialLinks.Remove(model);
            await _context.SaveChangesAsync();

            return Json(new { Success = true, Message = "Model başarıyla silindi!" });
        }

        [HttpPost]
        public async Task<IActionResult> MoveUp(Guid id)
        {
            var model = await _context.SocialLinks.FindAsync(id);
            if (model is null)
                return Json(new { Success = false, Message = "Model bulunamadı!" });

            if (model.Order == 1)
                return Json(new { Success = false, Message = "Model zaten en üstte!" });

            var prev = await _context.SocialLinks
                .Where(x => x.Order == model.Order - 1)
                .FirstOrDefaultAsync();

            prev!.Order++;
            model.Order--;

            _context.SocialLinks.Update(prev);
            _context.SocialLinks.Update(model);
            await _context.SaveChangesAsync();

            return Json(new { Success = true, Message = "Model başarıyla yukarı taşındı!" });
        }

        [HttpPost]
        public async Task<IActionResult> MoveDown(Guid id)
        {
            var model = await _context.SocialLinks.FindAsync(id);
            if (model is null)
                return Json(new { Success = false, Message = "Model bulunamadı!" });

            var maxOrder = await _context.SocialLinks
                .AsNoTracking()
                .MaxAsync(x => x.Order);

            if (model.Order == maxOrder)
                return Json(new { Success = false, Message = "Model zaten en altta!" });

            var next = await _context.SocialLinks
                .Where(x => x.Order == model.Order + 1)
                .FirstOrDefaultAsync();

            next!.Order--;
            model.Order++;

            _context.SocialLinks.Update(next);
            _context.SocialLinks.Update(model);
            await _context.SaveChangesAsync();

            return Json(new { Success = true, Message = "Model başarıyla yukarı taşındı!" });
        }
    }
}
