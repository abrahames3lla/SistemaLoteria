using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ValidarCampos
    {
        public static bool NotEmpty(string entry)
        {
            bool output = true;
            if (string.IsNullOrEmpty(entry))
            {
                output = false;
            }
            return output;
        }

        public static bool OnlyLetter(string entry)
        {
            bool output = true;
            if (!entry.All(char.IsLetter))
            {
                output = false;
            }
            return output;
        }

        public static bool OnlyNumber(string entry)
        {
            bool output = true;
            if (!entry.All(char.IsDigit))
            {
                output = false;
            }
            return output;
        }
    }
}
