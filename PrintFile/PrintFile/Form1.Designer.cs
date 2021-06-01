
namespace PrintFile
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
      this.printDocument1 = new System.Drawing.Printing.PrintDocument();
      this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // pageSetupToolStripMenuItem
      // 
      this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
      this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.pageSetupToolStripMenuItem.Text = "Page Setup";
      this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.printToolStripMenuItem.Text = "&Print";
      this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
      // 
      // printPreviewToolStripMenuItem
      // 
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.printPreviewToolStripMenuItem.Text = "Print Preview";
      this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
      // 
      // openFileToolStripMenuItem
      // 
      this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
      this.openFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.openFileToolStripMenuItem.Text = "&Open File";
      this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.quitToolStripMenuItem.Text = "&Quit";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // printDialog1
      // 
      this.printDialog1.UseEXDialog = true;
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
      this.printPreviewDialog1.Visible = false;
      // 
      // printDocument1
      // 
      this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
      // 
      // pageSetupDialog1
      // 
      this.pageSetupDialog1.Document = this.printDocument1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.PrintDialog printDialog1;
    private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    private System.Drawing.Printing.PrintDocument printDocument1;
    private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
  }
}

