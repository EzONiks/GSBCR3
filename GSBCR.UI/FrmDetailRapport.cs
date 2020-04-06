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
        private List<String> lesInfosRapport;
        public FrmDetailRapport(List<String> lesInfos)
        {
            InitializeComponent();
            this.lesInfosRapport = new List<string>();
            this.lesInfosRapport = lesInfos;
        }

        private void FrmDetailRapport_Load(object sender, EventArgs e)
        {
            txtMatricule.Text = this.lesInfosRapport.ElementAt(0);
            txtNum.Text = this.lesInfosRapport.ElementAt(1);
            txtPRANUM.Text = this.lesInfosRapport.ElementAt(2);
            txtDate.Text = this.lesInfosRapport.ElementAt(3);
            txtDATEVISITE.Text = this.lesInfosRapport.ElementAt(4);
            txtBilan.Text = this.lesInfosRapport.ElementAt(5);
            txtMotif.Text = this.lesInfosRapport.ElementAt(6);
            txtMotifAutre.Text = this.lesInfosRapport.ElementAt(7);
            txtRempl.Text = this.lesInfosRapport.ElementAt(8);
            txtMed1.Text = this.lesInfosRapport.ElementAt(9);
            txtMed2.Text = this.lesInfosRapport.ElementAt(10);
        }
    }
}
