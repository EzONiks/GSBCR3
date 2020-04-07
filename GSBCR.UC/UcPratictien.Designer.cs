namespace GSBCR.UC
{
    partial class UcPratictien
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCoef = new System.Windows.Forms.TextBox();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coordonnées";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Coef Notoriété";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fonction";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(84, 11);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(122, 20);
            this.txtNom.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(3, 31);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.ReadOnly = true;
            this.txtAddr.Size = new System.Drawing.Size(227, 20);
            this.txtAddr.TabIndex = 10;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(3, 5);
            this.txtCP.Name = "txtCP";
            this.txtCP.ReadOnly = true;
            this.txtCP.Size = new System.Drawing.Size(75, 20);
            this.txtCP.TabIndex = 11;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(84, 5);
            this.txtVille.Name = "txtVille";
            this.txtVille.ReadOnly = true;
            this.txtVille.Size = new System.Drawing.Size(146, 20);
            this.txtVille.TabIndex = 12;
            // 
            // txtCoef
            // 
            this.txtCoef.Location = new System.Drawing.Point(84, 170);
            this.txtCoef.Name = "txtCoef";
            this.txtCoef.ReadOnly = true;
            this.txtCoef.Size = new System.Drawing.Size(122, 20);
            this.txtCoef.TabIndex = 13;
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(84, 55);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.ReadOnly = true;
            this.txtFonction.Size = new System.Drawing.Size(193, 20);
            this.txtFonction.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCP);
            this.panel1.Controls.Add(this.txtAddr);
            this.panel1.Controls.Add(this.txtVille);
            this.panel1.Location = new System.Drawing.Point(102, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 60);
            this.panel1.TabIndex = 15;
            // 
            // UcPratictien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFonction);
            this.Controls.Add(this.txtCoef);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UcPratictien";
            this.Size = new System.Drawing.Size(359, 204);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCoef;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.Panel panel1;
    }
}
