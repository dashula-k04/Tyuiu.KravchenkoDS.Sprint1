using Tyuiu.KravchenkoDS.Sprint1.Task6.V11.Lib;

namespace Tyuiu.KravchenkoDS.Sprint1.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:  Работа со строками класс     String                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Написать программу: пользователь вводит текст.                         *");
            Console.WriteLine("*      Проверить, что первая буква строки входит в нее еще раз.           *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите текст:  ");

            string str = Console.ReadLine();
            
            bool res = ds.CheckeFirstLetterRepetition(str);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Первая буква входит в строку еще раз.");
            }
            else
            {
                Console.WriteLine("Первая буква больше не встречается в строке.");
            }

            Console.ReadKey();
        }
    }
}
