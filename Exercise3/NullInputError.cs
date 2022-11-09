using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a null input in a field. This fired an error!";
        }
    }
}
