using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogicClassLibraryDotNetFramework
{
    public class PasswordLogic
    {
        
        public bool pwconditions(string Input, int Minimum)
        {
            bool harTal = false;
            bool harStort = false;
            bool harLille = false;
            bool harSpec = false;
            char CharacterCount;
            char firstCount;
            char lastCount;

            if (!(Input.Length >= Minimum))
            {
                return false;
            }


            firstCount = Input[Input.Length-Input.Length+1];
            if (char.IsDigit(firstCount))
            {
                return false;
            }
            
            lastCount = Input[Input.Length-1];
            if (char.IsDigit(lastCount))
            {
                return false;
            }

            for (int i = 0; i < Input.Length; i++)
            {

            }

            for (int i = 0; i < Input.Length; i++)
            {
                CharacterCount = Input[i];
                if (char.IsDigit(CharacterCount))
                {
                    harTal = true;
                }
                else if (char.IsUpper(CharacterCount))
                {
                    harStort = true;
                }
                else if (char.IsLower(CharacterCount))
                {
                    harLille = true;
                }
                else if (!char.IsLetterOrDigit(CharacterCount))
                {
                    harSpec = true;
                }

                if (harTal && harStort && harLille && harSpec)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
