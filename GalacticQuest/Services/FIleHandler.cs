using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Services
{
    internal class FileHandler
    {
        private static FileHandler _instance;

        private static readonly object _lock = new object();

        private FileHandler() { }
        public static FileHandler Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new FileHandler();
                    }
                }
                return _instance;
            }
        }
        public void Write()
        {
            Console.WriteLine("Write");
        }
        public void Read()
        {
            Console.WriteLine("Read");
        }
    }
}
