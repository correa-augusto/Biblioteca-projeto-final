namespace Biblioteca
{
    partial class ExemplarForm
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
            GroupBoxExemplar = new GroupBox();
            LabelSubtitulo = new Label();
            LabelEscritor = new Label();
            LabelEditora = new Label();
            LabelAno = new Label();
            LabelGenero = new Label();
            ComboBoxGenero = new ComboBox();
            LabelStatus = new Label();
            ComboBoxStatus = new ComboBox();
            NumericUpDownAno = new NumericUpDown();
            TextBoxEditora = new TextBox();
            TextBoxEscritor = new TextBox();
            TextBoxSubtitulo = new TextBox();
            LabelTitulo = new Label();
            TextBoxTitulo = new TextBox();
            tabControlExemplar = new TabControl();
            TabLivro = new TabPage();
            GroupBoxEbook = new GroupBox();
            LabelUrl = new Label();
            TextBoxUrl = new TextBox();
            LabekTamanho = new Label();
            NumericTam = new NumericUpDown();
            LabelFormato = new Label();
            ComboBoxFormato = new ComboBox();
            CheckBoxEbook = new CheckBox();
            LabelIsbn = new Label();
            TextBoxIsbn = new TextBox();
            LabelCapa = new Label();
            ComboBoxCapa = new ComboBox();
            LabeNumPag = new Label();
            numericUpDown1 = new NumericUpDown();
            TabRevista = new TabPage();
            LabelPaginas = new Label();
            NumericNumPaginas = new NumericUpDown();
            LabelEdicao = new Label();
            NumericEdicao = new NumericUpDown();
            TabHq = new TabPage();
            LabelIlustrador = new Label();
            TextBoxIlustrador = new TextBox();
            LabelNumEdicao = new Label();
            NumericNumEdicao = new NumericUpDown();
            TabGenerico = new TabPage();
            ListBoxGenerico = new ListBox();
            ButtonSalvar = new Button();
            GroupBoxExemplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAno).BeginInit();
            tabControlExemplar.SuspendLayout();
            TabLivro.SuspendLayout();
            GroupBoxEbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericTam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            TabRevista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericNumPaginas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericEdicao).BeginInit();
            TabHq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericNumEdicao).BeginInit();
            TabGenerico.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxExemplar
            // 
            GroupBoxExemplar.Controls.Add(LabelSubtitulo);
            GroupBoxExemplar.Controls.Add(LabelEscritor);
            GroupBoxExemplar.Controls.Add(LabelEditora);
            GroupBoxExemplar.Controls.Add(LabelAno);
            GroupBoxExemplar.Controls.Add(LabelGenero);
            GroupBoxExemplar.Controls.Add(ComboBoxGenero);
            GroupBoxExemplar.Controls.Add(LabelStatus);
            GroupBoxExemplar.Controls.Add(ComboBoxStatus);
            GroupBoxExemplar.Controls.Add(NumericUpDownAno);
            GroupBoxExemplar.Controls.Add(TextBoxEditora);
            GroupBoxExemplar.Controls.Add(TextBoxEscritor);
            GroupBoxExemplar.Controls.Add(TextBoxSubtitulo);
            GroupBoxExemplar.Controls.Add(LabelTitulo);
            GroupBoxExemplar.Controls.Add(TextBoxTitulo);
            GroupBoxExemplar.Location = new Point(45, 25);
            GroupBoxExemplar.Name = "GroupBoxExemplar";
            GroupBoxExemplar.Size = new Size(600, 556);
            GroupBoxExemplar.TabIndex = 0;
            GroupBoxExemplar.TabStop = false;
            GroupBoxExemplar.Text = "Exemplar";
            // 
            // LabelSubtitulo
            // 
            LabelSubtitulo.AutoSize = true;
            LabelSubtitulo.Location = new Point(22, 113);
            LabelSubtitulo.Name = "LabelSubtitulo";
            LabelSubtitulo.Size = new Size(55, 15);
            LabelSubtitulo.TabIndex = 14;
            LabelSubtitulo.Text = "Subtitulo";
            // 
            // LabelEscritor
            // 
            LabelEscritor.AutoSize = true;
            LabelEscritor.Location = new Point(22, 174);
            LabelEscritor.Name = "LabelEscritor";
            LabelEscritor.Size = new Size(46, 15);
            LabelEscritor.TabIndex = 13;
            LabelEscritor.Text = "Escritor";
            LabelEscritor.Click += LabelEscritor_Click;
            // 
            // LabelEditora
            // 
            LabelEditora.AutoSize = true;
            LabelEditora.Location = new Point(21, 237);
            LabelEditora.Name = "LabelEditora";
            LabelEditora.Size = new Size(44, 15);
            LabelEditora.TabIndex = 12;
            LabelEditora.Text = "Editora";
            // 
            // LabelAno
            // 
            LabelAno.AutoSize = true;
            LabelAno.Location = new Point(22, 310);
            LabelAno.Name = "LabelAno";
            LabelAno.Size = new Size(90, 15);
            LabelAno.TabIndex = 11;
            LabelAno.Text = "Ano Publicação";
            // 
            // LabelGenero
            // 
            LabelGenero.AutoSize = true;
            LabelGenero.Location = new Point(22, 375);
            LabelGenero.Name = "LabelGenero";
            LabelGenero.Size = new Size(45, 15);
            LabelGenero.TabIndex = 10;
            LabelGenero.Text = "Genero";
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Items.AddRange(new object[] { "Romance", "Novela", "Conto", "Crônica", "Poema", " Canção", "Drama histórico", "Teatro de vanguarda" });
            ComboBoxGenero.Location = new Point(21, 393);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(522, 23);
            ComboBoxGenero.TabIndex = 9;
            ComboBoxGenero.SelectedIndexChanged += ComboBoxGenero_SelectedIndexChanged;
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.Location = new Point(21, 443);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(39, 15);
            LabelStatus.TabIndex = 8;
            LabelStatus.Text = "Status";
            // 
            // ComboBoxStatus
            // 
            ComboBoxStatus.FormattingEnabled = true;
            ComboBoxStatus.Location = new Point(21, 461);
            ComboBoxStatus.Name = "ComboBoxStatus";
            ComboBoxStatus.Size = new Size(522, 23);
            ComboBoxStatus.TabIndex = 7;
            // 
            // NumericUpDownAno
            // 
            NumericUpDownAno.Location = new Point(21, 328);
            NumericUpDownAno.Name = "NumericUpDownAno";
            NumericUpDownAno.Size = new Size(120, 23);
            NumericUpDownAno.TabIndex = 5;
            // 
            // TextBoxEditora
            // 
            TextBoxEditora.Location = new Point(21, 255);
            TextBoxEditora.Name = "TextBoxEditora";
            TextBoxEditora.Size = new Size(522, 23);
            TextBoxEditora.TabIndex = 4;
            // 
            // TextBoxEscritor
            // 
            TextBoxEscritor.Location = new Point(21, 192);
            TextBoxEscritor.Name = "TextBoxEscritor";
            TextBoxEscritor.Size = new Size(522, 23);
            TextBoxEscritor.TabIndex = 3;
            // 
            // TextBoxSubtitulo
            // 
            TextBoxSubtitulo.Location = new Point(21, 131);
            TextBoxSubtitulo.Name = "TextBoxSubtitulo";
            TextBoxSubtitulo.Size = new Size(522, 23);
            TextBoxSubtitulo.TabIndex = 2;
            // 
            // LabelTitulo
            // 
            LabelTitulo.AutoSize = true;
            LabelTitulo.Location = new Point(21, 47);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(38, 15);
            LabelTitulo.TabIndex = 1;
            LabelTitulo.Text = "Titulo";
            // 
            // TextBoxTitulo
            // 
            TextBoxTitulo.Location = new Point(21, 65);
            TextBoxTitulo.Name = "TextBoxTitulo";
            TextBoxTitulo.Size = new Size(522, 23);
            TextBoxTitulo.TabIndex = 0;
            // 
            // tabControlExemplar
            // 
            tabControlExemplar.Controls.Add(TabLivro);
            tabControlExemplar.Controls.Add(TabRevista);
            tabControlExemplar.Controls.Add(TabHq);
            tabControlExemplar.Controls.Add(TabGenerico);
            tabControlExemplar.Location = new Point(724, 25);
            tabControlExemplar.Name = "tabControlExemplar";
            tabControlExemplar.SelectedIndex = 0;
            tabControlExemplar.Size = new Size(464, 521);
            tabControlExemplar.TabIndex = 1;
            // 
            // TabLivro
            // 
            TabLivro.Controls.Add(GroupBoxEbook);
            TabLivro.Controls.Add(CheckBoxEbook);
            TabLivro.Controls.Add(LabelIsbn);
            TabLivro.Controls.Add(TextBoxIsbn);
            TabLivro.Controls.Add(LabelCapa);
            TabLivro.Controls.Add(ComboBoxCapa);
            TabLivro.Controls.Add(LabeNumPag);
            TabLivro.Controls.Add(numericUpDown1);
            TabLivro.Location = new Point(4, 24);
            TabLivro.Name = "TabLivro";
            TabLivro.Padding = new Padding(3);
            TabLivro.Size = new Size(456, 493);
            TabLivro.TabIndex = 0;
            TabLivro.Text = "Livro";
            TabLivro.UseVisualStyleBackColor = true;
            // 
            // GroupBoxEbook
            // 
            GroupBoxEbook.Controls.Add(LabelUrl);
            GroupBoxEbook.Controls.Add(TextBoxUrl);
            GroupBoxEbook.Controls.Add(LabekTamanho);
            GroupBoxEbook.Controls.Add(NumericTam);
            GroupBoxEbook.Controls.Add(LabelFormato);
            GroupBoxEbook.Controls.Add(ComboBoxFormato);
            GroupBoxEbook.Location = new Point(25, 251);
            GroupBoxEbook.Name = "GroupBoxEbook";
            GroupBoxEbook.Size = new Size(377, 209);
            GroupBoxEbook.TabIndex = 7;
            GroupBoxEbook.TabStop = false;
            // 
            // LabelUrl
            // 
            LabelUrl.AutoSize = true;
            LabelUrl.Location = new Point(16, 142);
            LabelUrl.Name = "LabelUrl";
            LabelUrl.Size = new Size(28, 15);
            LabelUrl.TabIndex = 5;
            LabelUrl.Text = "URL";
            // 
            // TextBoxUrl
            // 
            TextBoxUrl.Location = new Point(16, 160);
            TextBoxUrl.Name = "TextBoxUrl";
            TextBoxUrl.Size = new Size(337, 23);
            TextBoxUrl.TabIndex = 4;
            // 
            // LabekTamanho
            // 
            LabekTamanho.AutoSize = true;
            LabekTamanho.Location = new Point(11, 82);
            LabekTamanho.Name = "LabekTamanho";
            LabekTamanho.Size = new Size(57, 15);
            LabekTamanho.TabIndex = 3;
            LabekTamanho.Text = "Tamanho";
            LabekTamanho.Click += LabekTamanho_Click;
            // 
            // NumericTam
            // 
            NumericTam.Location = new Point(16, 100);
            NumericTam.Name = "NumericTam";
            NumericTam.Size = new Size(120, 23);
            NumericTam.TabIndex = 2;
            // 
            // LabelFormato
            // 
            LabelFormato.AutoSize = true;
            LabelFormato.Location = new Point(12, 35);
            LabelFormato.Name = "LabelFormato";
            LabelFormato.Size = new Size(52, 15);
            LabelFormato.TabIndex = 1;
            LabelFormato.Text = "Formato";
            // 
            // ComboBoxFormato
            // 
            ComboBoxFormato.FormattingEnabled = true;
            ComboBoxFormato.Items.AddRange(new object[] { "Portable Document Format (PDF)", "", "", "Electronic Publication (ePUB)", "", "", "Mobipocket (MOBI)", "", "", "Kindle Package Format (KPF)", "", "", "Outros" });
            ComboBoxFormato.Location = new Point(16, 53);
            ComboBoxFormato.Name = "ComboBoxFormato";
            ComboBoxFormato.Size = new Size(337, 23);
            ComboBoxFormato.TabIndex = 0;
            // 
            // CheckBoxEbook
            // 
            CheckBoxEbook.AutoSize = true;
            CheckBoxEbook.Location = new Point(25, 213);
            CheckBoxEbook.Name = "CheckBoxEbook";
            CheckBoxEbook.Size = new Size(64, 19);
            CheckBoxEbook.TabIndex = 6;
            CheckBoxEbook.Text = "EBOOK";
            CheckBoxEbook.UseVisualStyleBackColor = true;
            CheckBoxEbook.CheckedChanged += CheckBoxEbook_CheckedChanged;
            // 
            // LabelIsbn
            // 
            LabelIsbn.AutoSize = true;
            LabelIsbn.Location = new Point(25, 141);
            LabelIsbn.Name = "LabelIsbn";
            LabelIsbn.Size = new Size(32, 15);
            LabelIsbn.TabIndex = 5;
            LabelIsbn.Text = "ISBN";
            // 
            // TextBoxIsbn
            // 
            TextBoxIsbn.Location = new Point(25, 159);
            TextBoxIsbn.Name = "TextBoxIsbn";
            TextBoxIsbn.Size = new Size(377, 23);
            TextBoxIsbn.TabIndex = 4;
            // 
            // LabelCapa
            // 
            LabelCapa.AutoSize = true;
            LabelCapa.Location = new Point(25, 89);
            LabelCapa.Name = "LabelCapa";
            LabelCapa.Size = new Size(77, 15);
            LabelCapa.TabIndex = 3;
            LabelCapa.Text = "Tipo da Capa";
            // 
            // ComboBoxCapa
            // 
            ComboBoxCapa.FormattingEnabled = true;
            ComboBoxCapa.Items.AddRange(new object[] { "Capa Dura", "Capa Flexível ou Brochura", "Capa de Papel Cartão", "Capa com Sobrecapa (Jacket) • Capa com Relevo", "Capa com Verniz UV", "Capa Metalizada", "Capa de Tecido", "Capa com Janela", "Capa Transparente", "Capa Digital" });
            ComboBoxCapa.Location = new Point(25, 107);
            ComboBoxCapa.Name = "ComboBoxCapa";
            ComboBoxCapa.Size = new Size(377, 23);
            ComboBoxCapa.TabIndex = 2;
            // 
            // LabeNumPag
            // 
            LabeNumPag.AutoSize = true;
            LabeNumPag.Location = new Point(25, 34);
            LabeNumPag.Name = "LabeNumPag";
            LabeNumPag.Size = new Size(48, 15);
            LabeNumPag.TabIndex = 1;
            LabeNumPag.Text = "Paginas";
            LabeNumPag.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(25, 52);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(95, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // TabRevista
            // 
            TabRevista.Controls.Add(LabelPaginas);
            TabRevista.Controls.Add(NumericNumPaginas);
            TabRevista.Controls.Add(LabelEdicao);
            TabRevista.Controls.Add(NumericEdicao);
            TabRevista.Location = new Point(4, 24);
            TabRevista.Name = "TabRevista";
            TabRevista.Padding = new Padding(3);
            TabRevista.Size = new Size(456, 493);
            TabRevista.TabIndex = 1;
            TabRevista.Text = "Revista";
            TabRevista.UseVisualStyleBackColor = true;
            // 
            // LabelPaginas
            // 
            LabelPaginas.AutoSize = true;
            LabelPaginas.Location = new Point(41, 104);
            LabelPaginas.Name = "LabelPaginas";
            LabelPaginas.Size = new Size(48, 15);
            LabelPaginas.TabIndex = 3;
            LabelPaginas.Text = "Paginas";
            LabelPaginas.Click += label1_Click_1;
            // 
            // NumericNumPaginas
            // 
            NumericNumPaginas.Location = new Point(41, 122);
            NumericNumPaginas.Name = "NumericNumPaginas";
            NumericNumPaginas.Size = new Size(120, 23);
            NumericNumPaginas.TabIndex = 2;
            NumericNumPaginas.ValueChanged += NumericNumPaginas_ValueChanged;
            // 
            // LabelEdicao
            // 
            LabelEdicao.AutoSize = true;
            LabelEdicao.Location = new Point(41, 41);
            LabelEdicao.Name = "LabelEdicao";
            LabelEdicao.Size = new Size(42, 15);
            LabelEdicao.TabIndex = 1;
            LabelEdicao.Text = "Edição";
            LabelEdicao.Click += label1_Click;
            // 
            // NumericEdicao
            // 
            NumericEdicao.Location = new Point(41, 63);
            NumericEdicao.Name = "NumericEdicao";
            NumericEdicao.Size = new Size(120, 23);
            NumericEdicao.TabIndex = 0;
            // 
            // TabHq
            // 
            TabHq.Controls.Add(LabelIlustrador);
            TabHq.Controls.Add(TextBoxIlustrador);
            TabHq.Controls.Add(LabelNumEdicao);
            TabHq.Controls.Add(NumericNumEdicao);
            TabHq.Location = new Point(4, 24);
            TabHq.Name = "TabHq";
            TabHq.Padding = new Padding(3);
            TabHq.Size = new Size(456, 493);
            TabHq.TabIndex = 2;
            TabHq.Text = "HQ";
            TabHq.UseVisualStyleBackColor = true;
            // 
            // LabelIlustrador
            // 
            LabelIlustrador.AutoSize = true;
            LabelIlustrador.Location = new Point(46, 103);
            LabelIlustrador.Name = "LabelIlustrador";
            LabelIlustrador.Size = new Size(57, 15);
            LabelIlustrador.TabIndex = 3;
            LabelIlustrador.Text = "Ilustrador";
            // 
            // TextBoxIlustrador
            // 
            TextBoxIlustrador.Location = new Point(46, 121);
            TextBoxIlustrador.Name = "TextBoxIlustrador";
            TextBoxIlustrador.Size = new Size(371, 23);
            TextBoxIlustrador.TabIndex = 2;
            // 
            // LabelNumEdicao
            // 
            LabelNumEdicao.AutoSize = true;
            LabelNumEdicao.Location = new Point(46, 48);
            LabelNumEdicao.Name = "LabelNumEdicao";
            LabelNumEdicao.Size = new Size(42, 15);
            LabelNumEdicao.TabIndex = 1;
            LabelNumEdicao.Text = "Edição";
            // 
            // NumericNumEdicao
            // 
            NumericNumEdicao.Location = new Point(46, 67);
            NumericNumEdicao.Name = "NumericNumEdicao";
            NumericNumEdicao.Size = new Size(120, 23);
            NumericNumEdicao.TabIndex = 0;
            // 
            // TabGenerico
            // 
            TabGenerico.Controls.Add(ListBoxGenerico);
            TabGenerico.Location = new Point(4, 24);
            TabGenerico.Name = "TabGenerico";
            TabGenerico.Padding = new Padding(3);
            TabGenerico.Size = new Size(456, 493);
            TabGenerico.TabIndex = 3;
            TabGenerico.Text = "Generico";
            TabGenerico.UseVisualStyleBackColor = true;
            // 
            // ListBoxGenerico
            // 
            ListBoxGenerico.FormattingEnabled = true;
            ListBoxGenerico.Location = new Point(36, 23);
            ListBoxGenerico.Name = "ListBoxGenerico";
            ListBoxGenerico.Size = new Size(380, 439);
            ListBoxGenerico.TabIndex = 0;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.BackColor = SystemColors.ActiveCaption;
            ButtonSalvar.Location = new Point(26, 612);
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.Size = new Size(1240, 48);
            ButtonSalvar.TabIndex = 2;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.UseVisualStyleBackColor = false;
            // 
            // ExemplarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 698);
            Controls.Add(ButtonSalvar);
            Controls.Add(tabControlExemplar);
            Controls.Add(GroupBoxExemplar);
            Name = "ExemplarForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "ExemplarForm";
            Load += ExemplarForm_Load;
            GroupBoxExemplar.ResumeLayout(false);
            GroupBoxExemplar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAno).EndInit();
            tabControlExemplar.ResumeLayout(false);
            TabLivro.ResumeLayout(false);
            TabLivro.PerformLayout();
            GroupBoxEbook.ResumeLayout(false);
            GroupBoxEbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericTam).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            TabRevista.ResumeLayout(false);
            TabRevista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericNumPaginas).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericEdicao).EndInit();
            TabHq.ResumeLayout(false);
            TabHq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericNumEdicao).EndInit();
            TabGenerico.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxExemplar;
        private TextBox TextBoxSubtitulo;
        private Label LabelTitulo;
        private TextBox TextBoxTitulo;
        private Label LabelGenero;
        private ComboBox ComboBoxGenero;
        private Label LabelStatus;
        private ComboBox ComboBoxStatus;
        private NumericUpDown NumericUpDownAno;
        private TextBox TextBoxEditora;
        private TextBox TextBoxEscritor;
        private Label LabelAno;
        private Label LabelEditora;
        private Label LabelEscritor;
        private Label LabelSubtitulo;
        private TabControl tabControlExemplar;
        private TabPage TabLivro;
        private TabPage TabRevista;
        private TabPage TabHq;
        private TabPage TabGenerico;
        private Label LabeNumPag;
        private NumericUpDown numericUpDown1;
        private CheckBox CheckBoxEbook;
        private Label LabelIsbn;
        private TextBox TextBoxIsbn;
        private Label LabelCapa;
        private ComboBox ComboBoxCapa;
        private GroupBox GroupBoxEbook;
        private Label LabekTamanho;
        private NumericUpDown NumericTam;
        private Label LabelFormato;
        private ComboBox ComboBoxFormato;
        private Label LabelUrl;
        private TextBox TextBoxUrl;
        private Label LabelEdicao;
        private NumericUpDown NumericEdicao;
        private Label LabelPaginas;
        private NumericUpDown NumericNumPaginas;
        private NumericUpDown NumericNumEdicao;
        private Label LabelIlustrador;
        private TextBox TextBoxIlustrador;
        private Label LabelNumEdicao;
        private ListBox ListBoxGenerico;
        private Button ButtonSalvar;
    }
}