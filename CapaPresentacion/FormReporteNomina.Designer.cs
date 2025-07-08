namespace CapaPresentacion
{
    partial class FormReporteNomina
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

            lblTitulo = new Label();
            dgvNomina = new DataGridView();
            txtHorasExtras = new TextBox();
            txtHorasNocturnas = new TextBox();
            btnGuardarCambios = new Button();
            label1 = new Label();
            lblTotalNomina = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNomina).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(410, 145);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(470, 65);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reporte de Nomina";
            // 
            // dgvNomina
            // 
            dgvNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNomina.Location = new Point(131, 248);
            dgvNomina.Name = "dgvNomina";
            dgvNomina.Size = new Size(1036, 478);
            dgvNomina.TabIndex = 1;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(131, 749);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(201, 23);
            txtHorasExtras.TabIndex = 2;
            txtHorasExtras.Text = "Horas Extras";
            // 
            // txtHorasNocturnas
            // 
            txtHorasNocturnas.Location = new Point(131, 791);
            txtHorasNocturnas.Name = "txtHorasNocturnas";
            txtHorasNocturnas.Size = new Size(201, 23);
            txtHorasNocturnas.TabIndex = 3;
            txtHorasNocturnas.Text = "Horas Nocturnas";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(363, 765);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(110, 30);
            btnGuardarCambios.TabIndex = 4;
            btnGuardarCambios.Text = "Insertar";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(806, 781);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 5;
            label1.Text = "Total :";
            // 
            // lblTotalNomina
            // 
            lblTotalNomina.AutoSize = true;
            lblTotalNomina.BackColor = Color.Transparent;
            lblTotalNomina.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNomina.Location = new Point(879, 781);
            lblTotalNomina.Name = "lblTotalNomina";
            lblTotalNomina.Size = new Size(19, 21);
            lblTotalNomina.TabIndex = 6;
            lblTotalNomina.Text = "0";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(1024, 175);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(110, 67);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormReporteNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Obsidian__2_;
            ClientSize = new Size(1288, 875);
            Controls.Add(btnCerrar);
            Controls.Add(lblTotalNomina);
            Controls.Add(label1);
            Controls.Add(btnGuardarCambios);
            Controls.Add(txtHorasNocturnas);
            Controls.Add(txtHorasExtras);
            Controls.Add(dgvNomina);
            Controls.Add(lblTitulo);

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteNomina));
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            ptbVeo = new PictureBox();
            ptbNoveo = new PictureBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbVeo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbNoveo).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.LavenderBlush;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.ForeColor = SystemColors.WindowFrame;
            txtUsuario.Name = "txtUsuario";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.LavenderBlush;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtClave, "txtClave");
            txtClave.ForeColor = SystemColors.WindowFrame;
            txtClave.Name = "txtClave";
            // 
            // ptbVeo
            // 
            ptbVeo.Image = Properties.Resources.Diseño_sin_título__1_;
            resources.ApplyResources(ptbVeo, "ptbVeo");
            ptbVeo.Name = "ptbVeo";
            ptbVeo.TabStop = false;
            ptbVeo.Click += ptbVeo_Click;
            // 
            // ptbNoveo
            // 
            ptbNoveo.Image = Properties.Resources.Diseño_sin_título;
            resources.ApplyResources(ptbNoveo, "ptbNoveo");
            ptbNoveo.Name = "ptbNoveo";
            ptbNoveo.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Aquamarine;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormReporteNomina
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Obsidian;
            Controls.Add(btnLogin);
            Controls.Add(ptbNoveo);
            Controls.Add(ptbVeo);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;

            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormReporteNomina";

            Text = "FormLogin";
            Load += FormReporteNomina_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();

            Opacity = 0.9D;
            ((System.ComponentModel.ISupportInitialize)ptbVeo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbNoveo).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblTitulo;
        private DataGridView dgvNomina;
        private TextBox txtHorasExtras;
        private TextBox txtHorasNocturnas;
        private Button btnGuardarCambios;
        private Label label1;
        private Label lblTotalNomina;
        private Button btnCerrar;

        private TextBox txtUsuario;
        private TextBox txtClave;
        private PictureBox ptbVeo;
        private PictureBox ptbNoveo;
        private Button btnLogin;

    }
}