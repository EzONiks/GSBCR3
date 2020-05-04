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
    public partial class FrmConsultMedicament : Form
    {
        public FrmConsultMedicament(List<MEDICAMENT> lm)
        {
            InitializeComponent();
            bsMedicament.DataSource = lm;
            dgvMed.DataSource = bsMedicament;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultMedicament_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gSB_visite_RAVAZDataSet2.MEDICAMENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mEDICAMENTTableAdapter.Fill(this.gSB_visite_RAVAZDataSet2.MEDICAMENT);

        }

        private void bsMedicament_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
