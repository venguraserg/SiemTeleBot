using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace Model.Model.EntityFromFile
{
    public class DescriptionDataItem
    {
        public string Text { get; set; }
        public Guid IdPlc { get; set; }
        public int Db { get; set; }
        public int StartByteAdr { get; set; }
        public DataType DataType { get; set; }
        public VarType VarTypePLC { get; set; }

        public DescriptionDataItem()
        {

        }

        public DescriptionDataItem(string text, Guid id, int db, int startByteAdr, DataType dataType, VarType varType)
        {
            Text = text;
            IdPlc = id;
            Db = db;
            StartByteAdr = startByteAdr;
            DataType = dataType;
            VarTypePLC = varType;
        }

        
    }
}
