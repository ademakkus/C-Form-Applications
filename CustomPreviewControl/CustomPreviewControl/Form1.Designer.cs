
namespace CustomPreviewControl
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
      this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
      this.label1 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.btnPrint = new System.Windows.Forms.Button();
      this.printDocument1 = new System.Drawing.Printing.PrintDocument();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.btnPrint);
      this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
      this.splitContainer1.Panel1.Controls.Add(this.numericUpDown3);
      this.splitContainer1.Panel1.Controls.Add(this.label3);
      this.splitContainer1.Panel1.Controls.Add(this.numericUpDown2);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.printPreviewControl1);
      this.splitContainer1.Size = new System.Drawing.Size(800, 690);
      this.splitContainer1.SplitterDistance = 266;
      this.splitContainer1.TabIndex = 0;
      // 
      // printPreviewControl1
      // 
      this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.printPreviewControl1.Document = this.printDocument1;
      this.printPreviewControl1.Location = new System.Drawing.Point(0, 0);
      this.printPreviewControl1.Name = "printPreviewControl1";
      this.printPreviewControl1.Size = new System.Drawing.Size(530, 690);
      this.printPreviewControl1.TabIndex = 0;
      this.printPreviewControl1.Zoom = 0.47476475620188197D;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(29, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Rows";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.numericUpDown1.Location = new System.Drawing.Point(32, 73);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(120, 28);
      this.numericUpDown1.TabIndex = 1;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(32, 123);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 24);
      this.label2.TabIndex = 2;
      this.label2.Text = "Column";
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.numericUpDown2.Location = new System.Drawing.Point(32, 166);
      this.numericUpDown2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(120, 28);
      this.numericUpDown2.TabIndex = 3;
      this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(32, 214);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 24);
      this.label3.TabIndex = 4;
      this.label3.Text = "Zoom";
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.numericUpDown3.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
      this.numericUpDown3.Location = new System.Drawing.Point(32, 255);
      this.numericUpDown3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.numericUpDown3.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(120, 28);
      this.numericUpDown3.TabIndex = 5;
      this.numericUpDown3.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
      this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.checkBox1.Location = new System.Drawing.Point(32, 318);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(109, 28);
      this.checkBox1.TabIndex = 6;
      this.checkBox1.Text = "Anti Alias";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // btnPrint
      // 
      this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnPrint.Location = new System.Drawing.Point(36, 380);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new System.Drawing.Size(97, 39);
      this.btnPrint.TabIndex = 7;
      this.btnPrint.Text = "Print";
      this.btnPrint.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 690);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.NumericUpDown numericUpDown3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    private System.Drawing.Printing.PrintDocument printDocument1;
  }
}

