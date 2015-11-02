﻿namespace GestionAdministrativa.Win.Forms
{
    partial class FrmPrincipal
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
            this.BtnClientes = new Telerik.WinControls.UI.RadButton();
            this.BtnVentas = new Telerik.WinControls.UI.RadButton();
            this.BtnCobradores = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.Image = global::GestionAdministrativa.Win.Properties.Resources.CustomerGestionAdministrativa;
            this.BtnClientes.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BtnClientes.Location = new System.Drawing.Point(35, 37);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(156, 148);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnClientes.ThemeName = "TelerikMetro";
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.Image = global::GestionAdministrativa.Win.Properties.Resources.Sales_Order;
            this.BtnVentas.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVentas.Location = new System.Drawing.Point(218, 37);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(156, 148);
            this.BtnVentas.TabIndex = 2;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVentas.ThemeName = "TelerikMetro";
            this.BtnVentas.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // BtnCobradores
            // 
            this.BtnCobradores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCobradores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCobradores.Image = global::GestionAdministrativa.Win.Properties.Resources.cobradores;
            this.BtnCobradores.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCobradores.Location = new System.Drawing.Point(397, 37);
            this.BtnCobradores.Name = "BtnCobradores";
            this.BtnCobradores.Size = new System.Drawing.Size(156, 148);
            this.BtnCobradores.TabIndex = 3;
            this.BtnCobradores.Text = "Cobradores";
            this.BtnCobradores.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCobradores.ThemeName = "TelerikMetro";
            this.BtnCobradores.Click += new System.EventHandler(this.BtnCobradores_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 366);
            this.Controls.Add(this.BtnCobradores);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.BtnClientes);
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Alejandria";
            ((System.ComponentModel.ISupportInitialize)(this.BtnClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnClientes;
        private Telerik.WinControls.UI.RadButton BtnVentas;
        private Telerik.WinControls.UI.RadButton BtnCobradores;
    }
}
