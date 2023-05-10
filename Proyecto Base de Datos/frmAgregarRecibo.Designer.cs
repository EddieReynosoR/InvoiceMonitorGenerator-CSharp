namespace Proyecto_Base_de_Datos
{
    partial class frmAgregarRecibo
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
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.clasePaneles2 = new Proyecto_Base_de_Datos.clasePaneles();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.cmbSocio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDProyectoDataSet = new Proyecto_Base_de_Datos.BDProyectoDataSet();
            this.btnInsertarSocio = new FontAwesome.Sharp.IconButton();
            this.clasePaneles3 = new Proyecto_Base_de_Datos.clasePaneles();
            this.lblAdmin = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel19 = new Guna.UI.WinForms.GunaLabel();
            this.clasePaneles1 = new Proyecto_Base_de_Datos.clasePaneles();
            this.lblTest = new System.Windows.Forms.Label();
            this.fechaRecibo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNFolio = new System.Windows.Forms.TextBox();
            this.refrescarSocios = new System.Windows.Forms.Timer(this.components);
            this.socioTableAdapter = new Proyecto_Base_de_Datos.BDProyectoDataSetTableAdapters.socioTableAdapter();
            this.clasePaneles2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyectoDataSet)).BeginInit();
            this.clasePaneles3.SuspendLayout();
            this.clasePaneles1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.AutoSize = true;
            this.gunaLabel15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel15.Location = new System.Drawing.Point(75, 419);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(92, 20);
            this.gunaLabel15.TabIndex = 29;
            this.gunaLabel15.Text = "      Firmas    ";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(75, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(151, 20);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "    Datos del recibo    ";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(75, 251);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(119, 20);
            this.gunaLabel7.TabIndex = 31;
            this.gunaLabel7.Text = "    Datos socio    ";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(669, 443);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(175, 49);
            this.iconButton1.TabIndex = 27;
            this.iconButton1.Text = "Añadir";
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
            this.clasePaneles2.Controls.Add(this.gunaLabel8);
            this.clasePaneles2.Controls.Add(this.cmbSocio);
            this.clasePaneles2.Controls.Add(this.btnInsertarSocio);
            this.clasePaneles2.ForeColor = System.Drawing.Color.White;
            this.clasePaneles2.Location = new System.Drawing.Point(12, 261);
            this.clasePaneles2.Name = "clasePaneles2";
            this.clasePaneles2.Size = new System.Drawing.Size(849, 120);
            this.clasePaneles2.TabIndex = 30;
            this.clasePaneles2.TextColor = System.Drawing.Color.White;
            this.clasePaneles2.Paint += new System.Windows.Forms.PaintEventHandler(this.clasePaneles2_Paint);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(66, 23);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(124, 20);
            this.gunaLabel8.TabIndex = 18;
            this.gunaLabel8.Text = "Seleccionar socio";
            // 
            // cmbSocio
            // 
            this.cmbSocio.BackColor = System.Drawing.Color.Transparent;
            this.cmbSocio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocio.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSocio.FocusedState.Parent = this.cmbSocio;
            this.cmbSocio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.HoverState.Parent = this.cmbSocio;
            this.cmbSocio.ItemHeight = 30;
            this.cmbSocio.ItemsAppearance.Parent = this.cmbSocio;
            this.cmbSocio.Location = new System.Drawing.Point(67, 46);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.ShadowDecoration.Parent = this.cmbSocio;
            this.cmbSocio.Size = new System.Drawing.Size(333, 36);
            this.cmbSocio.TabIndex = 33;
            this.cmbSocio.DropDown += new System.EventHandler(this.cmbSocio_DropDown);
            this.cmbSocio.SelectedIndexChanged += new System.EventHandler(this.cmbSocio_SelectedIndexChanged);
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataMember = "socio";
            this.socioBindingSource.DataSource = this.bDProyectoDataSet;
            // 
            // bDProyectoDataSet
            // 
            this.bDProyectoDataSet.DataSetName = "BDProyectoDataSet";
            this.bDProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInsertarSocio
            // 
            this.btnInsertarSocio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsertarSocio.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarSocio.ForeColor = System.Drawing.Color.Black;
            this.btnInsertarSocio.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnInsertarSocio.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInsertarSocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertarSocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertarSocio.Location = new System.Drawing.Point(529, 37);
            this.btnInsertarSocio.Name = "btnInsertarSocio";
            this.btnInsertarSocio.Size = new System.Drawing.Size(265, 49);
            this.btnInsertarSocio.TabIndex = 32;
            this.btnInsertarSocio.Text = "Agregar nuevo socio";
            this.btnInsertarSocio.UseVisualStyleBackColor = false;
            this.btnInsertarSocio.Click += new System.EventHandler(this.btnInsertarSocio_Click);
            // 
            // clasePaneles3
            // 
            this.clasePaneles3.BackColor = System.Drawing.Color.Transparent;
            this.clasePaneles3.BackgroundColor = System.Drawing.Color.Transparent;
            this.clasePaneles3.BorderColor = System.Drawing.Color.Navy;
            this.clasePaneles3.BorderRadius = 20;
            this.clasePaneles3.BorderSize = 1;
            this.clasePaneles3.Controls.Add(this.lblAdmin);
            this.clasePaneles3.Controls.Add(this.gunaLabel19);
            this.clasePaneles3.ForeColor = System.Drawing.Color.White;
            this.clasePaneles3.Location = new System.Drawing.Point(12, 430);
            this.clasePaneles3.Name = "clasePaneles3";
            this.clasePaneles3.Size = new System.Drawing.Size(486, 95);
            this.clasePaneles3.TabIndex = 28;
            this.clasePaneles3.TextColor = System.Drawing.Color.White;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblAdmin.Location = new System.Drawing.Point(77, 27);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(78, 20);
            this.lblAdmin.TabIndex = 11;
            this.lblAdmin.Text = "lblAdmin";
            // 
            // gunaLabel19
            // 
            this.gunaLabel19.AutoSize = true;
            this.gunaLabel19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel19.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel19.Location = new System.Drawing.Point(184, 58);
            this.gunaLabel19.Name = "gunaLabel19";
            this.gunaLabel19.Size = new System.Drawing.Size(108, 20);
            this.gunaLabel19.TabIndex = 10;
            this.gunaLabel19.Text = "Firma asistente";
            // 
            // clasePaneles1
            // 
            this.clasePaneles1.BackColor = System.Drawing.Color.Transparent;
            this.clasePaneles1.BackgroundColor = System.Drawing.Color.Transparent;
            this.clasePaneles1.BorderColor = System.Drawing.Color.Navy;
            this.clasePaneles1.BorderRadius = 20;
            this.clasePaneles1.BorderSize = 1;
            this.clasePaneles1.Controls.Add(this.lblTest);
            this.clasePaneles1.Controls.Add(this.fechaRecibo);
            this.clasePaneles1.Controls.Add(this.gunaLabel5);
            this.clasePaneles1.Controls.Add(this.txtImporte);
            this.clasePaneles1.Controls.Add(this.gunaLabel4);
            this.clasePaneles1.Controls.Add(this.gunaLabel2);
            this.clasePaneles1.Controls.Add(this.txtNFolio);
            this.clasePaneles1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clasePaneles1.ForeColor = System.Drawing.Color.White;
            this.clasePaneles1.Location = new System.Drawing.Point(12, 26);
            this.clasePaneles1.Name = "clasePaneles1";
            this.clasePaneles1.Size = new System.Drawing.Size(880, 184);
            this.clasePaneles1.TabIndex = 23;
            this.clasePaneles1.TextColor = System.Drawing.Color.White;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.ForeColor = System.Drawing.Color.Black;
            this.lblTest.Location = new System.Drawing.Point(330, 83);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(45, 19);
            this.lblTest.TabIndex = 14;
            this.lblTest.Text = "label1";
            // 
            // fechaRecibo
            // 
            this.fechaRecibo.CheckedState.Parent = this.fechaRecibo;
            this.fechaRecibo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fechaRecibo.HoverState.Parent = this.fechaRecibo;
            this.fechaRecibo.Location = new System.Drawing.Point(632, 26);
            this.fechaRecibo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fechaRecibo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fechaRecibo.Name = "fechaRecibo";
            this.fechaRecibo.ShadowDecoration.Parent = this.fechaRecibo;
            this.fechaRecibo.Size = new System.Drawing.Size(200, 36);
            this.fechaRecibo.TabIndex = 13;
            this.fechaRecibo.Value = new System.DateTime(2023, 5, 9, 20, 46, 55, 783);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(48, 152);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(119, 20);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Importe en MNX";
            // 
            // txtImporte
            // 
            this.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(20, 122);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(189, 27);
            this.txtImporte.TabIndex = 11;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(695, 65);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(47, 20);
            this.gunaLabel4.TabIndex = 10;
            this.gunaLabel4.Text = "Fecha";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(52, 65);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(119, 20);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Numero de folio";
            // 
            // txtNFolio
            // 
            this.txtNFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNFolio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNFolio.Location = new System.Drawing.Point(20, 35);
            this.txtNFolio.Name = "txtNFolio";
            this.txtNFolio.Size = new System.Drawing.Size(189, 27);
            this.txtNFolio.TabIndex = 0;
            // 
            // refrescarSocios
            // 
            this.refrescarSocios.Tick += new System.EventHandler(this.refrescarSocios_Tick);
            // 
            // socioTableAdapter
            // 
            this.socioTableAdapter.ClearBeforeFill = true;
            // 
            // frmAgregarRecibo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.clasePaneles2);
            this.Controls.Add(this.gunaLabel15);
            this.Controls.Add(this.clasePaneles3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.clasePaneles1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarRecibo";
            this.Text = "frmAgregarRecibo";
            this.Load += new System.EventHandler(this.frmAgregarRecibo_Load);
            this.clasePaneles2.ResumeLayout(false);
            this.clasePaneles2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyectoDataSet)).EndInit();
            this.clasePaneles3.ResumeLayout(false);
            this.clasePaneles3.PerformLayout();
            this.clasePaneles1.ResumeLayout(false);
            this.clasePaneles1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        private clasePaneles clasePaneles3;
        private Guna.UI.WinForms.GunaLabel gunaLabel19;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private clasePaneles clasePaneles1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.TextBox txtNFolio;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private clasePaneles clasePaneles2;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSocio;
        private FontAwesome.Sharp.IconButton btnInsertarSocio;
        private System.Windows.Forms.Timer refrescarSocios;
        private Guna.UI.WinForms.GunaLabel lblAdmin;
        private Guna.UI2.WinForms.Guna2DateTimePicker fechaRecibo;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblTest;
        private BDProyectoDataSet bDProyectoDataSet;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private BDProyectoDataSetTableAdapters.socioTableAdapter socioTableAdapter;
    }
}