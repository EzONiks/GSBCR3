﻿using System;
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
            dgvPraticien.DataSource = bsPraticien;
        }
    }
}
