using Model.Model;
using System;
using System.Collections.Generic;
using S7.Net;

namespace SiemTeleBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "123";



            //Для создания файла раскоментируйте две нижние строки, десирилизацию закоментируйте
            // серилизация
            //var test = new DescriptionDataItem("Temp1", "Temp Paster", CpuType.S71200, "192.168.3.101",9,40, 0, 0, DataType.DataBlock, VarType.Real);
            //var test2 = new List<DescriptionDataItem>();
            //test2.Add(test);


            //LoadSaveDataItemPLC.SaveDataItemPLC(path, test2);




            //десерилизация
            //
            //List<DataItemPLC> poolDataItemPLC = LoadSaveDataItemPLC.LoadDataItemPLC(path);



            Console.WriteLine("------");
            Console.ReadKey();
        }
    }
}
