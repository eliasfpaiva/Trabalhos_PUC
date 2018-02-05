namespace Cada_Gota.Telas
{
    partial class consultar_valor_medio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultar_valor_medio));
            this.selectIdConsumidor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.campoValorMedio = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectIdConsumidor
            // 
            this.selectIdConsumidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectIdConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectIdConsumidor.FormattingEnabled = true;
            this.selectIdConsumidor.Location = new System.Drawing.Point(184, 12);
            this.selectIdConsumidor.Name = "selectIdConsumidor";
            this.selectIdConsumidor.Size = new System.Drawing.Size(886, 28);
            this.selectIdConsumidor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID do Consumidor:";
            // 
            // btn_consultar
            // 
            this.btn_consultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_consultar.Location = new System.Drawing.Point(283, 46);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(265, 45);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "CONSULTAR";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(560, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor médio das contas: R$";
            // 
            // campoValorMedio
            // 
            this.campoValorMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoValorMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoValorMedio.Location = new System.Drawing.Point(777, 58);
            this.campoValorMedio.Name = "campoValorMedio";
            this.campoValorMedio.Size = new System.Drawing.Size(293, 23);
            this.campoValorMedio.TabIndex = 5;
            // 
            // btn_voltar
            // 
            this.btn_voltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_voltar.Location = new System.Drawing.Point(12, 46);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(265, 45);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // consultar_valor_medio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 102);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.campoValorMedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.selectIdConsumidor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consultar_valor_medio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADA GOTA - Consultar Valor Médio das Contas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultar_valor_medio_FormClosing);
            this.Load += new System.EventHandler(this.consultar_valor_medio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectIdConsumidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label campoValorMedio;
        private System.Windows.Forms.Button btn_voltar;
    }
}