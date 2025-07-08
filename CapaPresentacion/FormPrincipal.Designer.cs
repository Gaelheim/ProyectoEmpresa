namespace CapaPresentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            btnRegistrarEmpleado = new Button();
            btnReporte = new Button();
            btnCerrarSesion = new Button();
            lblBienvenida = new Label();
            SuspendLayout();
            // 
            // btnRegistrarEmpleado
            // 
            btnRegistrarEmpleado.BackColor = Color.Transparent;
            btnRegistrarEmpleado.Cursor = Cursors.Hand;
            btnRegistrarEmpleado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRegistrarEmpleado.Location = new Point(135, 262);
            btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            btnRegistrarEmpleado.Size = new Size(83, 74);
            btnRegistrarEmpleado.TabIndex = 0;
            btnRegistrarEmpleado.Text = "Registrar Nuevo Empleado";
            btnRegistrarEmpleado.UseVisualStyleBackColor = false;
            btnRegistrarEmpleado.Click += btnRegistrarEmpleado_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.Transparent;
            btnReporte.Cursor = Cursors.Hand;
            btnReporte.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnReporte.Location = new Point(281, 262);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(75, 74);
            btnReporte.TabIndex = 1;
            btnReporte.Text = "Reporte Nomina";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCerrarSesion.Location = new Point(416, 262);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(75, 74);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(158, 133);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(244, 32);
            lblBienvenida.TabIndex = 3;
            lblBienvenida.Text = "Bienvenido Usuario.";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Obsidian__1_;
            ClientSize = new Size(645, 450);
            Controls.Add(lblBienvenida);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnReporte);
            Controls.Add(btnRegistrarEmpleado);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarEmpleado;
        private Button btnReporte;
        private Button btnCerrarSesion;
        private Label lblBienvenida;

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion

    }
}
