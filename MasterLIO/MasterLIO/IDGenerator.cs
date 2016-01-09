using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idgen.Net;

namespace MasterLIO
{
    class IDGenerator
    {
        public static long CreateId()
        {
            return Convert.ToInt64(Idgen.Net.IdGen.GenerateDni());
        }
    }
}
