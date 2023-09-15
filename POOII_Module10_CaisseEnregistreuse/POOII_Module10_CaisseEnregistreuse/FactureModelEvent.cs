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
        private FactureModel factureModel;

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
            get { return factureModel; }
        }

    }

    public enum TypeEvenementFactureModel
    {
        AJOUT_LIGNE,
        NOUVELLE
    }
}
