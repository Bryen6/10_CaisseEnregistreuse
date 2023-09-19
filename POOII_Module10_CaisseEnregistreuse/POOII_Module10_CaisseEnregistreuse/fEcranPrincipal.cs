using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOII_Module10_CaisseEnregistreuse
{
    public partial class fEcranPrincipal : Form
    {
        public fEcranClient m_fEcranClient;
        private FactureModel m_factureModel;
        private ObservateurFactureModel m_observateurEcranPrincipal;

        public fEcranPrincipal()
        {
            InitializeComponent();
            this.m_fEcranClient = new fEcranClient();
            this.m_fEcranClient.Show();
            m_factureModel = new FactureModel();
            m_observateurEcranPrincipal = new ObservateurFactureModel(
                m_factureModel,
                value =>
                {
                    if (value.Type == TypeEvenementFactureModel.AJOUT_LIGNE)
                    {
                        dgvArticles.Rows.Add(
                            value.LigneFactureModel.Description,
                            value.LigneFactureModel.Quantite,
                            value.LigneFactureModel.PrixUnitaire,
                            value.LigneFactureModel.PrixTotal
                        );
                    }
                    else if (value.Type == TypeEvenementFactureModel.NOUVELLE)
                    {
                        dgvArticles.Rows.Clear();
                        tbTotal.Text = "0";
                    }
                    tbTotal.Text = value.FactureModel.TotalFacture.ToString("C2");
                }
            );
        }

        private void fEcranPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btSimuler_Click(object sender, EventArgs e)
        {
            string description = this.tbDescription.Text;
            int quantite = (int)this.nudQuantite.Value; ;
            decimal prix = this.nudPrix.Value; ;

            LigneFactureModel nouvelleLigne = new LigneFactureModel(description, quantite, prix);

            this.m_factureModel.AjouterLigne(nouvelleLigne);

            tbDescription.Clear();
            nudQuantite.TextAlign = 0;
            nudPrix.TextAlign = 0;
        }
    }
}
