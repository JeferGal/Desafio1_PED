﻿
namespace Desafío1
{
    partial class BuscarPaciente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.lblDatos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblExpediente);
            this.panel1.Controls.Add(this.txtExpediente);
            this.panel1.Controls.Add(this.lblSeparador);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7);
            this.panel1.Size = new System.Drawing.Size(320, 452);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(70, 172);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(10);
            this.btnBuscar.Size = new System.Drawing.Size(170, 64);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpediente.ForeColor = System.Drawing.Color.White;
            this.lblExpediente.Location = new System.Drawing.Point(41, 67);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(111, 17);
            this.lblExpediente.TabIndex = 11;
            this.lblExpediente.Text = "N° Expediente";
            this.lblExpediente.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtExpediente
            // 
            this.txtExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.txtExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpediente.ForeColor = System.Drawing.Color.White;
            this.txtExpediente.Location = new System.Drawing.Point(44, 103);
            this.txtExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpediente.Multiline = true;
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(213, 29);
            this.txtExpediente.TabIndex = 13;
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador.ForeColor = System.Drawing.Color.White;
            this.lblSeparador.Location = new System.Drawing.Point(39, 115);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(176, 17);
            this.lblSeparador.TabIndex = 12;
            this.lblSeparador.Text = "_____________________";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnMenu.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 40;
            this.btnMenu.Location = new System.Drawing.Point(603, 380);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(91, 58);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(372, 94);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(49, 17);
            this.lblDatos.TabIndex = 8;
            this.lblDatos.Text = "Datos:";
            // 
            // BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPaciente";
            this.Load += new System.EventHandler(this.BuscarPaciente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.Label lblSeparador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label lblDatos;
    }
}