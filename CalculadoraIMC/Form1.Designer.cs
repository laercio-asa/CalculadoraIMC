namespace CalculadoraIMC
{
  partial class Form1
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(555, 138);
      this.panel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Location = new System.Drawing.Point(120, 150);
      this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(300, 38);
      this.panel2.TabIndex = 1;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
      this.panel3.Location = new System.Drawing.Point(120, 188);
      this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(300, 38);
      this.panel3.TabIndex = 2;
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.Color.LightGreen;
      this.panel4.Location = new System.Drawing.Point(120, 227);
      this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(300, 38);
      this.panel4.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(5, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Classificação";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(100, 10);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Faixa";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(150, 10);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(47, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Faixa";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(200, 10);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 20);
      this.label4.TabIndex = 3;
      this.label4.Text = "Faixa";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(245, 10);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(42, 20);
      this.label5.TabIndex = 4;
      this.label5.Text = "Faixa";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(555, 373);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
  }
}

