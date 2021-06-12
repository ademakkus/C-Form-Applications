
namespace MDISample
{
  partial class frmCustomer
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label customerIDLabel;
      System.Windows.Forms.Label companyNameLabel;
      System.Windows.Forms.Label contactNameLabel;
      System.Windows.Forms.Label contactTitleLabel;
      System.Windows.Forms.Label addressLabel;
      System.Windows.Forms.Label cityLabel;
      System.Windows.Forms.Label regionLabel;
      System.Windows.Forms.Label postalCodeLabel;
      System.Windows.Forms.Label countryLabel;
      System.Windows.Forms.Label phoneLabel;
      System.Windows.Forms.Label faxLabel;
      this.northwindDataSet = new MDISample.NorthwindDataSet();
      this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.customersTableAdapter = new MDISample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
      this.tableAdapterManager = new MDISample.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.ordersTableAdapter = new MDISample.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.customerIDTextBox = new System.Windows.Forms.TextBox();
      this.companyNameTextBox = new System.Windows.Forms.TextBox();
      this.contactNameTextBox = new System.Windows.Forms.TextBox();
      this.contactTitleTextBox = new System.Windows.Forms.TextBox();
      this.addressTextBox = new System.Windows.Forms.TextBox();
      this.cityTextBox = new System.Windows.Forms.TextBox();
      this.regionTextBox = new System.Windows.Forms.TextBox();
      this.postalCodeTextBox = new System.Windows.Forms.TextBox();
      this.countryTextBox = new System.Windows.Forms.TextBox();
      this.phoneTextBox = new System.Windows.Forms.TextBox();
      this.faxTextBox = new System.Windows.Forms.TextBox();
      this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ordersDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      customerIDLabel = new System.Windows.Forms.Label();
      companyNameLabel = new System.Windows.Forms.Label();
      contactNameLabel = new System.Windows.Forms.Label();
      contactTitleLabel = new System.Windows.Forms.Label();
      addressLabel = new System.Windows.Forms.Label();
      cityLabel = new System.Windows.Forms.Label();
      regionLabel = new System.Windows.Forms.Label();
      postalCodeLabel = new System.Windows.Forms.Label();
      countryLabel = new System.Windows.Forms.Label();
      phoneLabel = new System.Windows.Forms.Label();
      faxLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // customerIDLabel
      // 
      customerIDLabel.AutoSize = true;
      customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      customerIDLabel.Location = new System.Drawing.Point(43, 54);
      customerIDLabel.Name = "customerIDLabel";
      customerIDLabel.Size = new System.Drawing.Size(78, 15);
      customerIDLabel.TabIndex = 1;
      customerIDLabel.Text = "Customer ID:";
      // 
      // companyNameLabel
      // 
      companyNameLabel.AutoSize = true;
      companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      companyNameLabel.Location = new System.Drawing.Point(43, 80);
      companyNameLabel.Name = "companyNameLabel";
      companyNameLabel.Size = new System.Drawing.Size(99, 15);
      companyNameLabel.TabIndex = 3;
      companyNameLabel.Text = "Company Name:";
      // 
      // contactNameLabel
      // 
      contactNameLabel.AutoSize = true;
      contactNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      contactNameLabel.Location = new System.Drawing.Point(43, 106);
      contactNameLabel.Name = "contactNameLabel";
      contactNameLabel.Size = new System.Drawing.Size(88, 15);
      contactNameLabel.TabIndex = 5;
      contactNameLabel.Text = "Contact Name:";
      // 
      // contactTitleLabel
      // 
      contactTitleLabel.AutoSize = true;
      contactTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      contactTitleLabel.Location = new System.Drawing.Point(43, 132);
      contactTitleLabel.Name = "contactTitleLabel";
      contactTitleLabel.Size = new System.Drawing.Size(77, 15);
      contactTitleLabel.TabIndex = 7;
      contactTitleLabel.Text = "Contact Title:";
      // 
      // addressLabel
      // 
      addressLabel.AutoSize = true;
      addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      addressLabel.Location = new System.Drawing.Point(43, 158);
      addressLabel.Name = "addressLabel";
      addressLabel.Size = new System.Drawing.Size(54, 15);
      addressLabel.TabIndex = 9;
      addressLabel.Text = "Address:";
      // 
      // cityLabel
      // 
      cityLabel.AutoSize = true;
      cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      cityLabel.Location = new System.Drawing.Point(43, 184);
      cityLabel.Name = "cityLabel";
      cityLabel.Size = new System.Drawing.Size(29, 15);
      cityLabel.TabIndex = 11;
      cityLabel.Text = "City:";
      // 
      // regionLabel
      // 
      regionLabel.AutoSize = true;
      regionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      regionLabel.Location = new System.Drawing.Point(43, 210);
      regionLabel.Name = "regionLabel";
      regionLabel.Size = new System.Drawing.Size(50, 15);
      regionLabel.TabIndex = 13;
      regionLabel.Text = "Region:";
      // 
      // postalCodeLabel
      // 
      postalCodeLabel.AutoSize = true;
      postalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      postalCodeLabel.Location = new System.Drawing.Point(43, 236);
      postalCodeLabel.Name = "postalCodeLabel";
      postalCodeLabel.Size = new System.Drawing.Size(76, 15);
      postalCodeLabel.TabIndex = 15;
      postalCodeLabel.Text = "Postal Code:";
      // 
      // countryLabel
      // 
      countryLabel.AutoSize = true;
      countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      countryLabel.Location = new System.Drawing.Point(43, 262);
      countryLabel.Name = "countryLabel";
      countryLabel.Size = new System.Drawing.Size(51, 15);
      countryLabel.TabIndex = 17;
      countryLabel.Text = "Country:";
      // 
      // phoneLabel
      // 
      phoneLabel.AutoSize = true;
      phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      phoneLabel.Location = new System.Drawing.Point(43, 288);
      phoneLabel.Name = "phoneLabel";
      phoneLabel.Size = new System.Drawing.Size(46, 15);
      phoneLabel.TabIndex = 19;
      phoneLabel.Text = "Phone:";
      // 
      // faxLabel
      // 
      faxLabel.AutoSize = true;
      faxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      faxLabel.Location = new System.Drawing.Point(43, 314);
      faxLabel.Name = "faxLabel";
      faxLabel.Size = new System.Drawing.Size(30, 15);
      faxLabel.TabIndex = 21;
      faxLabel.Text = "Fax:";
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // customersBindingSource
      // 
      this.customersBindingSource.DataMember = "Customers";
      this.customersBindingSource.DataSource = this.northwindDataSet;
      // 
      // customersTableAdapter
      // 
      this.customersTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CategoriesTableAdapter = null;
      this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
      this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
      this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
      this.tableAdapterManager.EmployeesTableAdapter = null;
      this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
      this.tableAdapterManager.Order_DetailsTableAdapter = null;
      this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
      this.tableAdapterManager.ProductsTableAdapter = null;
      this.tableAdapterManager.RegionTableAdapter = null;
      this.tableAdapterManager.ShippersTableAdapter = null;
      this.tableAdapterManager.SuppliersTableAdapter = null;
      this.tableAdapterManager.TerritoriesTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MDISample.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // ordersTableAdapter
      // 
      this.ordersTableAdapter.ClearBeforeFill = true;
      // 
      // customerIDTextBox
      // 
      this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
      this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.customerIDTextBox.Location = new System.Drawing.Point(183, 51);
      this.customerIDTextBox.Name = "customerIDTextBox";
      this.customerIDTextBox.Size = new System.Drawing.Size(206, 21);
      this.customerIDTextBox.TabIndex = 2;
      // 
      // companyNameTextBox
      // 
      this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
      this.companyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.companyNameTextBox.Location = new System.Drawing.Point(183, 77);
      this.companyNameTextBox.Name = "companyNameTextBox";
      this.companyNameTextBox.Size = new System.Drawing.Size(206, 21);
      this.companyNameTextBox.TabIndex = 4;
      // 
      // contactNameTextBox
      // 
      this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactName", true));
      this.contactNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.contactNameTextBox.Location = new System.Drawing.Point(183, 103);
      this.contactNameTextBox.Name = "contactNameTextBox";
      this.contactNameTextBox.Size = new System.Drawing.Size(206, 21);
      this.contactNameTextBox.TabIndex = 6;
      // 
      // contactTitleTextBox
      // 
      this.contactTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactTitle", true));
      this.contactTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.contactTitleTextBox.Location = new System.Drawing.Point(183, 129);
      this.contactTitleTextBox.Name = "contactTitleTextBox";
      this.contactTitleTextBox.Size = new System.Drawing.Size(206, 21);
      this.contactTitleTextBox.TabIndex = 8;
      // 
      // addressTextBox
      // 
      this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
      this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addressTextBox.Location = new System.Drawing.Point(183, 155);
      this.addressTextBox.Name = "addressTextBox";
      this.addressTextBox.Size = new System.Drawing.Size(206, 21);
      this.addressTextBox.TabIndex = 10;
      // 
      // cityTextBox
      // 
      this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
      this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cityTextBox.Location = new System.Drawing.Point(183, 181);
      this.cityTextBox.Name = "cityTextBox";
      this.cityTextBox.Size = new System.Drawing.Size(206, 21);
      this.cityTextBox.TabIndex = 12;
      // 
      // regionTextBox
      // 
      this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Region", true));
      this.regionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.regionTextBox.Location = new System.Drawing.Point(183, 207);
      this.regionTextBox.Name = "regionTextBox";
      this.regionTextBox.Size = new System.Drawing.Size(206, 21);
      this.regionTextBox.TabIndex = 14;
      // 
      // postalCodeTextBox
      // 
      this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "PostalCode", true));
      this.postalCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.postalCodeTextBox.Location = new System.Drawing.Point(183, 233);
      this.postalCodeTextBox.Name = "postalCodeTextBox";
      this.postalCodeTextBox.Size = new System.Drawing.Size(206, 21);
      this.postalCodeTextBox.TabIndex = 16;
      // 
      // countryTextBox
      // 
      this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country", true));
      this.countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.countryTextBox.Location = new System.Drawing.Point(183, 259);
      this.countryTextBox.Name = "countryTextBox";
      this.countryTextBox.Size = new System.Drawing.Size(206, 21);
      this.countryTextBox.TabIndex = 18;
      // 
      // phoneTextBox
      // 
      this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
      this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.phoneTextBox.Location = new System.Drawing.Point(183, 285);
      this.phoneTextBox.Name = "phoneTextBox";
      this.phoneTextBox.Size = new System.Drawing.Size(206, 21);
      this.phoneTextBox.TabIndex = 20;
      // 
      // faxTextBox
      // 
      this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Fax", true));
      this.faxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.faxTextBox.Location = new System.Drawing.Point(183, 311);
      this.faxTextBox.Name = "faxTextBox";
      this.faxTextBox.Size = new System.Drawing.Size(206, 21);
      this.faxTextBox.TabIndex = 22;
      // 
      // ordersBindingSource
      // 
      this.ordersBindingSource.DataMember = "FK_Orders_Customers";
      this.ordersBindingSource.DataSource = this.customersBindingSource;
      // 
      // ordersDataGridView
      // 
      this.ordersDataGridView.AutoGenerateColumns = false;
      this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
      this.ordersDataGridView.DataSource = this.ordersBindingSource;
      this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ordersDataGridView.Location = new System.Drawing.Point(0, 358);
      this.ordersDataGridView.Name = "ordersDataGridView";
      this.ordersDataGridView.RowHeadersWidth = 51;
      this.ordersDataGridView.Size = new System.Drawing.Size(873, 176);
      this.ordersDataGridView.TabIndex = 23;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
      this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 125;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
      this.dataGridViewTextBoxColumn2.HeaderText = "CustomerID";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Width = 125;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "EmployeeID";
      this.dataGridViewTextBoxColumn3.HeaderText = "EmployeeID";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.Width = 125;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
      this.dataGridViewTextBoxColumn4.HeaderText = "OrderDate";
      this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.Width = 125;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "RequiredDate";
      this.dataGridViewTextBoxColumn5.HeaderText = "RequiredDate";
      this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.Width = 125;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "ShippedDate";
      this.dataGridViewTextBoxColumn6.HeaderText = "ShippedDate";
      this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.Width = 125;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "ShipVia";
      this.dataGridViewTextBoxColumn7.HeaderText = "ShipVia";
      this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.Width = 125;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "Freight";
      this.dataGridViewTextBoxColumn8.HeaderText = "Freight";
      this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.Width = 125;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "ShipName";
      this.dataGridViewTextBoxColumn9.HeaderText = "ShipName";
      this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.Width = 125;
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "ShipAddress";
      this.dataGridViewTextBoxColumn10.HeaderText = "ShipAddress";
      this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.Width = 125;
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.DataPropertyName = "ShipCity";
      this.dataGridViewTextBoxColumn11.HeaderText = "ShipCity";
      this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.Width = 125;
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.DataPropertyName = "ShipRegion";
      this.dataGridViewTextBoxColumn12.HeaderText = "ShipRegion";
      this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.Width = 125;
      // 
      // dataGridViewTextBoxColumn13
      // 
      this.dataGridViewTextBoxColumn13.DataPropertyName = "ShipPostalCode";
      this.dataGridViewTextBoxColumn13.HeaderText = "ShipPostalCode";
      this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      this.dataGridViewTextBoxColumn13.Width = 125;
      // 
      // dataGridViewTextBoxColumn14
      // 
      this.dataGridViewTextBoxColumn14.DataPropertyName = "ShipCountry";
      this.dataGridViewTextBoxColumn14.HeaderText = "ShipCountry";
      this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      this.dataGridViewTextBoxColumn14.Width = 125;
      // 
      // frmCustomer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1091, 667);
      this.Controls.Add(this.ordersDataGridView);
      this.Controls.Add(customerIDLabel);
      this.Controls.Add(this.customerIDTextBox);
      this.Controls.Add(companyNameLabel);
      this.Controls.Add(this.companyNameTextBox);
      this.Controls.Add(contactNameLabel);
      this.Controls.Add(this.contactNameTextBox);
      this.Controls.Add(contactTitleLabel);
      this.Controls.Add(this.contactTitleTextBox);
      this.Controls.Add(addressLabel);
      this.Controls.Add(this.addressTextBox);
      this.Controls.Add(cityLabel);
      this.Controls.Add(this.cityTextBox);
      this.Controls.Add(regionLabel);
      this.Controls.Add(this.regionTextBox);
      this.Controls.Add(postalCodeLabel);
      this.Controls.Add(this.postalCodeTextBox);
      this.Controls.Add(countryLabel);
      this.Controls.Add(this.countryTextBox);
      this.Controls.Add(phoneLabel);
      this.Controls.Add(this.phoneTextBox);
      this.Controls.Add(faxLabel);
      this.Controls.Add(this.faxTextBox);
      this.Name = "frmCustomer";
      this.Text = "frmCustomer";
      this.Load += new System.EventHandler(this.frmCustomer_Load);
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private NorthwindDataSet northwindDataSet;
    private System.Windows.Forms.BindingSource customersBindingSource;
    private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.TextBox customerIDTextBox;
    private System.Windows.Forms.TextBox companyNameTextBox;
    private System.Windows.Forms.TextBox contactNameTextBox;
    private System.Windows.Forms.TextBox contactTitleTextBox;
    private System.Windows.Forms.TextBox addressTextBox;
    private System.Windows.Forms.TextBox cityTextBox;
    private System.Windows.Forms.TextBox regionTextBox;
    private System.Windows.Forms.TextBox postalCodeTextBox;
    private System.Windows.Forms.TextBox countryTextBox;
    private System.Windows.Forms.TextBox phoneTextBox;
    private System.Windows.Forms.TextBox faxTextBox;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    private System.Windows.Forms.BindingSource ordersBindingSource;
    private System.Windows.Forms.DataGridView ordersDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
  }
}