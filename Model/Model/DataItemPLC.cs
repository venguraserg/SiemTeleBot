using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class DataItemPLC 
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public Plc Plc { get; set; }
        private CpuType Cpu { get; set; }
        private string IPAdress { get; set; }
        private short Rack { get; set; }
        private short Slot { get; set; }
        public DataType DataType { get; set; }
        public VarType VarTypePLC { get; set; }
        

        public DataItemPLC()
        {
        
        }

        public DataItemPLC(string name, string text, CpuType cpuType, string ipAdress, short rack, short slot, DataType dataType, VarType varTypePLC)
        {
            Name = name;
            Text = text;
            Plc = new Plc(cpuType, ipAdress, rack, slot);
                       
            DataType = dataType;
            VarTypePLC = varTypePLC;
        }

        public void ReadDataPoint_Real()
        {
            using (var plc = new Plc(this.Cpu, this.IPAdress, this.Rack, this.Slot))
            {
                plc.Open();
               // var result = (float)plc.Read(DataType, data.Db, data.Adr, VarType.Real, 1);
                plc.Close();

            }
            

            //return (double)result;

        }
    
    }
}
