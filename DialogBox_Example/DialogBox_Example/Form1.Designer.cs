
namespace DialogBox_Example
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
      this.label3 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtSurname = new System.Windows.Forms.TextBox();
      this.lstCity = new System.Windows.Forms.ListBox();
      this.btnName = new System.Windows.Forms.Button();
      this.btnSurname = new System.Windows.Forms.Button();
      this.btnAdNewCity = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(107, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(107, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Surname:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(107, 123);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 18);
      this.label3.TabIndex = 2;
      this.label3.Text = "City:";
      // 
      // txtName
      // 
      this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtName.Location = new System.Drawing.Point(198, 23);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(248, 24);
      this.txtName.TabIndex = 3;
      // 
      // txtSurname
      // 
      this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtSurname.Location = new System.Drawing.Point(198, 69);
      this.txtSurname.Name = "txtSurname";
      this.txtSurname.Size = new System.Drawing.Size(248, 24);
      this.txtSurname.TabIndex = 4;
      // 
      // lstCity
      // 
      this.lstCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lstCity.FormattingEnabled = true;
      this.lstCity.ItemHeight = 18;
      this.lstCity.Location = new System.Drawing.Point(198, 123);
      this.lstCity.Name = "lstCity";
      this.lstCity.Size = new System.Drawing.Size(248, 148);
      this.lstCity.TabIndex = 5;
      // 
      // btnName
      // 
      this.btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnName.Location = new System.Drawing.Point(501, 20);
      this.btnName.Name = "btnName";
      this.btnName.Size = new System.Drawing.Size(203, 31);
      this.btnName.TabIndex = 6;
      this.btnName.Text = "Enter Name";
      this.btnName.UseVisualStyleBackColor = true;
      this.btnName.Click += new System.EventHandler(this.btnName_Click);
      // 
      // btnSurname
      // 
      this.btnSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnSurname.Location = new System.Drawing.Point(501, 66);
      this.btnSurname.Name = "btnSurname";
      this.btnSurname.Size = new System.Drawing.Size(203, 31);
      this.btnSurname.TabIndex = 7;
      this.btnSurname.Text = "Enter Surname";
      this.btnSurname.UseVisualStyleBackColor = true;
      this.btnSurname.Click += new System.EventHandler(this.btnSurname_Click);
      // 
      // btnAdNewCity
      // 
      this.btnAdNewCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnAdNewCity.Location = new System.Drawing.Point(501, 123);
      this.btnAdNewCity.Name = "btnAdNewCity";
      this.btnAdNewCity.Size = new System.Drawing.Size(203, 31);
      this.btnAdNewCity.TabIndex = 8;
      this.btnAdNewCity.Text = "Add New City";
      this.btnAdNewCity.UseVisualStyleBackColor = true;
      this.btnAdNewCity.Click += new System.EventHandler(this.btnAdNewCity_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnAdNewCity);
      this.Controls.Add(this.btnSurname);
      this.Controls.Add(this.btnName);
      this.Controls.Add(this.lstCity);
      this.Controls.Add(this.txtSurname);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtSurname;
    private System.Windows.Forms.ListBox lstCity;
    private System.Windows.Forms.Button btnName;
    private System.Windows.Forms.Button btnSurname;
    private System.Windows.Forms.Button btnAdNewCity;
  }
}

