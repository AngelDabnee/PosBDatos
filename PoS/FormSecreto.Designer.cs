namespace PoS
{
    partial class FormSecreto
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
            pictureGif = new PictureBox();
            btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureGif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // pictureGif
            // 
            pictureGif.BackColor = SystemColors.Control;
            pictureGif.Location = new Point(455, 199);
            pictureGif.Name = "pictureGif";
            pictureGif.Size = new Size(125, 62);
            pictureGif.TabIndex = 0;
            pictureGif.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Control;
            btnCerrar.ForeColor = SystemColors.ControlText;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCerrar.IconColor = SystemColors.ControlText;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.IconSize = 40;
            btnCerrar.Location = new Point(551, 87);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormSecreto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(pictureGif);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSecreto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormSecreto";
            WindowState = FormWindowState.Maximized;
            Load += FormSecreto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureGif).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureGif;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
    }
}