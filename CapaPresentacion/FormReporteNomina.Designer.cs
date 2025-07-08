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
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormReporteNomina";
            Text = "FormLogin";
            Load += FormReporteNomina_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();
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
    }
}