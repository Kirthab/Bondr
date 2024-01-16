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
    public class PostsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Posts
        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
          if (_unitOfWork.Post == null)
          {
              return NotFound();
          }
            var Posts = await _unitOfWork.Post.GetAll();
            return Ok(Posts);
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
          if (_unitOfWork.Post == null)
          {
              return NotFound();
          }
            var Post = await _unitOfWork.Post.Get(q => q.Id == id);

            if (Post == null)
            {
                return NotFound();
            }

            return Ok(Post);
        }

        // PUT: api/Posts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(int id, Post Post)
        {
            if (id != Post.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Post.Update(Post);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PostExists(id))
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

        // POST: api/Posts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post Post)
        {
          if (_unitOfWork.Post == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Post'  is null.");
          }
            await _unitOfWork.Post.Insert(Post);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPost", new { id = Post.Id }, Post);
        }

        // DELETE: api/Posts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            if (_unitOfWork.Post == null)
            {
                return NotFound();
            }
            var Post = await _unitOfWork.Post.Get(q => q.Id == id);
            if (Post == null)
            {
                return NotFound();
            }

            await _unitOfWork.Post.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PostExists(int id)
        {
            var make = await _unitOfWork.Post.Get(q => q.Id == id);
            return make != null;
        }
    }
}
