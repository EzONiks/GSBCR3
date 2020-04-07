using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.modele;

namespace GSBCR.UI
{
    public partial class FrmRapportUnPraticien : Form
    {
        VISITEUR leVisiteur = null;
        public FrmRapportUnPraticien(List<RAPPORT_VISITE> lr, VISITEUR v)
        {
            InitializeComponent();
            bsRapportUnPraticien.DataSource = lr;
            dgvRapportUnPraticien.DataSource = bsRapportUnPraticien;
            dgvRapportUnPraticien.MultiSelect = false;
            leVisiteur = v;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvRapportUnPraticien.SelectedCells[0].RowIndex;
            int rapnum = (int)dgvRapportUnPraticien.Rows[selectedRow].Cells[0].Value;

            RAPPORT_VISITE leRapport = VisiteurManager.ChargerRapportVisite(leVisiteur.VIS_MATRICULE, rapnum);

            FrmDetailRapport f = new FrmDetailRapport(leRapport);
            f.ShowDialog();
        }
    }
}
