using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module10_CaisseEnregistreuse
{
    public class FactureModelEvent
    {
        private TypeEvenementFactureModel m_type;
        private LigneFactureModel m_LigneFactureModel;
        private FactureModel m_factureModel;

        public TypeEvenementFactureModel Type
        {
            get { return m_type; } 
        }
        public LigneFactureModel LigneFactureModel
        {
            get { return m_LigneFactureModel; }
        }

        public FactureModel FactureModel
        {
            get { return m_factureModel; }
        }

        public FactureModelEvent(TypeEvenementFactureModel p_type, LigneFactureModel p_ligneFactureModel, FactureModel p_factureModel)
        {
            m_type = p_type;
            m_LigneFactureModel = p_ligneFactureModel;
            m_factureModel = p_factureModel;
        }

    }

    public enum TypeEvenementFactureModel
    {
        AJOUT_LIGNE,
        NOUVELLE
    }
}
