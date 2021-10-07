using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class MyPLC
    {
        public string Name { get; set; }
        public Plc Plc { get; set; }

        public MyPLC()
        {

        }

        public MyPLC(string name, Plc plc)
        {
            Name = name;
            Plc = plc;
        }
    }
}
