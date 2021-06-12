using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDISample.NorthwindDataSetTableAdapters;
namespace MDISample
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      LoadCustomers();
      LoadSuppliers();
    }
    private void LoadCustomers()
    {
      CustomersTableAdapter customersTableAdapter = new CustomersTableAdapter();
      NorthwindDataSet.CustomersDataTable customersDataTable = new NorthwindDataSet.CustomersDataTable();
      customersTableAdapter.Fill(customersDataTable);
      foreach (NorthwindDataSet.CustomersRow customerRow in customersDataTable)
      {
        TreeNode newNode = new TreeNode();
        newNode.Text = customerRow.CompanyName;
        newNode.Name = customerRow.CustomerID.ToString();
        newNode.Tag = "Customer";
        treeView1.Nodes.Find("nodeMusteriler", true)[0].Nodes.Add(newNode);
      }
    }
    private void LoadSuppliers()
    {
      SuppliersTableAdapter suppliersTableAdapter = new SuppliersTableAdapter();
      NorthwindDataSet.SuppliersDataTable suppliersDataTable = new NorthwindDataSet.SuppliersDataTable();
      suppliersTableAdapter.Fill(suppliersDataTable);
      foreach (NorthwindDataSet.SuppliersRow supplierRow in suppliersDataTable)
      {
        TreeNode newNode = new TreeNode();
        newNode.Text = supplierRow.CompanyName;
        newNode.Name = supplierRow.SupplierID.ToString();
        newNode.Tag = "Supplier";
        treeView1.Nodes.Find("nodeTedarikciler", true)[0].Nodes.Add(newNode);

      }
    }

    private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      TreeNode clickedNode = e.Node;
      if ((string)clickedNode.Tag == "Customer")
      {
        // MessageBox.Show(clickedNode.Text,"Test");
        frmCustomer customer = new frmCustomer(clickedNode.Name);
        customer.MdiParent = this;
        customer.Show();
      }
      else if ((string)clickedNode.Tag == "Supplier")
      {

      }
     
    }
  }
}

