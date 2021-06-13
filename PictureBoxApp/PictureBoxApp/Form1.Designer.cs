
namespace PictureBoxApp
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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.btnResimAc = new System.Windows.Forms.Button();
      this.btnResimDonustur = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
      this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.btnResimDonustur);
      this.splitContainer1.Panel2.Controls.Add(this.btnResimAc);
      this.splitContainer1.Size = new System.Drawing.Size(1072, 840);
      this.splitContainer1.SplitterDistance = 602;
      this.splitContainer1.TabIndex = 0;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(456, 602);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
      this.pictureBox2.Location = new System.Drawing.Point(577, 0);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(495, 602);
      this.pictureBox2.TabIndex = 1;
      this.pictureBox2.TabStop = false;
      // 
      // btnResimAc
      // 
      this.btnResimAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnResimAc.ForeColor = System.Drawing.Color.Red;
      this.btnResimAc.Location = new System.Drawing.Point(72, 62);
      this.btnResimAc.Name = "btnResimAc";
      this.btnResimAc.Size = new System.Drawing.Size(207, 78);
      this.btnResimAc.TabIndex = 0;
      this.btnResimAc.Text = "Resmi Aç";
      this.btnResimAc.UseVisualStyleBackColor = true;
      this.btnResimAc.Click += new System.EventHandler(this.btnResimAc_Click);
      // 
      // btnResimDonustur
      // 
      this.btnResimDonustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnResimDonustur.ForeColor = System.Drawing.Color.Red;
      this.btnResimDonustur.Location = new System.Drawing.Point(470, 62);
      this.btnResimDonustur.Name = "btnResimDonustur";
      this.btnResimDonustur.Size = new System.Drawing.Size(207, 78);
      this.btnResimDonustur.TabIndex = 1;
      this.btnResimDonustur.Text = "Dönüştür";
      this.btnResimDonustur.UseVisualStyleBackColor = true;
      this.btnResimDonustur.Click += new System.EventHandler(this.btnResimDonustur_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1072, 840);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnResimDonustur;
    private System.Windows.Forms.Button btnResimAc;
  }
}

