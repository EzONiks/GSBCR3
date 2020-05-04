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
    public partial class FrmModifPwd : Form
    {
        private VISITEUR leVis;
        public FrmModifPwd(VISITEUR v)
        {
            InitializeComponent();
            this.leVis = v;
            txtOldPwd.UseSystemPasswordChar = true;
            txtOldPwd.PasswordChar = '\u25CF';
            txtNewPwd.UseSystemPasswordChar = true;
            txtNewPwd.PasswordChar = '\u25CF';
            txtConfPwd.UseSystemPasswordChar = true;
            txtConfPwd.PasswordChar = '\u25CF';

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            var oldMdp = txtOldPwd.Text;
            var confMdp = txtConfPwd.Text;
            var newMdp = txtNewPwd.Text;
            // Supprime les espaces vide
            oldMdp.Trim();
            // Verif le mdp actuel
            if ( confMdp == "" || newMdp == "" || oldMdp == "" )
            {
                MessageBox.Show("Veuillez saisir les informations");

            } else
            {
                if (this.leVis.vis_mdp != oldMdp)
                {
                    MessageBox.Show("Le mot de passe actuel n'est pas bon");
                }
                else if ( newMdp != confMdp )
                {
                    MessageBox.Show("Les 2 nouveaux mots de passe ne sont pas identique");
                }
                else if (newMdp == oldMdp)
                {
                    MessageBox.Show("Le nouveau mot de passe est identique à l'ancien");
                } 
                else if (newMdp.Length < 8 )
                {
                    MessageBox.Show("Le mot de passe est trop petit il doit être supérieur à 8 caractères");
                } 
                else if ( !newMdp.Any(char.IsUpper) || !newMdp.Any(char.IsLower) || !newMdp.Any(char.IsDigit) ) 
                {
                    MessageBox.Show("Le mot de passe n'est pas assez fort");
                }
                else
                {
                    VisiteurManager.updateMdpVisiteur(leVis.VIS_MATRICULE, newMdp);
                    MessageBox.Show("Mise à jour efffectué");
                    this.Close();
                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
