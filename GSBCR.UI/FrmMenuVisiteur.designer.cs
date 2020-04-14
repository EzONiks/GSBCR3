namespace GSBCR.UI
{
    partial class FrmMenuVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuVisiteur));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mesRapportsEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesRapportsValidésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesMedicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesPraticiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesDonnéesPersonnellesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierConsulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMonMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maRégionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsNonConsultésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauVisiteurDéléguéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion rapports de visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(429, 209);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(229, 33);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesRapportsEnCoursToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.mesDonnéesPersonnellesToolStripMenuItem,
            this.maRégionToolStripMenuItem,
            this.monSecteurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mesRapportsEnCoursToolStripMenuItem
            // 
            this.mesRapportsEnCoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.mesRapportsEnCoursToolStripMenuItem.Name = "mesRapportsEnCoursToolStripMenuItem";
            this.mesRapportsEnCoursToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.mesRapportsEnCoursToolStripMenuItem.Text = "Mes rapports en cours";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modifierToolStripMenuItem.Text = "Modifier / Consulter";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesRapportsValidésToolStripMenuItem,
            this.lesMedicamentsToolStripMenuItem,
            this.lesPraticiensToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // mesRapportsValidésToolStripMenuItem
            // 
            this.mesRapportsValidésToolStripMenuItem.Name = "mesRapportsValidésToolStripMenuItem";
            this.mesRapportsValidésToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mesRapportsValidésToolStripMenuItem.Text = "Mes rapports validés";
            this.mesRapportsValidésToolStripMenuItem.Click += new System.EventHandler(this.mesRapportsValidésToolStripMenuItem_Click);
            // 
            // lesMedicamentsToolStripMenuItem
            // 
            this.lesMedicamentsToolStripMenuItem.Name = "lesMedicamentsToolStripMenuItem";
            this.lesMedicamentsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.lesMedicamentsToolStripMenuItem.Text = "Les medicaments";
            // 
            // lesPraticiensToolStripMenuItem
            // 
            this.lesPraticiensToolStripMenuItem.Name = "lesPraticiensToolStripMenuItem";
            this.lesPraticiensToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.lesPraticiensToolStripMenuItem.Text = "Les praticiens";
            this.lesPraticiensToolStripMenuItem.Click += new System.EventHandler(this.lesPraticiensToolStripMenuItem_Click);
            // 
            // mesDonnéesPersonnellesToolStripMenuItem
            // 
            this.mesDonnéesPersonnellesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierConsulterToolStripMenuItem,
            this.changerMonMotDePasseToolStripMenuItem});
            this.mesDonnéesPersonnellesToolStripMenuItem.Name = "mesDonnéesPersonnellesToolStripMenuItem";
            this.mesDonnéesPersonnellesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mesDonnéesPersonnellesToolStripMenuItem.Text = "Mes données personnelles";
            // 
            // modifierConsulterToolStripMenuItem
            // 
            this.modifierConsulterToolStripMenuItem.Name = "modifierConsulterToolStripMenuItem";
            this.modifierConsulterToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.modifierConsulterToolStripMenuItem.Text = "Modifier / Consulter";
            this.modifierConsulterToolStripMenuItem.Click += new System.EventHandler(this.modifierConsulterToolStripMenuItem_Click);
            // 
            // changerMonMotDePasseToolStripMenuItem
            // 
            this.changerMonMotDePasseToolStripMenuItem.Name = "changerMonMotDePasseToolStripMenuItem";
            this.changerMonMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.changerMonMotDePasseToolStripMenuItem.Text = "Changer mon mot de passe";
            this.changerMonMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerMonMotDePasseToolStripMenuItem_Click);
            // 
            // maRégionToolStripMenuItem
            // 
            this.maRégionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportsNonConsultésToolStripMenuItem,
            this.listeDesVisiteursToolStripMenuItem});
            this.maRégionToolStripMenuItem.Enabled = false;
            this.maRégionToolStripMenuItem.Name = "maRégionToolStripMenuItem";
            this.maRégionToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.maRégionToolStripMenuItem.Text = "Ma région";
            // 
            // rapportsNonConsultésToolStripMenuItem
            // 
            this.rapportsNonConsultésToolStripMenuItem.Name = "rapportsNonConsultésToolStripMenuItem";
            this.rapportsNonConsultésToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.rapportsNonConsultésToolStripMenuItem.Text = "Rapports non consultés";
            // 
            // listeDesVisiteursToolStripMenuItem
            // 
            this.listeDesVisiteursToolStripMenuItem.Name = "listeDesVisiteursToolStripMenuItem";
            this.listeDesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listeDesVisiteursToolStripMenuItem.Text = "Liste des visiteurs";
            // 
            // monSecteurToolStripMenuItem
            // 
            this.monSecteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionÉquipeToolStripMenuItem,
            this.statistiquesSecteurToolStripMenuItem,
            this.nouveauVisiteurDéléguéToolStripMenuItem});
            this.monSecteurToolStripMenuItem.Enabled = false;
            this.monSecteurToolStripMenuItem.Name = "monSecteurToolStripMenuItem";
            this.monSecteurToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.monSecteurToolStripMenuItem.Text = "Mon secteur";
            // 
            // gestionÉquipeToolStripMenuItem
            // 
            this.gestionÉquipeToolStripMenuItem.Name = "gestionÉquipeToolStripMenuItem";
            this.gestionÉquipeToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.gestionÉquipeToolStripMenuItem.Text = "Gestion équipe";
            // 
            // statistiquesSecteurToolStripMenuItem
            // 
            this.statistiquesSecteurToolStripMenuItem.Name = "statistiquesSecteurToolStripMenuItem";
            this.statistiquesSecteurToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.statistiquesSecteurToolStripMenuItem.Text = "Statistiques secteur";
            // 
            // nouveauVisiteurDéléguéToolStripMenuItem
            // 
            this.nouveauVisiteurDéléguéToolStripMenuItem.Name = "nouveauVisiteurDéléguéToolStripMenuItem";
            this.nouveauVisiteurDéléguéToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.nouveauVisiteurDéléguéToolStripMenuItem.Text = "Nouveau visiteur / délégué";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // FrmMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(809, 374);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuVisiteur";
            this.Text = "GSBCR";
            this.Load += new System.EventHandler(this.FrmMenuVisiteur_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mesRapportsEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesRapportsValidésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesMedicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesPraticiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesDonnéesPersonnellesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierConsulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerMonMotDePasseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem maRégionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsNonConsultésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauVisiteurDéléguéToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}