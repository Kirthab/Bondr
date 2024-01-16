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
    public class StaffsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StaffsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs
        [HttpGet]
        public async Task<IActionResult> GetStaff()
        {
          if (_unitOfWork.Staff == null)
          {
              return NotFound();
          }
            var Staffs = await _unitOfWork.Staff.GetAll();
            return Ok(Staffs);
        }

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaff(int id)
        {
          if (_unitOfWork.Staff == null)
          {
              return NotFound();
          }
            var Staff = await _unitOfWork.Staff.Get(q => q.Id == id);

            if (Staff == null)
            {
                return NotFound();
            }

            return Ok(Staff);
        }

        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff Staff)
        {
            if (id != Staff.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Staff.Update(Staff);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await StaffExists(id))
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

        // POST: api/Staffs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff Staff)
        {
          if (_unitOfWork.Staff == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Staff'  is null.");
          }
            await _unitOfWork.Staff.Insert(Staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = Staff.Id }, Staff);
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            if (_unitOfWork.Staff == null)
            {
                return NotFound();
            }
            var Staff = await _unitOfWork.Staff.Get(q => q.Id == id);
            if (Staff == null)
            {
                return NotFound();
            }

            await _unitOfWork.Staff.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> StaffExists(int id)
        {
            var make = await _unitOfWork.Staff.Get(q => q.Id == id);
            return make != null;
        }
    }
}
