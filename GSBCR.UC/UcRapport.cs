using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UC
{
    public partial class UcRapport : UserControl
    {
        private RAPPORT_VISITE leRapportVisite;
        public UcRapport()
        {
            InitializeComponent();

            foreach (Control x in this.Controls)
            {
                if ( x is TextBox)
                {
                    ((TextBox)x).Enabled = false;
                }
            }
        }

        public RAPPORT_VISITE rRapport
        {
            get { return leRapportVisite; }
            set
            {
                leRapportVisite = value;
                if (leRapportVisite != null)
                {
                    ucRapportVisite_actualiser();
                }
            }


        }

        private void ucRapportVisite_actualiser()
        {
            
            txtMatricule.Text = 
            txtNum.Text = leRapportVisite.RAP_NUM.ToString();
            txtPRANUM.Text = leRapportVisite.LePraticien.PRA_NOM + " " + leRapportVisite.LePraticien.PRA_PRENOM;
            txtDate.Text = leRapportVisite.RAP_DATE.ToString();
            txtDATEVISITE.Text = leRapportVisite.RAP_DATVISIT.ToString();
            txtBilan.Text = leRapportVisite.RAP_BILAN;
            txtMotif.Text = leRapportVisite.LeMotifVisite.MOT_LIBEL;
            txtMotifAutre.Text = leRapportVisite.RAP_MOTIFAUTRE;
            txtNomRempl.Text = leRapportVisite.RAP_NOMREMPL;
            txtPNOMrempl.Text = leRapportVisite.RAP_PNOMREMPL;
            txtMed1.Text = leRapportVisite.leMedicament1.MED_NOMCOMMERCIAL;
            txtMed2.Text = leRapportVisite.LeMedicament2.MED_NOMCOMMERCIAL;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
