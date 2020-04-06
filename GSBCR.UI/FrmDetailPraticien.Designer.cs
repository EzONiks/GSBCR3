namespace GSBCR.UI
{
    partial class FrmDetailPraticien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailPraticien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoirRap = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxCoefPra = new System.Windows.Forms.TextBox();
            this.tbxTypePra = new System.Windows.Forms.TextBox();
            this.tbxLieuxPra = new System.Windows.Forms.TextBox();
            this.tbxVillePra = new System.Windows.Forms.TextBox();
            this.tbxCpPra = new System.Windows.Forms.TextBox();
            this.tbxAdressePra = new System.Windows.Forms.TextBox();
            this.tbxPrenomPra = new System.Windows.Forms.TextBox();
            this.tbxNomPra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Détail du praticien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code Postale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ville";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Coefficient de notoriété";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Type";
            // 
            // btnVoirRap
            // 
            this.btnVoirRap.Location = new System.Drawing.Point(285, 384);
            this.btnVoirRap.Name = "btnVoirRap";
            this.btnVoirRap.Size = new System.Drawing.Size(149, 28);
            this.btnVoirRap.TabIndex = 8;
            this.btnVoirRap.Text = "Voire les rapports";
            this.btnVoirRap.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(285, 418);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(149, 28);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Lieu de travail";
            // 
            // tbxCoefPra
            // 
            this.tbxCoefPra.Location = new System.Drawing.Point(220, 254);
            this.tbxCoefPra.Name = "tbxCoefPra";
            this.tbxCoefPra.ReadOnly = true;
            this.tbxCoefPra.Size = new System.Drawing.Size(168, 26);
            this.tbxCoefPra.TabIndex = 11;
            // 
            // tbxTypePra
            // 
            this.tbxTypePra.Location = new System.Drawing.Point(220, 289);
            this.tbxTypePra.Name = "tbxTypePra";
            this.tbxTypePra.ReadOnly = true;
            this.tbxTypePra.Size = new System.Drawing.Size(168, 26);
            this.tbxTypePra.TabIndex = 12;
            // 
            // tbxLieuxPra
            // 
            this.tbxLieuxPra.Location = new System.Drawing.Point(220, 322);
            this.tbxLieuxPra.Name = "tbxLieuxPra";
            this.tbxLieuxPra.ReadOnly = true;
            this.tbxLieuxPra.Size = new System.Drawing.Size(168, 26);
            this.tbxLieuxPra.TabIndex = 13;
            // 
            // tbxVillePra
            // 
            this.tbxVillePra.Location = new System.Drawing.Point(220, 219);
            this.tbxVillePra.Name = "tbxVillePra";
            this.tbxVillePra.ReadOnly = true;
            this.tbxVillePra.Size = new System.Drawing.Size(168, 26);
            this.tbxVillePra.TabIndex = 14;
            // 
            // tbxCpPra
            // 
            this.tbxCpPra.Location = new System.Drawing.Point(220, 184);
            this.tbxCpPra.Name = "tbxCpPra";
            this.tbxCpPra.ReadOnly = true;
            this.tbxCpPra.Size = new System.Drawing.Size(168, 26);
            this.tbxCpPra.TabIndex = 15;
            // 
            // tbxAdressePra
            // 
            this.tbxAdressePra.Location = new System.Drawing.Point(220, 148);
            this.tbxAdressePra.Name = "tbxAdressePra";
            this.tbxAdressePra.ReadOnly = true;
            this.tbxAdressePra.Size = new System.Drawing.Size(168, 26);
            this.tbxAdressePra.TabIndex = 16;
            // 
            // tbxPrenomPra
            // 
            this.tbxPrenomPra.Location = new System.Drawing.Point(220, 113);
            this.tbxPrenomPra.Name = "tbxPrenomPra";
            this.tbxPrenomPra.ReadOnly = true;
            this.tbxPrenomPra.Size = new System.Drawing.Size(168, 26);
            this.tbxPrenomPra.TabIndex = 17;
            // 
            // tbxNomPra
            // 
            this.tbxNomPra.Location = new System.Drawing.Point(220, 75);
            this.tbxNomPra.Name = "tbxNomPra";
            this.tbxNomPra.ReadOnly = true;
            this.tbxNomPra.Size = new System.Drawing.Size(168, 26);
            this.tbxNomPra.TabIndex = 18;
            // 
            // FrmDetailPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 461);
            this.Controls.Add(this.tbxNomPra);
            this.Controls.Add(this.tbxPrenomPra);
            this.Controls.Add(this.tbxAdressePra);
            this.Controls.Add(this.tbxCpPra);
            this.Controls.Add(this.tbxVillePra);
            this.Controls.Add(this.tbxLieuxPra);
            this.Controls.Add(this.tbxTypePra);
            this.Controls.Add(this.tbxCoefPra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnVoirRap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetailPraticien";
            this.Text = "GSBCR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoirRap;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxCoefPra;
        private System.Windows.Forms.TextBox tbxTypePra;
        private System.Windows.Forms.TextBox tbxLieuxPra;
        private System.Windows.Forms.TextBox tbxVillePra;
        private System.Windows.Forms.TextBox tbxCpPra;
        private System.Windows.Forms.TextBox tbxAdressePra;
        private System.Windows.Forms.TextBox tbxPrenomPra;
        private System.Windows.Forms.TextBox tbxNomPra;
    }
}