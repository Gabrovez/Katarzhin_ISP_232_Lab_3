namespace Katarzhin_ISP_232_Lab_3
{
    public class Program
    {
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        //enum TaskPriority
        //{
        //    low = 1,
        //    Medium =2,
        //    high = 3
        //}
        //enum TrafficLight { Red, Yellow, Green }
        //public enum OrderStatus { New, Processing, Shipped, Delivered };
        static void Main(string[] args)
        {

            //Задание 3
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Задание 4
            //int num = 5;
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine($"5 * {i} = {i * 5}");
            //}
            //Задание 5
            //string str = "Запомни: всего одна ошибка и ты ошибся";
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(str);
            //}
            //Задание 6
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n + 1; i++)
            //{
            //    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            //}
            //Задание 7
            //string str = Console.ReadLine();
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(str);
            //}
            //Задание 8
            //bool res = true;
            //for (int i = 0; i < 10; i++)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num % 2 != 0) { res = false; }
            //}
            //if (res == false) { Console.WriteLine("No"); }
            //else { Console.WriteLine("YES"); }
            //Задание 9
            //Console.WriteLine("Добро пожаловать на стрельбище.");
            //Console.WriteLine("Введить Стоп чтобы прекратить стрельбу");
            //for (int i = 0; ; i++)
            //{
            //    Console.Write("Нажмите Enter чтобы выстрелить: ");
            //    string test = Console.ReadLine();
            //    if (test == "Стоп")
            //    {
            //        Console.WriteLine("Стрельба завершина.");
            //        Console.WriteLine($"Израсходованно боеприпассов: {i}");
            //        break;
            //    }
            //    else { Console.WriteLine("Выстрел совершён."); }

            //}
            //Console.WriteLine(Environment.CurrentDirectory);
            //Console.WriteLine(Environment.OSVersion.VersionString);
            //Console.WriteLine("Namespace: {0}", typeof(Program).Namespace ?? "<null>");
            // Цикл for
            //int sum = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Сумма: {sum}");
            // Цикл do..while
            //int i = 10;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);
            // Цикл while
            //int i = 10;
            //while(i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //Цикл foreach
            //foreach (char i in "Hello world")
            //{
            //    Console.WriteLine(i);
            //}
            //Операторы continue и break
            //for (int i =0; i < 9; i++) 
            //{
            //    if (i == 5)  
            //        break; 
            //    Console.WriteLine(i);
            //}
            //Шаг 8. Эхо-чат
            //string? input;
            //while (true)
            //{
            //    Console.Write("> ");
            //    input = Console.ReadLine();
            //    if (input == null)
            //    {
            //        continue;
            //    }
            //    if (input.ToLower() == "выход")
            //    {
            //        Console.WriteLine("До встречи!");
            //        break;
            //    }
            //}
            //Console.WriteLine($"Вы сказали: {input}");
            //Шаг 9. Перечисления
            //DayOfWeek today = DayOfWeek.Friday;
            //Console.WriteLine(today); 
            //TaskPriority priority = TaskPriority.high;
            //Console.WriteLine((int)priority);
            DayOfWeek day = DayOfWeek.Saturday;
            switch (day)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Выходной!");
                    break;
                default:
                    Console.WriteLine("Будний день.");
                    break;
            }

        }
    }
}
