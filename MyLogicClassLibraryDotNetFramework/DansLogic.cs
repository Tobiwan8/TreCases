using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogicClassLibraryDotNetFramework
{
    public class DanceLogic
    {
        public string Navn = "";
        public int Point = 0;
        public DanceLogic(string navn, int point)
        {
            Navn = navn;
            Point = point;
        }

        public static DanceLogic operator +(DanceLogic danser1, DanceLogic danser2)
        {
            DanceLogic result = new DanceLogic(, danser1.Point + danser2.Point);

            return result;
        }
            
    }
}
