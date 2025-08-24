namespace GuardianPass
{
    partial class frmAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarSenha));
            txtBoxSenhaNovamente = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            btnAlterar = new Button();
            cBoxMostrarSenha = new CheckBox();
            txtBoxSenhaNova = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtBoxSenhaAtual = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBoxSenhaNovamente
            // 
            txtBoxSenhaNovamente.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenhaNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaNovamente.ForeColor = Color.White;
            txtBoxSenhaNovamente.Location = new Point(101, 252);
            txtBoxSenhaNovamente.MaxLength = 50;
            txtBoxSenhaNovamente.Name = "txtBoxSenhaNovamente";
            txtBoxSenhaNovamente.PlaceholderText = "Senha Novamente";
            txtBoxSenhaNovamente.Size = new Size(218, 34);
            txtBoxSenhaNovamente.TabIndex = 29;
            txtBoxSenhaNovamente.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(101, 218);
            label4.Name = "label4";
            label4.Size = new Size(210, 31);
            label4.TabIndex = 28;
            label4.Text = "Senha Novamente:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(138, 371);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(144, 43);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(0, 180, 216);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(138, 322);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(144, 43);
            btnAlterar.TabIndex = 26;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxMostrarSenha.Location = new Point(138, 289);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(144, 27);
            cBoxMostrarSenha.TabIndex = 25;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // txtBoxSenhaNova
            // 
            txtBoxSenhaNova.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenhaNova.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaNova.ForeColor = Color.White;
            txtBoxSenhaNova.Location = new Point(101, 181);
            txtBoxSenhaNova.MaxLength = 50;
            txtBoxSenhaNova.Name = "txtBoxSenhaNova";
            txtBoxSenhaNova.PlaceholderText = "Senha";
            txtBoxSenhaNova.Size = new Size(218, 34);
            txtBoxSenhaNova.TabIndex = 24;
            txtBoxSenhaNova.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(176, 176, 176);
            label3.Location = new Point(101, 147);
            label3.Name = "label3";
            label3.Size = new Size(145, 31);
            label3.TabIndex = 23;
            label3.Text = "Senha Nova:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 38);
            label1.TabIndex = 20;
            label1.Text = "Altere Sua Senha";
            // 
            // txtBoxSenhaAtual
            // 
            txtBoxSenhaAtual.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenhaAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaAtual.ForeColor = Color.White;
            txtBoxSenhaAtual.Location = new Point(101, 110);
            txtBoxSenhaAtual.MaxLength = 50;
            txtBoxSenhaAtual.Name = "txtBoxSenhaAtual";
            txtBoxSenhaAtual.PlaceholderText = "Senha";
            txtBoxSenhaAtual.Size = new Size(218, 34);
            txtBoxSenhaAtual.TabIndex = 31;
            txtBoxSenhaAtual.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(176, 176, 176);
            label2.Location = new Point(101, 76);
            label2.Name = "label2";
            label2.Size = new Size(143, 31);
            label2.TabIndex = 30;
            label2.Text = "Senha Atual:";
            // 
            // frmAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(420, 433);
            Controls.Add(txtBoxSenhaAtual);
            Controls.Add(label2);
            Controls.Add(txtBoxSenhaNovamente);
            Controls.Add(label4);
            Controls.Add(btnVoltar);
            Controls.Add(btnAlterar);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtBoxSenhaNova);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAlterarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSenhaNovamente;
        private Label label4;
        private Button btnVoltar;
        private Button btnAlterar;
        private CheckBox cBoxMostrarSenha;
        private TextBox txtBoxSenhaNova;
        private Label label3;
        private Label label1;
        private TextBox txtBoxSenhaAtual;
        private Label label2;
    }
}