
namespace CountWovelSounds
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.vowelslabel = new System.Windows.Forms.Label();
      this.consonantslabel = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.textBox1.Location = new System.Drawing.Point(208, 45);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(488, 28);
      this.textBox1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(29, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(125, 24);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter the text:";
      // 
      // vowelslabel
      // 
      this.vowelslabel.AutoSize = true;
      this.vowelslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.vowelslabel.Location = new System.Drawing.Point(327, 202);
      this.vowelslabel.Name = "vowelslabel";
      this.vowelslabel.Size = new System.Drawing.Size(177, 24);
      this.vowelslabel.TabIndex = 2;
      this.vowelslabel.Text = "Number of vowels : ";
      // 
      // consonantslabel
      // 
      this.consonantslabel.AutoSize = true;
      this.consonantslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.consonantslabel.Location = new System.Drawing.Point(313, 236);
      this.consonantslabel.Name = "consonantslabel";
      this.consonantslabel.Size = new System.Drawing.Size(211, 24);
      this.consonantslabel.TabIndex = 3;
      this.consonantslabel.Text = "Number of consonants: ";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button1.Location = new System.Drawing.Point(247, 97);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(322, 81);
      this.button1.TabIndex = 4;
      this.button1.Text = "Count the wovels and consonants sounds";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.consonantslabel);
      this.Controls.Add(this.vowelslabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label vowelslabel;
    private System.Windows.Forms.Label consonantslabel;
    private System.Windows.Forms.Button button1;
  }
}

