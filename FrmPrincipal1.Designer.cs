namespace PDV
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuários = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLancarVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacaoRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaidasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProduto,
            this.MenuMovimentacoes,
            this.MenuRelatorios,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1307, 32);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCliente,
            this.MenuFuncionario,
            this.MenuUsuários,
            this.MenuCargos,
            this.MenuFornecedor});
            this.MenuCadastro.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(121, 28);
            this.MenuCadastro.Text = "CADASTROS";
            // 
            // MenuCliente
            // 
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(180, 28);
            this.MenuCliente.Text = "Cliente";
            this.MenuCliente.Click += new System.EventHandler(this.abrirCadastroDeUsuario);
            // 
            // MenuFuncionario
            // 
            this.MenuFuncionario.Name = "MenuFuncionario";
            this.MenuFuncionario.Size = new System.Drawing.Size(180, 28);
            this.MenuFuncionario.Text = "Funcionário";
            // 
            // MenuUsuários
            // 
            this.MenuUsuários.Name = "MenuUsuários";
            this.MenuUsuários.Size = new System.Drawing.Size(180, 28);
            this.MenuUsuários.Text = "Usuários";
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            this.MenuCargos.Size = new System.Drawing.Size(180, 28);
            this.MenuCargos.Text = "Cargos";
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(180, 28);
            this.MenuFornecedor.Text = "Fornecedor";
            // 
            // MenuProduto
            // 
            this.MenuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutos,
            this.MenuEstoque});
            this.MenuProduto.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(113, 28);
            this.MenuProduto.Text = "PRODUTOS";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(180, 28);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(180, 28);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFluxoCaixa,
            this.MenuLancarVendas,
            this.MenuEntradas,
            this.MenuSaidas,
            this.MenuDespesas});
            this.MenuMovimentacoes.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(173, 28);
            this.MenuMovimentacoes.Text = "MOVIMENTAÇÕES";
            // 
            // MenuFluxoCaixa
            // 
            this.MenuFluxoCaixa.Name = "MenuFluxoCaixa";
            this.MenuFluxoCaixa.Size = new System.Drawing.Size(186, 28);
            this.MenuFluxoCaixa.Text = "Fluxo caixa";
            // 
            // MenuLancarVendas
            // 
            this.MenuLancarVendas.Name = "MenuLancarVendas";
            this.MenuLancarVendas.Size = new System.Drawing.Size(186, 28);
            this.MenuLancarVendas.Text = "Lançar venda";
            // 
            // MenuEntradas
            // 
            this.MenuEntradas.Name = "MenuEntradas";
            this.MenuEntradas.Size = new System.Drawing.Size(186, 28);
            this.MenuEntradas.Text = "Entradas";
            // 
            // MenuSaidas
            // 
            this.MenuSaidas.Name = "MenuSaidas";
            this.MenuSaidas.Size = new System.Drawing.Size(186, 28);
            this.MenuSaidas.Text = "Saídas";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(186, 28);
            this.MenuDespesas.Text = "Despesas";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutosRel,
            this.MenuVendasRel,
            this.MenuMovimentacaoRel,
            this.MenuEntradasRel,
            this.MenuSaidasRel,
            this.MenuDespesasRel});
            this.MenuRelatorios.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(117, 28);
            this.MenuRelatorios.Text = "RELATÓRIO";
            // 
            // MenuProdutosRel
            // 
            this.MenuProdutosRel.Name = "MenuProdutosRel";
            this.MenuProdutosRel.Size = new System.Drawing.Size(198, 28);
            this.MenuProdutosRel.Text = "Produtos";
            // 
            // MenuVendasRel
            // 
            this.MenuVendasRel.Name = "MenuVendasRel";
            this.MenuVendasRel.Size = new System.Drawing.Size(198, 28);
            this.MenuVendasRel.Text = "Vendas";
            // 
            // MenuMovimentacaoRel
            // 
            this.MenuMovimentacaoRel.Name = "MenuMovimentacaoRel";
            this.MenuMovimentacaoRel.Size = new System.Drawing.Size(198, 28);
            this.MenuMovimentacaoRel.Text = "Movimentação";
            // 
            // MenuEntradasRel
            // 
            this.MenuEntradasRel.Name = "MenuEntradasRel";
            this.MenuEntradasRel.Size = new System.Drawing.Size(198, 28);
            this.MenuEntradasRel.Text = "Entradas";
            // 
            // MenuSaidasRel
            // 
            this.MenuSaidasRel.Name = "MenuSaidasRel";
            this.MenuSaidasRel.Size = new System.Drawing.Size(198, 28);
            this.MenuSaidasRel.Text = "Saídas";
            // 
            // MenuDespesasRel
            // 
            this.MenuDespesasRel.Name = "MenuDespesasRel";
            this.MenuDespesasRel.Size = new System.Drawing.Size(198, 28);
            this.MenuDespesasRel.Text = "Despesas";
            // 
            // MenuSair
            // 
            this.MenuSair.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(61, 28);
            this.MenuSair.Text = "SAIR";
            this.MenuSair.Click += new System.EventHandler(this.buttonSair);
            // 
            // img01
            // 
            this.img01.Image = ((System.Drawing.Image)(resources.GetObject("img01.Image")));
            this.img01.Location = new System.Drawing.Point(183, 82);
            this.img01.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(195, 166);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img01.TabIndex = 2;
            this.img01.TabStop = false;
            // 
            // img04
            // 
            this.img04.Image = ((System.Drawing.Image)(resources.GetObject("img04.Image")));
            this.img04.Location = new System.Drawing.Point(378, 254);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(211, 148);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img04.TabIndex = 3;
            this.img04.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = ((System.Drawing.Image)(resources.GetObject("img02.Image")));
            this.img02.Location = new System.Drawing.Point(378, 82);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(205, 166);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img02.TabIndex = 3;
            this.img02.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = ((System.Drawing.Image)(resources.GetObject("img03.Image")));
            this.img03.Location = new System.Drawing.Point(183, 254);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(195, 148);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img03.TabIndex = 4;
            this.img03.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1307, 588);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.ToolStripMenuItem MenuCliente;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuários;
        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxoCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuLancarVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradas;
        private System.Windows.Forms.ToolStripMenuItem MenuSaidas;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuVendasRel;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacaoRel;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradasRel;
        private System.Windows.Forms.ToolStripMenuItem MenuSaidasRel;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesasRel;
    }
}

