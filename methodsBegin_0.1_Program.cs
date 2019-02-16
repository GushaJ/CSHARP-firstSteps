using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsBegin_01
{
    class Program
    {
        //пример описания метода для вывода в подсказках
        /// <summary>
        /// Вывод меню на экран с возможностью очистки экрана.
        /// </summary>
        /// <param name="clearScreen">флаг очистки экрана.</param>
        /// <returns>Возвращает номер выбранного пункта меню.</returns>
        static int MainMenu(bool clearScreen = false)//формальный параметр сlearScreen со значением по умолчанию
        {
            if (clearScreen)
                Console.Clear();
            Console.WriteLine("Main Menu.\nChoose the item - enter a number:\n" +
                            "1 - option 1;\n" +
                            "2 - option 2;\n" +
                            "3 - option 3;\n" +
                            "0 - exit.");
            // применение пользовательского метода для ввода числа пользователем с клавиатуры
            int option = enterUserNum(); 
            
            return option;
        }
        
        // пользовательский метод для ввода числа пользователем с клавиатуры
        static int enterUserNum ()
        {
            string userAnswer = Console.ReadLine();

            int num;
            if (!int.TryParse(userAnswer, out num))
            {
                Console.WriteLine("Wrong number!");
                Console.ReadKey();
                // в случае ошибки ввода пользователем числа
                // метод возвращает минимально возможное число типа int
                return int.MinValue;
            }
            return num;//возврат числа, которое ввел пользователь
        }
        static void Main(string[] args)
        {
            //вызов меню
            MainMenu(true);

            //работа программы

            //вызов меню
            MainMenu();// <=> MainMenu(false); вызов метода без передачи фактического параметра

            Console.ReadKey();
        }
    }
}
