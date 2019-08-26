namespace NovaInventory.Vista
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciar_Sesion = new System.Windows.Forms.Button();
            this.lklRecuperar_Contraseña = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCerrar_Login = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnMinmizar_Login = new System.Windows.Forms.ToolStripButton();
            this.btnPrimer_Uso = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo_Login = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Login)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(121, 152);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraseña.Location = new System.Drawing.Point(121, 188);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(132, 22);
            this.txtContraseña.TabIndex = 2;
            // 
            // btnIniciar_Sesion
            // 
            this.btnIniciar_Sesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIniciar_Sesion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIniciar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar_Sesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciar_Sesion.Location = new System.Drawing.Point(35, 220);
            this.btnIniciar_Sesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar_Sesion.Name = "btnIniciar_Sesion";
            this.btnIniciar_Sesion.Size = new System.Drawing.Size(197, 54);
            this.btnIniciar_Sesion.TabIndex = 3;
            this.btnIniciar_Sesion.Text = "Iniciar Sesión";
            this.btnIniciar_Sesion.UseVisualStyleBackColor = false;
            this.btnIniciar_Sesion.Click += new System.EventHandler(this.btnIniciar_Sesion_Click);
            // 
            // lklRecuperar_Contraseña
            // 
            this.lklRecuperar_Contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lklRecuperar_Contraseña.AutoSize = true;
            this.lklRecuperar_Contraseña.BackColor = System.Drawing.Color.Silver;
            this.lklRecuperar_Contraseña.Location = new System.Drawing.Point(4, 310);
            this.lklRecuperar_Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklRecuperar_Contraseña.Name = "lklRecuperar_Contraseña";
            this.lklRecuperar_Contraseña.Size = new System.Drawing.Size(143, 17);
            this.lklRecuperar_Contraseña.TabIndex = 4;
            this.lklRecuperar_Contraseña.TabStop = true;
            this.lklRecuperar_Contraseña.Text = "Olvidé Mi Contraseña";
            this.lklRecuperar_Contraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRecuperar_Contraseña_LinkClicked);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrar_Login,
            this.btnCerrar,
            this.btnMinmizar_Login});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCerrar_Login
            // 
            this.btnCerrar_Login.Name = "btnCerrar_Login";
            this.btnCerrar_Login.Size = new System.Drawing.Size(23, 24);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrar.Image = global::NovaInventory.Properties.Resources.cancel_button1;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar.Text = "toolStripButton1";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinmizar_Login
            // 
            this.btnMinmizar_Login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMinmizar_Login.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMinmizar_Login.Image = global::NovaInventory.Properties.Resources.minimize_window_26px;
            this.btnMinmizar_Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinmizar_Login.Name = "btnMinmizar_Login";
            this.btnMinmizar_Login.Size = new System.Drawing.Size(24, 24);
            this.btnMinmizar_Login.Text = "Minimizar";
            this.btnMinmizar_Login.Click += new System.EventHandler(this.btnMinmizar_Login_Click);
            // 
            // btnPrimer_Uso
            // 
            this.btnPrimer_Uso.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrimer_Uso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrimer_Uso.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimer_Uso.Location = new System.Drawing.Point(0, 266);
            this.btnPrimer_Uso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrimer_Uso.Name = "btnPrimer_Uso";
            this.btnPrimer_Uso.Size = new System.Drawing.Size(377, 60);
            this.btnPrimer_Uso.TabIndex = 8;
            this.btnPrimer_Uso.Text = "Primer Uso";
            this.btnPrimer_Uso.UseVisualStyleBackColor = false;
            this.btnPrimer_Uso.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lklRecuperar_Contraseña);
            this.panel1.Controls.Add(this.pbLogo_Login);
            this.panel1.Controls.Add(this.btnIniciar_Sesion);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(431, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 326);
            this.panel1.TabIndex = 10;
            // 
            // pbLogo_Login
            // 
            this.pbLogo_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo_Login.BackColor = System.Drawing.Color.Silver;
            this.pbLogo_Login.Image = global::NovaInventory.Properties.Resources.round_account_button_with_user_inside;
            this.pbLogo_Login.Location = new System.Drawing.Point(35, 4);
            this.pbLogo_Login.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo_Login.Name = "pbLogo_Login";
            this.pbLogo_Login.Size = new System.Drawing.Size(200, 122);
            this.pbLogo_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo_Login.TabIndex = 6;
            this.pbLogo_Login.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnPrimer_Uso);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(28, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 326);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NovaInventory.Properties.Resources.sistema;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(721, 410);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Login)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciar_Sesion;
        private System.Windows.Forms.LinkLabel lklRecuperar_Contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbLogo_Login;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMinmizar_Login;
        private System.Windows.Forms.ToolStripButton btnCerrar_Login;
        private System.Windows.Forms.Button btnPrimer_Uso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton btnCerrar;
    }
}