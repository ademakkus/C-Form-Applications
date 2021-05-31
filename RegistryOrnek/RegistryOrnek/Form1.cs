using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegistryOrnek
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    
      Registry.CurrentUser.CreateSubKey("AA");
      Registry.CurrentUser.CreateSubKey("AA").SetValue("adem", 3);
//Registry.Users.SetValue("adem", 3);
      textBox1.Text = Registry.CurrentUser.GetValue("kullanici").ToString();
     textBox2.Text = Registry.CurrentUser.GetValue("sifre").ToString();
     checkBox1.Checked = Convert.ToBoolean(Registry.CurrentUser.GetValue("hatirlaBeni"));
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Registry.CurrentUser.SetValue("kullanici", textBox1.Text);
      Registry.CurrentUser.SetValue("sifre", textBox2.Text);
      Registry.CurrentUser.SetValue("hatirlaBeni", checkBox1.Checked.ToString());
    }
  }
}
