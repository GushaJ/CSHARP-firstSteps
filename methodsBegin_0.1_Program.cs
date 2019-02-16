using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsBegin_0.1
{
    class Program
    {
        //(!!!)пример описания метода для вывода в подсказках
        /// <summary>
        /// Вывод меню на экран с возможностью очистки экрана.
        /// </summary>
        /// <param name="clearScreen">флаг очистки экрана.</param>
        /// <returns>Возвращает номер выбранного пункта меню.</returns>
        static int MainMenu(bool clearScreen = false)
        {
            if (clearScreen)
                Console.Clear();
            Console.WriteLine("Main Menu.\nChoose the item - enter a number:\n" +
                            "1 - option 1;\n" +
                            "2 - option 2;\n" +
                            "3 - option 3;\n" +
                            "0 - exit.");

            string userAnswer = Console.ReadLine();
            int option;
            if (!int.TryParse(userAnswer, out option))
            {
                Console.WriteLine("Wrong data!");
                Console.ReadKey();
                return -1;
                //throw new NotImplementedException();
            }

            return option;
        }
        static void Main(string[] args)
        {
            //вызов меню
            MainMenu(true);

            //работа программы

            //вызов меню
            MainMenu(false);

            Console.ReadKey();
        }
    }
}
