using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver.Model
{
    public class LoggingListener : IEventListeners
    {
        private readonly string log;
        private readonly string message;

        public LoggingListener(string log, string message)
        {
            this.log = log;
            this.message = message;
        }

        public void Update(string fileName)
        {
            Console.WriteLine($"{message}: {fileName} registrado en {log}");
        }
    }
}
