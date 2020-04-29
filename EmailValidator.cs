using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    class EmailValidator: IEmailValidatorService
    {
        
        public EmailValidator(){}
        public bool IsValidAddress(String candidate)
        {
            if(candidate.Contains('@'))
            { 
                if (candidate.EndsWith(".com"))
                {
                    return true;
                }
                else if (candidate.EndsWith(".hr"))
                    {
                        return true;
                    }
               
            }
            return false;
        }

        private bool ContainsDiffrentCharacterTypes(string candidate)
        {
            bool hasLower = false, hasUpper = false, hasNumber = false;
            foreach (char c in candidate)
            {
                if (char.IsDigit(c)) hasNumber = true;
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
            }
            return (hasLower && hasUpper && hasNumber);
        }

    }
}
