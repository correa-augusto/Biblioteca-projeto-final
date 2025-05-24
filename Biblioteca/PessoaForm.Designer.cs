namespace Biblioteca
{
    partial class PessoaForm
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
            PessoaGroup = new GroupBox();
            LabelTelefone = new Label();
            MaskedTelefone = new MaskedTextBox();
            LabelEmail = new Label();
            TextBoxEmail = new TextBox();
            LabelCpf = new Label();
            MaskedCpf = new MaskedTextBox();
            LabelNascimento = new Label();
            DateTimePickerNasc = new DateTimePicker();
            LabelNome = new Label();
            TextBoxNome = new TextBox();
            TabFuncionario = new TabPage();
            TextBoxFuncao = new TextBox();
            LabelFuncao = new Label();
            LabelCarga = new Label();
            NumericCarga = new NumericUpDown();
            LabelSalario = new Label();
            NumericSalario = new NumericUpDown();
            LabelCargo = new Label();
            ComboBoxCargo = new ComboBox();
            TabLeitor = new TabPage();
            LabelTipo = new Label();
            ListBoxTipoLeitor = new ListBox();
            PessoaTab = new TabControl();
            ButtonSalvar = new Button();
            PessoaGroup.SuspendLayout();
            TabFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericSalario).BeginInit();
            TabLeitor.SuspendLayout();
            PessoaTab.SuspendLayout();
            SuspendLayout();
            // 
            // PessoaGroup
            // 
            PessoaGroup.Controls.Add(LabelTelefone);
            PessoaGroup.Controls.Add(MaskedTelefone);
            PessoaGroup.Controls.Add(LabelEmail);
            PessoaGroup.Controls.Add(TextBoxEmail);
            PessoaGroup.Controls.Add(LabelCpf);
            PessoaGroup.Controls.Add(MaskedCpf);
            PessoaGroup.Controls.Add(LabelNascimento);
            PessoaGroup.Controls.Add(DateTimePickerNasc);
            PessoaGroup.Controls.Add(LabelNome);
            PessoaGroup.Controls.Add(TextBoxNome);
            PessoaGroup.Location = new Point(44, 38);
            PessoaGroup.Name = "PessoaGroup";
            PessoaGroup.Size = new Size(609, 418);
            PessoaGroup.TabIndex = 0;
            PessoaGroup.TabStop = false;
            PessoaGroup.Text = "Pessoa";
            PessoaGroup.Enter += groupBox1_Enter;
            // 
            // LabelTelefone
            // 
            LabelTelefone.AutoSize = true;
            LabelTelefone.Location = new Point(19, 296);
            LabelTelefone.Name = "LabelTelefone";
            LabelTelefone.Size = new Size(52, 15);
            LabelTelefone.TabIndex = 9;
            LabelTelefone.Text = "Telefone";
            // 
            // MaskedTelefone
            // 
            MaskedTelefone.Location = new Point(19, 314);
            MaskedTelefone.Mask = "(00 ) 00000-0000";
            MaskedTelefone.Name = "MaskedTelefone";
            MaskedTelefone.Size = new Size(139, 23);
            MaskedTelefone.TabIndex = 8;
            MaskedTelefone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(19, 234);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(36, 15);
            LabelEmail.TabIndex = 7;
            LabelEmail.Text = "Email";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(19, 252);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(546, 23);
            TextBoxEmail.TabIndex = 6;
            // 
            // LabelCpf
            // 
            LabelCpf.AutoSize = true;
            LabelCpf.Location = new Point(19, 174);
            LabelCpf.Name = "LabelCpf";
            LabelCpf.Size = new Size(26, 15);
            LabelCpf.TabIndex = 5;
            LabelCpf.Text = "Cpf";
            // 
            // MaskedCpf
            // 
            MaskedCpf.Location = new Point(19, 192);
            MaskedCpf.Mask = "000.000.000-00";
            MaskedCpf.Name = "MaskedCpf";
            MaskedCpf.Size = new Size(139, 23);
            MaskedCpf.TabIndex = 4;
            MaskedCpf.MaskInputRejected += Cpf_MaskInputRejected;
            // 
            // LabelNascimento
            // 
            LabelNascimento.AutoSize = true;
            LabelNascimento.Location = new Point(19, 111);
            LabelNascimento.Name = "LabelNascimento";
            LabelNascimento.Size = new Size(71, 15);
            LabelNascimento.TabIndex = 3;
            LabelNascimento.Text = "Nascimento";
            // 
            // DateTimePickerNasc
            // 
            DateTimePickerNasc.Location = new Point(19, 129);
            DateTimePickerNasc.Name = "DateTimePickerNasc";
            DateTimePickerNasc.Size = new Size(200, 23);
            DateTimePickerNasc.TabIndex = 2;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(19, 44);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(40, 15);
            LabelNome.TabIndex = 1;
            LabelNome.Text = "Nome";
            LabelNome.TextAlign = ContentAlignment.TopCenter;
            LabelNome.Click += label1_Click;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(19, 62);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(546, 23);
            TextBoxNome.TabIndex = 0;
            // 
            // TabFuncionario
            // 
            TabFuncionario.Controls.Add(TextBoxFuncao);
            TabFuncionario.Controls.Add(LabelFuncao);
            TabFuncionario.Controls.Add(LabelCarga);
            TabFuncionario.Controls.Add(NumericCarga);
            TabFuncionario.Controls.Add(LabelSalario);
            TabFuncionario.Controls.Add(NumericSalario);
            TabFuncionario.Controls.Add(LabelCargo);
            TabFuncionario.Controls.Add(ComboBoxCargo);
            TabFuncionario.Location = new Point(4, 24);
            TabFuncionario.Name = "TabFuncionario";
            TabFuncionario.Padding = new Padding(3);
            TabFuncionario.Size = new Size(552, 390);
            TabFuncionario.TabIndex = 1;
            TabFuncionario.Text = "Funcionario";
            TabFuncionario.UseVisualStyleBackColor = true;
            // 
            // TextBoxFuncao
            // 
            TextBoxFuncao.Location = new Point(48, 264);
            TextBoxFuncao.Name = "TextBoxFuncao";
            TextBoxFuncao.Size = new Size(351, 23);
            TextBoxFuncao.TabIndex = 8;
            // 
            // LabelFuncao
            // 
            LabelFuncao.AutoSize = true;
            LabelFuncao.Location = new Point(44, 235);
            LabelFuncao.Name = "LabelFuncao";
            LabelFuncao.Size = new Size(46, 15);
            LabelFuncao.TabIndex = 7;
            LabelFuncao.Text = "Função";
            // 
            // LabelCarga
            // 
            LabelCarga.AutoSize = true;
            LabelCarga.Location = new Point(45, 170);
            LabelCarga.Name = "LabelCarga";
            LabelCarga.Size = new Size(80, 15);
            LabelCarga.TabIndex = 5;
            LabelCarga.Text = "Carga Horária";
            // 
            // NumericCarga
            // 
            NumericCarga.Location = new Point(49, 188);
            NumericCarga.Name = "NumericCarga";
            NumericCarga.Size = new Size(120, 23);
            NumericCarga.TabIndex = 4;
            // 
            // LabelSalario
            // 
            LabelSalario.AutoSize = true;
            LabelSalario.Location = new Point(45, 111);
            LabelSalario.Name = "LabelSalario";
            LabelSalario.Size = new Size(42, 15);
            LabelSalario.TabIndex = 3;
            LabelSalario.Text = "Salario";
            // 
            // NumericSalario
            // 
            NumericSalario.Location = new Point(49, 129);
            NumericSalario.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            NumericSalario.Name = "NumericSalario";
            NumericSalario.Size = new Size(120, 23);
            NumericSalario.TabIndex = 2;
            // 
            // LabelCargo
            // 
            LabelCargo.AutoSize = true;
            LabelCargo.Location = new Point(45, 58);
            LabelCargo.Name = "LabelCargo";
            LabelCargo.Size = new Size(39, 15);
            LabelCargo.TabIndex = 1;
            LabelCargo.Text = "Cargo";
            LabelCargo.Click += LabelCargo_Click;
            // 
            // ComboBoxCargo
            // 
            ComboBoxCargo.FormattingEnabled = true;
            ComboBoxCargo.Location = new Point(48, 76);
            ComboBoxCargo.Name = "ComboBoxCargo";
            ComboBoxCargo.Size = new Size(145, 23);
            ComboBoxCargo.TabIndex = 0;
            // 
            // TabLeitor
            // 
            TabLeitor.Controls.Add(LabelTipo);
            TabLeitor.Controls.Add(ListBoxTipoLeitor);
            TabLeitor.Location = new Point(4, 24);
            TabLeitor.Name = "TabLeitor";
            TabLeitor.Padding = new Padding(3);
            TabLeitor.Size = new Size(552, 390);
            TabLeitor.TabIndex = 0;
            TabLeitor.Text = "Leitor";
            TabLeitor.UseVisualStyleBackColor = true;
            // 
            // LabelTipo
            // 
            LabelTipo.AutoSize = true;
            LabelTipo.Location = new Point(31, 30);
            LabelTipo.Name = "LabelTipo";
            LabelTipo.Size = new Size(31, 15);
            LabelTipo.TabIndex = 1;
            LabelTipo.Text = "Tipo";
            // 
            // ListBoxTipoLeitor
            // 
            ListBoxTipoLeitor.FormattingEnabled = true;
            ListBoxTipoLeitor.Items.AddRange(new object[] { "Leitor Casual", "Leitor Ávido", "Leitor de Ficção", "Leitor de não Ficção", "Leitor Critico", "Leitor de Best-Sellers", "Leitor de Classicos", "Leitor de Gênero Específico ", "Leitor Âcademico", "Leitor Digital", "Leitor Tradicional", "Leitor de Livros De Bolso", "Leitor multitarefas", "Outros" });
            ListBoxTipoLeitor.Location = new Point(31, 48);
            ListBoxTipoLeitor.Name = "ListBoxTipoLeitor";
            ListBoxTipoLeitor.Size = new Size(496, 244);
            ListBoxTipoLeitor.TabIndex = 0;
            ListBoxTipoLeitor.SelectedIndexChanged += ListBoxTipo_SelectedIndexChanged;
            // 
            // PessoaTab
            // 
            PessoaTab.Controls.Add(TabLeitor);
            PessoaTab.Controls.Add(TabFuncionario);
            PessoaTab.Location = new Point(747, 38);
            PessoaTab.Name = "PessoaTab";
            PessoaTab.SelectedIndex = 0;
            PessoaTab.Size = new Size(560, 418);
            PessoaTab.TabIndex = 1;
            PessoaTab.Tag = "";
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.BackColor = SystemColors.ActiveCaption;
            ButtonSalvar.Location = new Point(12, 491);
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.Size = new Size(1323, 42);
            ButtonSalvar.TabIndex = 2;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.UseVisualStyleBackColor = false;
            ButtonSalvar.Click += ButtonSalvar_Click;
            // 
            // PessoaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1411, 545);
            Controls.Add(ButtonSalvar);
            Controls.Add(PessoaTab);
            Controls.Add(PessoaGroup);
            Name = "PessoaForm";
            Text = "Pessoa";
            Load += PessoaForm_Load;
            PessoaGroup.ResumeLayout(false);
            PessoaGroup.PerformLayout();
            TabFuncionario.ResumeLayout(false);
            TabFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericSalario).EndInit();
            TabLeitor.ResumeLayout(false);
            TabLeitor.PerformLayout();
            PessoaTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox PessoaGroup;
        private TextBox TextBoxNome;
        private Label LabelNome;
        private Label LabelCpf;
        private MaskedTextBox MaskedCpf;
        private Label LabelNascimento;
        private DateTimePicker DateTimePickerNasc;
        private Label LabelTelefone;
        private MaskedTextBox MaskedTelefone;
        private Label LabelEmail;
        private TextBox TextBoxEmail;
        private TabPage TabFuncionario;
        private TabPage TabLeitor;
        private TabControl PessoaTab;
        private Label LabelTipo;
        private ListBox ListBoxTipoLeitor;
        private Label LabelCargo;
        private ComboBox ComboBoxCargo;
        private NumericUpDown NumericSalario;
        internal Label LabelSalario;
        private Label LabelFuncao;
        private Label LabelCarga;
        private NumericUpDown NumericCarga;
        private Button ButtonSalvar;
        private TextBox TextBoxFuncao;
    }
}