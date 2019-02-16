using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace methodsBegin_0.1
{
    class Program
    {
        private static void writeMenu(bool clearScreen)
        {
            if (clearScreen)
            {
                Console.WriteLine("clear");
                Thread.Sleep(1000); //приостанов, чтобы увидеть на консоли фразу "clear" 
                Console.Clear();    //очистка экрана
            }
            Console.WriteLine("Main Menu:\n" +
                            "1 - option 1;\n" +
                            "2 - option 2;\n" +
                            "3 - option 3;\n" +
                            "0 - exit.");
        }

        static void Main(string[] args)
        {
            //вызов меню
            writeMenu();

            //работа программы

            //вызов меню
            writeMenu(true);

            Console.ReadKey();
        }
    }
}
