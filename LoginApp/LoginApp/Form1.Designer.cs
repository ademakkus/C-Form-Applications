
namespace LoginApp
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
      this.userNameTextBox = new System.Windows.Forms.TextBox();
      this.passwordTextBox = new System.Windows.Forms.TextBox();
      this.enterButton = new System.Windows.Forms.Button();
      this.clearButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(154, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "User Name:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(167, 97);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(97, 24);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password:";
      // 
      // userNameTextBox
      // 
      this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.userNameTextBox.Location = new System.Drawing.Point(296, 41);
      this.userNameTextBox.Name = "userNameTextBox";
      this.userNameTextBox.Size = new System.Drawing.Size(179, 28);
      this.userNameTextBox.TabIndex = 2;
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.passwordTextBox.Location = new System.Drawing.Point(296, 97);
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.Size = new System.Drawing.Size(144, 28);
      this.passwordTextBox.TabIndex = 3;
      // 
      // enterButton
      // 
      this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.enterButton.Location = new System.Drawing.Point(255, 177);
      this.enterButton.Name = "enterButton";
      this.enterButton.Size = new System.Drawing.Size(149, 63);
      this.enterButton.TabIndex = 4;
      this.enterButton.Text = "Enter";
      this.enterButton.UseVisualStyleBackColor = true;
      this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
      // 
      // clearButton
      // 
      this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.clearButton.Location = new System.Drawing.Point(427, 177);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(136, 63);
      this.clearButton.TabIndex = 5;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.enterButton);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(this.userNameTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox userNameTextBox;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.Button enterButton;
    private System.Windows.Forms.Button clearButton;
  }
}

