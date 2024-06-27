
using System.ComponentModel;

namespace RepositoryPatternAndUnitOfWorkInWinforms.EFCore.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        BindingList<T> GetBindingList();

    }
}
