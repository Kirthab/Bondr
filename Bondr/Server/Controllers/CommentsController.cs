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
    public class CommentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Comments
        [HttpGet]
        public async Task<IActionResult> GetComment()
        {
          if (_unitOfWork.Comment == null)
          {
              return NotFound();
          }
            var Comments = await _unitOfWork.Comment.GetAll();
            return Ok(Comments);
        }

        // GET: api/Comments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
          if (_unitOfWork.Comment == null)
          {
              return NotFound();
          }
            var Comment = await _unitOfWork.Comment.Get(q => q.Id == id);

            if (Comment == null)
            {
                return NotFound();
            }

            return Ok(Comment);
        }

        // PUT: api/Comments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComment(int id, Comment Comment)
        {
            if (id != Comment.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Comment.Update(Comment);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CommentExists(id))
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

        // POST: api/Comments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comment>> PostComment(Comment Comment)
        {
          if (_unitOfWork.Comment == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Comment'  is null.");
          }
            await _unitOfWork.Comment.Insert(Comment);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetComment", new { id = Comment.Id }, Comment);
        }

        // DELETE: api/Comments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            if (_unitOfWork.Comment == null)
            {
                return NotFound();
            }
            var Comment = await _unitOfWork.Comment.Get(q => q.Id == id);
            if (Comment == null)
            {
                return NotFound();
            }

            await _unitOfWork.Comment.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CommentExists(int id)
        {
            var make = await _unitOfWork.Comment.Get(q => q.Id == id);
            return make != null;
        }
    }
}
