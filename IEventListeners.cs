using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public interface IEventListeners
    {
        void Update(string fileName);
    }
}
