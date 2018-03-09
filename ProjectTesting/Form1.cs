using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mởSổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoSoTietKiem form1 = new frmMoSoTietKiem();
            form1.ShowDialog();
        }
    }
}
