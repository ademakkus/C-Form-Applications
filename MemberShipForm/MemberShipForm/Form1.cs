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
using System.Configuration;
namespace MemberShipForm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MemberShipConnectionString"].ToString());
    private void Form1_Load(object sender, EventArgs e)
    {
      for (int i = 1; i <=31; i++)
      {
        birthDaycomboBox.Items.Add(i);
      }
      for (int i = 1; i <=12; i++)
      {
        birthMonthcomboBox.Items.Add(i);
      }
      for (int i = 1950; i <= 2021; i++)
      {
        birthYearcomboBox.Items.Add(i);
      }
    }



    private void ClearAll()
    {
      userNameTextBox.Text = "";
      passwordTextBox.Text = "";
      birthYearcomboBox.SelectedIndex = -1;
      birthMonthcomboBox.SelectedIndex = -1;
      birthDaycomboBox.SelectedIndex = -1;
      maleradioButton.Checked = false;
      femaleradioButton.Checked = false;
      emailtextBox.Text = "";
      userNameTextBox.Focus();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string gender = (maleradioButton.Checked) ? "Male" : "Female";
      //insert codes
      string query= "INSERT INTO Member(username,password,birthdate,gender,email)VALUES(@username,@password,@birthdate,@gender,@email)";
      try
      {
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@username",userNameTextBox.Text);
        cmd.Parameters.AddWithValue("@password",passwordTextBox.Text);
        cmd.Parameters.AddWithValue("@birthdate",birthDaycomboBox.Text+"/"+birthMonthcomboBox.Text+"/"+birthYearcomboBox.Text);
        cmd.Parameters.AddWithValue("@gender",gender);
        cmd.Parameters.AddWithValue("@email",emailtextBox.Text);
        cmd.ExecuteNonQuery();
      }
      catch (SqlException ex)
      {
        string msg = "Insert error : ";
        msg += ex.Message;
        throw new Exception(msg);
      }
      finally
      {
        conn.Close();
        conn.Dispose();
      }
      ClearAll();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      //update codes
      ClearAll();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      //delete codes
      ClearAll();
    }

    private void exitbutton_Click(object sender, EventArgs e)
    {
      DialogResult dialog = MessageBox.Show("Are you sure to exit?","Exit",MessageBoxButtons.OKCancel);
      if (dialog == DialogResult.OK)
        Application.Exit();
    }
  }
}
