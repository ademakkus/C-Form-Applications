
namespace TextBoxCustomDataSorurce
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
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textBox9 = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Çorum",
            "Kırşehir"});
      this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.textBox1.Location = new System.Drawing.Point(360, 44);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(303, 30);
      this.textBox1.TabIndex = 0;
      // 
      // textBox2
      // 
      this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
      this.textBox2.Location = new System.Drawing.Point(360, 90);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(303, 22);
      this.textBox2.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(34, 52);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(287, 18);
      this.label1.TabIndex = 2;
      this.label1.Text = "Auto Complete Custom Data Source:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(156, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(165, 18);
      this.label2.TabIndex = 3;
      this.label2.Text = "All System Sources: ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(210, 128);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(111, 18);
      this.label3.TabIndex = 3;
      this.label3.Text = "File System : ";
      // 
      // textBox3
      // 
      this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.textBox3.Location = new System.Drawing.Point(360, 128);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(303, 22);
      this.textBox3.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.Location = new System.Drawing.Point(222, 166);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(99, 18);
      this.label4.TabIndex = 3;
      this.label4.Text = "History List:";
      // 
      // textBox4
      // 
      this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
      this.textBox4.Location = new System.Drawing.Point(360, 166);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(303, 22);
      this.textBox4.TabIndex = 1;
      // 
      // textBox5
      // 
      this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.textBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
      this.textBox5.Location = new System.Drawing.Point(360, 204);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(303, 22);
      this.textBox5.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label5.Location = new System.Drawing.Point(140, 204);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(181, 18);
      this.label5.TabIndex = 3;
      this.label5.Text = "Recently Used Url List:";
      // 
      // textBox6
      // 
      this.textBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.textBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
      this.textBox6.Location = new System.Drawing.Point(360, 242);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(303, 22);
      this.textBox6.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label6.Location = new System.Drawing.Point(252, 242);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(69, 18);
      this.label6.TabIndex = 3;
      this.label6.Text = "All URL:";
      // 
      // textBox7
      // 
      this.textBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.textBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.textBox7.Location = new System.Drawing.Point(360, 280);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(303, 22);
      this.textBox7.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label7.Location = new System.Drawing.Point(127, 280);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(194, 18);
      this.label7.TabIndex = 3;
      this.label7.Text = "File System Directories :";
      // 
      // textBox8
      // 
      this.textBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.textBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.textBox8.Location = new System.Drawing.Point(360, 315);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(303, 22);
      this.textBox8.TabIndex = 1;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label8.Location = new System.Drawing.Point(127, 315);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(175, 18);
      this.label8.TabIndex = 3;
      this.label8.Text = "Array Custom Source:";
      // 
      // textBox9
      // 
      this.textBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.textBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.textBox9.Location = new System.Drawing.Point(360, 367);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new System.Drawing.Size(303, 22);
      this.textBox9.TabIndex = 1;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label9.Location = new System.Drawing.Point(124, 367);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(212, 18);
      this.label9.TabIndex = 3;
      this.label9.Text = "Database Custom Source :";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(360, 407);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(303, 24);
      this.comboBox1.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox9);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox8);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox7);
      this.Controls.Add(this.textBox6);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox9;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox comboBox1;
  }
}

