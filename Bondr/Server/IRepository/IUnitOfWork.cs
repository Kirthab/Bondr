using Bondr.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bondr.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Comment> Comment { get; }
        IGenericRepository<Community> Community { get; }
        IGenericRepository<Genre> Genre { get; }
        IGenericRepository<Post> Post { get; }
        IGenericRepository<Staff> Staff { get; }
        IGenericRepository<Subscription> Subscription { get; }
        IGenericRepository<User> User { get; }
    }
}