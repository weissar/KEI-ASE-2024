namespace cv3_db_okno
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
      this.button1 = new System.Windows.Forms.Button();
      this.grid = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Top;
      this.button1.Location = new System.Drawing.Point(0, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(632, 45);
      this.button1.TabIndex = 0;
      this.button1.Text = "Load data";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // grid
      // 
      this.grid.AllowUserToAddRows = false;
      this.grid.AllowUserToDeleteRows = false;
      this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid.Location = new System.Drawing.Point(0, 45);
      this.grid.Name = "grid";
      this.grid.ReadOnly = true;
      this.grid.Size = new System.Drawing.Size(632, 405);
      this.grid.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 450);
      this.Controls.Add(this.grid);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView grid;
  }
}

