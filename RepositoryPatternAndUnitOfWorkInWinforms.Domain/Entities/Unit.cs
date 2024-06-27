namespace RepositoryPatternAndUnitOfWorkInWinforms.Domain.Entities
{
    public class Unit
    {
        public int Id { get; set; }
        public string? Unit_Name { get; set; }
        public int Packaging { get; set; }
        public decimal price { get; set; }
        public bool Stop { get; set; }
        public virtual Product? Product { get; set; }
    }
}
