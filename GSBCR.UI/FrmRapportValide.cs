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
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmRapportValide : Form
    {
        private VISITEUR leVisiteur;

        public FrmRapportValide(VISITEUR v, List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            leVisiteur = v;
            txtboxVis.Text = leVisiteur.VIS_NOM + " " + leVisiteur.Vis_PRENOM;
            bsRapportValide.DataSource = lr;
            dvgRapportValide.DataSource = bsRapportValide;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgRapportValide_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RAPPORT_VISITE r = (RAPPORT_VISITE)bsRapportValide.Current;
            FrmDetailRapport f = new FrmDetailRapport(r);
            f.ShowDialog();
        }
    }
}
