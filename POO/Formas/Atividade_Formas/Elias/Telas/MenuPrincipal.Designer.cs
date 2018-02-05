namespace Atividade_Formas.Elias.Telas
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLado = new System.Windows.Forms.Label();
            this.lbLadoMaior = new System.Windows.Forms.Label();
            this.lbLadoMenor = new System.Windows.Forms.Label();
            this.lbRaio = new System.Windows.Forms.Label();
            this.tfLadoMenor = new System.Windows.Forms.TextBox();
            this.tfLadoMaior = new System.Windows.Forms.TextBox();
            this.tfLado = new System.Windows.Forms.TextBox();
            this.tfRaio = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(16, 32);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(235, 21);
            this.cbNome.TabIndex = 0;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a forma que deseja";
            // 
            // lbLado
            // 
            this.lbLado.AutoSize = true;
            this.lbLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLado.Location = new System.Drawing.Point(12, 66);
            this.lbLado.Name = "lbLado";
            this.lbLado.Size = new System.Drawing.Size(49, 20);
            this.lbLado.TabIndex = 2;
            this.lbLado.Text = "Lado:";
            this.lbLado.UseWaitCursor = true;
            this.lbLado.Visible = false;
            // 
            // lbLadoMaior
            // 
            this.lbLadoMaior.AutoSize = true;
            this.lbLadoMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLadoMaior.Location = new System.Drawing.Point(9, 66);
            this.lbLadoMaior.Name = "lbLadoMaior";
            this.lbLadoMaior.Size = new System.Drawing.Size(92, 20);
            this.lbLadoMaior.TabIndex = 3;
            this.lbLadoMaior.Text = "Lado Maior:";
            // 
            // lbLadoMenor
            // 
            this.lbLadoMenor.AutoSize = true;
            this.lbLadoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLadoMenor.Location = new System.Drawing.Point(9, 92);
            this.lbLadoMenor.Name = "lbLadoMenor";
            this.lbLadoMenor.Size = new System.Drawing.Size(98, 20);
            this.lbLadoMenor.TabIndex = 4;
            this.lbLadoMenor.Text = "Lado Menor:";
            // 
            // lbRaio
            // 
            this.lbRaio.AutoSize = true;
            this.lbRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRaio.Location = new System.Drawing.Point(9, 66);
            this.lbRaio.Name = "lbRaio";
            this.lbRaio.Size = new System.Drawing.Size(46, 20);
            this.lbRaio.TabIndex = 5;
            this.lbRaio.Text = "Raio:";
            // 
            // tfLadoMenor
            // 
            this.tfLadoMenor.Location = new System.Drawing.Point(113, 92);
            this.tfLadoMenor.Name = "tfLadoMenor";
            this.tfLadoMenor.Size = new System.Drawing.Size(138, 20);
            this.tfLadoMenor.TabIndex = 6;
            // 
            // tfLadoMaior
            // 
            this.tfLadoMaior.Location = new System.Drawing.Point(113, 66);
            this.tfLadoMaior.Name = "tfLadoMaior";
            this.tfLadoMaior.Size = new System.Drawing.Size(138, 20);
            this.tfLadoMaior.TabIndex = 7;
            // 
            // tfLado
            // 
            this.tfLado.Location = new System.Drawing.Point(113, 66);
            this.tfLado.Name = "tfLado";
            this.tfLado.Size = new System.Drawing.Size(138, 20);
            this.tfLado.TabIndex = 8;
            // 
            // tfRaio
            // 
            this.tfRaio.Location = new System.Drawing.Point(113, 66);
            this.tfRaio.Name = "tfRaio";
            this.tfRaio.Size = new System.Drawing.Size(138, 20);
            this.tfRaio.TabIndex = 9;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEnviar.Location = new System.Drawing.Point(13, 128);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(238, 66);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 207);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tfRaio);
            this.Controls.Add(this.tfLado);
            this.Controls.Add(this.tfLadoMaior);
            this.Controls.Add(this.tfLadoMenor);
            this.Controls.Add(this.lbRaio);
            this.Controls.Add(this.lbLadoMenor);
            this.Controls.Add(this.lbLadoMaior);
            this.Controls.Add(this.lbLado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLado;
        private System.Windows.Forms.Label lbLadoMaior;
        private System.Windows.Forms.Label lbLadoMenor;
        private System.Windows.Forms.Label lbRaio;
        private System.Windows.Forms.TextBox tfLadoMenor;
        private System.Windows.Forms.TextBox tfLadoMaior;
        private System.Windows.Forms.TextBox tfLado;
        private System.Windows.Forms.TextBox tfRaio;
        private System.Windows.Forms.Button btnEnviar;
    }
}