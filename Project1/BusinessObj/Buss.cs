using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataObject;

namespace BusinessObj
{
    public class Buss
    {
        public void save(Enty e)
        {
            Data d = new Data();
            d.add(e);

        }
    }
}
