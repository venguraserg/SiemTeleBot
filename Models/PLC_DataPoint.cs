using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PLC_DataPoint
    {
        public Guid IdDP {  get; set; }
        public string Name { get; set; } = string.Empty;
        public int Db { get; set; }
        public int Adr { get; set; }
        //public int DataType {  get; set; }
        public string TextTag { get; set; } = string.Empty;
        public PLC_DataPoint() { }
        public PLC_DataPoint(string name, int db, int adr, /*int datatype,*/ string text)
        {
            this.IdDP = Guid.NewGuid();
            this.Name = name;
            this.Db = db;
            this.Adr = adr;
            //this.DataType = datatype;
            this.TextTag = text;
        }
    }
}
