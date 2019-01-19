using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class SalutationBuilder
    {

        public String build(String name)
        {
            String salutation = "Hello " + name;
            return salutation;
        } 

    }
}
