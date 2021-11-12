
namespace Projeto_Chamada
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirALunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presençaNoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDePresençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.palestraToolStripMenuItem,
            this.relatorioDePresençaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1017, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunosToolStripMenuItem,
            this.atualizarAlunosToolStripMenuItem,
            this.excluirALunosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.arquivoToolStripMenuItem.Text = "Alunos";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // cadastrarAlunosToolStripMenuItem
            // 
            this.cadastrarAlunosToolStripMenuItem.Name = "cadastrarAlunosToolStripMenuItem";
            this.cadastrarAlunosToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.cadastrarAlunosToolStripMenuItem.Text = "Cadastrar Alunos";
            this.cadastrarAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunosToolStripMenuItem_Click);
            // 
            // atualizarAlunosToolStripMenuItem
            // 
            this.atualizarAlunosToolStripMenuItem.Name = "atualizarAlunosToolStripMenuItem";
            this.atualizarAlunosToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.atualizarAlunosToolStripMenuItem.Text = "Atualizar Alunos";
            this.atualizarAlunosToolStripMenuItem.Click += new System.EventHandler(this.atualizarAlunosToolStripMenuItem_Click);
            // 
            // excluirALunosToolStripMenuItem
            // 
            this.excluirALunosToolStripMenuItem.Name = "excluirALunosToolStripMenuItem";
            this.excluirALunosToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.excluirALunosToolStripMenuItem.Text = "Excluir Alunos";
            this.excluirALunosToolStripMenuItem.Click += new System.EventHandler(this.excluirALunosToolStripMenuItem_Click);
            // 
            // palestraToolStripMenuItem
            // 
            this.palestraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.presençaNoEventoToolStripMenuItem});
            this.palestraToolStripMenuItem.Name = "palestraToolStripMenuItem";
            this.palestraToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.palestraToolStripMenuItem.Text = "Palestra";
            this.palestraToolStripMenuItem.Click += new System.EventHandler(this.palestraToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // presençaNoEventoToolStripMenuItem
            // 
            this.presençaNoEventoToolStripMenuItem.Name = "presençaNoEventoToolStripMenuItem";
            this.presençaNoEventoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.presençaNoEventoToolStripMenuItem.Text = "Presença no Evento";
            this.presençaNoEventoToolStripMenuItem.Click += new System.EventHandler(this.presençaNoEventoToolStripMenuItem_Click);
            // 
            // relatorioDePresençaToolStripMenuItem
            // 
            this.relatorioDePresençaToolStripMenuItem.Name = "relatorioDePresençaToolStripMenuItem";
            this.relatorioDePresençaToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.relatorioDePresençaToolStripMenuItem.Text = "Relatório de presença";
            this.relatorioDePresençaToolStripMenuItem.Click += new System.EventHandler(this.relatórioDePresençaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 529);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Controle de Presença";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presençaNoEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirALunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDePresençaToolStripMenuItem;
    }
}

