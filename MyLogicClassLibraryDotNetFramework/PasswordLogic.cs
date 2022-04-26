using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogicClassLibraryDotNetFramework
{
    public class PasswordLogic
    {
        private string pwconditions;

        public PasswordLogic(string pwconditions)
        {
            Pwconditions = pwconditions;
        }

        public string Pwconditions
        {
            get { return pwconditions; }
            set 
            {
                if(value )
                pwconditions = value; 
            }   
        }


    }
}
