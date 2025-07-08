namespace CapaPresentacion
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            ptbVeo = new PictureBox();
            ptbNoveo = new PictureBox();
            btnLogin = new Button();
            lblMensaje = new Label();
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
            // lblMensaje
            // 
            resources.ApplyResources(lblMensaje, "lblMensaje");
            lblMensaje.Name = "lblMensaje";
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Obsidian;
            Controls.Add(lblMensaje);
            Controls.Add(btnLogin);
            Controls.Add(ptbNoveo);
            Controls.Add(ptbVeo);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormLogin";
            Opacity = 0.9D;
            ((System.ComponentModel.ISupportInitialize)ptbVeo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbNoveo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtClave;
        private PictureBox ptbVeo;
        private PictureBox ptbNoveo;
        private Button btnLogin;
        private Label lblMensaje;
    }
}