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
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string pranum = this.cbPraticien.SelectedItem.ToString();
            MessageBox.Show(pranum.ToString(), "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
