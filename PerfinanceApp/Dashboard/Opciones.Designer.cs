namespace Dashboard
{
    partial class Opciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.BotonCambiarTema = new CustomControls.Controls.ToggleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de tema";
            // 
            // BotonCambiarTema
            // 
            this.BotonCambiarTema.AutoSize = true;
            this.BotonCambiarTema.Location = new System.Drawing.Point(341, 141);
            this.BotonCambiarTema.MinimumSize = new System.Drawing.Size(45, 22);
            this.BotonCambiarTema.Name = "BotonCambiarTema";
            this.BotonCambiarTema.OffBackColor = System.Drawing.Color.Gray;
            this.BotonCambiarTema.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.BotonCambiarTema.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BotonCambiarTema.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.BotonCambiarTema.Size = new System.Drawing.Size(45, 22);
            this.BotonCambiarTema.TabIndex = 0;
            this.BotonCambiarTema.UseVisualStyleBackColor = true;
            this.BotonCambiarTema.CheckedChanged += new System.EventHandler(this.BotonCambiarTema_CheckedChanged);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(747, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonCambiarTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opciones";
            this.Text = "Opciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.Controls.ToggleButton BotonCambiarTema;
        private System.Windows.Forms.Label label1;
    }
}