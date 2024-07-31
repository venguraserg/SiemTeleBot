
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Timers;
using Services;


namespace ConsoleApp

{
    internal class Program
    {
        public static PLC_Reader Reader {  get; private set; } = new PLC_Reader();

        static void Main(string[] args)
        {
            
            //тест для заполнения
            /*
            for(int i = 0; i < 10; i++)
            {
                Reader.AddPLC($"Wateds{i}", 33+i, $"192.168.3.11{i}");
                for(int j = 0; j < 10; j++)
                {
                    Reader.AddDataPoint($"192.168.3.11{i}", $"data point {j}", 30 + j, 120 + j, 1, $"tempText{j}");
                }
            }
            */

            if (Reader.plc_list.Count == 0) { Console.WriteLine("База PLC пуста, заполните"); }


            //Инициализация таймера
            int cyclicTime = 5000; // ms
            System.Timers.Timer timer = new System.Timers.Timer(cyclicTime);
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;

            //timer.Start();

            
            

            string? response;

            do
            {
                Console.Write("-->");
                response = Console.ReadLine();



                switch (response)
                {
                    case "help":
                        HelpMsg();
                        break;
                    case "add plc":
                        AddPLC();
                        break;
                    case "clr":
                        Console.Clear();
                        break;
                    case "start":
                        timer.Start();
                        break;
                    case "stop":
                        timer.Stop();
                        break;
                    //---------------------------------------------------------------------------
                    //   VIEW PLC                                                              //
                    //---------------------------------------------------------------------------
                    case "view plc":
                        for(int i = 0; i < Reader.plc_list.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. {Reader.plc_list[i].IP_Adress}  {Reader.plc_list[i].Name}");                            
                        }
                        break;
                    //---------------------------------------------------------------------------
                    //   VIEW DATAPOINT                                                         //
                    //----------------------------------------------------------------------------
                    case "view datapoint":
                        for(int i=0;  i < Reader.plc_list.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {Reader.plc_list[i].IP_Adress}  {Reader.plc_list[i].Name}");
                            for (int j = 0; j < Reader.plc_list[i].DataArr.Count; j++)
                            {
                                Console.WriteLine($"    - {Reader.plc_list[i].DataArr[j].Name} {Reader.plc_list[i].DataArr[j].Db} {Reader.plc_list[i].DataArr[j].Adr} {Reader.plc_list[i].DataArr[j].TextTag}");
                            }                            
                        }
                        break;
                    //----------------------------------------------------------------------------
                    //                                                           //
                    //----------------------------------------------------------------------------
                    case "add datapoint":
                        Console.WriteLine("Введите IP адрес ПЛК");
                        var ip = Console.ReadLine();
                        Console.WriteLine("Тип данных REAL");
                        Console.WriteLine("Введите ИМЯ точки опроса");
                        var nameDataPoint = Console.ReadLine();
                        Console.WriteLine("Введите номер DB");
                        int dbNumber = 0;
                        if (!int.TryParse(Console.ReadLine(),out dbNumber))
                        {
                            Console.WriteLine("не коректный ввод");
                            break;
                        }
                        Console.WriteLine("Введите адрес в DB");
                        int dbAdr = 0;
                        if (!int.TryParse(Console.ReadLine(), out dbAdr))
                        {
                            Console.WriteLine("не коректный ввод");
                            break;
                        }
                        Console.WriteLine("Введите текст сообщения");
                        var text = Console.ReadLine();
                        
                        if (Reader.AddDataPoint(ip, nameDataPoint, dbNumber, dbAdr, text))
                        {
                            Console.WriteLine("Данные успешно записаны");
                        }
                        else
                        {
                            Console.WriteLine("ОШИБКА ПРИ ВВОДЕ ДАННЫХ");
                        }
                        break;


                    case "quit":
                        break;
                    default:
                        Console.WriteLine("не верная команда, help - для справки");
                        break;

                }

            } while (response != "quit");


            timer.Stop();

        }

        static void HelpMsg()
        {
            Console.Clear();
            Console.WriteLine("Справка по комнадам приложения");
            Console.WriteLine("help - справка\n" +
                "quit - выход из приложения\n" +
                "add plc - добавить ПЛК\n" +
                "start - запуск циклической передачи\n" +
                "stop - остановка передачи\n" +
                "clr - очистка экарана\n" +
                "view plc - просмотр списка ПЛК\n" +
                "view datapoint - просмотр списка точек чтения\n" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "");
        }
        static void AddPLC()
        {

        }
        static void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {

          
            

        }
        
    }
}
