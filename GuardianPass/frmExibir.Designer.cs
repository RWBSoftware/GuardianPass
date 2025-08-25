namespace GuardianPass
{
    partial class frmExibir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExibir));
            dgv1 = new DataGridView();
            btnExcluir = new Button();
            btnVoltar = new Button();
            btnEditar = new Button();
            txtBoxUsuario = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AllowUserToOrderColumns = true;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(0, -3);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(596, 454);
            dgv1.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 209, 102);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(602, 132);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(165, 43);
            btnExcluir.TabIndex = 23;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(602, 181);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(165, 43);
            btnVoltar.TabIndex = 22;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 180, 216);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(602, 83);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(165, 43);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.ForeColor = Color.White;
            txtBoxUsuario.Location = new Point(602, 43);
            txtBoxUsuario.MaxLength = 50;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Site/App";
            txtBoxUsuario.Size = new Size(165, 34);
            txtBoxUsuario.TabIndex = 24;
            txtBoxUsuario.TextChanged += txtBoxUsuario_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(602, 9);
            label4.Name = "label4";
            label4.Size = new Size(106, 31);
            label4.TabIndex = 25;
            label4.Text = "Site/App";
            // 
            // frmExibir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(779, 450);
            Controls.Add(label4);
            Controls.Add(txtBoxUsuario);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(btnEditar);
            Controls.Add(dgv1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmExibir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            Load += frmExibir_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv1;
        private Button btnExcluir;
        private Button btnVoltar;
        private Button btnEditar;
        private TextBox txtBoxUsuario;
        private Label label4;
    }
}