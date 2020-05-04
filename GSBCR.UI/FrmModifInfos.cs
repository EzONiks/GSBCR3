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
    public partial class FrmModifInfos : Form
    {
        private VISITEUR leVisiteur;
        public FrmModifInfos(VISITEUR v)
        {
            InitializeComponent();
            leVisiteur = v;
            txtboxVis.Text = leVisiteur.VIS_NOM + " " + leVisiteur.Vis_PRENOM;
            txtBoxAdresse.Text = leVisiteur.VIS_ADRESSE;
            txtBoxCp.Text = leVisiteur.VIS_CP;
            txtBoxVille.Text = leVisiteur.VIS_VILLE;
        }

        private void txtBoxAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            var addr = txtBoxAdresse.Text;
            var ville = txtBoxVille.Text;
            var cp = txtBoxCp.Text;

            if ( ville.Any(char.IsDigit) )
            {
                MessageBox.Show("La ville ne peut pas contenir un chiffre dans son nom");
            } else if ( cp.Any(char.IsLetter) )
            {
                MessageBox.Show("Le code postal ne peut pas contenir des lettres");
            } else if ( cp.Length < 5 || cp.Length > 5)
            {
                MessageBox.Show("Le code postal doit faire seulement 5 caractères");
            } else
            {
                bool ok = VisiteurManager.updateInfosVisiteur(leVisiteur.VIS_MATRICULE, addr, ville, cp);
                if ( ok )
                {
                    MessageBox.Show("Mise à jour efffectué");
                    this.Close();
                }
            }
        }
    }
}
