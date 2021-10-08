using Model.Model;
using Model.Model.EntityForProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemTeleBot
{
    public static class ConsoleIO
    {
        //internal static bool Menu(List<DataItemPLC> dataItemPLCs, string path)
        //{

        //    // Меню 
        //    bool quit = false;
        //    Console.Clear();
        //    Console.WriteLine("1- Меню ПЛК");
        //    switch (InputNumber())
        //    {
        //        case 1:


        //            break;

        //        case 9:
        //            quit = true;
        //            break;

        //        default:
        //            break;
        //    }
        //    return !quit;
        //}

        /// <summary>
        /// Метод ввода положительного числа
        /// </summary>
        /// <returns></returns>
        internal static int InputNumber()
        {
            int number;
            bool isCorrectParse;
            do
            {
                isCorrectParse = int.TryParse(Console.ReadLine(), out number);
                if (isCorrectParse == false && number < 0)
                {
                    Console.WriteLine("Не корректный ввод, попробуйте еще раз...");
                }
            } while (isCorrectParse == false && number < 0);

            return number;
        }
    }
}
