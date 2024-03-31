
namespace Desafío1
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.ClearFields = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(92, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOG IN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(150)))));
            this.panel2.Location = new System.Drawing.Point(68, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(150)))));
            this.panel3.Location = new System.Drawing.Point(68, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 6;
            // 
            // bttnLogin
            // 
            this.bttnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.bttnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttnLogin.Location = new System.Drawing.Point(35, 311);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(233, 35);
            this.bttnLogin.TabIndex = 7;
            this.bttnLogin.Text = "LOG IN";
            this.bttnLogin.UseVisualStyleBackColor = false;
            this.bttnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // EXIT
            // 
            this.EXIT.AutoSize = true;
            this.EXIT.BackColor = System.Drawing.Color.White;
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.EXIT.Location = new System.Drawing.Point(131, 368);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(44, 18);
            this.EXIT.TabIndex = 8;
            this.EXIT.Text = "EXIT";
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // textUserName
            // 
            this.textUserName.BackColor = System.Drawing.Color.White;
            this.textUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.textUserName.Location = new System.Drawing.Point(68, 181);
            this.textUserName.Multiline = true;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(200, 24);
            this.textUserName.TabIndex = 9;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.textPassword.Location = new System.Drawing.Point(68, 239);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(200, 24);
            this.textPassword.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 27;
            this.iconPictureBox1.Location = new System.Drawing.Point(35, 181);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(27, 27);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UnlockKeyhole;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 27;
            this.iconPictureBox2.Location = new System.Drawing.Point(35, 236);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(27, 27);
            this.iconPictureBox2.TabIndex = 12;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Medrt;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 79;
            this.iconPictureBox3.Location = new System.Drawing.Point(111, 96);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(79, 79);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox3.TabIndex = 13;
            this.iconPictureBox3.TabStop = false;
            // 
            // ClearFields
            // 
            this.ClearFields.AutoSize = true;
            this.ClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ClearFields.Location = new System.Drawing.Point(176, 286);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(92, 16);
            this.ClearFields.TabIndex = 14;
            this.ClearFields.Text = "Clear Fields";
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.ControlBox = false;
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Label EXIT;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label ClearFields;
    }
}

