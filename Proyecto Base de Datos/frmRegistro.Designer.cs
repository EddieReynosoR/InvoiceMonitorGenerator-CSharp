namespace Proyecto_Base_de_Datos
{
    partial class frmRegistro
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
            this.components = new System.ComponentModel.Container();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.clasePaneles2 = new Proyecto_Base_de_Datos.clasePaneles();
            this.cmbPuesto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.txtContraC = new System.Windows.Forms.TextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.clasePaneles1 = new Proyecto_Base_de_Datos.clasePaneles();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.gunaLabel17 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.clasePaneles2.SuspendLayout();
            this.clasePaneles1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1148, 53);
            this.panel5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(474, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de administrador";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.iconButton2);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(3, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 50);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registec";
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconButton2.IconColor = System.Drawing.Color.Thistle;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(-3, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(58, 42);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Proyecto_Base_de_Datos.Properties.Resources.icons8_círculo_rellenado_16__2_1;
            this.pictureBox2.Location = new System.Drawing.Point(1085, 12);
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
            this.pictureBox3.Location = new System.Drawing.Point(1118, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 29);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.gunaLabel5);
            this.panelContenedor.Controls.Add(this.iconButton1);
            this.panelContenedor.Controls.Add(this.clasePaneles2);
            this.panelContenedor.Controls.Add(this.gunaLabel1);
            this.panelContenedor.Controls.Add(this.clasePaneles1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 53);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1148, 577);
            this.panelContenedor.TabIndex = 8;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(71, 228);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(175, 20);
            this.gunaLabel5.TabIndex = 30;
            this.gunaLabel5.Text = "Datos de inicio de sesión";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(896, 497);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(175, 49);
            this.iconButton1.TabIndex = 29;
            this.iconButton1.Text = "Registrar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // clasePaneles2
            // 
            this.clasePaneles2.BackColor = System.Drawing.Color.Transparent;
            this.clasePaneles2.BackgroundColor = System.Drawing.Color.Transparent;
            this.clasePaneles2.BorderColor = System.Drawing.Color.Navy;
            this.clasePaneles2.BorderRadius = 20;
            this.clasePaneles2.BorderSize = 1;
            this.clasePaneles2.Controls.Add(this.cmbPuesto);
            this.clasePaneles2.Controls.Add(this.gunaLabel6);
            this.clasePaneles2.Controls.Add(this.gunaLabel12);
            this.clasePaneles2.Controls.Add(this.txtContraC);
            this.clasePaneles2.Controls.Add(this.gunaLabel13);
            this.clasePaneles2.Controls.Add(this.txtContra);
            this.clasePaneles2.Controls.Add(this.gunaLabel14);
            this.clasePaneles2.Controls.Add(this.txtUsuario);
            this.clasePaneles2.ForeColor = System.Drawing.Color.White;
            this.clasePaneles2.Location = new System.Drawing.Point(25, 235);
            this.clasePaneles2.Name = "clasePaneles2";
            this.clasePaneles2.Size = new System.Drawing.Size(880, 184);
            this.clasePaneles2.TabIndex = 27;
            this.clasePaneles2.TextColor = System.Drawing.Color.White;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.BackColor = System.Drawing.Color.Transparent;
            this.cmbPuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPuesto.FocusedState.Parent = this.cmbPuesto;
            this.cmbPuesto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.HoverState.Parent = this.cmbPuesto;
            this.cmbPuesto.ItemHeight = 30;
            this.cmbPuesto.ItemsAppearance.Parent = this.cmbPuesto;
            this.cmbPuesto.Location = new System.Drawing.Point(105, 134);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.ShadowDecoration.Parent = this.cmbPuesto;
            this.cmbPuesto.Size = new System.Drawing.Size(220, 36);
            this.cmbPuesto.TabIndex = 12;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(46, 139);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(53, 20);
            this.gunaLabel6.TabIndex = 11;
            this.gunaLabel6.Text = "Puesto";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel12.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel12.Location = new System.Drawing.Point(389, 65);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(83, 20);
            this.gunaLabel12.TabIndex = 10;
            this.gunaLabel12.Text = "Contraseña";
            // 
            // txtContraC
            // 
            this.txtContraC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContraC.Location = new System.Drawing.Point(637, 35);
            this.txtContraC.Name = "txtContraC";
            this.txtContraC.Size = new System.Drawing.Size(189, 27);
            this.txtContraC.TabIndex = 9;
            this.txtContraC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraC_KeyDown);
            this.txtContraC.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraC_Validating);
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel13.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel13.Location = new System.Drawing.Point(664, 65);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(151, 20);
            this.gunaLabel13.TabIndex = 8;
            this.gunaLabel13.Text = "Confirmar contraseña";
            // 
            // txtContra
            // 
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContra.Location = new System.Drawing.Point(330, 35);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(189, 27);
            this.txtContra.TabIndex = 7;
            this.txtContra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContra_KeyDown);
            this.txtContra.Validating += new System.ComponentModel.CancelEventHandler(this.txtContra_Validating);
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel14.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel14.Location = new System.Drawing.Point(46, 65);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(137, 20);
            this.gunaLabel14.TabIndex = 6;
            this.gunaLabel14.Text = "Nombre de usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(20, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 27);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(71, 40);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(155, 20);
            this.gunaLabel1.TabIndex = 26;
            this.gunaLabel1.Text = "    Datos personales    ";
            // 
            // clasePaneles1
            // 
            this.clasePaneles1.BackColor = System.Drawing.Color.Transparent;
            this.clasePaneles1.BackgroundColor = System.Drawing.Color.Transparent;
            this.clasePaneles1.BorderColor = System.Drawing.Color.Navy;
            this.clasePaneles1.BorderRadius = 20;
            this.clasePaneles1.BorderSize = 1;
            this.clasePaneles1.Controls.Add(this.txtInicial);
            this.clasePaneles1.Controls.Add(this.gunaLabel17);
            this.clasePaneles1.Controls.Add(this.gunaLabel4);
            this.clasePaneles1.Controls.Add(this.txtApellidoM);
            this.clasePaneles1.Controls.Add(this.gunaLabel3);
            this.clasePaneles1.Controls.Add(this.txtApellidoP);
            this.clasePaneles1.Controls.Add(this.gunaLabel2);
            this.clasePaneles1.Controls.Add(this.txtNombre);
            this.clasePaneles1.ForeColor = System.Drawing.Color.White;
            this.clasePaneles1.Location = new System.Drawing.Point(25, 49);
            this.clasePaneles1.Name = "clasePaneles1";
            this.clasePaneles1.Size = new System.Drawing.Size(1103, 114);
            this.clasePaneles1.TabIndex = 25;
            this.clasePaneles1.TextColor = System.Drawing.Color.White;
            // 
            // txtInicial
            // 
            this.txtInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInicial.Location = new System.Drawing.Point(260, 35);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(189, 27);
            this.txtInicial.TabIndex = 18;
            this.txtInicial.TextChanged += new System.EventHandler(this.txtInicial_TextChanged);
            this.txtInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInicial_KeyDown);
            this.txtInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInicial_KeyPress);
            this.txtInicial.Validating += new System.ComponentModel.CancelEventHandler(this.txtInicial_Validating);
            // 
            // gunaLabel17
            // 
            this.gunaLabel17.AutoSize = true;
            this.gunaLabel17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel17.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel17.Location = new System.Drawing.Point(326, 65);
            this.gunaLabel17.Name = "gunaLabel17";
            this.gunaLabel17.Size = new System.Drawing.Size(48, 20);
            this.gunaLabel17.TabIndex = 17;
            this.gunaLabel17.Text = "Inicial";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(867, 65);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(126, 20);
            this.gunaLabel4.TabIndex = 10;
            this.gunaLabel4.Text = "Apellido Materno";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellidoM.Location = new System.Drawing.Point(836, 35);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(189, 27);
            this.txtApellidoM.TabIndex = 9;
            this.txtApellidoM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellidoM_KeyDown);
            this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoM_KeyPress);
            this.txtApellidoM.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoM_Validating);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(568, 65);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(120, 20);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Apellido Paterno";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellidoP.Location = new System.Drawing.Point(531, 35);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(189, 27);
            this.txtApellidoP.TabIndex = 7;
            this.txtApellidoP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellidoP_KeyDown);
            this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoP_KeyPress);
            this.txtApellidoP.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoP_Validating);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(78, 65);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 20);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(20, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1148, 630);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.clasePaneles2.ResumeLayout(false);
            this.clasePaneles2.PerformLayout();
            this.clasePaneles1.ResumeLayout(false);
            this.clasePaneles1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private clasePaneles clasePaneles2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPuesto;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private System.Windows.Forms.TextBox txtContraC;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private System.Windows.Forms.TextBox txtContra;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private System.Windows.Forms.TextBox txtUsuario;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private clasePaneles clasePaneles1;
        private System.Windows.Forms.TextBox txtInicial;
        private Guna.UI.WinForms.GunaLabel gunaLabel17;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.TextBox txtApellidoM;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.TextBox txtApellidoP;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}