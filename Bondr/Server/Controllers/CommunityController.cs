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
    public class CommunitysController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommunitysController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Communitys
        [HttpGet]
        public async Task<IActionResult> GetCommunity()
        {
          if (_unitOfWork.Community == null)
          {
              return NotFound();
          }
            var Communitys = await _unitOfWork.Community.GetAll();
            return Ok(Communitys);
        }

        // GET: api/Communitys/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommunity(int id)
        {
          if (_unitOfWork.Community == null)
          {
              return NotFound();
          }
            var Community = await _unitOfWork.Community.Get(q => q.Id == id);

            if (Community == null)
            {
                return NotFound();
            }

            return Ok(Community);
        }

        // PUT: api/Communitys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommunity(int id, Community Community)
        {
            if (id != Community.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Community.Update(Community);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CommunityExists(id))
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

        // POST: api/Communitys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Community>> PostCommunity(Community Community)
        {
          if (_unitOfWork.Community == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Community'  is null.");
          }
            await _unitOfWork.Community.Insert(Community);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCommunity", new { id = Community.Id }, Community);
        }

        // DELETE: api/Communitys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommunity(int id)
        {
            if (_unitOfWork.Community == null)
            {
                return NotFound();
            }
            var Community = await _unitOfWork.Community.Get(q => q.Id == id);
            if (Community == null)
            {
                return NotFound();
            }

            await _unitOfWork.Community.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CommunityExists(int id)
        {
            var make = await _unitOfWork.Community.Get(q => q.Id == id);
            return make != null;
        }
    }
}
