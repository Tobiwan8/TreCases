using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodbold
{
    internal class ReadWriteToFile
    {
        private const string path = @"C:\Skole\cases-i-csharp\treCases\fodbold\trecases\Password\datafil.txt";
        public string GetPasswordAndUsername()
        {
            string[] datafile = File.ReadAllLines(path, Encoding.Unicode))

            return datafile[0];
        }
    }
}
