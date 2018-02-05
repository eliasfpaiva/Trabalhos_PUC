namespace Cada_Gota.Telas
{
    partial class consultar_variacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultar_variacao));
            this.btnCompararContas = new System.Windows.Forms.Button();
            this.selectPrimeiraConta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectIdConsumidor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectSegundaConta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campoValorPrimeiraConta = new System.Windows.Forms.Label();
            this.campoValorSegundaConta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.campoConsumoSegundaConta = new System.Windows.Forms.Label();
            this.labelConsumo2 = new System.Windows.Forms.Label();
            this.campoConsumoPrimeiraConta = new System.Windows.Forms.Label();
            this.labelConsumo1 = new System.Windows.Forms.Label();
            this.campoUnidadeMedida_1 = new System.Windows.Forms.Label();
            this.campoUnidadeMedida_2 = new System.Windows.Forms.Label();
            this.campoVariacaoValor = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.campoVariacaoConsumo = new System.Windows.Forms.Label();
            this.labelVariacaoConsumo = new System.Windows.Forms.Label();
            this.campoUnidadeMedida_3 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompararContas
            // 
            this.btnCompararContas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompararContas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCompararContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCompararContas.Location = new System.Drawing.Point(666, 115);
            this.btnCompararContas.Name = "btnCompararContas";
            this.btnCompararContas.Size = new System.Drawing.Size(648, 45);
            this.btnCompararContas.TabIndex = 4;
            this.btnCompararContas.Text = "COMPARAR CONTAS";
            this.btnCompararContas.UseVisualStyleBackColor = false;
            this.btnCompararContas.Click += new System.EventHandler(this.btnCompararContas_Click);
            // 
            // selectPrimeiraConta
            // 
            this.selectPrimeiraConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPrimeiraConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectPrimeiraConta.FormattingEnabled = true;
            this.selectPrimeiraConta.Location = new System.Drawing.Point(189, 47);
            this.selectPrimeiraConta.Name = "selectPrimeiraConta";
            this.selectPrimeiraConta.Size = new System.Drawing.Size(1125, 28);
            this.selectPrimeiraConta.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Selecione a 1ª Conta:";
            // 
            // selectIdConsumidor
            // 
            this.selectIdConsumidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectIdConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectIdConsumidor.FormattingEnabled = true;
            this.selectIdConsumidor.Location = new System.Drawing.Point(189, 13);
            this.selectIdConsumidor.Name = "selectIdConsumidor";
            this.selectIdConsumidor.Size = new System.Drawing.Size(1125, 28);
            this.selectIdConsumidor.TabIndex = 0;
            this.selectIdConsumidor.Leave += new System.EventHandler(this.selectIdConsumidor_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID do Consumidor:";
            // 
            // selectSegundaConta
            // 
            this.selectSegundaConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSegundaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectSegundaConta.FormattingEnabled = true;
            this.selectSegundaConta.Location = new System.Drawing.Point(189, 81);
            this.selectSegundaConta.Name = "selectSegundaConta";
            this.selectSegundaConta.Size = new System.Drawing.Size(1125, 28);
            this.selectSegundaConta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Selecione a 2ª Conta:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor da 1ª Conta: R$";
            // 
            // campoValorPrimeiraConta
            // 
            this.campoValorPrimeiraConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoValorPrimeiraConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoValorPrimeiraConta.Location = new System.Drawing.Point(189, 208);
            this.campoValorPrimeiraConta.Name = "campoValorPrimeiraConta";
            this.campoValorPrimeiraConta.Size = new System.Drawing.Size(471, 23);
            this.campoValorPrimeiraConta.TabIndex = 14;
            // 
            // campoValorSegundaConta
            // 
            this.campoValorSegundaConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoValorSegundaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoValorSegundaConta.Location = new System.Drawing.Point(843, 208);
            this.campoValorSegundaConta.Name = "campoValorSegundaConta";
            this.campoValorSegundaConta.Size = new System.Drawing.Size(471, 23);
            this.campoValorSegundaConta.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(666, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valor da 2ª Conta: R$";
            // 
            // campoConsumoSegundaConta
            // 
            this.campoConsumoSegundaConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoConsumoSegundaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoConsumoSegundaConta.Location = new System.Drawing.Point(839, 300);
            this.campoConsumoSegundaConta.Name = "campoConsumoSegundaConta";
            this.campoConsumoSegundaConta.Size = new System.Drawing.Size(394, 23);
            this.campoConsumoSegundaConta.TabIndex = 20;
            // 
            // labelConsumo2
            // 
            this.labelConsumo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelConsumo2.Location = new System.Drawing.Point(662, 300);
            this.labelConsumo2.Name = "labelConsumo2";
            this.labelConsumo2.Size = new System.Drawing.Size(171, 23);
            this.labelConsumo2.TabIndex = 19;
            this.labelConsumo2.Text = "Consumo da 2ª Conta:";
            // 
            // campoConsumoPrimeiraConta
            // 
            this.campoConsumoPrimeiraConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoConsumoPrimeiraConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoConsumoPrimeiraConta.Location = new System.Drawing.Point(185, 300);
            this.campoConsumoPrimeiraConta.Name = "campoConsumoPrimeiraConta";
            this.campoConsumoPrimeiraConta.Size = new System.Drawing.Size(394, 23);
            this.campoConsumoPrimeiraConta.TabIndex = 18;
            // 
            // labelConsumo1
            // 
            this.labelConsumo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelConsumo1.Location = new System.Drawing.Point(12, 300);
            this.labelConsumo1.Name = "labelConsumo1";
            this.labelConsumo1.Size = new System.Drawing.Size(167, 23);
            this.labelConsumo1.TabIndex = 17;
            this.labelConsumo1.Text = "Consumo da 1ª Conta:";
            // 
            // campoUnidadeMedida_1
            // 
            this.campoUnidadeMedida_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoUnidadeMedida_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoUnidadeMedida_1.Location = new System.Drawing.Point(585, 300);
            this.campoUnidadeMedida_1.Name = "campoUnidadeMedida_1";
            this.campoUnidadeMedida_1.Size = new System.Drawing.Size(75, 23);
            this.campoUnidadeMedida_1.TabIndex = 21;
            // 
            // campoUnidadeMedida_2
            // 
            this.campoUnidadeMedida_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoUnidadeMedida_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoUnidadeMedida_2.Location = new System.Drawing.Point(1239, 300);
            this.campoUnidadeMedida_2.Name = "campoUnidadeMedida_2";
            this.campoUnidadeMedida_2.Size = new System.Drawing.Size(75, 23);
            this.campoUnidadeMedida_2.TabIndex = 22;
            // 
            // campoVariacaoValor
            // 
            this.campoVariacaoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoVariacaoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoVariacaoValor.Location = new System.Drawing.Point(189, 241);
            this.campoVariacaoValor.Name = "campoVariacaoValor";
            this.campoVariacaoValor.Size = new System.Drawing.Size(471, 23);
            this.campoVariacaoValor.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(12, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 23);
            this.label15.TabIndex = 23;
            this.label15.Text = "Variação de Valor: R$";
            // 
            // campoVariacaoConsumo
            // 
            this.campoVariacaoConsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoVariacaoConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoVariacaoConsumo.Location = new System.Drawing.Point(185, 334);
            this.campoVariacaoConsumo.Name = "campoVariacaoConsumo";
            this.campoVariacaoConsumo.Size = new System.Drawing.Size(394, 23);
            this.campoVariacaoConsumo.TabIndex = 26;
            // 
            // labelVariacaoConsumo
            // 
            this.labelVariacaoConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelVariacaoConsumo.Location = new System.Drawing.Point(12, 334);
            this.labelVariacaoConsumo.Name = "labelVariacaoConsumo";
            this.labelVariacaoConsumo.Size = new System.Drawing.Size(167, 23);
            this.labelVariacaoConsumo.TabIndex = 25;
            this.labelVariacaoConsumo.Text = "Variação Consumo:";
            // 
            // campoUnidadeMedida_3
            // 
            this.campoUnidadeMedida_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campoUnidadeMedida_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoUnidadeMedida_3.Location = new System.Drawing.Point(585, 334);
            this.campoUnidadeMedida_3.Name = "campoUnidadeMedida_3";
            this.campoUnidadeMedida_3.Size = new System.Drawing.Size(75, 23);
            this.campoUnidadeMedida_3.TabIndex = 27;
            // 
            // btn_voltar
            // 
            this.btn_voltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_voltar.Location = new System.Drawing.Point(12, 115);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(648, 45);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // consultar_variacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 371);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.campoUnidadeMedida_3);
            this.Controls.Add(this.campoVariacaoConsumo);
            this.Controls.Add(this.labelVariacaoConsumo);
            this.Controls.Add(this.campoVariacaoValor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.campoUnidadeMedida_2);
            this.Controls.Add(this.campoUnidadeMedida_1);
            this.Controls.Add(this.campoConsumoSegundaConta);
            this.Controls.Add(this.labelConsumo2);
            this.Controls.Add(this.campoConsumoPrimeiraConta);
            this.Controls.Add(this.labelConsumo1);
            this.Controls.Add(this.campoValorSegundaConta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoValorPrimeiraConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectSegundaConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCompararContas);
            this.Controls.Add(this.selectPrimeiraConta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectIdConsumidor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consultar_variacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADA GOTA - Consultar Variação Entre Contas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultar_variacao_FormClosing);
            this.Load += new System.EventHandler(this.consultar_variacao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompararContas;
        private System.Windows.Forms.ComboBox selectPrimeiraConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectIdConsumidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectSegundaConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label campoValorPrimeiraConta;
        private System.Windows.Forms.Label campoValorSegundaConta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label campoConsumoSegundaConta;
        private System.Windows.Forms.Label labelConsumo2;
        private System.Windows.Forms.Label campoConsumoPrimeiraConta;
        private System.Windows.Forms.Label labelConsumo1;
        private System.Windows.Forms.Label campoUnidadeMedida_1;
        private System.Windows.Forms.Label campoUnidadeMedida_2;
        private System.Windows.Forms.Label campoVariacaoValor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label campoVariacaoConsumo;
        private System.Windows.Forms.Label labelVariacaoConsumo;
        private System.Windows.Forms.Label campoUnidadeMedida_3;
        private System.Windows.Forms.Button btn_voltar;
    }
}