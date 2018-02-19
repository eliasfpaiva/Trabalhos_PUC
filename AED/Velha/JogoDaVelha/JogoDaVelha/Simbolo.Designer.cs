namespace JogoDaVelha
{
    partial class Simbolo
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
            this.simbolo_O = new System.Windows.Forms.RadioButton();
            this.simbolo_X = new System.Windows.Forms.RadioButton();
            this.botao_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simbolo_O
            // 
            this.simbolo_O.AutoSize = true;
            this.simbolo_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.simbolo_O.Location = new System.Drawing.Point(114, 12);
            this.simbolo_O.Name = "simbolo_O";
            this.simbolo_O.Size = new System.Drawing.Size(53, 35);
            this.simbolo_O.TabIndex = 7;
            this.simbolo_O.TabStop = true;
            this.simbolo_O.Text = "O";
            this.simbolo_O.UseVisualStyleBackColor = true;
            // 
            // simbolo_X
            // 
            this.simbolo_X.AutoSize = true;
            this.simbolo_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.simbolo_X.Location = new System.Drawing.Point(12, 12);
            this.simbolo_X.Name = "simbolo_X";
            this.simbolo_X.Size = new System.Drawing.Size(50, 35);
            this.simbolo_X.TabIndex = 6;
            this.simbolo_X.TabStop = true;
            this.simbolo_X.Text = "X";
            this.simbolo_X.UseVisualStyleBackColor = true;
            // 
            // botao_OK
            // 
            this.botao_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.botao_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.botao_OK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botao_OK.Location = new System.Drawing.Point(12, 53);
            this.botao_OK.Name = "botao_OK";
            this.botao_OK.Size = new System.Drawing.Size(155, 51);
            this.botao_OK.TabIndex = 5;
            this.botao_OK.Text = "OK";
            this.botao_OK.UseVisualStyleBackColor = false;
            this.botao_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Símbolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 118);
            this.Controls.Add(this.simbolo_O);
            this.Controls.Add(this.simbolo_X);
            this.Controls.Add(this.botao_OK);
            this.Name = "Símbolo";
            this.Text = "Símbolo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton simbolo_O;
        private System.Windows.Forms.RadioButton simbolo_X;
        private System.Windows.Forms.Button botao_OK;
    }
}