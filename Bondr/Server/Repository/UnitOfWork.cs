using Bondr.Server.Data;
using Bondr.Server.IRepository;
using Bondr.Server.Models;
using Bondr.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Bondr.Server.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Comment> _comments;
        private IGenericRepository<Community> _communities;
        private IGenericRepository<Genre> _genres;
        private IGenericRepository<Post> _posts;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Subscription> _subscriptions;
        private IGenericRepository<Visitor> _visitors;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Comment> Comment
            => _comments ??= new GenericRepository<Comment>(_context);
        public IGenericRepository<Community> Community
            => _communities ??= new GenericRepository<Community>(_context);
        public IGenericRepository<Genre> Genre
            => _genres ??= new GenericRepository<Genre>(_context);
        public IGenericRepository<Post> Post
            => _posts ??= new GenericRepository<Post>(_context);
        public IGenericRepository<Staff> Staff
            => _staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<Subscription> Subscription
            => _subscriptions ??= new GenericRepository<Subscription>(_context);
        public IGenericRepository<Visitor> Visitor
            => _visitors ??= new GenericRepository<Visitor>(_context);

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}