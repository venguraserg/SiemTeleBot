using Model.Model.EntityForProgram;
using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class MyDataBase
    {
        public List<DataItemPLC> dataItemPLCs { get; set; }
        public List<MyPLC> Plc { get; set; }

        public MyDataBase()
        {
            dataItemPLCs = new List<DataItemPLC>();
            Plc = new List<MyPLC>();
        }

        public Plc GetPlcById(Guid id)
        {
            return this.Plc.Single(i => i.Id == id).Plc;
        }

        public Guid GetIdPlc(Plc plc)
        {
            
            return this.Plc.Single(i => i.Plc == plc).Id;
        }
    }
}
