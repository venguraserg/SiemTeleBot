using Model.Model;
using System;
using System.Collections.Generic;
using S7.Net;
using System.Text;

namespace SiemTeleBot
{
    class Program
    {
        static void Main(string[] args)
        {
            //путь к базе данных по умолчанию, не знаю почему, будем работать с json
            string path = "123";
            List<DescriptionDataItem> descriptions = new List<DescriptionDataItem>();
            for (int i = 0; i < 10; i++)
            {
                DescriptionDataItem item1 = new DescriptionDataItem($"Temp{i}", CpuType.S71200, $"192.168.3.10{i}", 9, 40+i, 0, 0, DataType.DataBlock, VarType.Real);
                descriptions.Add(item1);
            }
           
            LoadSaveDataItemPLC.SaveDataItemPLC(path, descriptions);

            //Настройка кодировки
            Console.OutputEncoding = Encoding.UTF8;
            List<DataItemPLC> dataItemPLCs = LoadSaveDataItemPLC.LoadDataItemPLC(path);
           // List<MyPLC> plcList = 
            



            while(ConsoleIO.Menu(dataItemPLCs,path))
            {




            }


            Console.WriteLine("------");
            Console.ReadKey();
        }
        
    }
}
