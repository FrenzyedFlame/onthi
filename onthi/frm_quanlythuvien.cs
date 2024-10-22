using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onthi
{
    public partial class frm_quanlythuvien : Form
    {
        public frm_quanlythuvien()
        {
            InitializeComponent();
        }

        private void nhapSẹcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhapsach nhapsach = new frm_nhapsach();
            nhapsach.MdiParent = this;
            nhapsach.Show();
        }
    }
}
