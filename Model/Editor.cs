using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronObserver.Model
{
    public class Editor
    {
        public EventManager Events { get; } = new EventManager();
        private string fileName;

        public void OpenFile(string path)
        {
            fileName = path;
            Console.WriteLine($"Archivo {fileName} abierto.");
            Events.Notify(fileName);
        }

        public void SaveFile()
        {
            Console.WriteLine($"Archivo {fileName} guardado.");
            Events.Notify(fileName);
        }

        public void CloseFile()
        {
            Console.WriteLine($"Archivo {fileName} cerrado.");
            Events.Notify(fileName);
        }
    }
}
