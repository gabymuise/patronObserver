using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver.Model
{
    public class EmailAlertsListener : IEventListeners
    {
        private readonly string email;
        private readonly string message;

        public EmailAlertsListener(string email, string message)
        {
            this.email = email;
            this.message = message;
        }

        public void Update(string fileName)
        {
            Console.WriteLine($"Email enviado a {email}: {message} sobre el archivo {fileName}");
        }
    }
}
