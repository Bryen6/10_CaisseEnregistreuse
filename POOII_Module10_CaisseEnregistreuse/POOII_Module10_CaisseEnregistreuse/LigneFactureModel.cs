using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module10_CaisseEnregistreuse
{
    public class LigneFactureModel
    {
        private string m_description;
        private int m_quantite;
        private decimal m_prixUnitaire;
        private decimal m_prixTotal;

        public LigneFactureModel(string p_description, int p_quantite, decimal p_prixUnitaire)
        {
            this.m_description = p_description;
            this.m_quantite = p_quantite;
            this.m_prixUnitaire = p_prixUnitaire;
            this.m_prixTotal = m_prixUnitaire * m_quantite;
        }

        public string Description
        {
            get { return m_description; }
        }

        public int Quantite
        {
            get { return m_quantite; }
        }

        public decimal PrixUnitaire
        {
            get { return m_prixUnitaire; }
        }

        public decimal PrixTotal
        {
            get { return m_prixTotal; }
        }

    }
}
