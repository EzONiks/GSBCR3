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
    public partial class FrmRapportEnCours : Form
    {
        private VISITEUR leVisiteur;
        public FrmRapportEnCours(VISITEUR v, List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            leVisiteur = v;
            label2.Text = leVisiteur.VIS_NOM;
            label3.Text = leVisiteur.Vis_PRENOM;
            bsRapportEnCours.DataSource = lr;
            dgvRapportEnCours.DataSource = bsRapportEnCours;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRapportEnCours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RAPPORT_VISITE r = (RAPPORT_VISITE)bsRapportEnCours.Current;
            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();
            //On relance la liaison de données pour actualiser l'état des rapports
            if (r.RAP_ETAT == "2")
            {
                //les rapports à l'état 2 ('saisie terminée') ne doivent pas apparaitre dans la liste
                bsRapportEnCours.RemoveCurrent();
            }
            else
            {
                bsRapportEnCours.ResetCurrentItem();
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true);
            if (f.ShowDialog() == DialogResult.OK)
            {
                bsRapportEnCours.Add(r);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvRapportEnCours.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvRapportEnCours.Rows[selectedRowIndex];
            int rap_num = Convert.ToInt32(selectedRow.Cells["rAPNUMDataGridViewTextBoxColumn"].Value);
            RAPPORT_VISITE r = VisiteurManager.ChargerRapportVisite(leVisiteur.VIS_MATRICULE, rap_num);
            FrmSaisir f = new FrmSaisir(r, true);
            if (f.ShowDialog() == DialogResult.OK)
            {
                List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurEncours(leVisiteur.VIS_MATRICULE);
                bsRapportEnCours.DataSource = lr;
            }
        }
    }
}
