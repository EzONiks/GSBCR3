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
    public partial class FrmPraticien : Form
    {
        private VISITEUR leVisiteur;
        private PRATICIEN lePraticien;
        private List<RAPPORT_VISITE> lesRapports;
        public FrmPraticien(VISITEUR v, List<PRATICIEN> lp)
        {
            InitializeComponent();
            leVisiteur = v;
            label2.Text = leVisiteur.VIS_NOM;
            label3.Text = leVisiteur.Vis_PRENOM;
            bsPraticien.DataSource = lp;
            cbPraticien.DataSource = bsPraticien;
            cbPraticien.DisplayMember = "PRA_FULLNAME";
            cbPraticien.ValueMember = "PRA_NUM";
            selectPraticien();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectPraticien();
        }

        private void selectPraticien()
        {
            PRATICIEN p = (PRATICIEN)this.cbPraticien.SelectedItem;
            if (p != null)
            {
                lePraticien = p;
                ucPratictien1.pRATICIEN = lePraticien;
                List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurPraticien(leVisiteur.VIS_MATRICULE, lePraticien.PRA_NUM);
                if (lr != null && lr.Count > 0)
                {
                    lesRapports = lr;
                    label4.Visible = false;
                    btnRapport.Visible = true;
                }
                else
                {
                    label4.Visible = true;
                    btnRapport.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Impossible de récupérer le praticien", "Détails praticien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            FrmRapportUnPraticien f = new FrmRapportUnPraticien(lesRapports, leVisiteur);
            f.ShowDialog();
        }
    }
}
