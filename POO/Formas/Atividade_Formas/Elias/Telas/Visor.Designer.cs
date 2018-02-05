namespace Atividade_Formas.Elias.Telas
{
    partial class Visor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Imagem = new System.Windows.Forms.PictureBox();
            this.TfPerimetro = new System.Windows.Forms.TextBox();
            this.TfArea = new System.Windows.Forms.TextBox();
            this.TfNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perímetro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Imagem:";
            // 
            // Imagem
            // 
            this.Imagem.Location = new System.Drawing.Point(128, 130);
            this.Imagem.Name = "Imagem";
            this.Imagem.Size = new System.Drawing.Size(115, 115);
            this.Imagem.TabIndex = 8;
            this.Imagem.TabStop = false;
            // 
            // TfPerimetro
            // 
            this.TfPerimetro.Location = new System.Drawing.Point(99, 95);
            this.TfPerimetro.Name = "TfPerimetro";
            this.TfPerimetro.Size = new System.Drawing.Size(173, 20);
            this.TfPerimetro.TabIndex = 9;
            // 
            // TfArea
            // 
            this.TfArea.Location = new System.Drawing.Point(99, 61);
            this.TfArea.Name = "TfArea";
            this.TfArea.Size = new System.Drawing.Size(173, 20);
            this.TfArea.TabIndex = 10;
            // 
            // TfNome
            // 
            this.TfNome.Location = new System.Drawing.Point(99, 26);
            this.TfNome.Name = "TfNome";
            this.TfNome.Size = new System.Drawing.Size(173, 20);
            this.TfNome.TabIndex = 11;
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TfNome);
            this.Controls.Add(this.TfArea);
            this.Controls.Add(this.TfPerimetro);
            this.Controls.Add(this.Imagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visor";
            this.Text = "Visor";
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Imagem;
        private System.Windows.Forms.TextBox TfPerimetro;
        private System.Windows.Forms.TextBox TfArea;
        private System.Windows.Forms.TextBox TfNome;
    }
}