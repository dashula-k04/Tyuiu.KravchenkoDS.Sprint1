using Tyuiu.KravchenkoDS.Sprint1.Task2.V25.Lib;

namespace Tyuiu.KravchenkoDS.Sprint1.Task2.V25
{
    internal class Program
    {
    
            static void Main(string[] args)
            {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в С#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известен угол в радианах. Перевести угол в градусы. Ответ округлите     *");
            Console.WriteLine("* до 3 знаков после запятой                                                ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value;

            Console.WriteLine("Введите угол в радианах:");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Угол в градусах = " + ds.ConvertRadsToDegrees(value));

            Console.ReadKey();
    }
    }

}
    

