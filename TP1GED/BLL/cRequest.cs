using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1GED.BLL
{
    class cRequest :cTable 
    {
        public DAL.Entities getEntities()
        {
            return context;
        }
    }
}
