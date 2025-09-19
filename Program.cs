namespace Katarzhin_ISP_232_Lab_3
{
    internal class Program
    {
        //enum TrafficLight { Red, Yellow, Green }
        //public enum OrderStatus { New, Processing, Shipped, Delivered };
        static void Main(string[] args)
        {
            //Задание 1
            //var trafficLight = Enum.GetValues(typeof(TrafficLight));
            //int i = 0;
            //for (; i < trafficLight.Length; i++)
            //{
            //    TrafficLight color = (TrafficLight)trafficLight.GetValue(i);
            //    if (color == TrafficLight.Green)
            //        break;
            //}
            //i = (i + 1) % trafficLight.Length;
            //TrafficLight nextColor = (TrafficLight)trafficLight.GetValue(i);
            //Console.WriteLine(nextColor); 
            //Задание 2
            //    Console.Write("Введите статус заказа: ");
            //    string input = Console.ReadLine();
            //    OrderStatus stat = (OrderStatus)Enum.Parse(typeof(OrderStatus), input);
            //    status_check((OrderStatus)stat);
            //}
            //public static void status_check(OrderStatus status)
            //{
            //    switch (status)
            //    {
            //        case OrderStatus.New:
            //        case OrderStatus.Processing:
            //            Console.WriteLine("Заказ можно отменить");  
            //            break;
            //        default:
            //            Console.WriteLine("Заказ нельзя отменить");
            //            break;
            //    }
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
            string str = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(str);
            }
        }
    }   
}
