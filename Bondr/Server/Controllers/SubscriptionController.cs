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
    public class SubscriptionsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubscriptionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Subscriptions
        [HttpGet]
        public async Task<IActionResult> GetSubscription()
        {
          if (_unitOfWork.Subscription == null)
          {
              return NotFound();
          }
            var Subscriptions = await _unitOfWork.Subscription.GetAll();
            return Ok(Subscriptions);
        }

        // GET: api/Subscriptions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubscription(int id)
        {
          if (_unitOfWork.Subscription == null)
          {
              return NotFound();
          }
            var Subscription = await _unitOfWork.Subscription.Get(q => q.Id == id);

            if (Subscription == null)
            {
                return NotFound();
            }

            return Ok(Subscription);
        }

        // PUT: api/Subscriptions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubscription(int id, Subscription Subscription)
        {
            if (id != Subscription.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Subscription.Update(Subscription);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SubscriptionExists(id))
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

        // POST: api/Subscriptions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Subscription>> PostSubscription(Subscription Subscription)
        {
          if (_unitOfWork.Subscription == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Subscription'  is null.");
          }
            await _unitOfWork.Subscription.Insert(Subscription);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSubscription", new { id = Subscription.Id }, Subscription);
        }

        // DELETE: api/Subscriptions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubscription(int id)
        {
            if (_unitOfWork.Subscription == null)
            {
                return NotFound();
            }
            var Subscription = await _unitOfWork.Subscription.Get(q => q.Id == id);
            if (Subscription == null)
            {
                return NotFound();
            }

            await _unitOfWork.Subscription.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SubscriptionExists(int id)
        {
            var make = await _unitOfWork.Subscription.Get(q => q.Id == id);
            return make != null;
        }
    }
}
