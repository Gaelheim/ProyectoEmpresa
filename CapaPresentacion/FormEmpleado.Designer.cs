namespace CapaPresentacion
{
    partial class FormEmpleado
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
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            txtCargo = new TextBox();
            txtSueldoBase = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            lblMensaje = new Label();
            btnGuardar = new Button();
            dgvEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 176);
            txtNombre.MaxLength = 99;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(128, 222);
            txtCedula.MaxLength = 14;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(176, 23);
            txtCedula.TabIndex = 1;
            txtCedula.Text = "Cedula / Pasaporte";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(128, 269);
            txtCargo.MaxLength = 49;
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(176, 23);
            txtCargo.TabIndex = 2;
            txtCargo.Text = "Cargo / Puesto y Dpto.";
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Location = new Point(362, 176);
            txtSueldoBase.MaxLength = 20;
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.Size = new Size(176, 23);
            txtSueldoBase.TabIndex = 3;
            txtSueldoBase.Text = "Sueldo Base";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(362, 222);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(200, 23);
            dtpFechaIngreso.TabIndex = 4;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(362, 275);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(121, 17);
            lblMensaje.TabIndex = 5;
            lblMensaje.Text = "Mostrar Resultado";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(627, 207);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 49);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(128, 332);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(1050, 481);
            dgvEmpleados.TabIndex = 7;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Obsidian__2_;
            ClientSize = new Size(1298, 856);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnGuardar);
            Controls.Add(lblMensaje);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(txtSueldoBase);
            Controls.Add(txtCargo);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormEmpleado";
            Text = "FormEmpleado";
            Load += FormEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtCargo;
        private TextBox txtSueldoBase;
        private DateTimePicker dtpFechaIngreso;
        private Label lblMensaje;
        private Button btnGuardar;
        private DataGridView dgvEmpleados;
    }
}