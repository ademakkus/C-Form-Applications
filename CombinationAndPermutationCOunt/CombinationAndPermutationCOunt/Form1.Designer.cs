
namespace CombinationAndPermutationCOunt
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.btnBirinci = new System.Windows.Forms.Button();
      this.btnIkinci = new System.Windows.Forms.Button();
      this.btnPermutation = new System.Windows.Forms.Button();
      this.btnCombination = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(13, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Birinci Sayı:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(16, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(81, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "İkinci Sayı: ";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.numericUpDown1.Location = new System.Drawing.Point(111, 26);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(120, 24);
      this.numericUpDown1.TabIndex = 2;
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.numericUpDown2.Location = new System.Drawing.Point(111, 55);
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(120, 24);
      this.numericUpDown2.TabIndex = 3;
      // 
      // btnBirinci
      // 
      this.btnBirinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnBirinci.ForeColor = System.Drawing.Color.Red;
      this.btnBirinci.Location = new System.Drawing.Point(31, 128);
      this.btnBirinci.Name = "btnBirinci";
      this.btnBirinci.Size = new System.Drawing.Size(186, 54);
      this.btnBirinci.TabIndex = 4;
      this.btnBirinci.Text = "Birinci Sayının Faktöriyelini Al";
      this.btnBirinci.UseVisualStyleBackColor = true;
      this.btnBirinci.Click += new System.EventHandler(this.btnBirinci_Click);
      // 
      // btnIkinci
      // 
      this.btnIkinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnIkinci.ForeColor = System.Drawing.Color.Red;
      this.btnIkinci.Location = new System.Drawing.Point(251, 128);
      this.btnIkinci.Name = "btnIkinci";
      this.btnIkinci.Size = new System.Drawing.Size(186, 54);
      this.btnIkinci.TabIndex = 5;
      this.btnIkinci.Text = "İkinci Sayının Faktöriyelini Al";
      this.btnIkinci.UseVisualStyleBackColor = true;
      this.btnIkinci.Click += new System.EventHandler(this.btnIkinci_Click);
      // 
      // btnPermutation
      // 
      this.btnPermutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnPermutation.ForeColor = System.Drawing.Color.DarkSlateGray;
      this.btnPermutation.Location = new System.Drawing.Point(31, 214);
      this.btnPermutation.Name = "btnPermutation";
      this.btnPermutation.Size = new System.Drawing.Size(186, 54);
      this.btnPermutation.TabIndex = 6;
      this.btnPermutation.Text = "Permütasyon Hesapla";
      this.btnPermutation.UseVisualStyleBackColor = true;
      this.btnPermutation.Click += new System.EventHandler(this.btnPermutation_Click);
      // 
      // btnCombination
      // 
      this.btnCombination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCombination.ForeColor = System.Drawing.Color.DarkSlateGray;
      this.btnCombination.Location = new System.Drawing.Point(251, 214);
      this.btnCombination.Name = "btnCombination";
      this.btnCombination.Size = new System.Drawing.Size(186, 54);
      this.btnCombination.TabIndex = 7;
      this.btnCombination.Text = "Kombinasyon Hesapla";
      this.btnCombination.UseVisualStyleBackColor = true;
      this.btnCombination.Click += new System.EventHandler(this.btnCombination_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(533, 25);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(255, 404);
      this.listBox1.TabIndex = 8;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.btnCombination);
      this.Controls.Add(this.btnPermutation);
      this.Controls.Add(this.btnIkinci);
      this.Controls.Add(this.btnBirinci);
      this.Controls.Add(this.numericUpDown2);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Button btnBirinci;
    private System.Windows.Forms.Button btnIkinci;
    private System.Windows.Forms.Button btnPermutation;
    private System.Windows.Forms.Button btnCombination;
    private System.Windows.Forms.ListBox listBox1;
  }
}

