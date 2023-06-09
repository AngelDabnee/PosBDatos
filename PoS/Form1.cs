using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System.Security.Cryptography;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using System.Windows.Forms;
using System.Windows.Documents;
using System.Drawing.Text;
using System.Linq.Expressions;
using MySqlX.XDevAPI.Relational;
using LibPrintTicket;
using FontAwesome.Sharp;

namespace PoS
{
    public partial class Form1 : Form
    {
        //Declaramos variables de clase 
        MySqlConnection con = new MySqlConnection("server=localhost;database=pos;uid=root;pwd=;");
        MySqlCommand comando;
        MySqlDataReader leer;
        String comandoSelect = "";
        String cantidad = "";
        double sumaTotal = 0;
        double descuento = 0;
        int rows = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //no djeamos habilitados los btn
            btnDescuento.Enabled = false;
            btnDescuento15.Enabled = false;
            btnDescuento20.Enabled = false;


            //Le damos fondo al form
            //this.BackgroundImage = Image.FromFile("..\\..\\..\\..\\logosForm\\fondoBurger.jpg");

            //colocamos un fondo
            this.BackColor = SystemColors.Menu;

            //ESTABLECEMOS EL LEABLE DANDOLE LA HORA Y FECHA. 
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            HoraFecha.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            //Localizacion del lable, con la linea 13, hacemos que se localice en la mitad.
            titulo.Location = new Point((this.Width / 2) - (titulo.Width / 2), 20);//ESTE LO LOCALIZAMOS EN EL CENTRO
            titulo.Font = new Font("Arial", 30F, FontStyle.Bold);
            titulo.Font = new Font("Arial", 30F, FontStyle.Underline);
            titulo.Font = new Font("Arial", 30F, FontStyle.Italic);
            titulo.AutoSize = true;
            //Centramos el desarrollado por, sobre el titulo que realizamos la inicio. 
            desarrolladoPor.Location = new Point(dataGridProductos.Width + panelInfUsuario.Width + btn1.Width + txtCodigo.Width + pictureBoxUsuario.Width + btn3.Width + titulo.Width - bottonSalir.Width - 45, pictureBoxLogo.Height - HoraFecha.Height);
            desarrolladoPor.Text = "Atendido por: Angel Dabnee";
            desarrolladoPor.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            desarrolladoPor.AutoSize = true;
            //Hora y fecha está a altura sumada de lo que vale titulo, desarrollado, centrado. 
            HoraFecha.Location = new Point(10 + dataGridProductos.Width + panelInfUsuario.Width + pictureBoxLogo.Width + titulo.Width + txtCodigo.Width + btn3.Width, (titulo.Height + Desarrollado.Height));//SE ESTABLECE EN EL CENTOR DEBAJO DEL TITULO ANTERIOR
            //Localizamos el datagrid, según al nivel de hora y fecha
            dataGridProductos.Location = new Point((10), (titulo.Height + Desarrollado.Height + HoraFecha.Height));//CENTRAMOS EL DATAGRID SEPARANDOLO 10 PIXELES DE CADA LADO
            dataGridProductos.Width = (this.Width / 2) - 20;//Con esto separamos 10 pixeles entre el objeto y la ventana, de cada lado. 
            dataGridProductos.Height = (this.Height / 4) * 3;//Con esto le damos al 3/4 segun la altura DE TODOS LOS PIXELES
            dataGridProductos.BackgroundColor = Color.White;
            //doy pie a que se mantenga seleccionada la ultima celda
            pictureBoxLogo.Location = new Point(10, 10); //ESTABLECEMOS QUE ESTÉ EN LA ESQUINA DE LA PANTALLA
            pictureBoxLogo.Size = new Size(300, titulo.Height + Desarrollado.Height);
            txtCodigo.Location = new Point((10), this.Height - txtCodigo.Height);
            txtCodigo.Width = this.Width - 20;//esta segun el nivel del data grid. 
            //COLOCAMOS LA LOCALIZACIÓN DEL PANEL. 
            panelInfUsuario.Location = new Point(30 + dataGridProductos.Width - 10, (titulo.Height + Desarrollado.Height + HoraFecha.Height));
            panelInfUsuario.Width = this.Width / 2;//localizamos el panel a la misma propocion que el datagrid
            panelInfUsuario.Height = (this.Height / 4) * 3;
            panelInfUsuario.BackColor = Color.White;

            //LOCALIZAR EL PICTUREBOX DEL USUARIO.
            pictureBoxUsuario.Location = new Point(((panelInfUsuario.Width + dataGridProductos.Width) / 4) * 3 - bottonSalir.Width, titulo.Height + pictureBoxLogo.Height + HoraFecha.Height);
            pictureBoxUsuario.Width = this.Width;
            pictureBoxUsuario.Height = pictureBoxUsuario.Height + dataGridProductos.Height / 8;
            pictureBoxUsuario.Image = Image.FromFile("..\\..\\..\\..\\logosForm\\usuarioPerfil.jpg");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuario.BackColor = Color.White;

            //Acomodo de los botones de calculadora de los paneles. 
            btn1.Location = new Point(10 + panelInfUsuario.Width, dataGridProductos.Height / 2);
            btn1.Text = "1";
            btn1.Font = new Font("Microsoft Sans Serif", 40F);
            btn1.AutoSize = true;
            //btn2
            btn2.Location = new Point(10 + panelInfUsuario.Width + btn1.Width, dataGridProductos.Height / 2);
            btn2.Text = "2";
            btn2.Font = new Font("Microsoft Sans Serif", 40F);
            btn2.AutoSize = true;
            //btn3
            btn3.Location = new Point(10 + panelInfUsuario.Width + btn1.Width + btn2.Width, dataGridProductos.Height / 2);
            btn3.Text = "3";
            btn3.Font = new Font("Microsoft Sans Serif", 40F);
            btn3.AutoSize = true;
            //btn4
            btn4.Location = new Point(10 + panelInfUsuario.Width, btn1.Height + (dataGridProductos.Height / 2));
            btn4.Text = "4";
            btn4.Font = new Font("Microsoft Sans Serif", 40F);
            btn4.AutoSize = true;
            //btn5
            btn5.Location = new Point(10 + panelInfUsuario.Width + btn1.Width, btn2.Height + (dataGridProductos.Height / 2));
            btn5.Text = "5";
            btn5.Font = new Font("Microsoft Sans Serif", 40F);
            btn5.AutoSize = true;
            //btn6
            btn6.Location = new Point(10 + panelInfUsuario.Width + btn1.Width + btn2.Width, btn3.Height + (dataGridProductos.Height / 2));
            btn6.Text = "6";
            btn6.Font = new Font("Microsoft Sans Serif", 40F);
            btn6.AutoSize = true;
            //btn7
            btn7.Location = new Point(10 + panelInfUsuario.Width, btn1.Height + btn4.Height + (dataGridProductos.Height / 2));
            btn7.Text = "7";
            btn7.Font = new Font("Microsoft Sans Serif", 40F);
            btn7.AutoSize = true;
            //btn8
            btn8.Location = new Point(10 + panelInfUsuario.Width + btn7.Width, btn1.Height + btn4.Height + (dataGridProductos.Height / 2));
            btn8.Text = "8";
            btn8.Font = new Font("Microsoft Sans Serif", 40F);
            btn8.AutoSize = true;
            //btn9
            btn9.Location = new Point(10 + panelInfUsuario.Width + btn7.Width + btn8.Width, btn1.Height + btn4.Height + (dataGridProductos.Height / 2));
            btn9.Text = "9";
            btn9.Font = new Font("Microsoft Sans Serif", 40F);
            btn9.AutoSize = true;
            //btn0
            btn0.Location = new Point(10 + panelInfUsuario.Width + btnPunto.Width, btn1.Height + btn4.Height + btn7.Height + (dataGridProductos.Height / 2));
            btn0.Text = "0";
            btn0.Font = new Font("Microsoft Sans Serif", 40F);
            btn0.AutoSize = true;
            //btnPunto
            btnPunto.Location = new Point(10 + panelInfUsuario.Width, btn1.Height + btn4.Height + btn7.Height + (dataGridProductos.Height / 2));
            btnPunto.Text = ".";
            btnPunto.Font = new Font("Microsoft Sans Serif", 40F);
            btnPunto.AutoSize = true;
            //btnBorrar
            btnBorrar.Location = new Point(10 + panelInfUsuario.Width + btnPunto.Width + btn0.Width, btn1.Height + btn4.Height + btn7.Height + (dataGridProductos.Height / 2));
            btnBorrar.Text = "x";
            btnBorrar.Font = new Font("Microsoft Sans Serif", 40F);
            btnBorrar.AutoSize = true;
            //btnSecreto
            btnSecreto.Location = new Point(10 + panelInfUsuario.Width + btn1.Width + btn2.Width + btn3.Width, dataGridProductos.Height / 2);
            btnSecreto.Height = this.Height + btn3.Height + btn6.Height - txtCodigo.Height - lableTotal.Height - panelInfUsuario.Height;
            btnSecreto.Text = "ENTER";
            btnPunto.Font = new Font("Microsoft Sans Serif", 40F);
            btnSecreto.AutoSize = true;


            //AÑADIMOS COLUMNAS, NOMBRES, EDITAMOS EL ESTILO Y DETERMINAMOS EL TAMAÑO
            //INICIAMOS ESTABLECIENDO LAS PROPIEDADES DE CANTIDAD. 
            dataGridProductos.Columns.Add("Cantidad", "Cantidad");//Aqui añadimos las columnas. 
            dataGridProductos.Columns[0].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);//Esta es la propiedad para cambiarle el tipo de letra tamaño
            dataGridProductos.Columns[0].Width = (dataGridProductos.Width * 20) / 100;//Damos el tamaño de cada columna
            //SE ESTABLECE LAS PROPIEDADES DE LA COLUMNA NOMBRE
            dataGridProductos.Columns.Add("Nombre", "Nombre");//Aqui añadimos las columnas. 
            dataGridProductos.Columns[1].Width = ((dataGridProductos.Width) * 40) / 100;//Damos el tamaño de la columna 2
            dataGridProductos.Columns[1].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            dataGridProductos.Columns[1].HeaderCell.Style.Font = new Font("Arial", 20F, FontStyle.Bold);

            //SE ESTABLECE LAS PRROPIEDADES DE LA COLUMNA PRECIO
            dataGridProductos.Columns.Add("Precio", "Precio");//Aqui añadimos las columnas. 
            dataGridProductos.Columns[2].Width = ((dataGridProductos.Width) * 20) / 100;//tamaño de la columna 3
            dataGridProductos.Columns[2].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            //SE ESTABLECE LAS PROPIEDADES DE LA COLUMNA TOTAL
            dataGridProductos.Columns.Add("Total", "Total");//Aqui añadimos las columnas. 
            dataGridProductos.Columns[3].Width = ((dataGridProductos.Width) * 20) / 100;//tamaño de la columna 4 
            dataGridProductos.Columns[3].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            //AGREGAR EL FORMATO PARA MONEDA
            dataGridProductos.Columns[3].DefaultCellStyle.Format = "C2";
            dataGridProductos.Columns[2].DefaultCellStyle.Format = "C2";
            //ALINEAR AL CENTRO LAS COLUMNAS DEL DATAGRID
            dataGridProductos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProductos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProductos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProductos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //IMPEDIR LA EDICIÓN DEL DATAGRID
            //LA PROPIEDAD ReadOnly, PERMITE QUE SE PUEDA O NO MODIFICAR EL TEXTO. 
            dataGridProductos.ReadOnly = true;
            //MODIFICAMOS LAS PROPIDADES DEL LABLE TOTAL. 
            Font fuente = new Font("Arial", 25);//AQUI ESTAMOS MODIFICANDO EL TAMAÑO DE LA FUENTE Y EL TIPO. 
            lableTotal.Font = fuente;//EL RESULTADO LO MANDAMOS AL VALOR DEL LABLE. 
            //CAMBIAMOS LA POSICIÓN DEL TXT TOTAL SUMANDO LAS POSICIONES DE ALGUNOS DE LOS COMPONENTES DE ESTE. 
            int posicion = (this.Height - (titulo.Height + Desarrollado.Height + HoraFecha.Height + dataGridProductos.Height + txtCodigo.Height));
            lableTotal.Location = new Point(10 + dataGridProductos.Columns[0].Width +
                dataGridProductos.Columns[1].Width + dataGridProductos.Columns[2].Width - btn1.Width, (titulo.Height +
                Desarrollado.Height + HoraFecha.Height + dataGridProductos.Height) + posicion / 4);





            //ACOMODO DE LOS BOTONES ADICIONALES
            //botones de descuento
            btnDescuento.Location = new Point(10, titulo.Height +
                Desarrollado.Height + HoraFecha.Height + dataGridProductos.Height);
            btnDescuento.Height = this.Height - titulo.Height - Desarrollado.Height - HoraFecha.Height - dataGridProductos.Height - txtCodigo.Height;
            btnDescuento.Text = "10%";
            btnDescuento.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            btnDescuento.AutoSize = true;
            //BTN15
            btnDescuento15.Location = new Point(10 + btnDescuento.Width + 10, ((titulo.Height +
            Desarrollado.Height + HoraFecha.Height + dataGridProductos.Height)));
            btnDescuento15.Height = this.Height - titulo.Height - Desarrollado.Height - HoraFecha.Height - dataGridProductos.Height - txtCodigo.Height;
            btnDescuento15.Text = "15%";
            btnDescuento15.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            btnDescuento15.AutoSize = true;
            //BTN20
            btnDescuento20.Location = new Point(10 + btnDescuento15.Width + btnDescuento.Width + 20, ((titulo.Height +
            Desarrollado.Height + HoraFecha.Height + dataGridProductos.Height)));
            btnDescuento20.Height = this.Height - titulo.Height - Desarrollado.Height - HoraFecha.Height - dataGridProductos.Height - txtCodigo.Height;
            btnDescuento20.Text = "20%";
            btnDescuento20.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            btnDescuento20.AutoSize = true;


            //HACEMOS QUE EL MOUSE SIEMPRE APAREZCA EN EL TXT DEL CODIGO
            txtCodigo.TabIndex = 0;
            //QUITAMOS LAS LINEAS DE LA TABLA
            this.dataGridProductos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            //Boton para salir
            bottonSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            bottonSalir.BackgroundImageLayout = ImageLayout.Stretch;
            bottonSalir.Location = new Point((this.Width - bottonSalir.Width), 0);
            //CAMBIAR LA FUENTE DEL DATA GRID VIEW
            dataGridProductos.DefaultCellStyle.Font = new Font("Arial", 18);

        }
        //Personalizamos el lable de hora y fecha según la hora y fecha del sistema, esta se actualiza. 
        private void time_Tick(object sender, EventArgs e)
        {
            //AL LEABLE 
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }
        //CON ESTE EVENTO, NO DEJAMOS MOVER AL USUARIO CON EL CODE. 
        private void txtCodigo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }

        }
        //PARA QUE FUNCIONE LA TECLA ENTER. 
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//PARA CUANDO EL USUARIO LE DE ENTER SE MANDE EL MENSAJE
            {
                try
                {

                    if (txtCodigo.Text.IndexOf('*') != -1)
                    {

                        String[] producto = txtCodigo.Text.Split('*');
                        cantidad = producto[0];
                        comandoSelect = "SELECT * FROM productos WHERE codigo = " + "'" + producto[1] + "'";
                    }
                    else
                    {
                        cantidad = "1";
                        comandoSelect = "SELECT * FROM productos WHERE codigo = " + "'" + txtCodigo.Text + "'";
                    }
                    con.Open();
                    comando = new MySqlCommand(comandoSelect, con);
                    leer = comando.ExecuteReader();
                    if (leer.HasRows)//LEEMOS LO QUE TENEMOS EN COMANDO
                    {

                        while (leer.Read())
                        {
                            //habilitamos los btn de descuento
                            btnDescuento.Enabled = true;
                            btnDescuento15.Enabled = true;
                            btnDescuento20.Enabled = true;
                            //DESPUÉS DE LEER AÑADIMOS LO QUE JALAMOS DE LA BASE DE DATOS Y LO PONEMOS EN RENGLONES EN EL DATAGRID, EN EL ORDEN DE LAS COLUMNAS
                            rows = dataGridProductos.Rows.Add(cantidad.ToString(), leer.GetString(1), Math.Round(leer.GetDouble(2), 2), (double.Parse(leer.GetString(2)) * double.Parse(cantidad.ToString())));

                            //CREAMOS UN CICLO FOREACH PARA OBTENER LOS DATOS DEL TOTAL 
                            dataGridProductos.ClearSelection();
                            dataGridProductos.Rows[rows].Selected = true;
                            if (rows < dataGridProductos.Rows.Count - 1)
                            {
                                dataGridProductos.CurrentCell = dataGridProductos.Rows[rows + 1].Cells[0];
                            }
                            actualizarPrecio();
                        }
                    }
                    con.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("ERROR AL BUSCAR PRODUCTO" + error.Message);
                }
                finally
                {
                    txtCodigo.Clear();
                }

            }
            //---------------------------------BOTON PARA PAGAR///GENERAR CAMBIO--------------------------------
            if (e.KeyChar.ToString() == "p" || e.KeyChar.ToString() == "P")
            {
                try
                {
                    e.Handled = true;
                    if (txtCodigo.Text != "")
                    {

                        if (double.Parse(txtCodigo.Text) > sumaTotal && sumaTotal != 0)
                        {
                            e.Handled = true;
                            lableTotal.Text = "Cambio $ " + Math.Round((double.Parse(txtCodigo.Text) - sumaTotal), 2);
                            comandoSelect = "INSERT INTO ventas(fecha,hora) VALUES(CURDATE(),CURTIME())";
                            con.Open();
                            comando = new MySqlCommand(comandoSelect, con);
                            comando.ExecuteNonQuery();
                            comandoSelect = "SELECT LAST_INSERT_id() FROM ventas";
                            comando = new MySqlCommand(comandoSelect, con);
                            String id = (comando.ExecuteScalar().ToString());

                            //---------------------REGISTRAMOS DETALLES DE LA VENTA. ---------------------------------------
                            foreach (DataGridViewRow datos in dataGridProductos.Rows)
                            {
                                comandoSelect = $"INSERT INTO ventas_detalle(id_venta,cantidad,nombre,precio) VALUES('{id}','{datos.Cells[0].Value}','{datos.Cells[1].Value}','{datos.Cells[2].Value}');";
                                comando = new MySqlCommand(comandoSelect, con);
                                comando.ExecuteNonQuery();
                            }


                            dataGridProductos.Rows.Clear();
                            sumaTotal = 0;//SE REINICIA LA VENTA PARA QUE SE SALGA DEL IF DE LA VENTA

                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());

                }
                finally
                {
                    txtCodigo.Clear();
                    con.Close();
                }
            }
            //----------------------------------BOTON PARA DUPLICAR PRODUCTO SELECCIONADO---------------------------------
            if (e.KeyChar == '¿')
            {
                try
                {
                    e.Handled = true;
                    if (dataGridProductos.Rows.Count > 0)
                    {
                        DataGridViewRow lastRow = dataGridProductos.Rows[dataGridProductos.Rows.Count - 1];
                        object[] cellValues = new object[lastRow.Cells.Count];
                        for (int i = 0; i < lastRow.Cells.Count; i++)
                        {
                            cellValues[i] = lastRow.Cells[i].Value;
                        }
                        // Agregar una nueva fila con los mismos valores
                        dataGridProductos.Rows.Add(cellValues);
                        actualizarPrecio();
                        txtCodigo.Clear();

                    }
                }
                catch (Exception error)
                {

                }
                finally
                {
                }
            }
            //-------------------BOTÓN PARA ELIMINAR PRODUCTO SELECCIONADO----------------------------------------
            if (e.KeyChar == '{' || e.KeyChar == '{')
            {
                e.Handled = true;
                try
                {
                    if (dataGridProductos.Rows.Count > 0)
                    {
                        dataGridProductos.Rows.RemoveAt(dataGridProductos.Rows.Count - 1);
                        actualizarPrecio();
                    }
                }
                catch (Exception error)
                {

                }
                finally
                {
                    txtCodigo.Clear();
                }
            }
        }
        //----------------------------BOTÓN DE SALIR-----------------------------------------------------
        private void bottonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDescuento_Click(object sender, EventArgs e)
        {
            calibrado();
            if (btnDescuento != null)
            {
                descuento = (sumaTotal * 10) / 100;
                sumaTotal = sumaTotal - descuento;
                lableTotal.Text = "Total $ " + Math.Round(sumaTotal, 2).ToString();
                btnDescuento.Enabled = false;
                if (dataGridProductos.Rows.Count == null)
                {
                    btnDescuento.Enabled = true;
                }
            }
        }
        private void btnDescuento15_Click(object sender, EventArgs e)
        {
            if (btnDescuento15 != null)
            {
                descuento = (sumaTotal * 15) / 100;
                sumaTotal = sumaTotal - descuento;
                lableTotal.Text = "Total $ " + Math.Round(sumaTotal, 2).ToString();
                btnDescuento.Enabled = false;
                if (dataGridProductos.Rows.Count == null)
                {
                    btnDescuento15.Enabled = true;
                }
            }
        }
        private void btnDescuento20_Click(object sender, EventArgs e)
        {
            if (btnDescuento20 != null)
            {
                descuento = (sumaTotal * 20) / 100;
                sumaTotal = sumaTotal - descuento;
                lableTotal.Text = "Total $ " + Math.Round(sumaTotal, 2).ToString();
                btnDescuento.Enabled = false;
                if (dataGridProductos.Rows.Count == null)
                {
                    btnDescuento20.Enabled = true;
                }
            }
        }

        //------------------------------MÉTODO PARA ACTUALIZAR EL PRECIO------------------------------------
        private void actualizarPrecio()
        {
            sumaTotal = 0;
            foreach (DataGridViewRow row in dataGridProductos.Rows)
            {
                DataGridViewCell cell = row.Cells[3];
                if (cell.Value != null)
                {
                    double total = double.Parse(cell.Value.ToString());
                    sumaTotal += total;
                }
                lableTotal.Text = "Total $ " + Math.Round(sumaTotal, 2).ToString();
            }
        }
        private void calibrado()
        {
            try
            {
                Ticket ticket = new Ticket();
                ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString().ToString());
                ticket.AddSubHeaderLine(DateTime.Now.ToShortTimeString().ToString());
                ticket.AddFooterLine("GRACIAS POR SU COMPRA");
                ticket.PrintTicket("EC-PM-5890X");
            }
            catch (Exception)
            {
                MessageBox.Show("IMPRESORA NO CONECTADA. ");
            }
        }
        //-------------------------------------REGION DE LOS BOTONES DE LA CALCULADORA------------------------
        #region
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "1";
                txtCodigo.Focus();
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "2";
                txtCodigo.Focus();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "3";
                txtCodigo.Focus();

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "4";
                txtCodigo.Focus();

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "5";
                txtCodigo.Focus();

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "6";
                txtCodigo.Focus();

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "7";
                txtCodigo.Focus();

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "8";
                txtCodigo.Focus();

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "9";
                txtCodigo.Focus();

            }
        }
        #endregion

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += "0";
                txtCodigo.Focus();
            }

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null)
            {
                txtCodigo.Text += ".";
                txtCodigo.Focus();
            }
        }

        private void btnSecreto_Click(object sender, EventArgs e)
        {
            Form formSecreto = new FormSecreto();
            formSecreto.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 1)
            {
                txtCodigo.Text = txtCodigo.Text.Substring(0, txtCodigo.Text.Length - 1);
            }
            else 
            {
                txtCodigo.Text = ""; 
            }
        }
    }

}


