using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Factory_miniProject1
{
    class product
    {
        public string ID;
        public string NAME;
        public string VOL;

        public product(string id, string name, string vol)
        {
            this.ID = id;
            this.NAME = name;
            this.VOL = vol;
        }
    }
}