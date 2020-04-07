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
using GSBCR.UI;

namespace GSBCR.UI
{
    public partial class FrmDetailMedicament : Form
    {
        private MEDICAMENT leMedicament;
        public FrmDetailMedicament(MEDICAMENT med)
        {
            InitializeComponent();
            this.leMedicament = med;
        }

        private void FrmDetailMedicament_Load(object sender, EventArgs e)
        {
            ucMedicament1.LeMedicament = this.leMedicament;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
