namespace PoS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            titulo = new Label();
            Desarrollado = new Label();
            HoraFecha = new Label();
            time = new System.Windows.Forms.Timer(components);
            dataGridProductos = new DataGridView();
            pictureBoxLogo = new PictureBox();
            txtCodigo = new TextBox();
            lableTotal = new Label();
            bottonSalir = new FontAwesome.Sharp.IconButton();
            button2 = new Button();
            button3 = new Button();
            openFileDialogDescuento = new OpenFileDialog();
            btnDescuento = new Button();
            panelInfUsuario = new Panel();
            nomUsuario = new Label();
            pictureBoxUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(222, 23);
            titulo.Name = "titulo";
            titulo.Size = new Size(277, 42);
            titulo.TabIndex = 0;
            titulo.Text = "DabneeBurger's";
            // 
            // Desarrollado
            // 
            Desarrollado.AutoSize = true;
            Desarrollado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Desarrollado.Location = new Point(398, 90);
            Desarrollado.Name = "Desarrollado";
            Desarrollado.Size = new Size(0, 24);
            Desarrollado.TabIndex = 1;
            // 
            // HoraFecha
            // 
            HoraFecha.AutoSize = true;
            HoraFecha.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HoraFecha.Location = new Point(397, 148);
            HoraFecha.Name = "HoraFecha";
            HoraFecha.Size = new Size(109, 24);
            HoraFecha.TabIndex = 2;
            HoraFecha.Text = "Hora y Fecha";
            // 
            // time
            // 
            time.Enabled = true;
            time.Interval = 1000;
            time.Tick += time_Tick;
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToAddRows = false;
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridProductos.Location = new Point(289, 206);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.RowHeadersVisible = false;
            dataGridProductos.RowHeadersWidth = 51;
            dataGridProductos.RowTemplate.Height = 29;
            dataGridProductos.Size = new Size(300, 188);
            dataGridProductos.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(654, 133);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(125, 62);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(159, 109);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 76);
            txtCodigo.TabIndex = 5;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            txtCodigo.PreviewKeyDown += txtCodigo_PreviewKeyDown;
            // 
            // lableTotal
            // 
            lableTotal.AutoSize = true;
            lableTotal.Location = new Point(638, 262);
            lableTotal.Name = "lableTotal";
            lableTotal.Size = new Size(88, 20);
            lableTotal.TabIndex = 6;
            lableTotal.Text = "Total: $ 0.00";
            // 
            // bottonSalir
            // 
            bottonSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            bottonSalir.IconColor = Color.Black;
            bottonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bottonSalir.Location = new Point(126, 288);
            bottonSalir.Name = "bottonSalir";
            bottonSalir.Size = new Size(94, 29);
            bottonSalir.TabIndex = 7;
            bottonSalir.Tag = "";
            bottonSalir.UseVisualStyleBackColor = true;
            bottonSalir.Click += bottonSalir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(632, 367);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(632, 402);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // openFileDialogDescuento
            // 
            openFileDialogDescuento.FileName = "openFileDialog1";
            // 
            // btnDescuento
            // 
            btnDescuento.Location = new Point(632, 332);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(94, 29);
            btnDescuento.TabIndex = 11;
            btnDescuento.Text = "button1";
            btnDescuento.UseVisualStyleBackColor = true;
            btnDescuento.Click += btnDescuento_Click;
            // 
            // panelInfUsuario
            // 
            panelInfUsuario.Location = new Point(529, 2);
            panelInfUsuario.Name = "panelInfUsuario";
            panelInfUsuario.Size = new Size(250, 125);
            panelInfUsuario.TabIndex = 12;
            // 
            // nomUsuario
            // 
            nomUsuario.AutoSize = true;
            nomUsuario.Location = new Point(535, 168);
            nomUsuario.Name = "nomUsuario";
            nomUsuario.Size = new Size(50, 20);
            nomUsuario.TabIndex = 13;
            nomUsuario.Text = "label1";
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Location = new Point(53, 38);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(125, 65);
            pictureBoxUsuario.TabIndex = 14;
            pictureBoxUsuario.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxUsuario);
            Controls.Add(nomUsuario);
            Controls.Add(panelInfUsuario);
            Controls.Add(btnDescuento);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(bottonSalir);
            Controls.Add(lableTotal);
            Controls.Add(txtCodigo);
            Controls.Add(pictureBoxLogo);
            Controls.Add(dataGridProductos);
            Controls.Add(HoraFecha);
            Controls.Add(Desarrollado);
            Controls.Add(titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label Desarrollado;
        private Label HoraFecha;
        private System.Windows.Forms.Timer time;
        private DataGridView dataGridProductos;
        private PictureBox pictureBoxLogo;
        private TextBox txtCodigo;
        private Label lableTotal;
        private FontAwesome.Sharp.IconButton bottonSalir;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialogDescuento;
        private Button btnDescuento;
        private Panel panelInfUsuario;
        private Label nomUsuario;
        private PictureBox pictureBoxUsuario;
    }
}