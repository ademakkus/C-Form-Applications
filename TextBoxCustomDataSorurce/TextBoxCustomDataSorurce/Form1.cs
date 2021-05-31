using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace TextBoxCustomDataSorurce
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
            string[] nameArray = { "Adem", "Gülten", "Ayşenur", "Kerem", "Can","Ali" };
      AutoCompleteStringCollection names = new AutoCompleteStringCollection();
      names.AddRange(nameArray);
      textBox8.AutoCompleteCustomSource = names;
      string[] hastaArray;
      AutoCompleteStringCollection hastalar = new AutoCompleteStringCollection();
      OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());
      try
      {
        
        string sorgu= "SELECT isim FROM tbl_Hasta";
        OleDbCommand cmd = new OleDbCommand(sorgu, conn);
       // cmd.CommandType = CommandType.Text;
      //  cmd.CommandText = "SELECT isim FROM tbl_Hasta";
       conn.Open();

        OleDbDataReader dr = cmd.ExecuteReader();

     //cmd.ExecuteReader();
        while (dr.Read())
        {
          hastalar.Add(dr.GetString(0));
          comboBox1.Items.Add(dr.GetString(0));
        }
      }
      catch (Exception exc)
      {

        MessageBox.Show(exc.Message.ToString(),"Veritabanı hatası");
      }
      finally
      {
   
        conn.Close();
      }
      textBox9.AutoCompleteCustomSource = hastalar;
    }
  }
}
