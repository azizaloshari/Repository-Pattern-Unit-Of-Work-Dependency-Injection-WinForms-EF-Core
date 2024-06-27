using RepositoryPatternAndUnitOfWorkInWinforms.Domain.Entities;
using RepositoryPatternAndUnitOfWorkInWinforms.EFCore;
using RepositoryPatternAndUnitOfWorkInWinforms.EFCore.Interfaces;
using RepositoryPatternAndUnitOfWorkInWinforms.Infrastructure.Repository;

namespace RepositoryPatternAndUnitOfWorkInWinforms.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _AppDbContext;
        //private bool _disposed;

        #region Declare Interfaces of IUnitOfWork
        private IBaseRepository<Product>? _Product;
        #endregion
        public UnitOfWork(ApplicationDbContext context)
        {
            _AppDbContext = context;
        }
        #region
        public IBaseRepository<Product> Products => _Product ?? (_Product = new BaseRepository<Product>(_AppDbContext));

        #endregion

        //protected void Dispose(bool disposing)
        //{
        //    if (!this._disposed)
        //    {
        //        if (disposing)
        //            _AppDbContext.Dispose();
        //    }
        //    this._disposed = true;
        //}
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        public int SaveChanges()
        {
            return _AppDbContext.SaveChanges();
        }

        public Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _AppDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
