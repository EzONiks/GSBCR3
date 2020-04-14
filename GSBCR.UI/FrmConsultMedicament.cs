using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCR.UI
{
    public partial class FrmConsultMedicament : Form
    {
        public FrmConsultMedicament()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultMedicament_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gSB_visite_RAVAZDataSet.MEDICAMENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mEDICAMENTTableAdapter.Fill(this.gSB_visite_RAVAZDataSet.MEDICAMENT);

        }
    }
}
