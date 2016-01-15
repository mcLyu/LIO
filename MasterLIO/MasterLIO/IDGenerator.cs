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
        public static int CreateId()
        {
            String id = IdGen.GenerateDni();
            return Convert.ToInt32(id.Substring(0,id.Length-1));//MAGIC!!!
        }
    }
}
