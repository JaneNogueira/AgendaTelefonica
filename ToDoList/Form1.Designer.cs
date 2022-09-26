namespace ToDoList
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.bxNome = new System.Windows.Forms.TextBox();
            this.bxEndereco = new System.Windows.Forms.TextBox();
            this.bxTelefone = new System.Windows.Forms.TextBox();
            this.bxEmail = new System.Windows.Forms.TextBox();
            this.dataContatos = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnExcluir);
            this.panelMenu.Controls.Add(this.btnLimpar);
            this.panelMenu.Controls.Add(this.btnEditar);
            this.panelMenu.Controls.Add(this.btnAdicionar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 493);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleDescription = "Exclui Deleta um contato da Lista";
            this.btnExcluir.AccessibleName = "Excluir";
            this.btnExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.Location = new System.Drawing.Point(0, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(188, 90);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AccessibleDescription = "Limpa o formulário";
            this.btnLimpar.AccessibleName = "Limpar";
            this.btnLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.Location = new System.Drawing.Point(0, 255);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(188, 90);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleDescription = "Edita e altera um contato";
            this.btnEditar.AccessibleName = "Editar";
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.Location = new System.Drawing.Point(0, 165);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(188, 90);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AccessibleDescription = "Adiciona um contato";
            this.btnAdicionar.AccessibleName = "Adicionar";
            this.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 75);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(188, 90);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 75);
            this.panelLogo.TabIndex = 1;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnClose);
            this.panelBarraTitulo.Controls.Add(this.lbLista);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(188, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(676, 75);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AccessibleDescription = "Botão de Minimizar a Janela";
            this.btnMinimizar.AccessibleName = "Minimizar";
            this.btnMinimizar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Conthrax Sb", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.Location = new System.Drawing.Point(553, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.Text = "O";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.AccessibleDescription = "Botão de Maximizar a Janela";
            this.btnMaximizar.AccessibleName = "Maximizar";
            this.btnMaximizar.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Conthrax Sb", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximizar.Location = new System.Drawing.Point(596, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.Text = "O";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "Botão de fechar a Janela";
            this.btnClose.AccessibleName = "Fechar";
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Conthrax Sb", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(639, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbLista
            // 
            this.lbLista.AccessibleDescription = "Lista Telefônica";
            this.lbLista.AccessibleName = "Lista Telefônica";
            this.lbLista.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.lbLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLista.AutoSize = true;
            this.lbLista.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbLista.Location = new System.Drawing.Point(232, 26);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(227, 25);
            this.lbLista.TabIndex = 2;
            this.lbLista.Text = "Lista Telefônica";
            this.lbLista.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNome.AutoSize = true;
            this.lbNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNome.Location = new System.Drawing.Point(226, 99);
            this.lbNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(100, 25);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbEndereco
            // 
            this.lbEndereco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEndereco.Location = new System.Drawing.Point(226, 150);
            this.lbEndereco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(156, 25);
            this.lbEndereco.TabIndex = 3;
            this.lbEndereco.Text = "Endereço:";
            this.lbEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTelefone
            // 
            this.lbTelefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTelefone.Location = new System.Drawing.Point(226, 201);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(137, 25);
            this.lbTelefone.TabIndex = 4;
            this.lbTelefone.Text = "Telefone:";
            this.lbTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmail.AutoSize = true;
            this.lbEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEmail.Location = new System.Drawing.Point(226, 250);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(100, 25);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "e-mail:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bxNome
            // 
            this.bxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bxNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bxNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.bxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bxNome.Location = new System.Drawing.Point(392, 99);
            this.bxNome.Name = "bxNome";
            this.bxNome.Size = new System.Drawing.Size(445, 26);
            this.bxNome.TabIndex = 7;
            this.bxNome.UseWaitCursor = true;
            this.bxNome.TextChanged += new System.EventHandler(this.bxNome_TextChanged);
            // 
            // bxEndereco
            // 
            this.bxEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bxEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bxEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.bxEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bxEndereco.Location = new System.Drawing.Point(392, 149);
            this.bxEndereco.Name = "bxEndereco";
            this.bxEndereco.Size = new System.Drawing.Size(445, 26);
            this.bxEndereco.TabIndex = 8;
            this.bxEndereco.UseWaitCursor = true;
            // 
            // bxTelefone
            // 
            this.bxTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bxTelefone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bxTelefone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.bxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bxTelefone.Location = new System.Drawing.Point(392, 199);
            this.bxTelefone.Name = "bxTelefone";
            this.bxTelefone.Size = new System.Drawing.Size(445, 26);
            this.bxTelefone.TabIndex = 9;
            this.bxTelefone.UseWaitCursor = true;
            this.bxTelefone.TextChanged += new System.EventHandler(this.txtbxTelefone_TextChanged);

            // 
            // bxEmail
            // 
            this.bxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bxEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.bxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bxEmail.Location = new System.Drawing.Point(392, 249);
            this.bxEmail.Name = "bxEmail";
            this.bxEmail.Size = new System.Drawing.Size(445, 26);
            this.bxEmail.TabIndex = 10;
            this.bxEmail.UseWaitCursor = true;
            this.bxEmail.TextChanged += new System.EventHandler(this.txtbxEmail_TextChanged);
            // 
            // dataContatos
            // 
            this.dataContatos.AllowUserToAddRows = false;
            this.dataContatos.AllowUserToDeleteRows = false;
            this.dataContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataContatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataContatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.endereco,
            this.telefone,
            this.email});
            this.dataContatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataContatos.GridColor = System.Drawing.Color.Gainsboro;
            this.dataContatos.Location = new System.Drawing.Point(188, 313);
            this.dataContatos.Name = "dataContatos";
            this.dataContatos.ReadOnly = true;
            this.dataContatos.Size = new System.Drawing.Size(676, 180);
            this.dataContatos.TabIndex = 11;
            this.dataContatos.SelectionChanged += new System.EventHandler(this.dataContatos_SelectionChanged);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(864, 493);
            this.Controls.Add(this.dataContatos);
            this.Controls.Add(this.bxEmail);
            this.Controls.Add(this.bxTelefone);
            this.Controls.Add(this.bxEndereco);
            this.Controls.Add(this.bxNome);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Neuropol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.MinimumSize = new System.Drawing.Size(880, 532);
            this.Name = "Form1";
            this.Text = "Agenda Telefônica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lbLista;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox bxNome;
        private System.Windows.Forms.TextBox bxEndereco;
        private System.Windows.Forms.TextBox bxTelefone;
        private System.Windows.Forms.TextBox bxEmail;
        private System.Windows.Forms.DataGridView dataContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}

