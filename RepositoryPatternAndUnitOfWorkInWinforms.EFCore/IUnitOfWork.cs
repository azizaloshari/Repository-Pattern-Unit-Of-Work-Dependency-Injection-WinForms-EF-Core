using RepositoryPatternAndUnitOfWorkInWinforms.Domain.Entities;
using RepositoryPatternAndUnitOfWorkInWinforms.EFCore.Interfaces;


namespace RepositoryPatternAndUnitOfWorkInWinforms.EFCore
{
    public interface IUnitOfWork
    {
        IBaseRepository<Product> Products { get; }
        int SaveChanges();
        Task SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

    }
}
