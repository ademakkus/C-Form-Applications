
namespace MemberShipForm
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
      this.maleradioButton = new System.Windows.Forms.RadioButton();
      this.femaleradioButton = new System.Windows.Forms.RadioButton();
      this.exitbutton = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.updatebutton = new System.Windows.Forms.Button();
      this.insertbutton = new System.Windows.Forms.Button();
      this.birthYearcomboBox = new System.Windows.Forms.ComboBox();
      this.birthMonthcomboBox = new System.Windows.Forms.ComboBox();
      this.birthDaycomboBox = new System.Windows.Forms.ComboBox();
      this.emailtextBox = new System.Windows.Forms.TextBox();
      this.passwordTextBox = new System.Windows.Forms.TextBox();
      this.userNameTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
      this.splitContainer1.Panel1.Controls.Add(this.maleradioButton);
      this.splitContainer1.Panel1.Controls.Add(this.femaleradioButton);
      this.splitContainer1.Panel1.Controls.Add(this.exitbutton);
      this.splitContainer1.Panel1.Controls.Add(this.button4);
      this.splitContainer1.Panel1.Controls.Add(this.button3);
      this.splitContainer1.Panel1.Controls.Add(this.updatebutton);
      this.splitContainer1.Panel1.Controls.Add(this.insertbutton);
      this.splitContainer1.Panel1.Controls.Add(this.birthYearcomboBox);
      this.splitContainer1.Panel1.Controls.Add(this.birthMonthcomboBox);
      this.splitContainer1.Panel1.Controls.Add(this.birthDaycomboBox);
      this.splitContainer1.Panel1.Controls.Add(this.emailtextBox);
      this.splitContainer1.Panel1.Controls.Add(this.passwordTextBox);
      this.splitContainer1.Panel1.Controls.Add(this.userNameTextBox);
      this.splitContainer1.Panel1.Controls.Add(this.label4);
      this.splitContainer1.Panel1.Controls.Add(this.label5);
      this.splitContainer1.Panel1.Controls.Add(this.label3);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
      this.splitContainer1.Size = new System.Drawing.Size(961, 627);
      this.splitContainer1.SplitterDistance = 433;
      this.splitContainer1.TabIndex = 0;
      // 
      // maleradioButton
      // 
      this.maleradioButton.AutoSize = true;
      this.maleradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.maleradioButton.Location = new System.Drawing.Point(314, 174);
      this.maleradioButton.Name = "maleradioButton";
      this.maleradioButton.Size = new System.Drawing.Size(72, 28);
      this.maleradioButton.TabIndex = 15;
      this.maleradioButton.TabStop = true;
      this.maleradioButton.Text = "Male";
      this.maleradioButton.UseVisualStyleBackColor = true;
      // 
      // femaleradioButton
      // 
      this.femaleradioButton.AutoSize = true;
      this.femaleradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.femaleradioButton.Location = new System.Drawing.Point(172, 174);
      this.femaleradioButton.Name = "femaleradioButton";
      this.femaleradioButton.Size = new System.Drawing.Size(95, 28);
      this.femaleradioButton.TabIndex = 14;
      this.femaleradioButton.TabStop = true;
      this.femaleradioButton.Text = "Female";
      this.femaleradioButton.UseVisualStyleBackColor = true;
      // 
      // exitbutton
      // 
      this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.exitbutton.Location = new System.Drawing.Point(715, 265);
      this.exitbutton.Name = "exitbutton";
      this.exitbutton.Size = new System.Drawing.Size(143, 68);
      this.exitbutton.TabIndex = 13;
      this.exitbutton.Text = "Exit";
      this.exitbutton.UseVisualStyleBackColor = true;
      this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button4.Location = new System.Drawing.Point(513, 265);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(143, 68);
      this.button4.TabIndex = 13;
      this.button4.Text = "Clear";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button3.Location = new System.Drawing.Point(351, 265);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(143, 68);
      this.button3.TabIndex = 12;
      this.button3.Text = "Delete";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // updatebutton
      // 
      this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.updatebutton.Location = new System.Drawing.Point(189, 265);
      this.updatebutton.Name = "updatebutton";
      this.updatebutton.Size = new System.Drawing.Size(143, 68);
      this.updatebutton.TabIndex = 11;
      this.updatebutton.Text = "Update";
      this.updatebutton.UseVisualStyleBackColor = true;
      this.updatebutton.Click += new System.EventHandler(this.button2_Click);
      // 
      // insertbutton
      // 
      this.insertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.insertbutton.Location = new System.Drawing.Point(27, 265);
      this.insertbutton.Name = "insertbutton";
      this.insertbutton.Size = new System.Drawing.Size(143, 68);
      this.insertbutton.TabIndex = 10;
      this.insertbutton.Text = "Insert";
      this.insertbutton.UseVisualStyleBackColor = true;
      this.insertbutton.Click += new System.EventHandler(this.button1_Click);
      // 
      // birthYearcomboBox
      // 
      this.birthYearcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.birthYearcomboBox.FormattingEnabled = true;
      this.birthYearcomboBox.Location = new System.Drawing.Point(364, 130);
      this.birthYearcomboBox.Name = "birthYearcomboBox";
      this.birthYearcomboBox.Size = new System.Drawing.Size(84, 30);
      this.birthYearcomboBox.TabIndex = 9;
      // 
      // birthMonthcomboBox
      // 
      this.birthMonthcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.birthMonthcomboBox.FormattingEnabled = true;
      this.birthMonthcomboBox.Location = new System.Drawing.Point(269, 130);
      this.birthMonthcomboBox.Name = "birthMonthcomboBox";
      this.birthMonthcomboBox.Size = new System.Drawing.Size(70, 30);
      this.birthMonthcomboBox.TabIndex = 8;
      // 
      // birthDaycomboBox
      // 
      this.birthDaycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.birthDaycomboBox.FormattingEnabled = true;
      this.birthDaycomboBox.Location = new System.Drawing.Point(172, 130);
      this.birthDaycomboBox.Name = "birthDaycomboBox";
      this.birthDaycomboBox.Size = new System.Drawing.Size(70, 30);
      this.birthDaycomboBox.TabIndex = 7;
      // 
      // emailtextBox
      // 
      this.emailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.emailtextBox.Location = new System.Drawing.Point(172, 211);
      this.emailtextBox.Name = "emailtextBox";
      this.emailtextBox.Size = new System.Drawing.Size(392, 28);
      this.emailtextBox.TabIndex = 6;
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.passwordTextBox.Location = new System.Drawing.Point(172, 87);
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.Size = new System.Drawing.Size(392, 28);
      this.passwordTextBox.TabIndex = 5;
      // 
      // userNameTextBox
      // 
      this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.userNameTextBox.Location = new System.Drawing.Point(172, 47);
      this.userNameTextBox.Name = "userNameTextBox";
      this.userNameTextBox.Size = new System.Drawing.Size(392, 28);
      this.userNameTextBox.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.Location = new System.Drawing.Point(75, 215);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(73, 24);
      this.label4.TabIndex = 3;
      this.label4.Text = "E-Mail :";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label5.Location = new System.Drawing.Point(48, 171);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(84, 24);
      this.label5.TabIndex = 2;
      this.label5.Text = "Gender :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(48, 136);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 24);
      this.label3.TabIndex = 2;
      this.label3.Text = "Birth Date :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(46, 91);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(102, 24);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password: ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(33, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(115, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "User Name :";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dataGridView1.Location = new System.Drawing.Point(0, 40);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(961, 150);
      this.dataGridView1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(961, 627);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Membership Form";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button updatebutton;
    private System.Windows.Forms.Button insertbutton;
    private System.Windows.Forms.ComboBox birthYearcomboBox;
    private System.Windows.Forms.ComboBox birthMonthcomboBox;
    private System.Windows.Forms.ComboBox birthDaycomboBox;
    private System.Windows.Forms.TextBox emailtextBox;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.TextBox userNameTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.RadioButton maleradioButton;
    private System.Windows.Forms.RadioButton femaleradioButton;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button exitbutton;
  }
}

