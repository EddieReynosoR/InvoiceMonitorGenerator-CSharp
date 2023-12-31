﻿
namespace Proyecto_Base_de_Datos
{
    partial class ImprimirRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirRecibo));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.btnPDF = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnCorreo = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.reciboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDProyectoDataSet1 = new Proyecto_Base_de_Datos.BDProyectoDataSet1();
            this.reciboTableAdapter = new Proyecto_Base_de_Datos.BDProyectoDataSet1TableAdapters.reciboTableAdapter();
            this.lblImporte = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblNumeroFolio = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyectoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnAtras);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(12, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 50);
            this.panel6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registec";
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnAtras.IconColor = System.Drawing.Color.Thistle;
            this.btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras.IconSize = 40;
            this.btnAtras.Location = new System.Drawing.Point(-3, 1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(58, 42);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(708, 53);
            this.panel5.TabIndex = 8;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(33, 82);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(178, 32);
            this.gunaLabel1.TabIndex = 44;
            this.gunaLabel1.Text = "Imprimir recibo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(35, 136);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(74, 20);
            this.gunaLabel2.TabIndex = 45;
            this.gunaLabel2.Text = "Opciones:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.CheckedState.Parent = this.btnImprimir;
            this.btnImprimir.CustomImages.Parent = this.btnImprimir;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.HoverState.Parent = this.btnImprimir;
            this.btnImprimir.Location = new System.Drawing.Point(39, 176);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ShadowDecoration.Parent = this.btnImprimir;
            this.btnImprimir.Size = new System.Drawing.Size(180, 45);
            this.btnImprimir.TabIndex = 46;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.CheckedState.Parent = this.btnPDF;
            this.btnPDF.CustomImages.Parent = this.btnPDF;
            this.btnPDF.FillColor = System.Drawing.Color.Red;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.HoverState.Parent = this.btnPDF;
            this.btnPDF.Location = new System.Drawing.Point(39, 248);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.ShadowDecoration.Parent = this.btnPDF;
            this.btnPDF.Size = new System.Drawing.Size(180, 45);
            this.btnPDF.TabIndex = 47;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.CheckedState.Parent = this.btnExcel;
            this.btnExcel.CustomImages.Parent = this.btnExcel;
            this.btnExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.HoverState.Parent = this.btnExcel;
            this.btnExcel.Location = new System.Drawing.Point(39, 319);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ShadowDecoration.Parent = this.btnExcel;
            this.btnExcel.Size = new System.Drawing.Size(180, 45);
            this.btnExcel.TabIndex = 48;
            this.btnExcel.Text = "Generar Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.CheckedState.Parent = this.btnCorreo;
            this.btnCorreo.CustomImages.Parent = this.btnCorreo;
            this.btnCorreo.FillColor = System.Drawing.Color.Gold;
            this.btnCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCorreo.ForeColor = System.Drawing.Color.White;
            this.btnCorreo.HoverState.Parent = this.btnCorreo;
            this.btnCorreo.Location = new System.Drawing.Point(39, 399);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.ShadowDecoration.Parent = this.btnCorreo;
            this.btnCorreo.Size = new System.Drawing.Size(180, 45);
            this.btnCorreo.TabIndex = 49;
            this.btnCorreo.Text = "Enviar por correo";
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // reciboBindingSource
            // 
            this.reciboBindingSource.DataMember = "recibo";
            this.reciboBindingSource.DataSource = this.bDProyectoDataSet1;
            // 
            // bDProyectoDataSet1
            // 
            this.bDProyectoDataSet1.DataSetName = "BDProyectoDataSet1";
            this.bDProyectoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reciboTableAdapter
            // 
            this.reciboTableAdapter.ClearBeforeFill = true;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(411, 191);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(63, 20);
            this.lblImporte.TabIndex = 53;
            this.lblImporte.Text = "Importe";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(300, 191);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(65, 20);
            this.gunaLabel3.TabIndex = 52;
            this.gunaLabel3.Text = "Importe:";
            // 
            // lblNumeroFolio
            // 
            this.lblNumeroFolio.AutoSize = true;
            this.lblNumeroFolio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFolio.Location = new System.Drawing.Point(446, 166);
            this.lblNumeroFolio.Name = "lblNumeroFolio";
            this.lblNumeroFolio.Size = new System.Drawing.Size(55, 20);
            this.lblNumeroFolio.TabIndex = 51;
            this.lblNumeroFolio.Text = "NFolio";
            this.lblNumeroFolio.Click += new System.EventHandler(this.lblNumeroFolio_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(283, 166);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(122, 20);
            this.gunaLabel4.TabIndex = 50;
            this.gunaLabel4.Text = "Número de folio:";
            // 
            // ImprimirRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 479);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lblNumeroFolio);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImprimirRecibo";
            this.Text = "ImprimirRecibo";
            this.Load += new System.EventHandler(this.ImprimirRecibo_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reciboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDProyectoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnAtras;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCorreo;
        private Guna.UI2.WinForms.Guna2Button btnExcel;
        private Guna.UI2.WinForms.Guna2Button btnPDF;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private BDProyectoDataSet1 bDProyectoDataSet1;
        private System.Windows.Forms.BindingSource reciboBindingSource;
        private BDProyectoDataSet1TableAdapters.reciboTableAdapter reciboTableAdapter;
        private Guna.UI.WinForms.GunaLabel lblImporte;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblNumeroFolio;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}