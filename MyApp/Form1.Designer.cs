
namespace WinFormsApp1
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
      this.dgvOrder = new System.Windows.Forms.DataGridView();
      this.btnCustomer = new System.Windows.Forms.Button();
      this.btnProduct = new System.Windows.Forms.Button();
      this.btnOrder = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvOrder
      // 
      this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvOrder.Location = new System.Drawing.Point(39, 204);
      this.dgvOrder.Name = "dgvOrder";
      this.dgvOrder.RowHeadersWidth = 102;
      this.dgvOrder.RowTemplate.Height = 49;
      this.dgvOrder.Size = new System.Drawing.Size(1109, 457);
      this.dgvOrder.TabIndex = 11;
      this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellDoubleClick);
      // 
      // btnCustomer
      // 
      this.btnCustomer.Location = new System.Drawing.Point(58, 40);
      this.btnCustomer.Name = "btnCustomer";
      this.btnCustomer.Size = new System.Drawing.Size(221, 91);
      this.btnCustomer.TabIndex = 12;
      this.btnCustomer.Text = "Add Customer";
      this.btnCustomer.UseVisualStyleBackColor = true;
      // 
      // btnProduct
      // 
      this.btnProduct.Location = new System.Drawing.Point(345, 40);
      this.btnProduct.Name = "btnProduct";
      this.btnProduct.Size = new System.Drawing.Size(228, 92);
      this.btnProduct.TabIndex = 13;
      this.btnProduct.Text = "Add Product";
      this.btnProduct.UseVisualStyleBackColor = true;
      this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
      // 
      // btnOrder
      // 
      this.btnOrder.Location = new System.Drawing.Point(650, 41);
      this.btnOrder.Name = "btnOrder";
      this.btnOrder.Size = new System.Drawing.Size(188, 91);
      this.btnOrder.TabIndex = 14;
      this.btnOrder.Text = "Add Order";
      this.btnOrder.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1174, 690);
      this.Controls.Add(this.btnOrder);
      this.Controls.Add(this.btnProduct);
      this.Controls.Add(this.btnCustomer);
      this.Controls.Add(this.dgvOrder);
      this.Name = "Form1";
      this.Text = "Order Collection";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView dgvOrder;
    private System.Windows.Forms.Button btnCustomer;
    private System.Windows.Forms.Button btnProduct;
    private System.Windows.Forms.Button btnOrder;
  }
}

