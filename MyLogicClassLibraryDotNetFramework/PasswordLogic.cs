using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogicClassLibraryDotNetFramework
{
    public class PasswordLogic
    {
        
            public static bool pwconditions(string Input, int Minimum)
            {
                bool harTal = false;
                bool harStort = false;
                bool harLille = false;
                bool harSpec = false;
                char currentCharacter;

                if (!(input.Length >= minimum))
                {
                    return false;
                }

                for (int i = 0; i < input.Length; i++)
                {

                }

                for (int i = 0; i < input.Length; i++)
                {
                    currentCharacter = input[i];
                    if (char.IsDigit(currentCharacter))
                    {
                        harTal = true;
                    }
                    else if (char.IsUpper(currentCharacter))
                    {
                        harStort = true;
                    }
                    else if (char.IsLower(currentCharacter))
                    {
                        harLille = true;
                    }
                    else if (!char.IsLetterOrDigit(currentCharacter))
                    {
                        harSpec = true;
                    }

                    if (harTal && harStort && harLille && harSpec)
                    {
                        return true;
                    }
                }
            }
        
    }
}
