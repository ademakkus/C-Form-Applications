
namespace SinemaBiletSatis
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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label33 = new System.Windows.Forms.Label();
      this.lblSatisTutari = new System.Windows.Forms.Label();
      this.lblBos = new System.Windows.Forms.Label();
      this.lblRezerve = new System.Windows.Forms.Label();
      this.lblSatilmis = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnPrint = new System.Windows.Forms.Button();
      this.btnPreview = new System.Windows.Forms.Button();
      this.btnPageSetup = new System.Windows.Forms.Button();
      this.cmbSeans = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.flpSalon = new System.Windows.Forms.FlowLayoutPanel();
      this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
      this.printDocument1 = new System.Drawing.Printing.PrintDocument();
      this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
      this.splitContainer1.Panel1.Controls.Add(this.btnExit);
      this.splitContainer1.Panel1.Controls.Add(this.btnPrint);
      this.splitContainer1.Panel1.Controls.Add(this.btnPreview);
      this.splitContainer1.Panel1.Controls.Add(this.btnPageSetup);
      this.splitContainer1.Panel1.Controls.Add(this.cmbSeans);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.flpSalon);
      this.splitContainer1.Size = new System.Drawing.Size(1272, 607);
      this.splitContainer1.SplitterDistance = 236;
      this.splitContainer1.SplitterWidth = 5;
      this.splitContainer1.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label33);
      this.groupBox1.Controls.Add(this.lblSatisTutari);
      this.groupBox1.Controls.Add(this.lblBos);
      this.groupBox1.Controls.Add(this.lblRezerve);
      this.groupBox1.Controls.Add(this.lblSatilmis);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox1.Location = new System.Drawing.Point(695, 0);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
      this.groupBox1.Size = new System.Drawing.Size(577, 236);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Satış Bilgileri";
      // 
      // label33
      // 
      this.label33.AutoSize = true;
      this.label33.Location = new System.Drawing.Point(45, 65);
      this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label33.Name = "label33";
      this.label33.Size = new System.Drawing.Size(173, 20);
      this.label33.TabIndex = 8;
      this.label33.Text = "Rezerve Koltuk Sayıs:";
      this.label33.Click += new System.EventHandler(this.label3_Click);
      // 
      // lblSatisTutari
      // 
      this.lblSatisTutari.AutoSize = true;
      this.lblSatisTutari.Location = new System.Drawing.Point(291, 132);
      this.lblSatisTutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblSatisTutari.Name = "lblSatisTutari";
      this.lblSatisTutari.Size = new System.Drawing.Size(56, 20);
      this.lblSatisTutari.TabIndex = 7;
      this.lblSatisTutari.Text = ".00 TL";
      // 
      // lblBos
      // 
      this.lblBos.AutoSize = true;
      this.lblBos.Location = new System.Drawing.Point(291, 98);
      this.lblBos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblBos.Name = "lblBos";
      this.lblBos.Size = new System.Drawing.Size(18, 20);
      this.lblBos.TabIndex = 6;
      this.lblBos.Text = "0";
      // 
      // lblRezerve
      // 
      this.lblRezerve.AutoSize = true;
      this.lblRezerve.Location = new System.Drawing.Point(291, 65);
      this.lblRezerve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblRezerve.Name = "lblRezerve";
      this.lblRezerve.Size = new System.Drawing.Size(18, 20);
      this.lblRezerve.TabIndex = 5;
      this.lblRezerve.Text = "0";
      // 
      // lblSatilmis
      // 
      this.lblSatilmis.AutoSize = true;
      this.lblSatilmis.Location = new System.Drawing.Point(291, 34);
      this.lblSatilmis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblSatilmis.Name = "lblSatilmis";
      this.lblSatilmis.Size = new System.Drawing.Size(18, 20);
      this.lblSatilmis.TabIndex = 4;
      this.lblSatilmis.Text = "0";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(41, 132);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(100, 20);
      this.label5.TabIndex = 3;
      this.label5.Text = "Satış Tutarı:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(41, 98);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(145, 20);
      this.label4.TabIndex = 2;
      this.label4.Text = "Boş Koltuk Sayısı:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(41, 34);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(175, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "Satılmış Koltuk Sayısı:";
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.Color.Yellow;
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnExit.ForeColor = System.Drawing.Color.Blue;
      this.btnExit.Location = new System.Drawing.Point(487, 106);
      this.btnExit.Margin = new System.Windows.Forms.Padding(4);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(147, 64);
      this.btnExit.TabIndex = 5;
      this.btnExit.Text = "Çıkış";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnPrint
      // 
      this.btnPrint.BackColor = System.Drawing.Color.Yellow;
      this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnPrint.ForeColor = System.Drawing.Color.Blue;
      this.btnPrint.Location = new System.Drawing.Point(331, 106);
      this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(147, 64);
      this.btnPrint.TabIndex = 4;
      this.btnPrint.Text = "Yazdır";
      this.btnPrint.UseVisualStyleBackColor = false;
      this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
      // 
      // btnPreview
      // 
      this.btnPreview.BackColor = System.Drawing.Color.Yellow;
      this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnPreview.ForeColor = System.Drawing.Color.Blue;
      this.btnPreview.Location = new System.Drawing.Point(173, 106);
      this.btnPreview.Margin = new System.Windows.Forms.Padding(4);
      this.btnPreview.Name = "btnPreview";
      this.btnPreview.Size = new System.Drawing.Size(147, 64);
      this.btnPreview.TabIndex = 3;
      this.btnPreview.Text = "Baskı Önizleme";
      this.btnPreview.UseVisualStyleBackColor = false;
      this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
      // 
      // btnPageSetup
      // 
      this.btnPageSetup.BackColor = System.Drawing.Color.Yellow;
      this.btnPageSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnPageSetup.ForeColor = System.Drawing.Color.Blue;
      this.btnPageSetup.Location = new System.Drawing.Point(16, 106);
      this.btnPageSetup.Margin = new System.Windows.Forms.Padding(4);
      this.btnPageSetup.Name = "btnPageSetup";
      this.btnPageSetup.Size = new System.Drawing.Size(147, 64);
      this.btnPageSetup.TabIndex = 2;
      this.btnPageSetup.Text = "Sayfa Ayarları";
      this.btnPageSetup.UseVisualStyleBackColor = false;
      this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
      // 
      // cmbSeans
      // 
      this.cmbSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.cmbSeans.FormattingEnabled = true;
      this.cmbSeans.Location = new System.Drawing.Point(109, 25);
      this.cmbSeans.Margin = new System.Windows.Forms.Padding(4);
      this.cmbSeans.Name = "cmbSeans";
      this.cmbSeans.Size = new System.Drawing.Size(367, 30);
      this.cmbSeans.TabIndex = 1;
      this.cmbSeans.SelectedIndexChanged += new System.EventHandler(this.cmbSeans_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(16, 23);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Seans:";
      // 
      // flpSalon
      // 
      this.flpSalon.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpSalon.Location = new System.Drawing.Point(0, 0);
      this.flpSalon.Margin = new System.Windows.Forms.Padding(4);
      this.flpSalon.Name = "flpSalon";
      this.flpSalon.Size = new System.Drawing.Size(1272, 366);
      this.flpSalon.TabIndex = 0;
      // 
      // pageSetupDialog1
      // 
      this.pageSetupDialog1.Document = this.printDocument1;
      // 
      // printDocument1
      // 
      this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
      // printDialog1
      // 
      this.printDialog1.Document = this.printDocument1;
      this.printDialog1.UseEXDialog = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1272, 607);
      this.Controls.Add(this.splitContainer1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "..:: Sinema Film Satış ::..";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblSatisTutari;
    private System.Windows.Forms.Label lblBos;
    private System.Windows.Forms.Label lblRezerve;
    private System.Windows.Forms.Label lblSatilmis;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.Button btnPreview;
    private System.Windows.Forms.Button btnPageSetup;
    private System.Windows.Forms.ComboBox cmbSeans;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.FlowLayoutPanel flpSalon;
    private System.Windows.Forms.Label label33;
    private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    private System.Drawing.Printing.PrintDocument printDocument1;
    private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    private System.Windows.Forms.PrintDialog printDialog1;
  }
}

