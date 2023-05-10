namespace Proyecto_Base_de_Datos
{
    partial class frmGestiondeRecibos
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
            this.txtBuscarRecibo = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panelRecibos = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // txtBuscarRecibo
            // 
            this.txtBuscarRecibo.BorderRadius = 20;
            this.txtBuscarRecibo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarRecibo.DefaultText = "";
            this.txtBuscarRecibo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarRecibo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarRecibo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarRecibo.DisabledState.Parent = this.txtBuscarRecibo;
            this.txtBuscarRecibo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarRecibo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarRecibo.FocusedState.Parent = this.txtBuscarRecibo;
            this.txtBuscarRecibo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarRecibo.HoverState.Parent = this.txtBuscarRecibo;
            this.txtBuscarRecibo.IconLeft = global::Proyecto_Base_de_Datos.Properties.Resources._3031293;
            this.txtBuscarRecibo.Location = new System.Drawing.Point(595, 13);
            this.txtBuscarRecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarRecibo.Name = "txtBuscarRecibo";
            this.txtBuscarRecibo.PasswordChar = '\0';
            this.txtBuscarRecibo.PlaceholderText = "";
            this.txtBuscarRecibo.SelectedText = "";
            this.txtBuscarRecibo.ShadowDecoration.Parent = this.txtBuscarRecibo;
            this.txtBuscarRecibo.Size = new System.Drawing.Size(267, 44);
            this.txtBuscarRecibo.TabIndex = 42;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.iconButton2.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(656, 516);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(224, 49);
            this.iconButton2.TabIndex = 41;
            this.iconButton2.Text = "Historial de cambios";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(220, 32);
            this.gunaLabel1.TabIndex = 43;
            this.gunaLabel1.Text = "Recibos registrados";
            // 
            // panelRecibos
            // 
            this.panelRecibos.AutoScroll = true;
            this.panelRecibos.Location = new System.Drawing.Point(33, 79);
            this.panelRecibos.Name = "panelRecibos";
            this.panelRecibos.ShadowDecoration.Parent = this.panelRecibos;
            this.panelRecibos.Size = new System.Drawing.Size(838, 431);
            this.panelRecibos.TabIndex = 44;
            // 
            // frmGestiondeRecibos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 577);
            this.Controls.Add(this.panelRecibos);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtBuscarRecibo);
            this.Controls.Add(this.iconButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestiondeRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestiondeRecibos";
            this.Load += new System.EventHandler(this.frmGestiondeRecibos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarRecibo;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Panel panelRecibos;
    }
}