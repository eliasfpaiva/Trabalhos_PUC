namespace Cada_Gota.Telas
{
    partial class consultar_conta_mais_cara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultar_conta_mais_cara));
            this.campoValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.selectIdConsumidor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.campoMesAno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.campoEndereco = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoValor
            // 
            this.campoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoValor.Location = new System.Drawing.Point(177, 142);
            this.campoValor.Name = "campoValor";
            this.campoValor.Size = new System.Drawing.Size(350, 23);
            this.campoValor.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor da Conta: R$";
            // 
            // btn_consultar
            // 
            this.btn_consultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_consultar.Location = new System.Drawing.Point(538, 46);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(525, 45);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "CONSULTAR";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // selectIdConsumidor
            // 
            this.selectIdConsumidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectIdConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectIdConsumidor.FormattingEnabled = true;
            this.selectIdConsumidor.Location = new System.Drawing.Point(177, 12);
            this.selectIdConsumidor.Name = "selectIdConsumidor";
            this.selectIdConsumidor.Size = new System.Drawing.Size(886, 28);
            this.selectIdConsumidor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID do Consumidor:";
            // 
            // campoMesAno
            // 
            this.campoMesAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoMesAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoMesAno.Location = new System.Drawing.Point(625, 142);
            this.campoMesAno.Name = "campoMesAno";
            this.campoMesAno.Size = new System.Drawing.Size(438, 23);
            this.campoMesAno.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(533, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mês/Ano:";
            // 
            // campoEndereco
            // 
            this.campoEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoEndereco.Location = new System.Drawing.Point(104, 179);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(959, 23);
            this.campoEndereco.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Endereço:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_voltar.Location = new System.Drawing.Point(12, 46);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(520, 45);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // consultar_conta_mais_cara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 216);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.campoEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoMesAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.selectIdConsumidor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consultar_conta_mais_cara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADA GOTA - Consultar Conta Mais Cara";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultar_conta_mais_cara_FormClosing);
            this.Load += new System.EventHandler(this.consultar_conta_mais_cara_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label campoValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.ComboBox selectIdConsumidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label campoMesAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label campoEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_voltar;
    }
}