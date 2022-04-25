using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogicClassLibraryDotNetFramework
{
    public class DansLogic
    {
        public int Pointsadded(int point1, int point2)
        {
            int result = 0;

            result = point1 + point2;

            return result;
        }

        public string NamesTogether(string navn1, string navn2)
        {
            string result = "";

            result = navn1 + " & " + navn2 + " ";

            return result;
        }
            
    }
}
