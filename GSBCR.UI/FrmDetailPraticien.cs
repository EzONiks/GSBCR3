using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;

namespace GSBCR.UI
{
    public partial class FrmDetailPraticien : Form
    {
        private PRATICIEN lePra;
        public FrmDetailPraticien(PRATICIEN p)
        {
            InitializeComponent();
            lePra = p;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetailPraticien_Load(object sender, EventArgs e)
        {
            ucPratictien1.pRATICIEN = this.lePra;
        }
    }
}
