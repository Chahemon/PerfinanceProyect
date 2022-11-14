
namespace Dashboard
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContra = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recoverPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EtiquetaInfo = new System.Windows.Forms.Label();
            this.EtiquetaInfo2 = new System.Windows.Forms.Label();
            this.RegisterLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textUsuario
            // 
            this.textUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.textUsuario.Location = new System.Drawing.Point(77, 270);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(219, 29);
            this.textUsuario.TabIndex = 2;
            this.textUsuario.Text = "USUARIO";
            this.textUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUsuario.Enter += new System.EventHandler(this.textUsuario_Enter);
            this.textUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textContra_KeyDown);
            this.textUsuario.Leave += new System.EventHandler(this.textUsuario_Leave);
            // 
            // textContra
            // 
            this.textContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.textContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textContra.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.textContra.Location = new System.Drawing.Point(77, 317);
            this.textContra.Name = "textContra";
            this.textContra.Size = new System.Drawing.Size(219, 29);
            this.textContra.TabIndex = 3;
            this.textContra.Text = "CONTRASEÑA";
            this.textContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textContra.Enter += new System.EventHandler(this.textContra_Enter);
            this.textContra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textContra_KeyDown);
            this.textContra.Leave += new System.EventHandler(this.textContra_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.btnAcceder.Location = new System.Drawing.Point(77, 397);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(219, 37);
            this.btnAcceder.TabIndex = 1;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            this.btnAcceder.MouseEnter += new System.EventHandler(this.btnAcceder_MouseEnter);
            this.btnAcceder.MouseLeave += new System.EventHandler(this.btnAcceder_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // recoverPasswordLabel
            // 
            this.recoverPasswordLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.recoverPasswordLabel.AutoSize = true;
            this.recoverPasswordLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoverPasswordLabel.LinkColor = System.Drawing.Color.DimGray;
            this.recoverPasswordLabel.Location = new System.Drawing.Point(177, 351);
            this.recoverPasswordLabel.Name = "recoverPasswordLabel";
            this.recoverPasswordLabel.Size = new System.Drawing.Size(119, 13);
            this.recoverPasswordLabel.TabIndex = 4;
            this.recoverPasswordLabel.TabStop = true;
            this.recoverPasswordLabel.Text = "Recuperar contraseña";
            this.recoverPasswordLabel.Click += new System.EventHandler(this.recoverPasswordLabel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 38);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(313, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.buttonMinimizePointed);
            this.button3.MouseLeave += new System.EventHandler(this.buttonMinimizeDisapointed);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(340, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.buttonClosePointed);
            this.button2.MouseLeave += new System.EventHandler(this.buttonCloseDisapointed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.ProyectoLogo;
            this.pictureBox1.Location = new System.Drawing.Point(60, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 153);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // EtiquetaInfo
            // 
            this.EtiquetaInfo.AutoSize = true;
            this.EtiquetaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaInfo.ForeColor = System.Drawing.Color.Red;
            this.EtiquetaInfo.Location = new System.Drawing.Point(79, 245);
            this.EtiquetaInfo.Name = "EtiquetaInfo";
            this.EtiquetaInfo.Size = new System.Drawing.Size(214, 13);
            this.EtiquetaInfo.TabIndex = 0;
            this.EtiquetaInfo.Text = "LA CONTRASEÑA ES INCORRECTA";
            this.EtiquetaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EtiquetaInfo2
            // 
            this.EtiquetaInfo2.AutoSize = true;
            this.EtiquetaInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaInfo2.ForeColor = System.Drawing.Color.Red;
            this.EtiquetaInfo2.Location = new System.Drawing.Point(74, 245);
            this.EtiquetaInfo2.Name = "EtiquetaInfo2";
            this.EtiquetaInfo2.Size = new System.Drawing.Size(229, 13);
            this.EtiquetaInfo2.TabIndex = 7;
            this.EtiquetaInfo2.Text = "EL USUARIO INGRESADO NO EXISTE";
            // 
            // RegisterLinkedLabel
            // 
            this.RegisterLinkedLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RegisterLinkedLabel.AutoSize = true;
            this.RegisterLinkedLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLinkedLabel.LinkColor = System.Drawing.Color.DimGray;
            this.RegisterLinkedLabel.Location = new System.Drawing.Point(111, 372);
            this.RegisterLinkedLabel.Name = "RegisterLinkedLabel";
            this.RegisterLinkedLabel.Size = new System.Drawing.Size(182, 13);
            this.RegisterLinkedLabel.TabIndex = 8;
            this.RegisterLinkedLabel.TabStop = true;
            this.RegisterLinkedLabel.Text = "¿No tienes cuenta aun? Registrate";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(372, 478);
            this.Controls.Add(this.RegisterLinkedLabel);
            this.Controls.Add(this.EtiquetaInfo2);
            this.Controls.Add(this.EtiquetaInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.recoverPasswordLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.textContra);
            this.Controls.Add(this.textUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfinance Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel recoverPasswordLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EtiquetaInfo;
        private System.Windows.Forms.Label EtiquetaInfo2;
        private System.Windows.Forms.LinkLabel RegisterLinkedLabel;
    }
}