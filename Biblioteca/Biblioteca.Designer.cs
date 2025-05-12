namespace Biblioteca
{
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
            // 
            // ButtonExemplar
            // 
            ButtonExemplar.Location = new Point(67, 342);
            ButtonExemplar.Name = "ButtonExemplar";
            ButtonExemplar.Size = new Size(314, 76);
            ButtonExemplar.TabIndex = 1;
            ButtonExemplar.Text = "Cadastro Exemplar";
            ButtonExemplar.UseVisualStyleBackColor = true;
            // 
            // BibliotecaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 773);
            Controls.Add(ButtonExemplar);
            Controls.Add(ButtonPessoa);
            Name = "BibliotecaForm";
            Text = "Biblioteca";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonPessoa;
        private Button ButtonExemplar;
    }
}