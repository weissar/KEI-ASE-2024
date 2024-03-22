namespace cv6_winforms
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.custom1 = new cv6_winforms.Custom();
      this.mojeKresleni1 = new cv6_winforms.MojeKresleni();
      this.knihovnaKresleni1 = new cv6_winforms.KnihovnaKresleni();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.custom1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.mojeKresleni1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.knihovnaKresleni1, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(394, 225);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
      // 
      // custom1
      // 
      this.custom1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.custom1.Location = new System.Drawing.Point(403, 3);
      this.custom1.Name = "custom1";
      this.custom1.Size = new System.Drawing.Size(394, 219);
      this.custom1.TabIndex = 1;
      this.custom1.Text = "custom1";
      // 
      // mojeKresleni1
      // 
      this.mojeKresleni1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mojeKresleni1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.mojeKresleni1.Location = new System.Drawing.Point(3, 228);
      this.mojeKresleni1.Name = "mojeKresleni1";
      this.mojeKresleni1.Size = new System.Drawing.Size(394, 219);
      this.mojeKresleni1.TabIndex = 2;
      this.mojeKresleni1.Text = "mojeKresleni1";
      // 
      // knihovnaKresleni1
      // 
      this.knihovnaKresleni1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.knihovnaKresleni1.Location = new System.Drawing.Point(403, 228);
      this.knihovnaKresleni1.Name = "knihovnaKresleni1";
      this.knihovnaKresleni1.Size = new System.Drawing.Size(394, 219);
      this.knihovnaKresleni1.TabIndex = 3;
      this.knihovnaKresleni1.Text = "knihovnaKresleni1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private Custom custom1;
    private MojeKresleni mojeKresleni1;
    private KnihovnaKresleni knihovnaKresleni1;
  }
}

