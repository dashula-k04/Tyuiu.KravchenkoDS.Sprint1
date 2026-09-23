using Tyuiu.KravchenkoDS.Sprint1.Task7.V12.Lib;

namespace Tyuiu.KravchenkoDS.Sprint1.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу  которая вычисляет математическое выражение по исходным *");
            Console.WriteLine("*     значениям данных, вводимых пользователем.                            *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             * ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*     ( x + 1 ) ^ x                                                       *");
            Console.WriteLine("* z = (-------) + 18 * x * y ^ 2                                          *"); 
            Console.WriteLine("*     ( x - 1 )                                                           *");
            Console.WriteLine("*                                                                         *");

            double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.Calculate(x, y)); 
            Console.ReadKey();
        }
    }
}
