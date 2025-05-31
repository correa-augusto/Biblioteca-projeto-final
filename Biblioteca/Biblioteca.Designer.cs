namespace Biblioteca
{//AUGUSTO DOS SANTOS CORRÊA
    partial class BibliotecaForm
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
            ButtonPessoa = new Button();
            ButtonExemplar = new Button();
            TabCadastros = new TabControl();
            TabFuncionarios = new TabPage();
            DataViewFuncionario = new DataGridView();
            TabLeitores = new TabPage();
            DataViewLeitores = new DataGridView();
            TabExemplares = new TabPage();
            DataViewExemplares = new DataGridView();
            TabCadastros.SuspendLayout();
            TabFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataViewFuncionario).BeginInit();
            TabLeitores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataViewLeitores).BeginInit();
            TabExemplares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataViewExemplares).BeginInit();
            SuspendLayout();
            // 
            // ButtonPessoa
            // 
            ButtonPessoa.Location = new Point(67, 221);
            ButtonPessoa.Name = "ButtonPessoa";
            ButtonPessoa.Size = new Size(314, 75);
            ButtonPessoa.TabIndex = 0;
            ButtonPessoa.Text = "Cadastro Pessoa";
            ButtonPessoa.UseVisualStyleBackColor = true;
            ButtonPessoa.Click += ButtonPessoa_Click;
            // 
            // ButtonExemplar
            // 
            ButtonExemplar.Location = new Point(67, 342);
            ButtonExemplar.Name = "ButtonExemplar";
            ButtonExemplar.Size = new Size(314, 76);
            ButtonExemplar.TabIndex = 1;
            ButtonExemplar.Text = "Cadastro Exemplar";
            ButtonExemplar.UseVisualStyleBackColor = true;
            ButtonExemplar.Click += ButtonExemplar_Click;
            // 
            // TabCadastros
            // 
            TabCadastros.Controls.Add(TabFuncionarios);
            TabCadastros.Controls.Add(TabLeitores);
            TabCadastros.Controls.Add(TabExemplares);
            TabCadastros.Location = new Point(409, 40);
            TabCadastros.Name = "TabCadastros";
            TabCadastros.SelectedIndex = 0;
            TabCadastros.Size = new Size(523, 487);
            TabCadastros.TabIndex = 2;
            // 
            // TabFuncionarios
            // 
            TabFuncionarios.Controls.Add(DataViewFuncionario);
            TabFuncionarios.Location = new Point(4, 24);
            TabFuncionarios.Name = "TabFuncionarios";
            TabFuncionarios.Padding = new Padding(3);
            TabFuncionarios.Size = new Size(515, 459);
            TabFuncionarios.TabIndex = 0;
            TabFuncionarios.Text = "Funcionarios";
            TabFuncionarios.UseVisualStyleBackColor = true;
            // 
            // DataViewFuncionario
            // 
            DataViewFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataViewFuncionario.Location = new Point(5, 3);
            DataViewFuncionario.Name = "DataViewFuncionario";
            DataViewFuncionario.Size = new Size(503, 213);
            DataViewFuncionario.TabIndex = 0;
            DataViewFuncionario.CellContentClick += DataViewFuncionario_CellContentClick;
            DataViewFuncionario.CellFormatting += DataViewFuncionario_CellFormatting;
            DataViewFuncionario.DoubleClick += DataViewFuncionario_DoubleClick;
            // 
            // TabLeitores
            // 
            TabLeitores.Controls.Add(DataViewLeitores);
            TabLeitores.Location = new Point(4, 24);
            TabLeitores.Name = "TabLeitores";
            TabLeitores.Padding = new Padding(3);
            TabLeitores.Size = new Size(515, 459);
            TabLeitores.TabIndex = 1;
            TabLeitores.Text = "Leitores";
            TabLeitores.UseVisualStyleBackColor = true;
            // 
            // DataViewLeitores
            // 
            DataViewLeitores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataViewLeitores.Location = new Point(3, 0);
            DataViewLeitores.Name = "DataViewLeitores";
            DataViewLeitores.Size = new Size(512, 164);
            DataViewLeitores.TabIndex = 0;
            DataViewLeitores.DoubleClick += DataViewLeitores_DoubleClick;
            // 
            // TabExemplares
            // 
            TabExemplares.Controls.Add(DataViewExemplares);
            TabExemplares.Location = new Point(4, 24);
            TabExemplares.Name = "TabExemplares";
            TabExemplares.Size = new Size(515, 459);
            TabExemplares.TabIndex = 2;
            TabExemplares.Text = "Exemplares";
            TabExemplares.UseVisualStyleBackColor = true;
            // 
            // DataViewExemplares
            // 
            DataViewExemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataViewExemplares.Location = new Point(0, 0);
            DataViewExemplares.Name = "DataViewExemplares";
            DataViewExemplares.Size = new Size(512, 223);
            DataViewExemplares.TabIndex = 0;
            DataViewExemplares.DoubleClick += DataViewExemplares_DoubleClick;
            // 
            // BibliotecaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 773);
            Controls.Add(TabCadastros);
            Controls.Add(ButtonExemplar);
            Controls.Add(ButtonPessoa);
            Name = "BibliotecaForm";
            Text = "Biblioteca";
            Activated += FormBiblioteca_Activated;
            Load += BibliotecaForm_Load;
            TabCadastros.ResumeLayout(false);
            TabFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataViewFuncionario).EndInit();
            TabLeitores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataViewLeitores).EndInit();
            TabExemplares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataViewExemplares).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonPessoa;
        private Button ButtonExemplar;
        private TabControl TabCadastros;
        private TabPage TabFuncionarios;
        private DataGridView DataViewFuncionario;
        private TabPage TabLeitores;
        private DataGridView DataViewLeitores;
        private TabPage TabExemplares;
        private DataGridView DataViewExemplares;
    }
}