using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module10_CaisseEnregistreuse
{
    // Sujet
    public class FactureModel : IObservable<FactureModelEvent>
    {
        private List<IObserver<FactureModelEvent>> m_observateurs;
        private List<LigneFactureModel> m_lignesFacture;

        public FactureModel() 
        { 
            this.m_observateurs = new List<IObserver<FactureModelEvent>>();
            this.m_lignesFacture = new List<LigneFactureModel>();
        }

        public List<LigneFactureModel> LigneFacture
        {
            get 
            { 
                return m_lignesFacture;
            }
            set 
            { 
                this.m_lignesFacture = value; 
                this.InformerObservateurs();
            }
        }

        private void InformerObservateurs()
        {
            foreach (var observateur in m_observateurs)
            {
                observateur.OnNext(this.m_lignesFacture);
            }
        }

        public IDisposable Subscribe(IObserver<FactureModelEvent> p_observateur)
        {
            if (this.m_observateurs is null)
            {
                throw new ArgumentNullException(nameof(this.m_observateurs));
            }
            this.m_observateurs.Add(p_observateur);
            return new UnsubscribeFactureModel(p_observateur, this.m_observateurs);
        }

        public void AjouterLigne(LigneFactureModel p_ligne)
        {
            m_lignesFacture.Add(p_ligne);
            InformerObservateurs();
        }

        public void SupprimerToutesLesLignes()
        {
            m_lignesFacture.Clear();
            InformerObservateurs();
        }

        
    }
}
