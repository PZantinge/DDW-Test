using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FarmNumberGuessing.Data
{
    public interface IGameContext
    {
        DbSet<Game> Games { get; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        DatabaseFacade Database { get; }
    }
}