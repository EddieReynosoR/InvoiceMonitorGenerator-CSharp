
namespace Proyecto_Base_de_Datos
{
    partial class registroRecibo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblNumeroFolio = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblImporte = new Guna.UI.WinForms.GunaLabel();
            this.lblPeriodo = new Guna.UI.WinForms.GunaLabel();
            this.lblSocio = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblEstatus = new Guna.UI.WinForms.GunaLabel();
            this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblAdmins = new Guna.UI.WinForms.GunaLabel();
            this.lblAdmin2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.Gold;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(925, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(180, 45);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar recibo";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(19, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(122, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Número de folio:";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // lblNumeroFolio
            // 
            this.lblNumeroFolio.AutoSize = true;
            this.lblNumeroFolio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFolio.Location = new System.Drawing.Point(182, 24);
            this.lblNumeroFolio.Name = "lblNumeroFolio";
            this.lblNumeroFolio.Size = new System.Drawing.Size(55, 20);
            this.lblNumeroFolio.TabIndex = 2;
            this.lblNumeroFolio.Text = "NFolio";
            this.lblNumeroFolio.Click += new System.EventHandler(this.lblNumeroFolio_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(36, 49);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(65, 20);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Importe:";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(147, 49);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(63, 20);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "Importe";
            this.lblImporte.Click += new System.EventHandler(this.lblImporte_Click);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(36, 107);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(62, 20);
            this.lblPeriodo.TabIndex = 5;
            this.lblPeriodo.Text = "Periodo";
            this.lblPeriodo.Click += new System.EventHandler(this.lblPeriodo_Click);
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(584, 44);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(46, 20);
            this.lblSocio.TabIndex = 6;
            this.lblSocio.Text = "Socio";
            this.lblSocio.Click += new System.EventHandler(this.lblSocio_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(584, 24);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(49, 20);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Socio:";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(813, 24);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(58, 20);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Estatus:";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(813, 49);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(56, 20);
            this.lblEstatus.TabIndex = 9;
            this.lblEstatus.Text = "Estatus";
            this.lblEstatus.Click += new System.EventHandler(this.lblEstatus_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BorderRadius = 20;
            this.btnImprimir.CheckedState.Parent = this.btnImprimir;
            this.btnImprimir.CustomImages.Parent = this.btnImprimir;
            this.btnImprimir.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImprimir.HoverState.Parent = this.btnImprimir;
            this.btnImprimir.Location = new System.Drawing.Point(925, 86);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ShadowDecoration.Parent = this.btnImprimir;
            this.btnImprimir.Size = new System.Drawing.Size(180, 45);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir/Exportar";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(36, 151);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(94, 20);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Firmado por:";
            this.gunaLabel5.Click += new System.EventHandler(this.gunaLabel5_Click);
            // 
            // lblAdmins
            // 
            this.lblAdmins.AutoSize = true;
            this.lblAdmins.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmins.Location = new System.Drawing.Point(182, 151);
            this.lblAdmins.Name = "lblAdmins";
            this.lblAdmins.Size = new System.Drawing.Size(77, 20);
            this.lblAdmins.TabIndex = 12;
            this.lblAdmins.Text = "lblAdmins";
            this.lblAdmins.Click += new System.EventHandler(this.lblAdmins_Click);
            // 
            // lblAdmin2
            // 
            this.lblAdmin2.AutoSize = true;
            this.lblAdmin2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin2.Location = new System.Drawing.Point(182, 171);
            this.lblAdmin2.Name = "lblAdmin2";
            this.lblAdmin2.Size = new System.Drawing.Size(88, 20);
            this.lblAdmin2.TabIndex = 13;
            this.lblAdmin2.Text = "gunaLabel6";
            // 
            // registroRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblAdmin2);
            this.Controls.Add(this.lblAdmins);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.lblNumeroFolio);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnEditar);
            this.Name = "registroRecibo";
            this.Size = new System.Drawing.Size(1115, 203);
            this.Load += new System.EventHandler(this.registroRecibo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblNumeroFolio;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblImporte;
        private Guna.UI.WinForms.GunaLabel lblPeriodo;
        private Guna.UI.WinForms.GunaLabel lblSocio;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblEstatus;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lblAdmins;
        private Guna.UI.WinForms.GunaLabel lblAdmin2;
    }
}
