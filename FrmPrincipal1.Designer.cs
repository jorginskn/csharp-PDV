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
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MenuCadastro.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(121, 28);
            this.MenuCadastro.Text = "CADASTROS";
            // 
            // MenuProduto
            // 
            this.MenuProduto.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(113, 28);
            this.MenuProduto.Text = "PRODUTOS";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(173, 28);
            this.MenuMovimentacoes.Text = "MOVIMENTAÇÕES";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(117, 28);
            this.MenuRelatorios.Text = "RELATÓRIO";
            // 
            // MenuSair
            // 
            this.MenuSair.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(61, 28);
            this.MenuSair.Text = "SAIR";
            // 
            // img01
            // 
            this.img01.Image = ((System.Drawing.Image)(resources.GetObject("img01.Image")));
            this.img01.Location = new System.Drawing.Point(183, 82);
            this.img01.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(189, 166);
            this.img01.TabIndex = 2;
            this.img01.TabStop = false;
            // 
            // img04
            // 
            this.img04.Location = new System.Drawing.Point(378, 254);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(211, 148);
            this.img04.TabIndex = 3;
            this.img04.TabStop = false;
            // 
            // img02
            // 
            this.img02.Location = new System.Drawing.Point(384, 82);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(205, 166);
            this.img02.TabIndex = 3;
            this.img02.TabStop = false;
            // 
            // img03
            // 
            this.img03.Location = new System.Drawing.Point(183, 254);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(189, 148);
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
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Tela Principal";
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
    }
}

