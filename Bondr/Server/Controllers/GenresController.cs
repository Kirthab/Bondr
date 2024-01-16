using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bondr.Server.Data;
using Bondr.Shared.Domain;
using Bondr.Server.IRepository;
using System.Runtime.CompilerServices;

namespace Bondr.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenresController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Genres
        [HttpGet]
        public async Task<IActionResult> GetGenre()
        {
          if (_unitOfWork.Genre == null)
          {
              return NotFound();
          }
            var genres = await _unitOfWork.Genre.GetAll();
            return Ok(genres);
        }

        // GET: api/Genres/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGenre(int id)
        {
          if (_unitOfWork.Genre == null)
          {
              return NotFound();
          }
            var genre = await _unitOfWork.Genre.Get(q => q.Id == id);

            if (genre == null)
            {
                return NotFound();
            }

            return Ok(genre);
        }

        // PUT: api/Genres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenre(int id, Genre genre)
        {
            if (id != genre.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Genre.Update(genre);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await GenreExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Genres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Genre>> PostGenre(Genre genre)
        {
          if (_unitOfWork.Genre == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Genre'  is null.");
          }
            await _unitOfWork.Genre.Insert(genre);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetGenre", new { id = genre.Id }, genre);
        }

        // DELETE: api/Genres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            if (_unitOfWork.Genre == null)
            {
                return NotFound();
            }
            var genre = await _unitOfWork.Genre.Get(q => q.Id == id);
            if (genre == null)
            {
                return NotFound();
            }

            await _unitOfWork.Genre.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> GenreExists(int id)
        {
            var make = await _unitOfWork.Genre.Get(q => q.Id == id);
            return make != null;
        }
    }
}
