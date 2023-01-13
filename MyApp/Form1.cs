using MyApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
    }

    private void dgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnClear_Click(object sender, EventArgs e)
    {

    }

    private void btnProduct_Click(object sender, EventArgs e)
    {
      form1 p = new form1();
      p.ShowDialog();
    }
  }
}
