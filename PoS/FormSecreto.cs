using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PoS
{
    public partial class FormSecreto : Form
    {
        private SoundPlayer player;
        public FormSecreto()
        {
            InitializeComponent();
            player = new SoundPlayer("C:\\Users\\Uesda\\source\\repos\\PuntoVentaBasedeDatos\\logosForm\\aplausos.wav");
        }

        private void FormSecreto_Load(object sender, EventArgs e)
        {
            //----btnCerrar
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Location = new Point((this.Width - btnCerrar.Width - 10), 10);

            //--picture
            pictureGif.Image = Image.FromFile("..\\..\\..\\..\\logosForm\\saludo.gif");
            pictureGif.Dock = DockStyle.Fill;
            pictureGif.SizeMode = PictureBoxSizeMode.StretchImage;
            player.Play();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            player.Stop();
        }
    }
}
