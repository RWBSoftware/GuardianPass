namespace GuardianPass
{
    partial class frmAdicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionar));
            btnVoltar = new Button();
            btnSalvar = new Button();
            cBoxMostrarSenha = new CheckBox();
            txtBoxSenha = new TextBox();
            label3 = new Label();
            txtBoxUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtBoxSiteApp = new TextBox();
            label4 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(148, 413);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(144, 43);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 180, 216);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(148, 315);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(144, 43);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxMostrarSenha.Location = new Point(148, 282);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(144, 27);
            cBoxMostrarSenha.TabIndex = 14;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.ForeColor = Color.White;
            txtBoxSenha.Location = new Point(111, 167);
            txtBoxSenha.MaxLength = 50;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Senha";
            txtBoxSenha.Size = new Size(218, 34);
            txtBoxSenha.TabIndex = 13;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(176, 176, 176);
            label3.Location = new Point(111, 133);
            label3.Name = "label3";
            label3.Size = new Size(83, 31);
            label3.TabIndex = 12;
            label3.Text = "Senha:";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.ForeColor = Color.White;
            txtBoxUsuario.Location = new Point(111, 96);
            txtBoxUsuario.MaxLength = 50;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Usuário";
            txtBoxUsuario.Size = new Size(218, 34);
            txtBoxUsuario.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(176, 176, 176);
            label2.Location = new Point(111, 62);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 10;
            label2.Text = "Usuário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 38);
            label1.TabIndex = 9;
            label1.Text = "Adicionar Conta";
            // 
            // txtBoxSiteApp
            // 
            txtBoxSiteApp.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSiteApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSiteApp.ForeColor = Color.White;
            txtBoxSiteApp.Location = new Point(111, 238);
            txtBoxSiteApp.MaxLength = 50;
            txtBoxSiteApp.Name = "txtBoxSiteApp";
            txtBoxSiteApp.PlaceholderText = "Nome Site/App";
            txtBoxSiteApp.Size = new Size(218, 34);
            txtBoxSiteApp.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(111, 204);
            label4.Name = "label4";
            label4.Size = new Size(182, 31);
            label4.TabIndex = 18;
            label4.Text = "Nome Site/App:";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(0, 180, 216);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(148, 364);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(144, 43);
            btnLimpar.TabIndex = 20;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmAdicionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(440, 491);
            Controls.Add(btnLimpar);
            Controls.Add(txtBoxSiteApp);
            Controls.Add(label4);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(label3);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAdicionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Button btnSalvar;
        private CheckBox cBoxMostrarSenha;
        private TextBox txtBoxSenha;
        private Label label3;
        private TextBox txtBoxUsuario;
        private Label label2;
        private Label label1;
        private TextBox txtBoxSiteApp;
        private Label label4;
        private Button btnLimpar;
    }
}