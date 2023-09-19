
namespace NombreCache
{
    partial class frmNombreCache
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNombreCache));
            this.grpValeur = new System.Windows.Forms.GroupBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpReponse = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpValeur.SuspendLayout();
            this.grpReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpValeur
            // 
            this.grpValeur.Controls.Add(this.btnValider);
            this.grpValeur.Controls.Add(this.txtValeur);
            this.grpValeur.Location = new System.Drawing.Point(12, 12);
            this.grpValeur.Name = "grpValeur";
            this.grpValeur.Size = new System.Drawing.Size(201, 62);
            this.grpValeur.TabIndex = 0;
            this.grpValeur.TabStop = false;
            this.grpValeur.Text = "Essai (entre 1 et 100)";
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(6, 22);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(138, 22);
            this.txtValeur.TabIndex = 0;
            this.txtValeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(150, 22);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(36, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "OK";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = ((System.Drawing.Image)(resources.GetObject("btnRejouer.Image")));
            this.btnRejouer.Location = new System.Drawing.Point(229, 12);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(58, 62);
            this.btnRejouer.TabIndex = 1;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitter.BackgroundImage")));
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Location = new System.Drawing.Point(229, 80);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(58, 59);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // grpReponse
            // 
            this.grpReponse.Controls.Add(this.lblMessage);
            this.grpReponse.Location = new System.Drawing.Point(12, 80);
            this.grpReponse.Name = "grpReponse";
            this.grpReponse.Size = new System.Drawing.Size(201, 62);
            this.grpReponse.TabIndex = 3;
            this.grpReponse.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 27);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 0;
            // 
            // frmNombreCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 280);
            this.Controls.Add(this.grpReponse);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.grpValeur);
            this.Controls.Add(this.btnRejouer);
            this.Name = "frmNombreCache";
            this.Text = "nombre caché";
            this.Load += new System.EventHandler(this.frmNombreCache_Load);
            this.grpValeur.ResumeLayout(false);
            this.grpValeur.PerformLayout();
            this.grpReponse.ResumeLayout(false);
            this.grpReponse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpValeur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox grpReponse;
        private System.Windows.Forms.Label lblMessage;
    }
}

