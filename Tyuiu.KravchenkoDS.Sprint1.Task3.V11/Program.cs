using Tyuiu.KravchenkoDS.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KravchenkoDS.Sprint1.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:     Операторы составного присваивания                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая вычисляет площадь треугольника, если известны координаты его углов    *");
            Console.WriteLine("*Ответ округлите до 3 знаков после запятой                                 ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x1, y1, x2, y2, x3, y3;
            Console.Write("Введите x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x3: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y3: ");
            y3 = Convert.ToDouble(Console.ReadLine());

            double res = ds.TriangleArea(x1, y1, x2, y2, x3, y3);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Площадь треугольника: " + res + " кв.см");

            Console.ReadKey();


        }
    }
}
