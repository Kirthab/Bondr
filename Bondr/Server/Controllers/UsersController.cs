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
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
          if (_unitOfWork.User == null)
          {
              return NotFound();
          }
            var Users = await _unitOfWork.User.GetAll();
            return Ok(Users);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
          if (_unitOfWork.User == null)
          {
              return NotFound();
          }
            var User = await _unitOfWork.User.Get(q => q.Id == id);

            if (User == null)
            {
                return NotFound();
            }

            return Ok(User);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User User)
        {
            if (id != User.Id)
            {
                return BadRequest();
            }

            _unitOfWork.User.Update(User);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await UserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User User)
        {
          if (_unitOfWork.User == null)
          {
              return Problem("Entity set 'ApplicationDbContext.User'  is null.");
          }
            await _unitOfWork.User.Insert(User);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetUser", new { id = User.Id }, User);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_unitOfWork.User == null)
            {
                return NotFound();
            }
            var User = await _unitOfWork.User.Get(q => q.Id == id);
            if (User == null)
            {
                return NotFound();
            }

            await _unitOfWork.User.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> UserExists(int id)
        {
            var make = await _unitOfWork.User.Get(q => q.Id == id);
            return make != null;
        }
    }
}
