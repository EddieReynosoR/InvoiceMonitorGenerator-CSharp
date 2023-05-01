namespace Proyecto_Base_de_Datos
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.menuButton = new FontAwesome.Sharp.IconButton();
            this.btnSubmenu = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnGestiondeRecibo = new FontAwesome.Sharp.IconButton();
            this.btnAñadirRecibo = new FontAwesome.Sharp.IconButton();
            this.btnActivarSubmenu = new FontAwesome.Sharp.IconButton();
            this.btnDesactivarSubmenu = new FontAwesome.Sharp.IconButton();
            this.sidebar.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.HomeContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.gunaPanel1);
            this.sidebar.Controls.Add(this.HomeContainer);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(244, 590);
            this.sidebar.MinimumSize = new System.Drawing.Size(63, 590);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(244, 590);
            this.sidebar.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnAtras);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 50);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registec";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.menuButton);
            this.gunaPanel1.ForeColor = System.Drawing.Color.White;
            this.gunaPanel1.Location = new System.Drawing.Point(3, 59);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(241, 61);
            this.gunaPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barra";
            // 
            // HomeContainer
            // 
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.HomeContainer.Controls.Add(this.panel4);
            this.HomeContainer.Controls.Add(this.panel1);
            this.HomeContainer.Location = new System.Drawing.Point(3, 126);
            this.HomeContainer.MaximumSize = new System.Drawing.Size(241, 117);
            this.HomeContainer.MinimumSize = new System.Drawing.Size(241, 53);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(241, 62);
            this.HomeContainer.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDesactivarSubmenu);
            this.panel4.Controls.Add(this.btnSubmenu);
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 59);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActivarSubmenu);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 59);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGestiondeRecibo);
            this.panel2.Location = new System.Drawing.Point(3, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 59);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAñadirRecibo);
            this.panel3.Location = new System.Drawing.Point(3, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 59);
            this.panel3.TabIndex = 3;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 10;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(244, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(862, 53);
            this.panel5.TabIndex = 5;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.panel5;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(244, 53);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(862, 537);
            this.panelContenedor.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Proyecto_Base_de_Datos.Properties.Resources.icons8_círculo_rellenado_16__2_1;
            this.pictureBox2.Location = new System.Drawing.Point(799, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 29);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Proyecto_Base_de_Datos.Properties.Resources.icons8_círculo_rellenado_16__3_;
            this.pictureBox3.Location = new System.Drawing.Point(832, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 29);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnAtras.IconColor = System.Drawing.Color.White;
            this.btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras.Location = new System.Drawing.Point(-3, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(58, 42);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.menuButton.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.menuButton.IconColor = System.Drawing.Color.White;
            this.menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuButton.Location = new System.Drawing.Point(-3, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(64, 52);
            this.menuButton.TabIndex = 0;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // btnSubmenu
            // 
            this.btnSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmenu.ForeColor = System.Drawing.Color.White;
            this.btnSubmenu.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnSubmenu.IconColor = System.Drawing.Color.White;
            this.btnSubmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmenu.Location = new System.Drawing.Point(-3, -18);
            this.btnSubmenu.Name = "btnSubmenu";
            this.btnSubmenu.Size = new System.Drawing.Size(255, 85);
            this.btnSubmenu.TabIndex = 1;
            this.btnSubmenu.Text = "                 Submenu";
            this.btnSubmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmenu.UseVisualStyleBackColor = false;
            this.btnSubmenu.Click += new System.EventHandler(this.btnSubmenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-3, -18);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(255, 85);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "                 Menu\r\n";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // btnGestiondeRecibo
            // 
            this.btnGestiondeRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnGestiondeRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestiondeRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestiondeRecibo.ForeColor = System.Drawing.Color.White;
            this.btnGestiondeRecibo.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnGestiondeRecibo.IconColor = System.Drawing.Color.White;
            this.btnGestiondeRecibo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestiondeRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestiondeRecibo.Location = new System.Drawing.Point(-3, -17);
            this.btnGestiondeRecibo.Name = "btnGestiondeRecibo";
            this.btnGestiondeRecibo.Size = new System.Drawing.Size(255, 85);
            this.btnGestiondeRecibo.TabIndex = 1;
            this.btnGestiondeRecibo.Text = "                 Gestion de recibos";
            this.btnGestiondeRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestiondeRecibo.UseVisualStyleBackColor = false;
            this.btnGestiondeRecibo.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnAñadirRecibo
            // 
            this.btnAñadirRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAñadirRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirRecibo.ForeColor = System.Drawing.Color.White;
            this.btnAñadirRecibo.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnAñadirRecibo.IconColor = System.Drawing.Color.White;
            this.btnAñadirRecibo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadirRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirRecibo.Location = new System.Drawing.Point(-3, -15);
            this.btnAñadirRecibo.Name = "btnAñadirRecibo";
            this.btnAñadirRecibo.Size = new System.Drawing.Size(255, 85);
            this.btnAñadirRecibo.TabIndex = 1;
            this.btnAñadirRecibo.Text = "                 Añadir recibo\r\n";
            this.btnAñadirRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirRecibo.UseVisualStyleBackColor = false;
            this.btnAñadirRecibo.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnActivarSubmenu
            // 
            this.btnActivarSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnActivarSubmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivarSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarSubmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnActivarSubmenu.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnActivarSubmenu.IconColor = System.Drawing.Color.White;
            this.btnActivarSubmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActivarSubmenu.IconSize = 20;
            this.btnActivarSubmenu.Location = new System.Drawing.Point(191, 9);
            this.btnActivarSubmenu.Name = "btnActivarSubmenu";
            this.btnActivarSubmenu.Size = new System.Drawing.Size(44, 41);
            this.btnActivarSubmenu.TabIndex = 3;
            this.btnActivarSubmenu.UseVisualStyleBackColor = false;
            this.btnActivarSubmenu.Click += new System.EventHandler(this.btnActivarSubmenu_Click);
            // 
            // btnDesactivarSubmenu
            // 
            this.btnDesactivarSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnDesactivarSubmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivarSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarSubmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnDesactivarSubmenu.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnDesactivarSubmenu.IconColor = System.Drawing.Color.White;
            this.btnDesactivarSubmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesactivarSubmenu.IconSize = 20;
            this.btnDesactivarSubmenu.Location = new System.Drawing.Point(191, 0);
            this.btnDesactivarSubmenu.Name = "btnDesactivarSubmenu";
            this.btnDesactivarSubmenu.Size = new System.Drawing.Size(44, 41);
            this.btnDesactivarSubmenu.TabIndex = 4;
            this.btnDesactivarSubmenu.UseVisualStyleBackColor = false;
            this.btnDesactivarSubmenu.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1106, 590);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.sidebar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.HomeContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnGestiondeRecibo;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnAñadirRecibo;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton menuButton;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnSubmenu;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private FontAwesome.Sharp.IconButton btnAtras;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnActivarSubmenu;
        private FontAwesome.Sharp.IconButton btnDesactivarSubmenu;
    }
}

