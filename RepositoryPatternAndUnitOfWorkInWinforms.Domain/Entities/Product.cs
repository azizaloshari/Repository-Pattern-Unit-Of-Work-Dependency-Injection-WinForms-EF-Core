using System.ComponentModel;
using static RepositoryPatternAndUnitOfWorkInWinforms.Domain.MyEnum;

namespace RepositoryPatternAndUnitOfWorkInWinforms.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public ProductType Type { get; set; }
        public virtual IList<Unit>? Units { get; private set; }
            = new BindingList<Unit>();

    }
}
