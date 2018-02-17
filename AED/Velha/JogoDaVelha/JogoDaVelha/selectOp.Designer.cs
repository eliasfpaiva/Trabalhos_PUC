namespace JogoDaVelha
{
    partial class selectOp
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
            this.campo_jogador2 = new System.Windows.Forms.RadioButton();
            this.campo_computador = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // campo_jogador2
            // 
            this.campo_jogador2.AutoSize = true;
            this.campo_jogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.campo_jogador2.Location = new System.Drawing.Point(12, 12);
            this.campo_jogador2.Name = "campo_jogador2";
            this.campo_jogador2.Size = new System.Drawing.Size(152, 35);
            this.campo_jogador2.TabIndex = 3;
            this.campo_jogador2.TabStop = true;
            this.campo_jogador2.Text = "Jogador 2";
            this.campo_jogador2.UseVisualStyleBackColor = true;
            // 
            // campo_computador
            // 
            this.campo_computador.AutoSize = true;
            this.campo_computador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.campo_computador.Location = new System.Drawing.Point(12, 53);
            this.campo_computador.Name = "campo_computador";
            this.campo_computador.Size = new System.Drawing.Size(181, 35);
            this.campo_computador.TabIndex = 4;
            this.campo_computador.TabStop = true;
            this.campo_computador.Text = "Computador";
            this.campo_computador.UseVisualStyleBackColor = true;
            // 
            // selectOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 173);
            this.Controls.Add(this.campo_computador);
            this.Controls.Add(this.campo_jogador2);
            this.Controls.Add(this.button1);
            this.Name = "selectOp";
            this.Text = "Seleção de Oponente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton campo_jogador2;
        private System.Windows.Forms.RadioButton campo_computador;
    }
}