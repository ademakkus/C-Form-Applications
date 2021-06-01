
namespace PrintApp
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      this.btnPrint = new System.Windows.Forms.Button();
      this.printDocument1 = new System.Drawing.Printing.PrintDocument();
      this.btnPageSetup = new System.Windows.Forms.Button();
      this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
      this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
      this.btnPrintPreview = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // printDialog1
      // 
      this.printDialog1.AllowSelection = true;
      this.printDialog1.AllowSomePages = true;
      this.printDialog1.PrintToFile = true;
      this.printDialog1.ShowHelp = true;
      this.printDialog1.UseEXDialog = true;
      // 
      // btnPrint
      // 
      this.btnPrint.Location = new System.Drawing.Point(166, 283);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(135, 56);
      this.btnPrint.TabIndex = 0;
      this.btnPrint.Text = "Print";
      this.btnPrint.UseVisualStyleBackColor = true;
      this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
      // 
      // printDocument1
      // 
      this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
      this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
      this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
      // 
      // btnPageSetup
      // 
      this.btnPageSetup.Location = new System.Drawing.Point(343, 282);
      this.btnPageSetup.Name = "btnPageSetup";
      this.btnPageSetup.Size = new System.Drawing.Size(130, 56);
      this.btnPageSetup.TabIndex = 1;
      this.btnPageSetup.Text = "Page Setup";
      this.btnPageSetup.UseVisualStyleBackColor = true;
      this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
      // 
      // pageSetupDialog1
      // 
      this.pageSetupDialog1.Document = this.printDocument1;
      // 
      // printPreviewDialog1
      // 
      this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
      this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
      this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.Enabled = true;
      this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
      this.printPreviewDialog1.Name = "printPreviewDialog1";
      this.printPreviewDialog1.UseAntiAlias = true;
      this.printPreviewDialog1.Visible = false;
      // 
      // btnPrintPreview
      // 
      this.btnPrintPreview.Location = new System.Drawing.Point(502, 282);
      this.btnPrintPreview.Name = "btnPrintPreview";
      this.btnPrintPreview.Size = new System.Drawing.Size(159, 57);
      this.btnPrintPreview.TabIndex = 2;
      this.btnPrintPreview.Text = "Pirnt Preview";
      this.btnPrintPreview.UseVisualStyleBackColor = true;
      this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnPrintPreview);
      this.Controls.Add(this.btnPageSetup);
      this.Controls.Add(this.btnPrint);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PrintDialog printDialog1;
    private System.Windows.Forms.Button btnPrint;
    private System.Drawing.Printing.PrintDocument printDocument1;
    private System.Windows.Forms.Button btnPageSetup;
    private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    private System.Windows.Forms.Button btnPrintPreview;
  }
}

