namespace Cada_Gota
{
    partial class menu_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_principal));
            this.btn_cadastrar_consumidor = new System.Windows.Forms.Button();
            this.btn_cadastrar_conta = new System.Windows.Forms.Button();
            this.btn_consultar_conta = new System.Windows.Forms.Button();
            this.btn_consultar_variacao = new System.Windows.Forms.Button();
            this.btn_consultar_valor_medio = new System.Windows.Forms.Button();
            this.btn_consultar_maior_valor = new System.Windows.Forms.Button();
            this.btnCadastraImovel = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadastrar_consumidor
            // 
            this.btn_cadastrar_consumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cadastrar_consumidor.Location = new System.Drawing.Point(12, 12);
            this.btn_cadastrar_consumidor.Name = "btn_cadastrar_consumidor";
            this.btn_cadastrar_consumidor.Size = new System.Drawing.Size(347, 46);
            this.btn_cadastrar_consumidor.TabIndex = 0;
            this.btn_cadastrar_consumidor.Text = "CADASTRAR NOVO CONSUMIDOR";
            this.btn_cadastrar_consumidor.UseVisualStyleBackColor = true;
            this.btn_cadastrar_consumidor.Click += new System.EventHandler(this.btn_cadastrar_consumidor_Click);
            // 
            // btn_cadastrar_conta
            // 
            this.btn_cadastrar_conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cadastrar_conta.Location = new System.Drawing.Point(12, 116);
            this.btn_cadastrar_conta.Name = "btn_cadastrar_conta";
            this.btn_cadastrar_conta.Size = new System.Drawing.Size(347, 46);
            this.btn_cadastrar_conta.TabIndex = 2;
            this.btn_cadastrar_conta.Text = "CADASTRAR CONTA";
            this.btn_cadastrar_conta.UseVisualStyleBackColor = true;
            this.btn_cadastrar_conta.Click += new System.EventHandler(this.btn_cadastrar_conta_Click);
            // 
            // btn_consultar_conta
            // 
            this.btn_consultar_conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_consultar_conta.Location = new System.Drawing.Point(12, 168);
            this.btn_consultar_conta.Name = "btn_consultar_conta";
            this.btn_consultar_conta.Size = new System.Drawing.Size(347, 46);
            this.btn_consultar_conta.TabIndex = 3;
            this.btn_consultar_conta.Text = "CONSULTAR CONTA";
            this.btn_consultar_conta.UseVisualStyleBackColor = true;
            this.btn_consultar_conta.Click += new System.EventHandler(this.btn_consultar_conta_Click);
            // 
            // btn_consultar_variacao
            // 
            this.btn_consultar_variacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_consultar_variacao.Location = new System.Drawing.Point(12, 220);
            this.btn_consultar_variacao.Name = "btn_consultar_variacao";
            this.btn_consultar_variacao.Size = new System.Drawing.Size(347, 46);
            this.btn_consultar_variacao.TabIndex = 4;
            this.btn_consultar_variacao.Text = "CONSULTAR VARIAÇÃO ENTRE CONTAS";
            this.btn_consultar_variacao.UseVisualStyleBackColor = true;
            this.btn_consultar_variacao.Click += new System.EventHandler(this.btn_consultar_variacao_Click);
            // 
            // btn_consultar_valor_medio
            // 
            this.btn_consultar_valor_medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_consultar_valor_medio.Location = new System.Drawing.Point(12, 272);
            this.btn_consultar_valor_medio.Name = "btn_consultar_valor_medio";
            this.btn_consultar_valor_medio.Size = new System.Drawing.Size(347, 46);
            this.btn_consultar_valor_medio.TabIndex = 5;
            this.btn_consultar_valor_medio.Text = "CONSULTAR VALOR MÉDIO DAS CONTAS";
            this.btn_consultar_valor_medio.UseVisualStyleBackColor = true;
            this.btn_consultar_valor_medio.Click += new System.EventHandler(this.btn_consultar_valor_medio_Click);
            // 
            // btn_consultar_maior_valor
            // 
            this.btn_consultar_maior_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_consultar_maior_valor.Location = new System.Drawing.Point(12, 324);
            this.btn_consultar_maior_valor.Name = "btn_consultar_maior_valor";
            this.btn_consultar_maior_valor.Size = new System.Drawing.Size(347, 46);
            this.btn_consultar_maior_valor.TabIndex = 6;
            this.btn_consultar_maior_valor.Text = "CONSULTAR CONTA MAIS CARA";
            this.btn_consultar_maior_valor.UseVisualStyleBackColor = true;
            this.btn_consultar_maior_valor.Click += new System.EventHandler(this.btn_consultar_maior_valor_Click);
            // 
            // btnCadastraImovel
            // 
            this.btnCadastraImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCadastraImovel.Location = new System.Drawing.Point(12, 64);
            this.btnCadastraImovel.Name = "btnCadastraImovel";
            this.btnCadastraImovel.Size = new System.Drawing.Size(347, 46);
            this.btnCadastraImovel.TabIndex = 1;
            this.btnCadastraImovel.Text = "CADASTRAR IMÓVEL";
            this.btnCadastraImovel.UseVisualStyleBackColor = true;
            this.btnCadastraImovel.Click += new System.EventHandler(this.btnCadastraImovel_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_sair.Location = new System.Drawing.Point(12, 376);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(347, 46);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(375, 434);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btnCadastraImovel);
            this.Controls.Add(this.btn_consultar_maior_valor);
            this.Controls.Add(this.btn_consultar_valor_medio);
            this.Controls.Add(this.btn_consultar_variacao);
            this.Controls.Add(this.btn_consultar_conta);
            this.Controls.Add(this.btn_cadastrar_conta);
            this.Controls.Add(this.btn_cadastrar_consumidor);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu_principal";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADA GOTA - Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_principal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar_consumidor;
        private System.Windows.Forms.Button btn_cadastrar_conta;
        private System.Windows.Forms.Button btn_consultar_conta;
        private System.Windows.Forms.Button btn_consultar_variacao;
        private System.Windows.Forms.Button btn_consultar_valor_medio;
        private System.Windows.Forms.Button btn_consultar_maior_valor;
        private System.Windows.Forms.Button btnCadastraImovel;
        private System.Windows.Forms.Button btn_sair;
    }
}

