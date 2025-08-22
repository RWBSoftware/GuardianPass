namespace GuardianPass
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            label1 = new Label();
            btnVoltar = new Button();
            btnExigirSenha = new Button();
            btnTrocar = new Button();
            btnAlterar = new Button();
            btnAvaliacao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 10;
            label1.Text = "Configuração";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(80, 269);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(201, 43);
            btnVoltar.TabIndex = 25;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnExigirSenha
            // 
            btnExigirSenha.BackColor = Color.FromArgb(0, 180, 216);
            btnExigirSenha.FlatAppearance.BorderSize = 0;
            btnExigirSenha.FlatStyle = FlatStyle.Flat;
            btnExigirSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExigirSenha.Location = new Point(80, 73);
            btnExigirSenha.Name = "btnExigirSenha";
            btnExigirSenha.Size = new Size(201, 43);
            btnExigirSenha.TabIndex = 24;
            btnExigirSenha.Text = "EXIGIR SENHA";
            btnExigirSenha.UseVisualStyleBackColor = false;
            btnExigirSenha.Click += btnExigirSenha_Click;
            // 
            // btnTrocar
            // 
            btnTrocar.BackColor = Color.FromArgb(0, 180, 216);
            btnTrocar.FlatAppearance.BorderSize = 0;
            btnTrocar.FlatStyle = FlatStyle.Flat;
            btnTrocar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrocar.Location = new Point(80, 122);
            btnTrocar.Name = "btnTrocar";
            btnTrocar.Size = new Size(201, 43);
            btnTrocar.TabIndex = 26;
            btnTrocar.Text = "TROCAR CONTA";
            btnTrocar.UseVisualStyleBackColor = false;
            btnTrocar.Click += btnTrocar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(0, 180, 216);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(80, 171);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(201, 43);
            btnAlterar.TabIndex = 27;
            btnAlterar.Text = "ALTERAR SENHA";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnAvaliacao
            // 
            btnAvaliacao.BackColor = Color.FromArgb(0, 180, 216);
            btnAvaliacao.FlatAppearance.BorderSize = 0;
            btnAvaliacao.FlatStyle = FlatStyle.Flat;
            btnAvaliacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvaliacao.Location = new Point(80, 220);
            btnAvaliacao.Name = "btnAvaliacao";
            btnAvaliacao.Size = new Size(201, 43);
            btnAvaliacao.TabIndex = 28;
            btnAvaliacao.Text = "AVALIAÇÃO";
            btnAvaliacao.UseVisualStyleBackColor = false;
            btnAvaliacao.Click += btnAvaliacao_Click;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(360, 355);
            Controls.Add(btnAvaliacao);
            Controls.Add(btnAlterar);
            Controls.Add(btnTrocar);
            Controls.Add(btnVoltar);
            Controls.Add(btnExigirSenha);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVoltar;
        private Button btnExigirSenha;
        private Button btnTrocar;
        private Button btnAlterar;
        private Button btnAvaliacao;
    }
}