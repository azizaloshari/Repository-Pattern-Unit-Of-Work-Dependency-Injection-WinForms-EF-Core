using RepositoryPatternAndUnitOfWorkInWinforms.EFCore;

namespace RepositoryPatternAndUnitOfWorkInWinforms.App
{
    internal static class AppUnit
    {
        internal static  IUnitOfWork? SetUnitOfWork { get; set; }
        private static IUnitOfWork? _uow;
        internal static IUnitOfWork? UOW => _uow ??= SetUnitOfWork;



    }
}
