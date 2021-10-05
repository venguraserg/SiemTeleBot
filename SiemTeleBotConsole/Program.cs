using System;

namespace SiemTeleBot
{
    class Program
    {
        static void Main(string[] args)
        {
            DescriptionList plcDataPool = new();
            //Для создания файла раскоментируйте две нижние строки, десирилизацию закоментируйте
            // серилизация
            //plcDataPool.AddPoint(new DataItemModel("temp1", "Температура", S7.Net.CpuType.S71200, "192.168.3.101", 0, 0, S7.Net.DataType.DataBlock, S7.Net.VarType.Real));
            //plcDataPool.JsonSerialize("123");


            //десерилизация
            plcDataPool.dataPoints = DescriptionList.JsonDeserialize("123");

            var ddd = InitDataItem.GetDataPLC(plcDataPool);



            Console.WriteLine("------");
            Console.ReadKey();
        }
    }
}
