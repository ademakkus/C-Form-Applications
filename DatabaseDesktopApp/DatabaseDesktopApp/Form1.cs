using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDesktopApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
      string connectionString = @"Data Source =.; Initial Catalog = Northwind; Integrated Security = True";
      try
      {
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.CommandText = "SELECT * FROM Customers";
        sqlCommand.Connection = conn;
        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        dataGridView1.DataSource = dataTable;
      }
      catch (SqlException ex)
      {
        MessageBox.Show(ex.Message,"Test");
     //  throw;
      }
    }
  }
}
