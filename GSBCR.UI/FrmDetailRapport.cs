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
    public partial class FrmDetailRapport : Form
    {
        private RAPPORT_VISITE leRapport;
        private VISITEUR vis;
        private PRATICIEN lePra;
        private MOTIF_VISITE mv;
        private MEDICAMENT med1;
        private MEDICAMENT med2;

        public FrmDetailRapport(RAPPORT_VISITE r)
        {
            InitializeComponent();
            this.leRapport = r;
            this.vis = VisiteurManager.getUnVisiteur(r.RAP_MATRICULE);
            this.lePra = VisiteurManager.ChargerLePraticien(r.RAP_PRANUM);
            this.mv = VisiteurManager.chargerLeMotifVisite(r.RAP_MOTIF);
            if(r.RAP_MED1 != null)
            {
                this.med1 = VisiteurManager.ChargerLeMedicament(r.RAP_MED1);
            }
            if(r.RAP_MED2 != null)
            {
                this.med2 = VisiteurManager.ChargerLeMedicament(r.RAP_MED2);
            }
            // Partie design
            this.DoubleBuffered = true;
        }

        private void FrmDetailRapport_Load(object sender, EventArgs e)
        {
            txtMatricule.Text = vis.VIS_NOM + " " + vis.Vis_PRENOM;
            txtNum.Text = leRapport.RAP_NUM.ToString();
            txtPRANUM.Text = lePra.PRA_NOM + " " + lePra.PRA_PRENOM;
            txtDate.Text = leRapport.RAP_DATE.ToString("dd-MM-yyyy");
            txtDATEVISITE.Text = leRapport.RAP_DATVISIT.ToString("dd-MM-yyyy");
            txtETAT.Text = leRapport.RAP_ETAT;
            txtConfiance.Text = leRapport.RAP_CONFIANCE;
            txtBilan.Text = leRapport.RAP_BILAN;
            txtMotif.Text = mv.MOT_LIBEL;
            txtMotifAutre.Text = leRapport.RAP_MOTIFAUTRE;
            txtRempl.Text = leRapport.RAP_NOMREMPL + " " + leRapport.RAP_PNOMREMPL;
            if (med1 == null)
            {
                txtMed1.Text = "";
            } else
            {
                txtMed1.Text = med1.MED_NOMCOMMERCIAL;
            }
            if (med2 == null)
            {
                txtMed2.Text = "";
            }
            else
            {
                txtMed2.Text = med2.MED_NOMCOMMERCIAL;
            }
        }

        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkMed1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtMed1.Text))
            {
                MessageBox.Show("Aucun médicament sur ce rapport");
            } else
            {
                FrmDetailMedicament f = new FrmDetailMedicament(med1);
                f.ShowDialog();
            }
            
        }

        private void linkMed2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMed2.Text))
            {
                MessageBox.Show("Aucun médicament sur ce rapport");
            }
            else
            {
                FrmDetailMedicament f = new FrmDetailMedicament(med2);
                f.ShowDialog();
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            FrmDetailPraticien f = new FrmDetailPraticien(this.lePra);
            f.ShowDialog();
        }

        private void txtPRANUM_Click(object sender, EventArgs e)
        {
            FrmDetailPraticien f = new FrmDetailPraticien(this.lePra);
            f.ShowDialog();
        }
    }
}
