using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronObserver.Model
{
    public class EventManager
    {
        private readonly List<IEventListeners> listeners = new List<IEventListeners>();

        public void Subscribe(IEventListeners listener)
        {
            listeners.Add(listener);
        }

        public void Unsubscribe(IEventListeners listener)
        {
            listeners.Remove(listener);
        }

        public void Notify(string fileName)
        {
            foreach (var listener in listeners)
            {
                listener.Update(fileName);
            }
        }
    }
}
