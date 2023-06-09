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
            pictureBoxUsuario = new PictureBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            desarrolladoPor = new Label();
            btnPunto = new Button();
            btn0 = new Button();
            btnBorrar = new Button();
            btnSecreto = new Button();
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
            Desarrollado.Location = new Point(398, 91);
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
            dataGridProductos.Location = new Point(289, 205);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.RowHeadersVisible = false;
            dataGridProductos.RowHeadersWidth = 51;
            dataGridProductos.RowTemplate.Height = 29;
            dataGridProductos.Size = new Size(299, 188);
            dataGridProductos.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(654, 133);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(125, 61);
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
            lableTotal.Location = new Point(638, 261);
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
            // btnDescuento15
            // 
            btnDescuento15.Location = new Point(632, 367);
            btnDescuento15.Name = "btnDescuento15";
            btnDescuento15.Size = new Size(94, 29);
            btnDescuento15.TabIndex = 9;
            btnDescuento15.Text = "button2";
            btnDescuento15.UseVisualStyleBackColor = true;
            btnDescuento15.Click += btnDescuento15_Click;
            // 
            // btnDescuento20
            // 
            btnDescuento20.Location = new Point(632, 403);
            btnDescuento20.Name = "btnDescuento20";
            btnDescuento20.Size = new Size(94, 29);
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
            panelInfUsuario.Location = new Point(529, 3);
            panelInfUsuario.Name = "panelInfUsuario";
            panelInfUsuario.Size = new Size(250, 125);
            panelInfUsuario.TabIndex = 12;
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Location = new Point(53, 37);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(125, 65);
            pictureBoxUsuario.TabIndex = 14;
            pictureBoxUsuario.TabStop = false;
            // 
            // btn1
            // 
            btn1.Location = new Point(563, 466);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 15;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(696, 475);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 16;
            btn2.Text = "button1";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(799, 489);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 17;
            btn3.Text = "button1";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(546, 500);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 29);
            btn4.TabIndex = 18;
            btn4.Text = "button1";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(679, 517);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 29);
            btn5.TabIndex = 19;
            btn5.Text = "button1";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(812, 527);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 29);
            btn6.TabIndex = 20;
            btn6.Text = "button1";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(578, 550);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 29);
            btn7.TabIndex = 21;
            btn7.Text = "button1";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(705, 562);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 29);
            btn8.TabIndex = 22;
            btn8.Text = "button1";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(848, 581);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 29);
            btn9.TabIndex = 23;
            btn9.Text = "button1";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // desarrolladoPor
            // 
            desarrolladoPor.AutoSize = true;
            desarrolladoPor.Location = new Point(696, 218);
            desarrolladoPor.Name = "desarrolladoPor";
            desarrolladoPor.Size = new Size(50, 20);
            desarrolladoPor.TabIndex = 24;
            desarrolladoPor.Text = "label1";
            // 
            // btnPunto
            // 
            btnPunto.Location = new Point(574, 592);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(94, 29);
            btnPunto.TabIndex = 25;
            btnPunto.Text = "button1";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(704, 600);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 29);
            btn0.TabIndex = 26;
            btn0.Text = "button1";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(826, 619);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 27;
            btnBorrar.Text = "button1";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSecreto
            // 
            btnSecreto.Location = new Point(443, 591);
            btnSecreto.Name = "btnSecreto";
            btnSecreto.Size = new Size(94, 29);
            btnSecreto.TabIndex = 28;
            btnSecreto.Text = "button1";
            btnSecreto.UseVisualStyleBackColor = true;
            btnSecreto.Click += btnSecreto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(991, 654);
            Controls.Add(btnSecreto);
            Controls.Add(btnBorrar);
            Controls.Add(btn0);
            Controls.Add(btnPunto);
            Controls.Add(desarrolladoPor);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(pictureBoxUsuario);
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
        private PictureBox pictureBoxUsuario;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label desarrolladoPor;
        private Button btnPunto;
        private Button btn0;
        private Button btnBorrar;
        private Button btnSecreto;
    }
}