
namespace FormPrint
{
  partial class Form1
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
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Asus  Bilgisayar",
            "100",
            "150",
            "TL"}, -1);
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Fare",
            "200",
            "100",
            "TL"}, -1);
      System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "SD Disk",
            "500",
            "400",
            "TL"}, -1);
      System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Anakart",
            "1000",
            "100"}, -1);
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.lvProducts = new System.Windows.Forms.ListView();
      this.btnFirst = new System.Windows.Forms.Button();
      this.btnPrevious = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.btnLast = new System.Windows.Forms.Button();
      this.btnPageSetup = new System.Windows.Forms.Button();
      this.btnPreview = new System.Windows.Forms.Button();
      this.btnPrint = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.lblLocation = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtSum = new System.Windows.Forms.TextBox();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.printDocument1 = new System.Drawing.Printing.PrintDocument();
      this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
      this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      this.SuspendLayout();
      // 
      // lvProducts
      // 
      this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
      this.lvProducts.Dock = System.Windows.Forms.DockStyle.Top;
      this.lvProducts.FullRowSelect = true;
      this.lvProducts.GridLines = true;
      this.lvProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lvProducts.HideSelection = false;
      this.lvProducts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
      this.lvProducts.Location = new System.Drawing.Point(0, 0);
      this.lvProducts.Name = "lvProducts";
      this.lvProducts.Size = new System.Drawing.Size(1043, 282);
      this.lvProducts.TabIndex = 0;
      this.lvProducts.UseCompatibleStateImageBehavior = false;
      this.lvProducts.View = System.Windows.Forms.View.Details;
      this.lvProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvProducts_KeyDown);
      this.lvProducts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvProducts_KeyUp);
      this.lvProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseClick);
      // 
      // btnFirst
      // 
      this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnFirst.Location = new System.Drawing.Point(34, 323);
      this.btnFirst.Name = "btnFirst";
      this.btnFirst.Size = new System.Drawing.Size(93, 29);
      this.btnFirst.TabIndex = 1;
      this.btnFirst.Text = "<<";
      this.btnFirst.UseVisualStyleBackColor = true;
      this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
      // 
      // btnPrevious
      // 
      this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnPrevious.Location = new System.Drawing.Point(170, 323);
      this.btnPrevious.Name = "btnPrevious";
      this.btnPrevious.Size = new System.Drawing.Size(93, 29);
      this.btnPrevious.TabIndex = 2;
      this.btnPrevious.Text = "<";
      this.btnPrevious.UseVisualStyleBackColor = true;
      this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
      // 
      // btnNext
      // 
      this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnNext.Location = new System.Drawing.Point(404, 324);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(93, 29);
      this.btnNext.TabIndex = 3;
      this.btnNext.Text = ">";
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // btnLast
      // 
      this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnLast.Location = new System.Drawing.Point(540, 323);
      this.btnLast.Name = "btnLast";
      this.btnLast.Size = new System.Drawing.Size(93, 29);
      this.btnLast.TabIndex = 4;
      this.btnLast.Text = ">>";
      this.btnLast.UseVisualStyleBackColor = true;
      this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
      // 
      // btnPageSetup
      // 
      this.btnPageSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnPageSetup.Location = new System.Drawing.Point(203, 409);
      this.btnPageSetup.Name = "btnPageSetup";
      this.btnPageSetup.Size = new System.Drawing.Size(160, 33);
      this.btnPageSetup.TabIndex = 5;
      this.btnPageSetup.Text = "Sayfa Ayarları";
      this.btnPageSetup.UseVisualStyleBackColor = true;
      this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
      // 
      // btnPreview
      // 
      this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnPreview.Location = new System.Drawing.Point(388, 409);
      this.btnPreview.Name = "btnPreview";
      this.btnPreview.Size = new System.Drawing.Size(152, 33);
      this.btnPreview.TabIndex = 6;
      this.btnPreview.Text = "Baskı Önizleme";
      this.btnPreview.UseVisualStyleBackColor = true;
      this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
      // 
      // btnPrint
      // 
      this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnPrint.Location = new System.Drawing.Point(595, 409);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(82, 33);
      this.btnPrint.TabIndex = 8;
      this.btnPrint.Text = "Yazdir";
      this.btnPrint.UseVisualStyleBackColor = true;
      this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
      // 
      // btnExit
      // 
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnExit.Location = new System.Drawing.Point(739, 409);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(82, 33);
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = "Çıkış";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // lblLocation
      // 
      this.lblLocation.AutoSize = true;
      this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblLocation.Location = new System.Drawing.Point(287, 334);
      this.lblLocation.Name = "lblLocation";
      this.lblLocation.Size = new System.Drawing.Size(60, 20);
      this.lblLocation.TabIndex = 10;
      this.lblLocation.Text = "10 / 10";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(684, 321);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(113, 20);
      this.label2.TabIndex = 11;
      this.label2.Text = "Toplam Tutar:";
      // 
      // txtSum
      // 
      this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtSum.Location = new System.Drawing.Point(815, 318);
      this.txtSum.Name = "txtSum";
      this.txtSum.Size = new System.Drawing.Size(192, 26);
      this.txtSum.TabIndex = 12;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Ürün Adı";
      this.columnHeader1.Width = 431;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Adet";
      this.columnHeader2.Width = 83;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Ürün Fiyat";
      this.columnHeader3.Width = 109;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "";
      // 
      // printDocument1
      // 
      this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
      // 
      // pageSetupDialog1
      // 
      this.pageSetupDialog1.Document = this.printDocument1;
      // 
      // printPreviewDialog1
      // 
      this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
      this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
      this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.Enabled = true;
      this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
      this.printPreviewDialog1.Name = "printPreviewDialog1";
      this.printPreviewDialog1.Visible = false;
      this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
      // 
      // printDialog1
      // 
      this.printDialog1.UseEXDialog = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1043, 586);
      this.Controls.Add(this.txtSum);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblLocation);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnPrint);
      this.Controls.Add(this.btnPreview);
      this.Controls.Add(this.btnPageSetup);
      this.Controls.Add(this.btnLast);
      this.Controls.Add(this.btnNext);
      this.Controls.Add(this.btnPrevious);
      this.Controls.Add(this.btnFirst);
      this.Controls.Add(this.lvProducts);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lvProducts;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.Button btnFirst;
    private System.Windows.Forms.Button btnPrevious;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnLast;
    private System.Windows.Forms.Button btnPageSetup;
    private System.Windows.Forms.Button btnPreview;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label lblLocation;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSum;
    private System.Drawing.Printing.PrintDocument printDocument1;
    private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    private System.Windows.Forms.PrintDialog printDialog1;
  }
}

