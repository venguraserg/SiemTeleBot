using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model.EntityForProgram
{
    public class MyPLC
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Plc Plc { get; set; }

        public MyPLC()
        {

        }

        public MyPLC(string name, Guid id, Plc plc)
        {
            Id = id;
            Name = name;
            Plc = plc;
        }
    }
}
