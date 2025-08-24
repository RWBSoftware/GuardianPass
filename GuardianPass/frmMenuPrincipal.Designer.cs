namespace GuardianPass
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdicionar = new Button();
            btnGerarSenha = new Button();
            btnExibir = new Button();
            btnConfig = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAdicionar);
            flowLayoutPanel1.Controls.Add(btnGerarSenha);
            flowLayoutPanel1.Controls.Add(btnExibir);
            flowLayoutPanel1.Controls.Add(btnConfig);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(206, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(0, 180, 216);
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(3, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(199, 52);
            btnAdicionar.TabIndex = 17;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnGerarSenha
            // 
            btnGerarSenha.BackColor = Color.FromArgb(0, 180, 216);
            btnGerarSenha.FlatAppearance.BorderSize = 0;
            btnGerarSenha.FlatStyle = FlatStyle.Flat;
            btnGerarSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarSenha.Location = new Point(3, 61);
            btnGerarSenha.Name = "btnGerarSenha";
            btnGerarSenha.Size = new Size(199, 52);
            btnGerarSenha.TabIndex = 18;
            btnGerarSenha.Text = "GERAR SENHA";
            btnGerarSenha.UseVisualStyleBackColor = false;
            btnGerarSenha.Click += btnGerarSenha_Click;
            // 
            // btnExibir
            // 
            btnExibir.BackColor = Color.FromArgb(0, 180, 216);
            btnExibir.FlatAppearance.BorderSize = 0;
            btnExibir.FlatStyle = FlatStyle.Flat;
            btnExibir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExibir.Location = new Point(3, 119);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(199, 52);
            btnExibir.TabIndex = 19;
            btnExibir.Text = "EXIBIR";
            btnExibir.UseVisualStyleBackColor = false;
            btnExibir.Click += btnExibir_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(102, 102, 102);
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.Location = new Point(3, 177);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(199, 52);
            btnConfig.TabIndex = 20;
            btnConfig.Text = "CONFIG";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(3, 235);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(199, 52);
            btnSair.TabIndex = 21;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 450);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(208, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(594, 455);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Logo_Sem_Fundo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnAdicionar;
        private Button btnGerarSenha;
        private Button btnExibir;
        private Button btnConfig;
        private Button btnSair;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}