
namespace MinMaxAverageOf100Numbers
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
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(0, 0);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(192, 753);
      this.listBox1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button1.ForeColor = System.Drawing.Color.Blue;
      this.button1.Location = new System.Drawing.Point(205, 201);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(212, 104);
      this.button1.TabIndex = 1;
      this.button1.Text = "Generate 100 Numbers Between 1 And 1000";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
      this.label1.Location = new System.Drawing.Point(460, 80);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(266, 24);
      this.label1.TabIndex = 2;
      this.label1.Text = "Numbers of positive numbers :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.ForeColor = System.Drawing.Color.Teal;
      this.label2.Location = new System.Drawing.Point(463, 128);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(279, 24);
      this.label2.TabIndex = 3;
      this.label2.Text = "Numbers of negative  numbers :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
      this.label3.Location = new System.Drawing.Point(466, 281);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(104, 24);
      this.label3.TabIndex = 4;
      this.label3.Text = "Avreage is:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
      this.label4.Location = new System.Drawing.Point(466, 322);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 24);
      this.label4.TabIndex = 5;
      this.label4.Text = "Sum is: ";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
      this.label5.Location = new System.Drawing.Point(466, 165);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(240, 24);
      this.label5.TabIndex = 3;
      this.label5.Text = "Numbers of notr  numbers :";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label6.ForeColor = System.Drawing.Color.Red;
      this.label6.Location = new System.Drawing.Point(466, 201);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(56, 24);
      this.label6.TabIndex = 3;
      this.label6.Text = "Max :";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label7.ForeColor = System.Drawing.Color.Green;
      this.label7.Location = new System.Drawing.Point(463, 242);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(51, 24);
      this.label7.TabIndex = 3;
      this.label7.Text = "Min :";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 753);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.listBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

