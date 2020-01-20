namespace GasolinavsEtanol
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.txtGasolina = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.txtEtanol = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.Label4 = new System.Windows.Forms.Label();
         this.btnCalcular = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.lblResultado = new System.Windows.Forms.Label();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         this.SuspendLayout();
         // 
         // txtGasolina
         // 
         this.txtGasolina.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtGasolina.Location = new System.Drawing.Point(43, 201);
         this.txtGasolina.Name = "txtGasolina";
         this.txtGasolina.Size = new System.Drawing.Size(100, 25);
         this.txtGasolina.TabIndex = 0;
         this.txtGasolina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(31, 176);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(124, 22);
         this.label1.TabIndex = 1;
         this.label1.Text = "Gasolina (R$)";
         // 
         // txtEtanol
         // 
         this.txtEtanol.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEtanol.Location = new System.Drawing.Point(270, 201);
         this.txtEtanol.Name = "txtEtanol";
         this.txtEtanol.Size = new System.Drawing.Size(100, 25);
         this.txtEtanol.TabIndex = 1;
         this.txtEtanol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(268, 173);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(105, 22);
         this.label2.TabIndex = 1;
         this.label2.Text = "Etanol (R$)";
         // 
         // Label4
         // 
         this.Label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Label4.Location = new System.Drawing.Point(11, 311);
         this.Label4.Name = "Label4";
         this.Label4.Size = new System.Drawing.Size(282, 32);
         this.Label4.TabIndex = 1;
         this.Label4.Text = "A melhor opção é abastecer com:";
         this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnCalcular
         // 
         this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCalcular.Location = new System.Drawing.Point(122, 271);
         this.btnCalcular.Name = "btnCalcular";
         this.btnCalcular.Size = new System.Drawing.Size(171, 28);
         this.btnCalcular.TabIndex = 2;
         this.btnCalcular.Text = "Calcular";
         this.btnCalcular.UseVisualStyleBackColor = true;
         this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(129, 28);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(156, 135);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         // 
         // lblResultado
         // 
         this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblResultado.Location = new System.Drawing.Point(291, 311);
         this.lblResultado.Name = "lblResultado";
         this.lblResultado.Size = new System.Drawing.Size(112, 32);
         this.lblResultado.TabIndex = 1;
         this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
         this.pictureBox2.Location = new System.Drawing.Point(171, 188);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(71, 50);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox2.TabIndex = 3;
         this.pictureBox2.TabStop = false;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(415, 357);
         this.Controls.Add(this.pictureBox2);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.btnCalcular);
         this.Controls.Add(this.lblResultado);
         this.Controls.Add(this.Label4);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtEtanol);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtGasolina);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "#### Etanol vs Gasolina ####";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtGasolina;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtEtanol;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label Label4;
      private System.Windows.Forms.Button btnCalcular;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label lblResultado;
      private System.Windows.Forms.PictureBox pictureBox2;
   }
}

