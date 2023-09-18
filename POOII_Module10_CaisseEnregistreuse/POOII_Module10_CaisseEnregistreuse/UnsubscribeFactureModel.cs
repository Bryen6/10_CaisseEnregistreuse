using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module10_CaisseEnregistreuse
{
    public class UnsubscribeFactureModel : IDisposable
    {
        private IObserver<FactureModelEvent> m_observateur;
        private List<IObserver<FactureModelEvent>> m_observateurs;

        public UnsubscribeFactureModel(IObserver<FactureModelEvent> p_observateur, List<IObserver<FactureModelEvent>> m_observateurs) 
        {
            this.m_observateur = p_observateur;
            this.m_observateurs = m_observateurs;
        }

        public void Dispose()
        {
            this.m_observateurs.Remove(this.m_observateur);
        }
    }
}
