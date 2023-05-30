namespace PoS
{
    partial class FormDescuento
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
            btnClose = new FontAwesome.Sharp.IconPictureBox();
            btn10 = new Button();
            btn15 = new Button();
            btn20 = new Button();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClose.IconColor = SystemColors.ControlText;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 40;
            btnClose.Location = new Point(678, 37);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btn10
            // 
            btn10.Location = new Point(425, 86);
            btn10.Name = "btn10";
            btn10.Size = new Size(94, 29);
            btn10.TabIndex = 1;
            btn10.Text = "button1";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn10_Click;
            // 
            // btn15
            // 
            btn15.Location = new Point(425, 122);
            btn15.Name = "btn15";
            btn15.Size = new Size(94, 29);
            btn15.TabIndex = 2;
            btn15.Text = "button2";
            btn15.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            btn20.Location = new Point(425, 157);
            btn20.Name = "btn20";
            btn20.Size = new Size(94, 29);
            btn20.TabIndex = 3;
            btn20.Text = "button3";
            btn20.UseVisualStyleBackColor = true;
            // 
            // FormDescuento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn20);
            Controls.Add(btn15);
            Controls.Add(btn10);
            Controls.Add(btnClose);
            Name = "FormDescuento";
            Text = "FormDescuento";
            Load += FormDescuento_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnClose;
        private Button btn10;
        private Button btn15;
        private Button btn20;
    }
}