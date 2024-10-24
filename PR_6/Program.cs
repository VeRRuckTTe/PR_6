/***********************************************************************************/
/* Практическая работа №6                                                          */
/* Выполнила: Корнеева В.Е., 2-ИСП                                                 */
/* Задание: Cоставить программу рассчета дискриминанта во всех случаях             */
/***********************************************************************************/
using System;

namespace PR_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практичекая работа №6";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Здравствуйте.");
            Console.ForegroundColor = ConsoleColor.Blue;
            while (true)
            {
                double a = 0, b = 0, c = 0, d, x1, x2, x11, x21;
                try
                {
                    Console.Write("Введите a: ");
                    a = Convert.ToDouble(Console.ReadLine()); //Преобразует введенные пользователем данные в тип double
                    Console.Write("Введите b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите c: ");
                    c = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка: " + ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                switch (b)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Ошибка: b не может равняться нулю.");
                        break;
                    default:
                        switch (c)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine("Ошибка: c не может равняться нулю.");
                                break;
                            default:
                                d = Math.Pow(b, 2) - 4 * a * c;
                                switch (d)
                                {
                                    case 0:
                                        x1 = -(b / 2 * a);
                                        Console.WriteLine("Корень уравнения равен: " + x1);
                                        break;
                                    default:
                                        switch (d > 0 ? d : 0) // 
                                        {
                                            case 0:
                                                d = d * -1;
                                                x1 = (-b / 2 * a);
                                                x11 = (Math.Sqrt(d) / 2);
                                                x2 = (-b / 2 * a);
                                                x21 = Math.Sqrt(d) / 2;
                                                Console.WriteLine($"Ваш результат имеет два комлпексных корня: {x1} + {Math.Round(x11, 4)}i , {x2} - {Math.Round(x21, 4)}i");
                                                break;
                                            default:
                                                x1 = -b + Math.Sqrt(d) / 2 * a;
                                                x2 = -b - Math.Sqrt(d) / 2 * a;
                                                Console.WriteLine($"Корни уравнения равны: {x1} и {x2}");
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Вы хотите выйти? нажмите букву Y, иначе любую другую чтобы выйти:");
                if (Console.ReadKey().Key == ConsoleKey.Y) //Проверка нажатия клавиши пользователем
                    break;
                Console.Clear();
            }
        }
    }
}
