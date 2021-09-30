using Model.Model;
using System;

namespace SiemTeleBot
{
    class Program
    {
        static void Main(string[] args)
        {
            PollingPointSet plcDataPool = new PollingPointSet();

            plcDataPool.dataPoints = PollingPointSet.JsonDeserialize("123");



            //plcDataPool.AddPoint(new DataPointPLC("temp1", "Температура", S7.Net.CpuType.S71200, "192.168.3.101", 0, 0, S7.Net.DataType.DataBlock, S7.Net.VarType.Real));
            //plcDataPool.JsonSerialize("123");
            Console.WriteLine("------");
            Console.ReadKey();
        }
    }
}
