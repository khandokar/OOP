
namespace MyApp
{
  partial class form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.gvProduct = new System.Windows.Forms.DataGridView();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
      this.Delete1 = new System.Windows.Forms.DataGridViewLinkColumn();
      this.btnSave = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
      this.SuspendLayout();
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(181, 97);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(600, 47);
      this.txtName.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(62, 97);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 41);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name";
      // 
      // gvProduct
      // 
      this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name1,
            this.CreateTime,
            this.Edit,
            this.Delete1});
      this.gvProduct.Location = new System.Drawing.Point(181, 280);
      this.gvProduct.Name = "gvProduct";
      this.gvProduct.RowHeadersWidth = 102;
      this.gvProduct.RowTemplate.Height = 49;
      this.gvProduct.Size = new System.Drawing.Size(1586, 407);
      this.gvProduct.TabIndex = 2;
      this.gvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProduct_CellClick);
      // 
      // Id
      // 
      this.Id.DataPropertyName = "Id";
      this.Id.HeaderText = "Id";
      this.Id.MinimumWidth = 12;
      this.Id.Name = "Id";
      this.Id.Width = 250;
      // 
      // Name1
      // 
      this.Name1.DataPropertyName = "Name";
      this.Name1.HeaderText = "Name";
      this.Name1.MinimumWidth = 12;
      this.Name1.Name = "Name1";
      this.Name1.Width = 250;
      // 
      // CreateTime
      // 
      this.CreateTime.DataPropertyName = "CreateTime";
      this.CreateTime.HeaderText = "CreateTime";
      this.CreateTime.MinimumWidth = 12;
      this.CreateTime.Name = "CreateTime";
      this.CreateTime.Width = 250;
      // 
      // Edit
      // 
      this.Edit.DataPropertyName = "Edit";
      this.Edit.HeaderText = "Edit";
      this.Edit.LinkColor = System.Drawing.Color.Blue;
      this.Edit.MinimumWidth = 12;
      this.Edit.Name = "Edit";
      this.Edit.Text = "Edit";
      this.Edit.UseColumnTextForLinkValue = true;
      this.Edit.Width = 250;
      // 
      // Delete
      // 
      this.Delete1.HeaderText = "Delete";
      this.Delete1.MinimumWidth = 12;
      this.Delete1.Name = "Delete";
      this.Delete1.Text = "Delete";
      this.Delete1.UseColumnTextForLinkValue = true;
      this.Delete1.Width = 250;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(181, 169);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(188, 58);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1798, 716);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.gvProduct);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtName);
      this.Name = "form1";
      this.Text = "Product";
      this.Load += new System.EventHandler(this.frmProduct_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView gvProduct;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
    private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    private System.Windows.Forms.DataGridViewLinkColumn Edit;
    private System.Windows.Forms.DataGridViewLinkColumn Delete1;
  }
}