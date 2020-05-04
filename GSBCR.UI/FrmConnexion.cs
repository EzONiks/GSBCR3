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
using GSBCR.UC;

namespace GSBCR.UI
{
    public partial class FrmConnexion : Form
    {
        private VISITEUR leVisiteur;
        private const bool V = true;
      

        public FrmConnexion()
        {
            InitializeComponent();
        }

        //Bouton pour quitter le formulaire
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Bouton de connexion 
        private void button1_Click(object sender, EventArgs e)
        {

            string matricule;
            string mdp;

            matricule = tbxID.Text.ToString();
            mdp = tbxMDP.Text.ToString();
            //Visiteur
            if (matricule != "" && mdp != "")
            {
                leVisiteur = VisiteurManager.ChargerVisiteur(matricule, mdp);
                if (leVisiteur == null)
                {
                    lblError.Visible = V ;
                    lblError.Text = "Connexion échoué";
                }
                else
                {
                    lblError.Visible = V;
                    lblError.Text = "Connexion réussie";
                    FrmMenuVisiteur v = new FrmMenuVisiteur(matricule, mdp);
                    v.ShowDialog();
                }
            }
            else
            {
                lblError.Visible = V;
                lblError.Text = "Veuillez remplir les champs vides";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
