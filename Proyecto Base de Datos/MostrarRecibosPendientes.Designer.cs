
namespace Proyecto_Base_de_Datos
{
    partial class MostrarRecibosPendientes
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelRecibos = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarRecibo = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelRecibos
            // 
            this.panelRecibos.AutoScroll = true;
            this.panelRecibos.Location = new System.Drawing.Point(39, 89);
            this.panelRecibos.Name = "panelRecibos";
            this.panelRecibos.ShadowDecoration.Parent = this.panelRecibos;
            this.panelRecibos.Size = new System.Drawing.Size(838, 431);
            this.panelRecibos.TabIndex = 47;
            this.panelRecibos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRecibos_Paint);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(33, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(442, 32);
            this.gunaLabel1.TabIndex = 46;
            this.gunaLabel1.Text = "Recibos registrados pendientes de firma";
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
            this.txtBuscarRecibo.Location = new System.Drawing.Point(601, 23);
            this.txtBuscarRecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarRecibo.Name = "txtBuscarRecibo";
            this.txtBuscarRecibo.PasswordChar = '\0';
            this.txtBuscarRecibo.PlaceholderText = "";
            this.txtBuscarRecibo.SelectedText = "";
            this.txtBuscarRecibo.ShadowDecoration.Parent = this.txtBuscarRecibo;
            this.txtBuscarRecibo.Size = new System.Drawing.Size(267, 44);
            this.txtBuscarRecibo.TabIndex = 45;
            // 
            // MostrarRecibosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 577);
            this.Controls.Add(this.panelRecibos);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtBuscarRecibo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarRecibosPendientes";
            this.Text = "MostrarRecibosPendientes";
            this.Load += new System.EventHandler(this.MostrarRecibosPendientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panelRecibos;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarRecibo;
    }
}