using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Controllers
{
    public class PhongController : Controller
    {
        //private readonly AppDbContext _context;

        //public PhongController(AppDbContext context)
        //{
        //    _context = context;
        //}

        //// GET: Phong
        //public async Task<IActionResult> Index()
        //{
        //    var phongs = _context.Phongs.Include(p => p.LoaiPhong);
        //    return View(await phongs.ToListAsync());
        //}

        //// GET: Phong/Create
        //public IActionResult Create()
        //{
        //    ViewData["MaLP"] = new SelectList(_context.LoaiPhongs, "MaLP", "LoaiPhongName");
        //    return View();
        //}

        //// POST: Phong/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("MaP,MaLP,GiaPhong,TrangThai")] Phong phong)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(phong);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["MaLP"] = new SelectList(_context.LoaiPhongs, "MaLP", "LoaiPhongName", phong.MaLP);
        //    return View(phong);
        //}

        //// GET: Phong/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null) return NotFound();

        //    var phong = await _context.Phongs.FindAsync(id);
        //    if (phong == null) return NotFound();

        //    ViewData["MaLP"] = new SelectList(_context.LoaiPhongs, "MaLP", "LoaiPhongName", phong.MaLP);
        //    return View(phong);
        //}

        //// POST: Phong/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("MaP,MaLP,GiaPhong,TrangThai")] Phong phong)
        //{
        //    if (id != phong.MaP) return NotFound();

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(phong);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!_context.Phongs.Any(e => e.MaP == id))
        //                return NotFound();
        //            else
        //                throw;
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["MaLP"] = new SelectList(_context.LoaiPhongs, "MaLP", "LoaiPhongName", phong.MaLP);
        //    return View(phong);
        //}

        //// GET: Phong/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null) return NotFound();

        //    var phong = await _context.Phongs
        //        .Include(p => p.LoaiPhong)
        //        .FirstOrDefaultAsync(m => m.MaP == id);

        //    if (phong == null) return NotFound();

        //    return View(phong);
        //}

        //// POST: Phong/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var phong = await _context.Phongs.FindAsync(id);
        //    _context.Phongs.Remove(phong);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
