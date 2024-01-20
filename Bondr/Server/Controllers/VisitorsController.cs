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
    public class VisitorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VisitorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Visitors
        [HttpGet]
        public async Task<IActionResult> GetVisitor()
        {
          if (_unitOfWork.Visitor == null)
          {
              return NotFound();
          }
            var Visitors = await _unitOfWork.Visitor.GetAll();
            return Ok(Visitors);
        }

        // GET: api/Visitors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVisitor(int id)
        {
          if (_unitOfWork.Visitor == null)
          {
              return NotFound();
          }
            var Visitor = await _unitOfWork.Visitor.Get(q => q.Id == id);

            if (Visitor == null)
            {
                return NotFound();
            }

            return Ok(Visitor);
        }

        // PUT: api/Visitors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisitor(int id, Visitor Visitor)
        {
            if (id != Visitor.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Visitor.Update(Visitor);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VisitorExists(id))
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

        // POST: api/Visitors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Visitor>> PostVisitor(Visitor Visitor)
        {
          if (_unitOfWork.Visitor == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Visitor'  is null.");
          }
            await _unitOfWork.Visitor.Insert(Visitor);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVisitor", new { id = Visitor.Id }, Visitor);
        }

        // DELETE: api/Visitors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisitor(int id)
        {
            if (_unitOfWork.Visitor == null)
            {
                return NotFound();
            }
            var Visitor = await _unitOfWork.Visitor.Get(q => q.Id == id);
            if (Visitor == null)
            {
                return NotFound();
            }

            await _unitOfWork.Visitor.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VisitorExists(int id)
        {
            var make = await _unitOfWork.Visitor.Get(q => q.Id == id);
            return make != null;
        }
    }
}
