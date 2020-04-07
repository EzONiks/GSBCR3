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
    public partial class FrmDetailPraticien : Form
    {
        List<RAPPORT_VISITE> lesRapports = null;
        VISITEUR leVisiteur;
        public FrmDetailPraticien(PRATICIEN p, TYPE_PRATICIEN tp, VISITEUR v)
        {
            InitializeComponent();
            tbxNomPra.Text = p.PRA_NOM;
            tbxPrenomPra.Text = p.PRA_PRENOM;
            tbxAdressePra.Text = p.PRA_ADRESSE;
            tbxCpPra.Text = p.PRA_CP;
            tbxVillePra.Text = p.PRA_VILLE;
            tbxCoefPra.Text = p.PRA_COEFNOTORIETE.ToString();
            tbxTypePra.Text = tp.TYP_LIBELLE;
            tbxLieuxPra.Text = tp.TYP_LIEU;

            List<RAPPORT_VISITE> lr = null;
            try
            {
                lr = VisiteurManager.ChargerRapportVisiteurPraticien(v.VIS_MATRICULE, p.PRA_NUM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (lr == null || lr.Count == 0)
            {
                btnVoirRap.Visible = false;
            } else
            {
                label10.Visible = false;
                lesRapports = lr;
            }
            leVisiteur = v;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoirRap_Click(object sender, EventArgs e)
        {
            FrmRapportUnPraticien f = new FrmRapportUnPraticien(lesRapports, leVisiteur);
            f.ShowDialog();
        }
    }
}
