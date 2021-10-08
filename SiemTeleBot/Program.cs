using Model.Model;
using System;
using System.Collections.Generic;
using S7.Net;
using System.Text;
using Model.Model.EntityForProgram;

namespace SiemTeleBot
{
    class Program
    {
        static void Main(string[] args)
        {
            //путь к базе данных по умолчанию, не знаю почему, будем работать с json
            string path = "123";
            

            //Настройка кодировки
            Console.OutputEncoding = Encoding.UTF8;
            MyDataBase db = LoadSaveDataMethos.GetDataFromFile(path);

            //for (int i = 0; i < 10; i++)
            //{
            //    db.Plc.Add(new MyPLC($"plc{i}", Guid.NewGuid(), new Plc(CpuType.S71200, $"192.168.3.10{i}", 0, 0)));
            //    db.dataItemPLCs.Add(new DataItemPLC($"text_{i}", db.Plc[i].Plc, 10 + i, 40 + i, DataType.DataBlock, VarType.Real));
            //}


            //LoadSaveDataMethos.SaveDataFromFile(path, db);
            
            
            
            
            
            

            bool quit = false;

            while(!quit)
            {
                switch (ConsoleIO.InputNumber())
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Меню ПЛК");
                        Console.WriteLine("------------------------");
                        Console.WriteLine("1 - Посмотеть список ПЛК");
                        switch (ConsoleIO.InputNumber())
                        {
                            case 1:
                                break;
                            default:
                                break;
                        }


                        break;
                    default:
                        break;
                }



            }


            Console.WriteLine("------");
            Console.ReadKey();
        }
        
    }
}
