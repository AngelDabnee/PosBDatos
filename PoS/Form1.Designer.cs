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
            btnDescuento15 = new Button();
            btnDescuento20 = new Button();
            openFileDialogDescuento = new OpenFileDialog();
            btnDescuento = new Button();
            panelInfUsuario = new Panel();
            nomUsuario = new Label();
            pictureBoxUsuario = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(194, 17);
            titulo.Name = "titulo";
            titulo.Size = new Size(226, 33);
            titulo.TabIndex = 0;
            titulo.Text = "DabneeBurger's";
            // 
            // Desarrollado
            // 
            Desarrollado.AutoSize = true;
            Desarrollado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Desarrollado.Location = new Point(348, 68);
            Desarrollado.Name = "Desarrollado";
            Desarrollado.Size = new Size(0, 20);
            Desarrollado.TabIndex = 1;
            // 
            // HoraFecha
            // 
            HoraFecha.AutoSize = true;
            HoraFecha.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HoraFecha.Location = new Point(347, 111);
            HoraFecha.Name = "HoraFecha";
            HoraFecha.Size = new Size(89, 20);
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
            dataGridProductos.Location = new Point(253, 154);
            dataGridProductos.Margin = new Padding(3, 2, 3, 2);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.RowHeadersVisible = false;
            dataGridProductos.RowHeadersWidth = 51;
            dataGridProductos.RowTemplate.Height = 29;
            dataGridProductos.Size = new Size(262, 141);
            dataGridProductos.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(572, 100);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(109, 46);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(139, 82);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(110, 63);
            txtCodigo.TabIndex = 5;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            txtCodigo.PreviewKeyDown += txtCodigo_PreviewKeyDown;
            // 
            // lableTotal
            // 
            lableTotal.AutoSize = true;
            lableTotal.Location = new Point(558, 196);
            lableTotal.Name = "lableTotal";
            lableTotal.Size = new Size(68, 15);
            lableTotal.TabIndex = 6;
            lableTotal.Text = "Total: $ 0.00";
            // 
            // bottonSalir
            // 
            bottonSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            bottonSalir.IconColor = Color.Black;
            bottonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bottonSalir.Location = new Point(110, 216);
            bottonSalir.Margin = new Padding(3, 2, 3, 2);
            bottonSalir.Name = "bottonSalir";
            bottonSalir.Size = new Size(82, 22);
            bottonSalir.TabIndex = 7;
            bottonSalir.Tag = "";
            bottonSalir.UseVisualStyleBackColor = true;
            bottonSalir.Click += bottonSalir_Click;
            // 
            // btnDescuento15
            // 
            btnDescuento15.Location = new Point(553, 275);
            btnDescuento15.Margin = new Padding(3, 2, 3, 2);
            btnDescuento15.Name = "btnDescuento15";
            btnDescuento15.Size = new Size(82, 22);
            btnDescuento15.TabIndex = 9;
            btnDescuento15.Text = "button2";
            btnDescuento15.UseVisualStyleBackColor = true;
            btnDescuento15.Click += btnDescuento15_Click;
            // 
            // btnDescuento20
            // 
            btnDescuento20.Location = new Point(553, 302);
            btnDescuento20.Margin = new Padding(3, 2, 3, 2);
            btnDescuento20.Name = "btnDescuento20";
            btnDescuento20.Size = new Size(82, 22);
            btnDescuento20.TabIndex = 10;
            btnDescuento20.Text = "button3";
            btnDescuento20.UseVisualStyleBackColor = true;
            btnDescuento20.Click += btnDescuento20_Click;
            // 
            // openFileDialogDescuento
            // 
            openFileDialogDescuento.FileName = "openFileDialog1";
            // 
            // btnDescuento
            // 
            btnDescuento.Location = new Point(553, 249);
            btnDescuento.Margin = new Padding(3, 2, 3, 2);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(82, 22);
            btnDescuento.TabIndex = 11;
            btnDescuento.Text = "button1";
            btnDescuento.UseVisualStyleBackColor = true;
            btnDescuento.Click += btnDescuento_Click;
            // 
            // panelInfUsuario
            // 
            panelInfUsuario.Location = new Point(463, 2);
            panelInfUsuario.Margin = new Padding(3, 2, 3, 2);
            panelInfUsuario.Name = "panelInfUsuario";
            panelInfUsuario.Size = new Size(219, 94);
            panelInfUsuario.TabIndex = 12;
            // 
            // nomUsuario
            // 
            nomUsuario.AutoSize = true;
            nomUsuario.Location = new Point(468, 126);
            nomUsuario.Name = "nomUsuario";
            nomUsuario.Size = new Size(38, 15);
            nomUsuario.TabIndex = 13;
            nomUsuario.Text = "label1";
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Location = new Point(46, 28);
            pictureBoxUsuario.Margin = new Padding(3, 2, 3, 2);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(109, 49);
            pictureBoxUsuario.TabIndex = 14;
            pictureBoxUsuario.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(596, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(pictureBoxUsuario);
            Controls.Add(nomUsuario);
            Controls.Add(panelInfUsuario);
            Controls.Add(btnDescuento);
            Controls.Add(btnDescuento20);
            Controls.Add(btnDescuento15);
            Controls.Add(bottonSalir);
            Controls.Add(lableTotal);
            Controls.Add(txtCodigo);
            Controls.Add(pictureBoxLogo);
            Controls.Add(dataGridProductos);
            Controls.Add(HoraFecha);
            Controls.Add(Desarrollado);
            Controls.Add(titulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnDescuento15;
        private Button btnDescuento20;
        private OpenFileDialog openFileDialogDescuento;
        private Button btnDescuento;
        private Panel panelInfUsuario;
        private Label nomUsuario;
        private PictureBox pictureBoxUsuario;
        private Button button1;
    }
}