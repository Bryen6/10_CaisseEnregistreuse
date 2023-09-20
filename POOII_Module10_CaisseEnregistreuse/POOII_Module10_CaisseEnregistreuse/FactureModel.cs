using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module10_CaisseEnregistreuse
{
    // Sujet
    public class FactureModel : IObservable<FactureModelEvent>  //Le type d'éléments envoyé pour les notifications
    {
        private List<IObserver<FactureModelEvent>> m_observateurs;
        private List<LigneFactureModel> m_lignesFacture;

        public FactureModel() 
        { 
            this.m_observateurs = new List<IObserver<FactureModelEvent>>();
            this.m_lignesFacture = new List<LigneFactureModel>();  
        }
        public decimal TotalFacture
        {
            get
            {
                decimal totalFacture = 0;
                foreach(LigneFactureModel lignes in m_lignesFacture)
                {
                    totalFacture += lignes.PrixTotal;
                }
                return totalFacture;
            }
        }

        private void InformerObservateurs(FactureModelEvent p_action)
        {
            foreach (var observateur in m_observateurs)
            {
                observateur.OnNext(p_action);
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
            InformerObservateurs(new FactureModelEvent(TypeEvenementFactureModel.AJOUT_LIGNE, p_ligne, this));
        }

        public void SupprimerToutesLesLignes()
        {
            m_lignesFacture.Clear();
            InformerObservateurs(new FactureModelEvent (TypeEvenementFactureModel.NOUVELLE, null, this));
        }
 
    }
}
