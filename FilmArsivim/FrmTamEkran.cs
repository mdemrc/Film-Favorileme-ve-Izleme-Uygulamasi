using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmArsivim
{
    public partial class FrmTamEkran : Form
    {
        public FrmTamEkran()
        {
            InitializeComponent();
        }
        public string link2;
        private void FrmTamEkran_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            webBrowser1.Navigate(link2);
        }
    }
}
