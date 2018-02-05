namespace Cada_Gota.Telas
{
    partial class cadastrar_imovel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar_imovel));
            this.btn_salvar = new System.Windows.Forms.Button();
            this.campoTipoServico = new System.Windows.Forms.ComboBox();
            this.campoTipoImovel = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.campoCep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.campoPais = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.campoEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.campoComplemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.campoCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.campoBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectIdConsumidor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_salvar.Location = new System.Drawing.Point(567, 181);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(522, 45);
            this.btn_salvar.TabIndex = 12;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // campoTipoServico
            // 
            this.campoTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoTipoServico.FormattingEnabled = true;
            this.campoTipoServico.Items.AddRange(new object[] {
            "Fornecimento de Água",
            "Fornecimento de Energia Elétrica"});
            this.campoTipoServico.Location = new System.Drawing.Point(697, 145);
            this.campoTipoServico.Name = "campoTipoServico";
            this.campoTipoServico.Size = new System.Drawing.Size(392, 28);
            this.campoTipoServico.TabIndex = 10;
            // 
            // campoTipoImovel
            // 
            this.campoTipoImovel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoTipoImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoTipoImovel.FormattingEnabled = true;
            this.campoTipoImovel.Items.AddRange(new object[] {
            "Residencial",
            "Comercial"});
            this.campoTipoImovel.Location = new System.Drawing.Point(161, 145);
            this.campoTipoImovel.Name = "campoTipoImovel";
            this.campoTipoImovel.Size = new System.Drawing.Size(396, 28);
            this.campoTipoImovel.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(563, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 48;
            this.label12.Text = "Tipo de Serviço:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(12, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 23);
            this.label13.TabIndex = 47;
            this.label13.Text = "Tipo de Imóvel:";
            // 
            // campoCep
            // 
            this.campoCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoCep.Location = new System.Drawing.Point(411, 113);
            this.campoCep.Name = "campoCep";
            this.campoCep.Size = new System.Drawing.Size(146, 26);
            this.campoCep.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(277, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 45;
            this.label9.Text = "CEP:";
            // 
            // campoPais
            // 
            this.campoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoPais.Location = new System.Drawing.Point(697, 113);
            this.campoPais.Name = "campoPais";
            this.campoPais.Size = new System.Drawing.Size(392, 26);
            this.campoPais.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(563, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 23);
            this.label10.TabIndex = 46;
            this.label10.Text = "País:";
            // 
            // campoEstado
            // 
            this.campoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoEstado.Location = new System.Drawing.Point(161, 113);
            this.campoEstado.Name = "campoEstado";
            this.campoEstado.Size = new System.Drawing.Size(110, 26);
            this.campoEstado.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(12, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "Estado:";
            // 
            // campoComplemento
            // 
            this.campoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoComplemento.Location = new System.Drawing.Point(411, 81);
            this.campoComplemento.Name = "campoComplemento";
            this.campoComplemento.Size = new System.Drawing.Size(146, 26);
            this.campoComplemento.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(277, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Complemento:";
            // 
            // campoCidade
            // 
            this.campoCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoCidade.Location = new System.Drawing.Point(697, 81);
            this.campoCidade.Name = "campoCidade";
            this.campoCidade.Size = new System.Drawing.Size(392, 26);
            this.campoCidade.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(563, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cidade:";
            // 
            // campoNumero
            // 
            this.campoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoNumero.Location = new System.Drawing.Point(161, 81);
            this.campoNumero.Name = "campoNumero";
            this.campoNumero.Size = new System.Drawing.Size(110, 26);
            this.campoNumero.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Número:";
            // 
            // campoBairro
            // 
            this.campoBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoBairro.Location = new System.Drawing.Point(697, 49);
            this.campoBairro.Name = "campoBairro";
            this.campoBairro.Size = new System.Drawing.Size(392, 26);
            this.campoBairro.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(563, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Bairro:";
            // 
            // campoEndereco
            // 
            this.campoEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoEndereco.Location = new System.Drawing.Point(161, 49);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(396, 26);
            this.campoEndereco.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Endereço:";
            // 
            // selectIdConsumidor
            // 
            this.selectIdConsumidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectIdConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectIdConsumidor.FormattingEnabled = true;
            this.selectIdConsumidor.Location = new System.Drawing.Point(161, 15);
            this.selectIdConsumidor.Name = "selectIdConsumidor";
            this.selectIdConsumidor.Size = new System.Drawing.Size(928, 28);
            this.selectIdConsumidor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID do Consumidor:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_voltar.Location = new System.Drawing.Point(12, 181);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(545, 45);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // cadastrar_imovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 238);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.selectIdConsumidor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.campoTipoServico);
            this.Controls.Add(this.campoTipoImovel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.campoCep);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.campoPais);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.campoEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.campoComplemento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.campoCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoBairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.campoEndereco);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastrar_imovel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADA GOTA - Cadastrar Imóvel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cadastrar_imovel_FormClosing);
            this.Load += new System.EventHandler(this.cadastrar_imovel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ComboBox campoTipoServico;
        private System.Windows.Forms.ComboBox campoTipoImovel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox campoCep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox campoPais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox campoEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox campoComplemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox campoCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox campoBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox selectIdConsumidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voltar;
    }
}