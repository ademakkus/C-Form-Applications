using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDISample
{
  public partial class frmCustomer : Form
  {
    private string _customerID;
    public frmCustomer(string customerID)
    {
      
      InitializeComponent();
      _customerID = customerID;
    }

    private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      //this.Validate();
      //this.customersBindingSource.EndEdit();
      //this.tableAdapterManager.UpdateAll(this.northwindDataSet);

    }

    private void frmCustomer_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'northwindDataSet.Orders' table. You can move, or remove it, as needed.
      this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
      // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
      this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
      this.customersBindingSource.Filter = "CustomerId='"+_customerID+"'";

    }
  }
}
