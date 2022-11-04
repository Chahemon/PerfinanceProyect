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
            this.BotonCambiarTema = new CustomControls.Controls.ToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonCambiarTema
            // 
            this.BotonCambiarTema.AutoSize = true;
            this.BotonCambiarTema.Location = new System.Drawing.Point(239, 77);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cambiar tema de la app";
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(747, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonCambiarTema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opciones";
            this.Text = "Opciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.Controls.ToggleButton BotonCambiarTema;
        private System.Windows.Forms.Label label2;
    }
}