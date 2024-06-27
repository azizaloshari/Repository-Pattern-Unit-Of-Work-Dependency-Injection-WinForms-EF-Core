using RepositoryPatternAndUnitOfWorkInWinforms.EFCore;

namespace RepositoryPatternAndUnitOfWorkInWinforms.App
{
    public partial class Form1 : Form
    {
        private readonly IUnitOfWork? _unitwork;
        private readonly BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();
             _unitwork = AppUnit.UOW;
            //_unitwork = Program._UOW;

            bindingSource = new BindingSource();
            bindingSource.DataSource = typeof(Domain.Entities.Product);
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            bindingSource.DataSource = _unitwork.Products.GetBindingList();
            dgProduct.DataSource = bindingSource;
            dgProductUnits.DataBindings.Add(new Binding("DataSource", this.bindingSource, "Units"));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            _unitwork.SaveChangesAsync();
        }
    }
}