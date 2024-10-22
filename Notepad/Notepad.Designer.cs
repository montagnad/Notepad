namespace Notepad
{
    partial class BlocoDeNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlocoDeNotas));
            this.barraDeMenu = new System.Windows.Forms.MenuStrip();
            this.arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.editar = new System.Windows.Forms.ToolStripMenuItem();
            this.formatar = new System.Windows.Forms.ToolStripMenuItem();
            this.exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirBarraDeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeStatus = new System.Windows.Forms.StatusStrip();
            this.labelLinha = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelDivisor = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelColuna = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelColumn = new System.Windows.Forms.ToolStripStatusLabel();
            this.caixaDeTexto = new System.Windows.Forms.RichTextBox();
            this.arquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.editarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.editarSelecionarTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarQuebraDeLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeMenu.SuspendLayout();
            this.barraDeStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraDeMenu
            // 
            this.barraDeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivo,
            this.editar,
            this.formatar,
            this.exibir,
            this.ajuda});
            this.barraDeMenu.Location = new System.Drawing.Point(0, 0);
            this.barraDeMenu.Name = "barraDeMenu";
            this.barraDeMenu.Size = new System.Drawing.Size(1200, 24);
            this.barraDeMenu.TabIndex = 0;
            this.barraDeMenu.Text = "menuStrip1";
            // 
            // arquivo
            // 
            this.arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoNovo,
            this.arquivoAbrir,
            this.arquivoSalvar,
            this.arquivoSalvarComo,
            this.arquivoSair});
            this.arquivo.Name = "arquivo";
            this.arquivo.Size = new System.Drawing.Size(61, 20);
            this.arquivo.Text = "Arquivo";
            // 
            // editar
            // 
            this.editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarDesfazer,
            this.editarRecortar,
            this.editarCopiar,
            this.editarColar,
            this.editarSelecionarTudo});
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(49, 20);
            this.editar.Text = "Editar";
            // 
            // formatar
            // 
            this.formatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatarQuebraDeLinha,
            this.formatarFonte});
            this.formatar.Name = "formatar";
            this.formatar.Size = new System.Drawing.Size(67, 20);
            this.formatar.Text = "Formatar";
            // 
            // exibir
            // 
            this.exibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirBarraDeStatus});
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(47, 20);
            this.exibir.Text = "Exibir";
            // 
            // exibirBarraDeStatus
            // 
            this.exibirBarraDeStatus.Checked = true;
            this.exibirBarraDeStatus.CheckOnClick = true;
            this.exibirBarraDeStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exibirBarraDeStatus.Name = "exibirBarraDeStatus";
            this.exibirBarraDeStatus.Size = new System.Drawing.Size(152, 22);
            this.exibirBarraDeStatus.Text = "Barra de Status";
            this.exibirBarraDeStatus.Click += new System.EventHandler(this.barraDeStatusToolStripMenuItem_Click);
            // 
            // ajuda
            // 
            this.ajuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaSobre});
            this.ajuda.Name = "ajuda";
            this.ajuda.Size = new System.Drawing.Size(50, 20);
            this.ajuda.Text = "Ajuda";
            // 
            // barraDeStatus
            // 
            this.barraDeStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelLinha,
            this.labelLine,
            this.labelDivisor,
            this.labelColuna,
            this.labelColumn});
            this.barraDeStatus.Location = new System.Drawing.Point(0, 578);
            this.barraDeStatus.Name = "barraDeStatus";
            this.barraDeStatus.Size = new System.Drawing.Size(1200, 22);
            this.barraDeStatus.TabIndex = 1;
            this.barraDeStatus.Text = "statusStrip1";
            // 
            // labelLinha
            // 
            this.labelLinha.Name = "labelLinha";
            this.labelLinha.Size = new System.Drawing.Size(20, 17);
            this.labelLinha.Text = "Ln";
            this.labelLinha.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // labelLine
            // 
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(26, 17);
            this.labelLine.Text = "line";
            // 
            // labelDivisor
            // 
            this.labelDivisor.Name = "labelDivisor";
            this.labelDivisor.Size = new System.Drawing.Size(10, 17);
            this.labelDivisor.Text = "|";
            // 
            // labelColuna
            // 
            this.labelColuna.Name = "labelColuna";
            this.labelColuna.Size = new System.Drawing.Size(25, 17);
            this.labelColuna.Text = "Col";
            // 
            // labelColumn
            // 
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(48, 17);
            this.labelColumn.Text = "column";
            // 
            // caixaDeTexto
            // 
            this.caixaDeTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caixaDeTexto.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaDeTexto.Location = new System.Drawing.Point(12, 27);
            this.caixaDeTexto.Name = "caixaDeTexto";
            this.caixaDeTexto.Size = new System.Drawing.Size(1176, 548);
            this.caixaDeTexto.TabIndex = 2;
            this.caixaDeTexto.Text = "";
            this.caixaDeTexto.CursorChanged += new System.EventHandler(this.caixaDeTexto_CursorChanged);
            this.caixaDeTexto.LocationChanged += new System.EventHandler(this.caixaDeTexto_LocationChanged);
            this.caixaDeTexto.TextChanged += new System.EventHandler(this.caixaDeTexto_TextChanged);
            this.caixaDeTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.caixaDeTexto_KeyDown);
            this.caixaDeTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caixaDeTexto_KeyPress);
            this.caixaDeTexto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.caixaDeTexto_MouseDown);
            // 
            // arquivoNovo
            // 
            this.arquivoNovo.Image = ((System.Drawing.Image)(resources.GetObject("arquivoNovo.Image")));
            this.arquivoNovo.Name = "arquivoNovo";
            this.arquivoNovo.Size = new System.Drawing.Size(141, 22);
            this.arquivoNovo.Text = "Novo";
            this.arquivoNovo.ToolTipText = "Crie um novo arquivo";
            // 
            // arquivoAbrir
            // 
            this.arquivoAbrir.Image = global::Notepad.Properties.Resources.icons8_abrir_arquivo_96;
            this.arquivoAbrir.Name = "arquivoAbrir";
            this.arquivoAbrir.Size = new System.Drawing.Size(141, 22);
            this.arquivoAbrir.Text = "Abrir";
            // 
            // arquivoSalvar
            // 
            this.arquivoSalvar.Image = global::Notepad.Properties.Resources.icons8_salvar_96;
            this.arquivoSalvar.Name = "arquivoSalvar";
            this.arquivoSalvar.Size = new System.Drawing.Size(141, 22);
            this.arquivoSalvar.Text = "Salvar";
            // 
            // arquivoSalvarComo
            // 
            this.arquivoSalvarComo.Image = global::Notepad.Properties.Resources.icons8_salvar_como_96;
            this.arquivoSalvarComo.Name = "arquivoSalvarComo";
            this.arquivoSalvarComo.Size = new System.Drawing.Size(141, 22);
            this.arquivoSalvarComo.Text = "Salvar Como";
            // 
            // arquivoSair
            // 
            this.arquivoSair.Image = global::Notepad.Properties.Resources.icons8_sair_96;
            this.arquivoSair.Name = "arquivoSair";
            this.arquivoSair.Size = new System.Drawing.Size(141, 22);
            this.arquivoSair.Text = "Sair";
            this.arquivoSair.Click += new System.EventHandler(this.arquivoSair_Click);
            // 
            // editarDesfazer
            // 
            this.editarDesfazer.Image = global::Notepad.Properties.Resources.icons8_desfazer_96;
            this.editarDesfazer.Name = "editarDesfazer";
            this.editarDesfazer.Size = new System.Drawing.Size(159, 22);
            this.editarDesfazer.Text = "Desfazer";
            // 
            // editarRecortar
            // 
            this.editarRecortar.Image = global::Notepad.Properties.Resources.icons8_cortar_96;
            this.editarRecortar.Name = "editarRecortar";
            this.editarRecortar.Size = new System.Drawing.Size(159, 22);
            this.editarRecortar.Text = "Recortar";
            // 
            // editarCopiar
            // 
            this.editarCopiar.Image = global::Notepad.Properties.Resources.icons8_copiar_96;
            this.editarCopiar.Name = "editarCopiar";
            this.editarCopiar.Size = new System.Drawing.Size(159, 22);
            this.editarCopiar.Text = "Copiar";
            // 
            // editarColar
            // 
            this.editarColar.Image = global::Notepad.Properties.Resources.icons8_colar_96;
            this.editarColar.Name = "editarColar";
            this.editarColar.Size = new System.Drawing.Size(159, 22);
            this.editarColar.Text = "Colar";
            // 
            // editarSelecionarTudo
            // 
            this.editarSelecionarTudo.Image = global::Notepad.Properties.Resources.icons8_selecionar_tudo_96;
            this.editarSelecionarTudo.Name = "editarSelecionarTudo";
            this.editarSelecionarTudo.Size = new System.Drawing.Size(159, 22);
            this.editarSelecionarTudo.Text = "Selecionar Tudo";
            // 
            // formatarQuebraDeLinha
            // 
            this.formatarQuebraDeLinha.Checked = true;
            this.formatarQuebraDeLinha.CheckOnClick = true;
            this.formatarQuebraDeLinha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.formatarQuebraDeLinha.Image = global::Notepad.Properties.Resources.icons8_quebra_de_linha_96;
            this.formatarQuebraDeLinha.Name = "formatarQuebraDeLinha";
            this.formatarQuebraDeLinha.Size = new System.Drawing.Size(161, 22);
            this.formatarQuebraDeLinha.Text = "Quebra de Linha";
            this.formatarQuebraDeLinha.Click += new System.EventHandler(this.formatarQuebraDeLinha_Click);
            // 
            // formatarFonte
            // 
            this.formatarFonte.Image = global::Notepad.Properties.Resources.icons8_fonte_96;
            this.formatarFonte.Name = "formatarFonte";
            this.formatarFonte.Size = new System.Drawing.Size(161, 22);
            this.formatarFonte.Text = "Fonte";
            // 
            // ajudaSobre
            // 
            this.ajudaSobre.Image = global::Notepad.Properties.Resources.icons8_informações_96;
            this.ajudaSobre.Name = "ajudaSobre";
            this.ajudaSobre.Size = new System.Drawing.Size(180, 22);
            this.ajudaSobre.Text = "Sobre";
            this.ajudaSobre.Click += new System.EventHandler(this.ajudaSobre_Click);
            // 
            // BlocoDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.caixaDeTexto);
            this.Controls.Add(this.barraDeStatus);
            this.Controls.Add(this.barraDeMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barraDeMenu;
            this.Name = "BlocoDeNotas";
            this.Text = "CtrlAltDanrlei | Notepad";
            this.barraDeMenu.ResumeLayout(false);
            this.barraDeMenu.PerformLayout();
            this.barraDeStatus.ResumeLayout(false);
            this.barraDeStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip barraDeMenu;
        private System.Windows.Forms.ToolStripMenuItem arquivo;
        private System.Windows.Forms.ToolStripMenuItem arquivoNovo;
        private System.Windows.Forms.ToolStripMenuItem arquivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem arquivoSalvar;
        private System.Windows.Forms.ToolStripMenuItem arquivoSalvarComo;
        private System.Windows.Forms.ToolStripMenuItem arquivoSair;
        private System.Windows.Forms.ToolStripMenuItem editar;
        private System.Windows.Forms.ToolStripMenuItem editarDesfazer;
        private System.Windows.Forms.ToolStripMenuItem editarRecortar;
        private System.Windows.Forms.ToolStripMenuItem editarCopiar;
        private System.Windows.Forms.ToolStripMenuItem editarColar;
        private System.Windows.Forms.ToolStripMenuItem editarSelecionarTudo;
        private System.Windows.Forms.ToolStripMenuItem formatar;
        private System.Windows.Forms.ToolStripMenuItem formatarQuebraDeLinha;
        private System.Windows.Forms.ToolStripMenuItem formatarFonte;
        private System.Windows.Forms.ToolStripMenuItem ajuda;
        private System.Windows.Forms.ToolStripMenuItem ajudaSobre;
        private System.Windows.Forms.StatusStrip barraDeStatus;
        private System.Windows.Forms.ToolStripStatusLabel labelLinha;
        private System.Windows.Forms.ToolStripStatusLabel labelLine;
        private System.Windows.Forms.ToolStripStatusLabel labelDivisor;
        private System.Windows.Forms.ToolStripStatusLabel labelColuna;
        private System.Windows.Forms.ToolStripStatusLabel labelColumn;
        private System.Windows.Forms.ToolStripMenuItem exibir;
        private System.Windows.Forms.ToolStripMenuItem exibirBarraDeStatus;
        private System.Windows.Forms.RichTextBox caixaDeTexto;
    }
}

