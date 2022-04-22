using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogicClassLibraryDotNetFramework
{
    public class Football
    {
        public string HowMuchDoWeeCheer(int passes)
        {
            string result = string.Empty;

            if (passes < 1)
            {
                result = "Shh";
            }
            else if (passes >= 10)
            {
                result = "High Five - Jubel!!!";
            }
            else
            {
                for (int i = 0; i < passes; i++)
                {
                    result += "Huh! ";
                }

                result = "";
            }
            return result;
        }

        public string WeCelebrateIfGoal(string goal)
        {
            if (goal == "mål")
            {
                return "Olé Olé Olé";
            }

        }
    }
}
