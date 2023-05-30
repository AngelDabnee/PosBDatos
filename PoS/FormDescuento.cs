using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace PoS
{
    public partial class FormDescuento : Form
    {
        public FormDescuento()
        {
            InitializeComponent();
        }

        private void FormDescuento_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btn10.Location = new Point((this.Width - btn10.Width) / 3, this.Height / 2);
            btn10.Width = this.Width / 2;
            btn15.Location = new Point((this.Width - btn15.Width) / 3, btn10.Height + this.Height / 2);
            btn15.Width = this.Width / 2;
            btn20.Location = new Point((this.Width - btn20.Width) / 3, btn10.Height + btn15.Height + this.Height / 2);
            btn20.Width = this.Width / 2;
            btn10.Text = "10" + "%";
            btn10.Font = new Font("Arial", 12, FontStyle.Bold);
            btn15.Text = "15" + "%";
            btn15.Font = new Font("Arial", 12, FontStyle.Bold);
            btn20.Text = "20" + "%";
            btn20.Font = new Font("Arial", 12, FontStyle.Bold);
            double desc = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            double desc10 = 0;
            desc10 = double.Parse(btn10.Text.ToString());
            
        }
    }
}
