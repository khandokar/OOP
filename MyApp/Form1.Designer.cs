
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
      this.txtName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtAccNumber = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.dtpDOB = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.cboCountry = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.dgvPerson = new System.Windows.Forms.DataGridView();
      this.btnClear = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
      this.SuspendLayout();
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(213, 12);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(933, 47);
      this.txtName.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 41);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name";
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(213, 66);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(933, 47);
      this.txtAddress.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 81);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 41);
      this.label2.TabIndex = 3;
      this.label2.Text = "Address";
      // 
      // txtAccNumber
      // 
      this.txtAccNumber.Location = new System.Drawing.Point(213, 120);
      this.txtAccNumber.Name = "txtAccNumber";
      this.txtAccNumber.Size = new System.Drawing.Size(933, 47);
      this.txtAccNumber.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(25, 134);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(120, 41);
      this.label3.TabIndex = 5;
      this.label3.Text = "Acc. No";
      // 
      // dtpDOB
      // 
      this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDOB.Location = new System.Drawing.Point(213, 174);
      this.dtpDOB.Name = "dtpDOB";
      this.dtpDOB.Size = new System.Drawing.Size(933, 47);
      this.dtpDOB.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 191);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(189, 41);
      this.label4.TabIndex = 7;
      this.label4.Text = "Date Of Birth";
      // 
      // cboCountry
      // 
      this.cboCountry.FormattingEnabled = true;
      this.cboCountry.Location = new System.Drawing.Point(213, 232);
      this.cboCountry.Name = "cboCountry";
      this.cboCountry.Size = new System.Drawing.Size(933, 49);
      this.cboCountry.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(29, 248);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(124, 41);
      this.label5.TabIndex = 9;
      this.label5.Text = "Country";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(211, 289);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(152, 58);
      this.button1.TabIndex = 10;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // dgvPerson
      // 
      this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPerson.Location = new System.Drawing.Point(211, 382);
      this.dgvPerson.Name = "dgvPerson";
      this.dgvPerson.RowHeadersWidth = 102;
      this.dgvPerson.RowTemplate.Height = 49;
      this.dgvPerson.Size = new System.Drawing.Size(935, 296);
      this.dgvPerson.TabIndex = 11;
      this.dgvPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellDoubleClick);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(387, 289);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(188, 58);
      this.btnClear.TabIndex = 12;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1174, 690);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.dgvPerson);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.cboCountry);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.dtpDOB);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtAccNumber);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtName);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtAccNumber;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DateTimePicker dtpDOB;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cboCountry;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dgvPerson;
    private System.Windows.Forms.Button btnClear;
  }
}

