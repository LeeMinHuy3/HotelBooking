using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Models;
using System;

namespace HotelBooking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NguoiDungController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NguoiDungController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/NguoiDung
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NguoiDung>>> GetAll()
        {
            return await _context.NguoiDungs.ToListAsync();
        }

        // GET: api/NguoiDung/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NguoiDung>> GetById(int id)
        {
            var nguoiDung = await _context.NguoiDungs.FindAsync(id);

            if (nguoiDung == null)
            {
                return NotFound();
            }

            return nguoiDung;
        }

        // POST: api/NguoiDung
        [HttpPost]
        public async Task<ActionResult<NguoiDung>> Create(NguoiDung nguoiDung)
        {
            _context.NguoiDungs.Add(nguoiDung);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = nguoiDung.MaND }, nguoiDung);
        }

        // PUT: api/NguoiDung/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, NguoiDung nguoiDung)
        {
            if (id != nguoiDung.MaND)
            {
                return BadRequest();
            }

            _context.Entry(nguoiDung).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/NguoiDung/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var nguoiDung = await _context.NguoiDungs.FindAsync(id);
            if (nguoiDung == null)
            {
                return NotFound();
            }

            _context.NguoiDungs.Remove(nguoiDung);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
