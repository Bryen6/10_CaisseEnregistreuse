using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_Module10_CaisseEnregistreuse
{
    public class ObservateurFactureModel : IObserver<FactureModelEvent>
    {
        private IDisposable m_seDesabonner;
        private Action<FactureModelEvent> m_action; 

        public ObservateurFactureModel(IObservable<FactureModelEvent> p_sujet, Action<FactureModelEvent> p_action)
        {
            if (p_sujet == null)
            {
                throw new ArgumentNullException(nameof(p_sujet));
            }
            if (p_action == null)
            {
                throw new ArgumentNullException (nameof(p_action));
            }

            this.m_action = p_action;
            this.m_seDesabonner = p_sujet.Subscribe(this);
        }

        public void SeDesabonner()
        {
            this.m_seDesabonner?.Dispose();
            this.m_seDesabonner = null;
        }

        public void OnCompleted()
        {
            this.SeDesabonner();
        }

        public void OnError(Exception p_error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(FactureModelEvent p_action)
        {
            this.m_action(p_action);
        }

        

    }
}
