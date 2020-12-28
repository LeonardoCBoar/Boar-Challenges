namespace Boar_Base_Calc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dec = new System.Windows.Forms.TextBox();
            this.Bin = new System.Windows.Forms.TextBox();
            this.Hex = new System.Windows.Forms.TextBox();
            this.Oct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pixel Digivolve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pixel Digivolve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Binário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pixel Digivolve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(13, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hexadecimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pixel Digivolve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(13, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Octal";
            // 
            // Dec
            // 
            this.Dec.BackColor = System.Drawing.Color.Black;
            this.Dec.Font = new System.Drawing.Font("Pixel Digivolve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dec.ForeColor = System.Drawing.Color.Red;
            this.Dec.Location = new System.Drawing.Point(256, 90);
            this.Dec.MaxLength = 17;
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(760, 45);
            this.Dec.TabIndex = 4;
            this.Dec.Text = "0000000000";
            this.Dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Dec.TextChanged += new System.EventHandler(this.Dec_TextChanged);
            // 
            // Bin
            // 
            this.Bin.BackColor = System.Drawing.Color.Black;
            this.Bin.Font = new System.Drawing.Font("Pixel Digivolve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bin.ForeColor = System.Drawing.Color.Lime;
            this.Bin.Location = new System.Drawing.Point(256, 148);
            this.Bin.MaxLength = 55;
            this.Bin.Name = "Bin";
            this.Bin.Size = new System.Drawing.Size(760, 45);
            this.Bin.TabIndex = 5;
            this.Bin.Text = "0000000000";
            this.Bin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Bin.TextChanged += new System.EventHandler(this.Bin_TextChanged);
            // 
            // Hex
            // 
            this.Hex.BackColor = System.Drawing.Color.Black;
            this.Hex.Font = new System.Drawing.Font("Pixel Digivolve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hex.ForeColor = System.Drawing.Color.Blue;
            this.Hex.Location = new System.Drawing.Point(256, 203);
            this.Hex.MaxLength = 14;
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(760, 45);
            this.Hex.TabIndex = 6;
            this.Hex.Text = "0000000000";
            this.Hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Hex.TextChanged += new System.EventHandler(this.Hex_TextChanged);
            // 
            // Oct
            // 
            this.Oct.BackColor = System.Drawing.Color.Black;
            this.Oct.Font = new System.Drawing.Font("Pixel Digivolve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oct.ForeColor = System.Drawing.Color.Yellow;
            this.Oct.Location = new System.Drawing.Point(256, 258);
            this.Oct.MaxLength = 19;
            this.Oct.Name = "Oct";
            this.Oct.Size = new System.Drawing.Size(760, 45);
            this.Oct.TabIndex = 7;
            this.Oct.Text = "0000000000";
            this.Oct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Oct.TextChanged += new System.EventHandler(this.Oct_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.Oct);
            this.Controls.Add(this.Hex);
            this.Controls.Add(this.Bin);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Boar Base Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Dec;
        private System.Windows.Forms.TextBox Bin;
        private System.Windows.Forms.TextBox Hex;
        private System.Windows.Forms.TextBox Oct;
    }
}

