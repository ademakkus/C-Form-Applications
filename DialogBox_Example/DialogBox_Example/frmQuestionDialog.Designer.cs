
namespace DialogBox_Example
{
  partial class frmQuestionDialog
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
      this.lblQuestion = new System.Windows.Forms.Label();
      this.txtAnswer = new System.Windows.Forms.TextBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblQuestion
      // 
      this.lblQuestion.AutoSize = true;
      this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblQuestion.Location = new System.Drawing.Point(12, 20);
      this.lblQuestion.Name = "lblQuestion";
      this.lblQuestion.Size = new System.Drawing.Size(52, 18);
      this.lblQuestion.TabIndex = 0;
      this.lblQuestion.Text = "label1";
      // 
      // txtAnswer
      // 
      this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtAnswer.Location = new System.Drawing.Point(208, 20);
      this.txtAnswer.Name = "txtAnswer";
      this.txtAnswer.Size = new System.Drawing.Size(639, 24);
      this.txtAnswer.TabIndex = 1;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(295, 68);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(203, 41);
      this.btnOK.TabIndex = 2;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(559, 68);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(203, 41);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // frmQuestionDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(859, 133);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.txtAnswer);
      this.Controls.Add(this.lblQuestion);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmQuestionDialog";
      this.Text = "Question";
      this.Load += new System.EventHandler(this.frmQuestionDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblQuestion;
    private System.Windows.Forms.TextBox txtAnswer;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
  }
}