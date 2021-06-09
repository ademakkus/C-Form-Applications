
namespace MDISample
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.müşteriBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aktifFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.yatayHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dikeyHizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.arrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aktifFormToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.layoutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriBilgileriToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // müşteriBilgileriToolStripMenuItem
      // 
      this.müşteriBilgileriToolStripMenuItem.Name = "müşteriBilgileriToolStripMenuItem";
      this.müşteriBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.müşteriBilgileriToolStripMenuItem.Text = "Müşteri Bilgileri";
      this.müşteriBilgileriToolStripMenuItem.Click += new System.EventHandler(this.müşteriBilgileriToolStripMenuItem_Click);
      // 
      // aktifFormToolStripMenuItem
      // 
      this.aktifFormToolStripMenuItem.Name = "aktifFormToolStripMenuItem";
      this.aktifFormToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
      this.aktifFormToolStripMenuItem.Text = "Aktif Form";
      this.aktifFormToolStripMenuItem.Click += new System.EventHandler(this.aktifFormToolStripMenuItem_Click);
      // 
      // windowToolStripMenuItem
      // 
      this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
      this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
      this.windowToolStripMenuItem.Text = "Window";
      // 
      // layoutToolStripMenuItem
      // 
      this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.yatayHizalaToolStripMenuItem,
            this.dikeyHizalaToolStripMenuItem,
            this.arrangeToolStripMenuItem});
      this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
      this.layoutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.layoutToolStripMenuItem.Text = "Layout";
      // 
      // cascadeToolStripMenuItem
      // 
      this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
      this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.cascadeToolStripMenuItem.Text = "Cascade";
      this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
      // 
      // yatayHizalaToolStripMenuItem
      // 
      this.yatayHizalaToolStripMenuItem.Name = "yatayHizalaToolStripMenuItem";
      this.yatayHizalaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.yatayHizalaToolStripMenuItem.Text = "Yatay Hizala";
      this.yatayHizalaToolStripMenuItem.Click += new System.EventHandler(this.yatayHizalaToolStripMenuItem_Click);
      // 
      // dikeyHizalaToolStripMenuItem
      // 
      this.dikeyHizalaToolStripMenuItem.Name = "dikeyHizalaToolStripMenuItem";
      this.dikeyHizalaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.dikeyHizalaToolStripMenuItem.Text = "Dikey Hizala";
      this.dikeyHizalaToolStripMenuItem.Click += new System.EventHandler(this.dikeyHizalaToolStripMenuItem_Click);
      // 
      // arrangeToolStripMenuItem
      // 
      this.arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
      this.arrangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.arrangeToolStripMenuItem.Text = "Arrange";
      this.arrangeToolStripMenuItem.Click += new System.EventHandler(this.arrangeToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
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
    private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aktifFormToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem yatayHizalaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dikeyHizalaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem arrangeToolStripMenuItem;
  }
}

