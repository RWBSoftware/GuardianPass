namespace GuardianPass
{
    partial class frmGerarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarSenha));
            txtBoxSenha = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            btnGerar = new Button();
            cBoxLetra = new CheckBox();
            label1 = new Label();
            cBoxNumeros = new CheckBox();
            cBoxSimbolos = new CheckBox();
            nupQuantidade = new NumericUpDown();
            btnCopiar = new Button();
            ((System.ComponentModel.ISupportInitialize)nupQuantidade).BeginInit();
            SuspendLayout();
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.ForeColor = Color.White;
            txtBoxSenha.Location = new Point(76, 100);
            txtBoxSenha.MaxLength = 50;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Senha";
            txtBoxSenha.ReadOnly = true;
            txtBoxSenha.Size = new Size(218, 34);
            txtBoxSenha.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(76, 66);
            label4.Name = "label4";
            label4.Size = new Size(164, 31);
            label4.TabIndex = 24;
            label4.Text = "Senha Gerada:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(143, 337);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(144, 43);
            btnVoltar.TabIndex = 23;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.FromArgb(0, 180, 216);
            btnGerar.FlatAppearance.BorderSize = 0;
            btnGerar.FlatStyle = FlatStyle.Flat;
            btnGerar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerar.Location = new Point(143, 239);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(144, 43);
            btnGerar.TabIndex = 22;
            btnGerar.Text = "GERAR";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // cBoxLetra
            // 
            cBoxLetra.AutoSize = true;
            cBoxLetra.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxLetra.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxLetra.Location = new Point(76, 140);
            cBoxLetra.Name = "cBoxLetra";
            cBoxLetra.Size = new Size(77, 27);
            cBoxLetra.TabIndex = 21;
            cBoxLetra.Text = "Letras";
            cBoxLetra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 38);
            label1.TabIndex = 27;
            label1.Text = "Gere Sua Senha";
            // 
            // cBoxNumeros
            // 
            cBoxNumeros.AutoSize = true;
            cBoxNumeros.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxNumeros.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxNumeros.Location = new Point(76, 173);
            cBoxNumeros.Name = "cBoxNumeros";
            cBoxNumeros.Size = new Size(102, 27);
            cBoxNumeros.TabIndex = 28;
            cBoxNumeros.Text = "Números";
            cBoxNumeros.UseVisualStyleBackColor = true;
            // 
            // cBoxSimbolos
            // 
            cBoxSimbolos.AutoSize = true;
            cBoxSimbolos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxSimbolos.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxSimbolos.Location = new Point(77, 206);
            cBoxSimbolos.Name = "cBoxSimbolos";
            cBoxSimbolos.Size = new Size(101, 27);
            cBoxSimbolos.TabIndex = 29;
            cBoxSimbolos.Text = "Símbolos";
            cBoxSimbolos.UseVisualStyleBackColor = true;
            // 
            // nupQuantidade
            // 
            nupQuantidade.BackColor = Color.FromArgb(27, 38, 59);
            nupQuantidade.Font = new Font("Segoe UI", 12F);
            nupQuantidade.ForeColor = Color.White;
            nupQuantidade.Location = new Point(300, 100);
            nupQuantidade.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nupQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupQuantidade.Name = "nupQuantidade";
            nupQuantidade.ReadOnly = true;
            nupQuantidade.Size = new Size(60, 34);
            nupQuantidade.TabIndex = 30;
            nupQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCopiar
            // 
            btnCopiar.BackColor = Color.FromArgb(0, 180, 216);
            btnCopiar.FlatAppearance.BorderSize = 0;
            btnCopiar.FlatStyle = FlatStyle.Flat;
            btnCopiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiar.Location = new Point(143, 288);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(144, 43);
            btnCopiar.TabIndex = 31;
            btnCopiar.Text = "COPIAR";
            btnCopiar.UseVisualStyleBackColor = false;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // frmGerarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(430, 420);
            Controls.Add(btnCopiar);
            Controls.Add(nupQuantidade);
            Controls.Add(cBoxSimbolos);
            Controls.Add(cBoxNumeros);
            Controls.Add(label1);
            Controls.Add(txtBoxSenha);
            Controls.Add(label4);
            Controls.Add(btnVoltar);
            Controls.Add(btnGerar);
            Controls.Add(cBoxLetra);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmGerarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            ((System.ComponentModel.ISupportInitialize)nupQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxSenha;
        private Label label4;
        private Button btnVoltar;
        private Button btnGerar;
        private CheckBox cBoxLetra;
        private Label label1;
        private CheckBox cBoxNumeros;
        private CheckBox cBoxSimbolos;
        private NumericUpDown nupQuantidade;
        private Button btnCopiar;
    }
}