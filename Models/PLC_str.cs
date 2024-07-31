using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PLC_str
    {
        public Guid IdPlc { get; set; }
        public string? Name { get; set; }
        public int TypeCPU { get; set; }
        public string? IP_Adress { get; set; }
        public int Rack {  get; set; }
        public int Slot {  get; set; }    
        public ObservableCollection<PLC_DataPoint> DataArr { get; set; } = new ObservableCollection<PLC_DataPoint>();


        public PLC_str()
        {
            
        }
        public PLC_str(string name, int typeCpu, string ipAdress)
        {
            this.IdPlc = Guid.NewGuid();
            this.Name = name;
            this.TypeCPU = typeCpu;
            this.IP_Adress = ipAdress;
            this.Rack = 0;
            this.Slot = 0;
            this.DataArr = new ObservableCollection<PLC_DataPoint>();
        }

        public void AddDataPoint(PLC_DataPoint dataPoint)
        {
            this.DataArr.Add(dataPoint);
        }
        public override string ToString()
        {
            return this.IP_Adress.ToString();
        }

    }
}
