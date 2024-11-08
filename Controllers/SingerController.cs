using Castle.Core.Resource;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZeneStreamingAPI.Context;
using ZeneStreamingAPI.Entities;

namespace ZeneStreamingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingerController : ControllerBase
    {
        private readonly StreamContext _context;
        public SingerController(StreamContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Singer>>> GetSinger()
        {
            return await _context.Singers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Singer>> GetSinger(int id)
        {
            var singer = await _context.Singers.FindAsync(id);

            if (singer == null)
            {
                return NotFound();
            }
            return singer;
        }


        [HttpPost]
        public async Task<ActionResult<Singer>> PostSinger(Singer singer)
        {
            _context.Singers.Add(singer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSinger), new { id = singer.Id }, singer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSinger(int id, Singer singer)
        {
            if (id != singer.Id)
            {
                return BadRequest();
            }

            _context.Entry(singer).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSinger(int id)
        {
            var singer = await _context.Singers.FindAsync(id);
            if (singer == null)
            {
                return NotFound();
            }

            _context.Singers.Remove(singer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
