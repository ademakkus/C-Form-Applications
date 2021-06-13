using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
  public partial class Form2 : Form
  {
    private string _password;
    private string _userName;
    public Form2()
    {

    }
    public Form2(string username, string password)
    {
      
      InitializeComponent();
this._userName = username;
      this._password = password;
      label1.Text ="User name: "+ this._userName+" \nPassword : "+this._password;
      label1.ForeColor = Color.White;
     
      label1.BackColor = Color.Red;
    }

    private void Form2_Load(object sender, EventArgs e)
    {
    
     
    }
  }
}
