using Microsoft.EntityFrameworkCore;
using RepositoryPatternAndUnitOfWorkInWinforms.EFCore.Interfaces;
using System.ComponentModel;

namespace RepositoryPatternAndUnitOfWorkInWinforms.Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        protected DbSet<T> _entities=null!;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<T>();
                return _entities;
            }
        }
        public BindingList<T> GetBindingList()
        {
            Entities.Load();
            return Entities.Local.ToBindingList();
        }
    }
}
