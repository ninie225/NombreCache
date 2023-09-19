using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NombreCache
{
    public partial class frmNombreCache : Form
    {
        private int phase;
        private int valeurAChercher;
        private int nbEssai;
        public frmNombreCache()
        {
            InitializeComponent();
        }
        private void efface()
        {
            txtValeur.Text = "";
            txtValeur.Focus();
        }
        private void initialiser()
        {
            if (phase==1)
            {
                grpValeur.Text = "Valeur (entre 1 et 100)";
                grpReponse.Visible = false;
            }
            else
            {
                grpValeur.Text = "Essai (entre 1 et 100)";
                nbEssai = 0;
                grpReponse.Visible = true;
                grpReponse.Text = "";
            }
            lblMessage.Text = "";
            efface();
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            phase = 1;
            initialiser();
        }

        private void frmNombreCache_Load(object sender, EventArgs e)
        {
            btnRejouer_Click(null, null);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int valeur = 0;
            try
            {
                valeur = int.Parse(txtValeur.Text);
                if (valeur>100 || valeur<0)
                {
                    efface();
                }
                else
                {
                    if (phase == 1)
                    {
                        valeurAChercher = valeur;
                        phase = 2;
                        initialiser();
                    }
                    else
                    {
                        nbEssai++;
                        grpReponse.Text = "Essai n°" + nbEssai;

                        if (valeurAChercher == valeur)
                        {
                            lblMessage.Text = "Bravo !!! C'était bien " + valeurAChercher;
                            efface();
                            btnRejouer.Focus();
                        }
                        else
                        {
                            if (valeurAChercher > valeur)
                            {
                                lblMessage.Text = valeur + " est trop petit";
                            }
                            else
                            {
                                lblMessage.Text = valeur + " est trop grand";
                            }
                            efface();
                        }
                    }
                }

            }
            catch
            {
                efface();
            }
        }

        private void txtValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnValider_Click(null, null);
            }
        }
    }
}
