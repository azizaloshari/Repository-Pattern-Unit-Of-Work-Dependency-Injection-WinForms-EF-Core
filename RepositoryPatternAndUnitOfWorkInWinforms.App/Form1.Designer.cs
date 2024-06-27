namespace RepositoryPatternAndUnitOfWorkInWinforms.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgProduct = new DataGridView();
            dgProductUnits = new DataGridView();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProductUnits).BeginInit();
            SuspendLayout();
            // 
            // dgProduct
            // 
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(12, 1);
            dgProduct.Name = "dgProduct";
            dgProduct.RowTemplate.Height = 25;
            dgProduct.Size = new Size(651, 175);
            dgProduct.TabIndex = 0;
            // 
            // dgProductUnits
            // 
            dgProductUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductUnits.Location = new Point(12, 175);
            dgProductUnits.Name = "dgProductUnits";
            dgProductUnits.RowTemplate.Height = 25;
            dgProductUnits.Size = new Size(651, 147);
            dgProductUnits.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(281, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 362);
            Controls.Add(btnSave);
            Controls.Add(dgProductUnits);
            Controls.Add(dgProduct);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Units";
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProductUnits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProduct;
        private DataGridView dgProductUnits;
        private Button btnSave;
    }
}