
namespace Proyecto_Base_de_Datos
{
    partial class frmGestionRecibosAprob
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panelRecibos = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(47, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(290, 32);
            this.gunaLabel1.TabIndex = 44;
            this.gunaLabel1.Text = "Recibos con ambas firmas";
            // 
            // panelRecibos
            // 
            this.panelRecibos.AutoScroll = true;
            this.panelRecibos.Location = new System.Drawing.Point(49, 87);
            this.panelRecibos.Name = "panelRecibos";
            this.panelRecibos.ShadowDecoration.Parent = this.panelRecibos;
            this.panelRecibos.Size = new System.Drawing.Size(1119, 431);
            this.panelRecibos.TabIndex = 45;
            this.panelRecibos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRecibos_Paint);
            // 
            // frmGestionRecibosAprob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 604);
            this.Controls.Add(this.panelRecibos);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionRecibosAprob";
            this.Text = "frmGestionRecibosAprob";
            this.Load += new System.EventHandler(this.frmGestionRecibosAprob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Panel panelRecibos;
    }
}