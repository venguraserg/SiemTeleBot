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

        public int Db { get; set; }
        public int StartByteAdr { get; set; }

        public DataType DataType { get; set; }
        public VarType VarTypePLC { get; set; }
        

        public DataItemPLC()
        {
        
        }

        public DataItemPLC(string name, string text, CpuType cpuType, string ipAdress, short rack, short slot, int db, int startByteAdress, DataType dataType, VarType varTypePLC)
        {
            Name = name;
            Text = text;
            Plc = new Plc(cpuType, ipAdress, rack, slot);

            Db = db;
            StartByteAdr = startByteAdress;

            DataType = dataType;
            VarTypePLC = varTypePLC;
        }

        public void ReadDataPoint_Real()
        {
            using (var plc = Plc)
            {
                plc.Open();
               // var result = (float)plc.Read(DataType, data.Db, data.Adr, VarType.Real, 1);

                plc.Close();

            }
            

            //return (double)result;

        }
        public override string ToString()
        {
            return $"{Name} {Text}";
        }

    }
}
