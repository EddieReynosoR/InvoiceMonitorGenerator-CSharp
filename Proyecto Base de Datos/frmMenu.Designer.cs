namespace Proyecto_Base_de_Datos
{
    partial class frmMenu
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
            this.clasePaneles1 = new Proyecto_Base_de_Datos.clasePaneles();
            this.SuspendLayout();
            // 
            // clasePaneles1
            // 
            this.clasePaneles1.BackColor = System.Drawing.Color.Transparent;
            this.clasePaneles1.BackgroundColor = System.Drawing.Color.Transparent;
            this.clasePaneles1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clasePaneles1.BorderRadius = 8;
            this.clasePaneles1.BorderSize = 1;
            this.clasePaneles1.ForeColor = System.Drawing.Color.White;
            this.clasePaneles1.Location = new System.Drawing.Point(99, 90);
            this.clasePaneles1.Name = "clasePaneles1";
            this.clasePaneles1.Size = new System.Drawing.Size(584, 189);
            this.clasePaneles1.TabIndex = 0;
            this.clasePaneles1.TextColor = System.Drawing.Color.White;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clasePaneles1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private clasePaneles clasePaneles1;
    }
}