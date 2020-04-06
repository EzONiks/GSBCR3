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
    public partial class FrmRapportValide : Form
    {
        private VISITEUR leVisiteur;

        public FrmRapportValide(VISITEUR v, List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            leVisiteur = v;
            label3.Text = leVisiteur.VIS_NOM;
            label1.Text = leVisiteur.Vis_PRENOM;
            bsRapportValide.DataSource = lr;
            dvgRapportValide.DataSource = bsRapportValide;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgRapportValide_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RAPPORT_VISITE r = (RAPPORT_VISITE)bsRapportValide.Current;
            //Array pour contenir toutes les informations 
            List<String> infoRapport = new List<String>();
            // Nom + prénom du visiteur
            VISITEUR vis = VisiteurManager.getUnVisiteur(r.RAP_MATRICULE);
            infoRapport.Add(vis.VIS_NOM + " " + vis.Vis_PRENOM);
            // Rapport num
            infoRapport.Add(r.RAP_NUM.ToString());
            // Le Praticien
            PRATICIEN lePra = VisiteurManager.ChargerLePraticien(r.RAP_PRANUM);
            infoRapport.Add(lePra.PRA_NOM + " " + lePra.PRA_PRENOM);
            // Date 
            infoRapport.Add(r.RAP_DATE.ToString());
            // DATE VISITE
            infoRapport.Add(r.RAP_DATVISIT.ToString());
            // Bilan
            infoRapport.Add(r.RAP_BILAN);
            // Motif
            MOTIF_VISITE mv = VisiteurManager.chargerLeMotifVisite(r.RAP_MOTIF);
            infoRapport.Add(mv.MOT_LIBEL);
            // Motif autre
            infoRapport.Add(r.RAP_MOTIFAUTRE);
            // Nom Remplacent + prenom Remplacent
            infoRapport.Add(r.RAP_NOMREMPL + " " + r.RAP_PNOMREMPL);
            // Medicament 1 
            MEDICAMENT m1 = VisiteurManager.ChargerLeMedicament(r.RAP_MED1);
            infoRapport.Add(m1.MED_NOMCOMMERCIAL);
            // Medicament 2
            MEDICAMENT m2 = VisiteurManager.ChargerLeMedicament(r.RAP_MED2);
            infoRapport.Add(m2.MED_NOMCOMMERCIAL);
            // Constructeur formulaire passage du array
            FrmDetailRapport f = new FrmDetailRapport(infoRapport);
            f.ShowDialog();
        }
    }
}
